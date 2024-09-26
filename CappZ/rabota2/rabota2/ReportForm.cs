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
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic.ApplicationServices;


namespace rabota2
{
    public partial class ReportForm : Form
    {
        public NpgsqlConnection con;
        System.Data.DataTable dt = new System.Data.DataTable();
        DataSet ds = new DataSet();
        public ReportForm(NpgsqlConnection con)
        {

            InitializeComponent();
            this.con = con;

        }

        private void accept_Click(object sender, EventArgs e)
        {
            ExportToExcel(dataGridView1);
        }
        private void ExportToExcel(DataGridView dataGridView)
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Workbooks.Add();
            Excel._Worksheet worksheet = (Excel._Worksheet)excelApp.ActiveSheet;
            excelApp.Visible = true;

            // Заголовки столбцов
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = dataGridView.Columns[i].HeaderText;
            }

            // Данные строк
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value;
                }

            }


            // Опционально: автоматическое форматирование столбцов
            worksheet.Columns.AutoFit();

            // Сохранение файла (опционально)
            // string filePath = @"C:\path\to\your\file.xlsx";
            // worksheet.SaveAs(filePath);

            // Освобождение ресурсов
            releaseObject(worksheet);
            releaseObject(excelApp);
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }


        private void button_update_Click(object sender, EventArgs e)
        {
            DateTime dt1 = dateTimePicker1.Value;
            DateTime dt2 = dateTimePicker2.Value;
            NpgsqlDataAdapter da = new NpgsqlDataAdapter($"SELECT t.name_tov, dt.count, dt.price FROM Dog_tov dt INNER JOIN Tovar t ON dt.id_tovar = t.id_tov INNER JOIN Dogovor d ON dt.id_dogovor = d.id_dog WHERE d.date BETWEEN '{dt1:yyyy-MM-dd}' AND '{dt2:yyyy-MM-dd}'", con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Название товара";
            dataGridView1.Columns[1].HeaderText = "Количество";
            dataGridView1.Columns[2].HeaderText = "Цена";
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ReportForm_Load_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}



