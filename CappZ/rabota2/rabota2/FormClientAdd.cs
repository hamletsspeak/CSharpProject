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
    public partial class FormClientAdd : Form
    {
        public NpgsqlConnection con;
        public int id;
        public FormClientAdd(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;
            id = -1;
        }
        public FormClientAdd(NpgsqlConnection con, int id, string name, string adress)
        {
            InitializeComponent();
            this.con = con;
            this.id = id;
            textBoxName.Text = name;
            textBoxAdres.Text = adress;

        }
        private void add_button_Click(object sender, EventArgs e)
        {
            if (id == -1)
            {
                try
                {
                    NpgsqlCommand command = new NpgsqlCommand
                        ("INSERT INTO client (name,adress) VALUES (:name,:adress)", con);
                    command.Parameters.AddWithValue("name", textBoxName.Text);
                    command.Parameters.AddWithValue("adress", textBoxAdres.Text);
                    command.ExecuteNonQuery();
                    Close();

                }
                catch { }
            }
            else
            {
                try
                {
                    NpgsqlCommand command = new NpgsqlCommand
                        ("Update client SET (name,adress) = (:name,:adress) WHERE id_cl=:id", con);
                    command.Parameters.AddWithValue("name", textBoxName.Text);
                    command.Parameters.AddWithValue("adress", textBoxAdres.Text);
                    command.Parameters.AddWithValue("id", id);
                    command.ExecuteNonQuery();

                }
                catch { }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void close_button_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEd_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Update();
        }

        private void FormClientAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
