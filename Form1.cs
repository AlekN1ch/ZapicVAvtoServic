using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZapicVAvtoServic
{
    public partial class Form1 : Form
    {
        public static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.accdb";
        private OleDbConnection myConnection;
        
        public string adminName;
        public string adminPassword;
        public  static string userName;
        public string userPassword;
        public bool  log=false,acces=false;
        public Form1()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectionString);
            myConnection.Open();
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workGraficDataSet.Grafic". При необходимости она может быть перемещена или удалена.
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "usersDataSet.AdminsTable". При необходимости она может быть перемещена или удалена.
            this.adminsTableTableAdapter.Fill(this.usersDataSet.AdminsTable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "usersDataSet.UsersTable". При необходимости она может быть перемещена или удалена.
            this.usersTableTableAdapter.Fill(this.usersDataSet.UsersTable);

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
           

        }
        private void button2_Click(object sender, EventArgs e)
        {
            string query = "SELECT UserName FROM AdminsTable WHERE Код = 1";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            adminName = command.ExecuteScalar().ToString();
            string query1 = "SELECT Password FROM AdminsTable WHERE Код = 1";
            OleDbCommand command1 = new OleDbCommand(query1, myConnection);
            adminPassword = command1.ExecuteScalar().ToString();
            if (textBox1.Text.ToString() == adminName)
            {
                if (textBox2.Text.ToString() == adminPassword)
                {
                    MessageBox.Show("Вход в систему от имени администратора прошел успешно");
                    Form5 form5 = new Form5();
                    form5.Show();
                }
                else
                {
                    MessageBox.Show("Неверный пароль");
                }

            }
            else
            {
                MessageBox.Show("Не существует Администратора с таким логином");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form2 f2= new Form2();
            f2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT UserName FROM UsersTable ORDER BY Код";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            listBox1.Items.Clear();
            while (reader.Read())
            {
                listBox1.Items.Add(reader[0].ToString());
            }
            reader.Close();
            foreach (var item in listBox1.Items)
            {
                if (textBox1.Text == item.ToString())
                {
                    log = true;
                    string query1 = "SELECT Password FROM UsersTable ORDER BY Код";
                    OleDbCommand command1 = new OleDbCommand(query1, myConnection);
                    OleDbDataReader reade1r = command1.ExecuteReader();
                    listBox2.Items.Clear();
                    while (reade1r.Read())
                    {
                        listBox2.Items.Add(reade1r[0].ToString());
                    }
                    reade1r.Close();
                    
                    foreach (var item1 in listBox2.Items)
                    {
                        if (textBox2.Text == item1.ToString())
                        { 
                            acces = true;
                        }
                        else
                        {
                           label7.Visible= true;
                        }
                    }

                }
                else
                {
                    
                     labelEr.Visible = true;
                    
                }
                
            }
            if (acces)
            {
                userName=textBox1.Text;
                label7.Visible = false;
                labelEr.Visible = false;

                

                MessageBox.Show("Вход в систему от имени Клиента прошел успешно");
                Form3 f3 = new Form3();
                f3.Show();
            }
            if (log)
            {
                labelEr.Visible = false;
            }
            if (log && acces == false)
            {
                label7.Visible = true;
                labelEr.Visible = false;
            }
            if (log==false && acces == false)
            {
                label7.Visible = true;
                labelEr.Visible = true;
            }
        }
    }
}
