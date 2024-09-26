using Npgsql;
namespace rabota2
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();

        }
        public NpgsqlConnection con;
        public void MyLoad()
        {
            try
            {
                StartPosition = FormStartPosition.CenterScreen;
                con = new NpgsqlConnection("Server=localhost;Port=5432;UserID=postgres;Password=1;Database=postgres");
                con.Open();
                MessageBox.Show("Соединение с базой данных установлено", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при подключении к базе данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            MyLoad();
        }

        private void StripMenu_Items_Click(object sender, EventArgs e)
        {
            FormProduct fp = new FormProduct(con);
            fp.ShowDialog();
        }

        private void StripMenu_Overhead_Click(object sender, EventArgs e)
        {
            Form_futura ff = new Form_futura(con);
            ff.ShowDialog();
        }

        private void StripMenu_Clients_Click(object sender, EventArgs e)
        {
            FormClient fc = new FormClient(con);
            fc.ShowDialog();

        }

        private void StripMenu_Report_Click(object sender, EventArgs e)
        {
            ReportForm rp = new ReportForm(con);
            rp.ShowDialog();
        }
    }
}