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
    public partial class FormFuturaInfoAdd : Form
    {
        public NpgsqlConnection con;
        public int id;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        DataTable dt1 = new DataTable();
        DataSet ds1 = new DataSet();
        public FormFuturaInfoAdd(NpgsqlConnection con, int id)
        {
            InitializeComponent();
            this.con = con;
            this.id = id;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void Update()
        {
            String sql = "Select * from tovar";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            prodcomboBox.DataSource = dt;
            prodcomboBox.DisplayMember = "name_tov";
            prodcomboBox.ValueMember = "id_tov";
        }

        public void Update1()
        {
            String sql = "Select * from dogovor";
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(sql, con);
            ds1.Reset();
            da1.Fill(ds1);
            dt1 = ds1.Tables[0];
            comboBox1.DataSource = dt1;
            comboBox1.DisplayMember = "id_dog";
            comboBox1.ValueMember = "id_dog"; 
            comboBox1.SelectedValue = id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormFuturaInfoAdd_Load(object sender, EventArgs e)
        {
            Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            NpgsqlCommand cmd = new NpgsqlCommand(
            "INSERT INTO dog_tov (id_dogovor,id_tovar,count,price) VALUES(:id_dogovor,:id_tovar,:count,:price)", con);
            cmd.Parameters.AddWithValue(":id_dogovor", comboBox1.SelectedValue);
            cmd.Parameters.AddWithValue(":count", Convert.ToDouble(textBoxQan.Text));
            cmd.Parameters.AddWithValue(":price", Convert.ToDouble(textBoxPr.Text));
            cmd.Parameters.AddWithValue(":id_tovar", prodcomboBox.SelectedValue);
            cmd.ExecuteNonQuery();
            Close();

        }

        private void FormFuturaInfoAdd_Load_1(object sender, EventArgs e)
        {
            Update1();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
