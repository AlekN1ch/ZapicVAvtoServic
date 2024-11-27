using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZapicVAvtoServic
{
    public partial class Form5 : Form
    {
        public static string connectionStringJob = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = Jobs.accdb";
        private OleDbConnection myConnectionJob;
        public Form5()
        {
            InitializeComponent();
            myConnectionJob = new OleDbConnection(connectionStringJob);
            myConnectionJob.Open();
        }
        public void FillTables()
        {
            string query = "SELECT UserName FROM JobTable ORDER BY Код";
            OleDbCommand command = new OleDbCommand(query, myConnectionJob);
            OleDbDataReader reader = command.ExecuteReader();
            listBox4.Items.Clear();
            while (reader.Read())
            {
                listBox4.Items.Add(reader[0].ToString());
            }
            reader.Close();
            string query2 = "SELECT JobData FROM JobTable ORDER BY Код";
            OleDbCommand command2 = new OleDbCommand(query2, myConnectionJob);
            OleDbDataReader reader2 = command2.ExecuteReader();
            listBox1.Items.Clear();
            while (reader2.Read())
            {
                listBox1.Items.Add(reader2[0].ToString());
            }
            reader2.Close();
            string query3 = "SELECT JobTime FROM JobTable ORDER BY Код";
            OleDbCommand command3 = new OleDbCommand(query3, myConnectionJob);
            OleDbDataReader reader3 = command3.ExecuteReader();
            listBox2.Items.Clear();
            while (reader3.Read())
            {
                listBox2.Items.Add(reader3[0].ToString());
            }
            reader3.Close();
            string query4 = "SELECT JobType FROM JobTable ORDER BY Код";
            OleDbCommand command4 = new OleDbCommand(query4, myConnectionJob);
            OleDbDataReader reader4 = command4.ExecuteReader();
            listBox3.Items.Clear();
            while (reader4.Read())
            {
                listBox3.Items.Add(reader4[0].ToString());
            }
            reader4.Close();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "jobsDataSet.JobTable". При необходимости она может быть перемещена или удалена.
            this.jobTableTableAdapter.Fill(this.jobsDataSet.JobTable);
            int i = 0;
            while (i < 37)
            {
                label6.Text += " ";
                i++;
            }
            FillTables();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnectionJob.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillTables();
        }
    }
}
