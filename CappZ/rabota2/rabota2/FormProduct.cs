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
    public partial class FormProduct : Form
    {
        public NpgsqlConnection con;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        public void Update()
        {
            String sql = "Select * from tovar";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView.DataSource = dt;
            dataGridView.Columns[0].HeaderText = "id";
            dataGridView.Columns[1].HeaderText = "Наименование";
            StartPosition = FormStartPosition.CenterScreen;
        }
        public FormProduct(NpgsqlConnection con)
        {

            InitializeComponent();
            this.con = con;
        }

        private void StripMenu_Exit_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void StripMenu_Add_Click(object sender, EventArgs e)
        {
            Form_add form_Add = new Form_add(con);
            form_Add.ShowDialog();
            Update();
        }

        private void StripMenu_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Подтверждение удаления?", "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    int id = (int)dataGridView.CurrentRow.Cells["id_tov"].Value;
                    NpgsqlCommand command = new NpgsqlCommand("delete from tovar where id_tov= :id", con);
                    command.Parameters.AddWithValue("id", id);
                    command.ExecuteNonQuery();
                    Update();
                }
                if (res == DialogResult.Cancel)
                {
                    MessageBox.Show("Удаление остановлено");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка удаления в бд!");
            }
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            Update();
        }

        private void StripMenu_Change_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView.CurrentRow.Cells["id_tov"].Value;
            string name = (string)dataGridView.CurrentRow.Cells["name_tov"].Value;
            Form_add form_Add = new Form_add(con, id, name);
            form_Add.ShowDialog();
            Update();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
