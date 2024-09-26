using Npgsql;
using System.Data;

namespace rabota2
{
    public partial class Form_futura : Form
    {
        public NpgsqlConnection con;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        DataTable dt1 = new DataTable();
        DataSet ds1 = new DataSet();
        public Form_futura(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void Update2()
        {

            string sql = "SELECT dog_tov.id_dogovor, dog_tov.id_tovar, dog_tov.count, dog_tov.price, tovar.name_tov AS name_tov " +
             "FROM dog_tov " +
             "INNER JOIN tovar ON dog_tov.id_tovar = tovar.id_tov";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds1.Reset();
            da.Fill(ds1);
            dt1 = ds1.Tables[0];
            dataGridView2.DataSource = dt1;
            dataGridView2.Columns[0].HeaderText = "id Договора";
            dataGridView2.Columns[1].HeaderText = "id Товара";
            dataGridView2.Columns[2].HeaderText = "Количество";
            dataGridView2.Columns[3].HeaderText = "Стоимость";
            dataGridView2.Columns[4].HeaderText = "Название Товара";
            StartPosition = FormStartPosition.CenterScreen;

        }
        public void Update3()
        {
            NpgsqlCommand cmd = new NpgsqlCommand(
                    "UPDATE dogovor " +
                    "SET sum = ( " +
                    "    SELECT SUM(count * price) " +
                    "    FROM dog_tov " +
                    "    WHERE dog_tov.id_dogovor = dogovor.id_dog " +
                    ")", con);

            cmd.ExecuteNonQuery();
        }

        public void Update1()
        {

            String sql = "Select * from dogovor";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "id Договора";
            dataGridView1.Columns[1].HeaderText = "id Клиента";
            dataGridView1.Columns[2].HeaderText = "Дата";
            dataGridView1.Columns[3].HeaderText = "Итоговая сумма";         
            StartPosition = FormStartPosition.CenterScreen;
        }



        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void futuraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuturaFormAdd ffa = new FuturaFormAdd(con);
            ffa.ShowDialog();
            Update1();

        }

        private void futurainfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells["id_dog"].Value;
            FormFuturaInfoAdd ffia = new FormFuturaInfoAdd(con, id);
            ffia.ShowDialog();
            Update2();
        }

        private void Form_futura_Load(object sender, EventArgs e)
        {
            Update1();
            Update2();
            Update3();
        }

        private void futuraDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Подтвердить удаление?", "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    int id = (int)dataGridView1.CurrentRow.Cells["id_dog"].Value;
                    NpgsqlCommand command = new NpgsqlCommand("delete from dogovor where id_dog= :id", con);
                    command.Parameters.AddWithValue("id", id);
                    command.ExecuteNonQuery();
                    Update1();
                }
                if (res == DialogResult.Cancel)
                {
                    MessageBox.Show("Отмена удаления!");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка удаления!");
            }
        }

        private void futuraInfoDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Подтверждение удаления?", "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    int id = (int)dataGridView2.CurrentRow.Cells["id_tov"].Value;
                    NpgsqlCommand command = new NpgsqlCommand("delete from dog_tov where id_tov= :id", con);
                    command.Parameters.AddWithValue("id_tov", id);
                    command.ExecuteNonQuery();
                    Update1();
                }
                if (res == DialogResult.Cancel)
                {
                    MessageBox.Show("Отмена удаления!");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка удаления!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update1();
            Update2();
            Update3();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells["id_dog"].Value;
            String sql = $"Select * from dog_tov where id_dogovor = '{id}'";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds1.Reset();
            da.Fill(ds1);
            dt1 = ds1.Tables[0];
            dataGridView2.DataSource = dt1;
            dataGridView2.Columns[0].HeaderText = "id Договора";
            dataGridView2.Columns[1].HeaderText = "id Товара";
            dataGridView2.Columns[2].HeaderText = "Количество";
            dataGridView2.Columns[3].HeaderText = "Стоимость";
            StartPosition = FormStartPosition.CenterScreen;

        }

        private void Form_futura_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells["id_dog"].Value;
        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

