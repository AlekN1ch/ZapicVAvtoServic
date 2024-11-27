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
using System.Xml.Linq;

namespace ZapicVAvtoServic
{
    public partial class Form2 : Form
    {
        public static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.accdb";
        private OleDbConnection myConnection;
        public string userName;
        public string userPassword;
        public string userMail;
        public Form2()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectionString);
            myConnection.Open();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "usersDataSet.UsersTable". При необходимости она может быть перемещена или удалена.
            this.usersTableTableAdapter.Fill(this.usersDataSet.UsersTable);
            string query1 = "SELECT UserName FROM UsersTable ORDER BY Код";
            OleDbCommand command1 = new OleDbCommand(query1, myConnection);
            OleDbDataReader reade1r = command1.ExecuteReader();
            listBox1.Items.Clear();
            while (reade1r.Read())
            {
                listBox1.Items.Add(reade1r[0].ToString());
            }
            reade1r.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool am = false;
            foreach (var item in listBox1.Items)
            {
                if (item.ToString() == textBox1.Text)
                {
                    MessageBox.Show("Эта учетная запись занята ");
                    break;
                }
                else
                {
                    userName = textBox1.Text.ToString();
                    userPassword = textBox2.Text.ToString();
                    userMail = textBox3.Text.ToString();
                    string query = "INSERT INTO UsersTable ([UserName],[Password],[Gmail]) VALUES " + "('" + userName + "','" + userPassword + "','" + userMail + "')";
                    OleDbCommand command = new OleDbCommand(query, myConnection);
                    command.ExecuteNonQuery();
                    am= true;
                    usersTableBindingSource1.EndEdit();
                    usersTableTableAdapter.Update(usersDataSet);
                    this.usersTableTableAdapter.Fill(this.usersDataSet.UsersTable);
                  
                }
            }
            if (am)
            {
                MessageBox.Show("Учетная запись добавленна");
                this.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
