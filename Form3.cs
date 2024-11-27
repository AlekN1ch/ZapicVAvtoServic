using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZapicVAvtoServic
{
    public partial class Form3 : Form
    {
        public static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.accdb";
        private OleDbConnection myConnection;
        public static string connectionStringJob = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = Jobs.accdb";
        private OleDbConnection myConnectionJob;
        public string date,jobType,jobTime,user;
        
        public Form3()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectionString);
            myConnection.Open();
            myConnectionJob = new OleDbConnection(connectionStringJob);
            myConnectionJob.Open();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {  
            Form4 f4= new Form4();
            f4.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "jobsDataSet.JobTable". При необходимости она может быть перемещена или удалена.
            this.jobTableTableAdapter.Fill(this.jobsDataSet.JobTable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "usersDataSet.UsersTable". При необходимости она может быть перемещена или удалена.
            this.usersTableTableAdapter.Fill(this.usersDataSet.UsersTable);
            FillListBoxes();
            int i = 0;
            while (i < 37)
            {
                label6.Text += " ";
                i++;
            }
        }

        public void FillListBoxes()
        {
            user = Form1.userName;
            string query = "SELECT UserName FROM JobTable ORDER BY Код";
            OleDbCommand command = new OleDbCommand(query, myConnectionJob);
            OleDbDataReader reader = command.ExecuteReader();
            listBox4.Items.Clear();
            while (reader.Read())
            {
                listBox4.Items.Add(reader[0].ToString());
            }
            reader.Close();
            foreach (var item in listBox4.Items)
            {
                if (user == item.ToString())
                {
                    string query1 = "SELECT JobData FROM JobTable WHERE ([UserName]='" + user + "')";
                    OleDbCommand command1 = new OleDbCommand(query1, myConnectionJob);
                    OleDbDataReader reader1 = command1.ExecuteReader();
                    listBox1.Items.Clear();
                    while (reader1.Read())
                    {
                        listBox1.Items.Add(reader1[0].ToString());
                    }
                    reader1.Close();
                    string query2 = "SELECT JobTime FROM JobTable WHERE ([UserName]='" + user + "')";
                    OleDbCommand command2 = new OleDbCommand(query2, myConnectionJob);
                    OleDbDataReader reader2 = command2.ExecuteReader();
                    listBox2.Items.Clear();
                    while (reader2.Read())
                    {
                        listBox2.Items.Add(reader2[0].ToString());
                    }
                    reader2.Close();
                    string query3 = "SELECT JobType FROM JobTable WHERE ([UserName]='" + user + "')";
                    OleDbCommand command3 = new OleDbCommand(query3, myConnectionJob);
                    OleDbDataReader reader3 = command3.ExecuteReader();
                    listBox3.Items.Clear();
                    while (reader3.Read())
                    {
                        listBox3.Items.Add(reader3[0].ToString());
                    }
                    reader3.Close();
                    
                }
                else
                {
                    string query1 = "SELECT JobData FROM JobTable WHERE Код=-1";
                    OleDbCommand command1 = new OleDbCommand(query1, myConnectionJob);
                    OleDbDataReader reader1 = command1.ExecuteReader();
                    listBox1.Items.Clear();
                    while (reader1.Read())
                    {
                        listBox1.Items.Add(reader1[0].ToString());
                    }
                    reader1.Close();
                    string query2 = "SELECT JobTime FROM JobTable WHERE Код=-1";
                    OleDbCommand command2 = new OleDbCommand(query2, myConnectionJob);
                    OleDbDataReader reader2 = command2.ExecuteReader();
                    listBox2.Items.Clear();
                    while (reader2.Read())
                    {
                        listBox2.Items.Add(reader2[0].ToString());
                    }
                    reader2.Close();
                    string query3 = "SELECT JobType FROM JobTable WHERE Код=-1";
                    OleDbCommand command3 = new OleDbCommand(query3, myConnectionJob);
                    OleDbDataReader reader3 = command3.ExecuteReader();
                    listBox3.Items.Clear();
                    while (reader3.Read())
                    {
                        listBox3.Items.Add(reader3[0].ToString());
                    }
                    reader3.Close();
                }
            }
        }
        public void LenghtListBoxes()
        {
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FillListBoxes();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
           myConnection.Close();
           myConnectionJob.Close();
        }
    }
}
