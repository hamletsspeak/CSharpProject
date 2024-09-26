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
    public partial class FuturaFormAdd : Form
    {
        public NpgsqlConnection con;
        public int id;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        public FuturaFormAdd(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;

        }
        public void Update()
        {
            String sql = "Select * from client";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            comboBoxClient.DataSource = dt;
            comboBoxClient.DisplayMember = "name";
            comboBoxClient.ValueMember = "id_cl";
        }

        private void FuturaFormAdd_Load(object sender, EventArgs e)
        {
            Update();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            int day1 = dateTimePicker1.Value.Day;
            int month1 = dateTimePicker1.Value.Month;
            int year1 = dateTimePicker1.Value.Year;
            String sql = String.Format("INSERT INTO dogovor (id_cl, date, sum)  VALUES (@id_cl, '{0}-{1}-{2}', @sum) ", year1, month1, day1);
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            DateTime dt1 = this.dateTimePicker1.Value.Date;
            cmd.Parameters.AddWithValue("@id_cl", comboBoxClient.SelectedValue);
            cmd.Parameters.AddWithValue("@sum", 0);
            cmd.ExecuteNonQuery();
            Close();
        }

        private void comboBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
