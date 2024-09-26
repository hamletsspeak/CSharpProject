using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace rabota2
{
    public partial class FormClient : Form
    {
        public NpgsqlConnection con;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        public void Update()
        {
            String sql = "Select* from client";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView2.DataSource = dt;
            dataGridView2.Columns[0].HeaderText = "id";
            dataGridView2.Columns[1].HeaderText = "ФИО";
            dataGridView2.Columns[2].HeaderText = "Адрес";
            StartPosition = FormStartPosition.CenterScreen;
        }
        public FormClient(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;
            Update();
        }

        private void StripMenu_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void StripMenu_Add_Click(object sender, EventArgs e)
        {
            FormClientAdd fca = new FormClientAdd(con);

            fca.ShowDialog();
            Update();
        }

        private void StripMenu_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Подтвердить удаление?", "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    int id = (int)dataGridView2.CurrentRow.Cells["id_cl"].Value;
                    NpgsqlCommand command = new NpgsqlCommand("delete from client where id_cl= :id", con);
                    command.Parameters.AddWithValue("id", id);
                    command.ExecuteNonQuery();
                    Update();
                }
                if (res == DialogResult.Cancel)
                {
                    MessageBox.Show("Клиент не удалён");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка удаления в бд!");
            }

        }


        private void StripMenu_Change_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView2.CurrentRow.Cells["id_cl"].Value;
            string name = (string)dataGridView2.CurrentRow.Cells["name"].Value;
            string adres = (string)dataGridView2.CurrentRow.Cells["adress"].Value;
            FormClientAdd fca = new FormClientAdd(con, id, name, adres);
            fca.ShowDialog();
            Update();
            Close();
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            Update();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
