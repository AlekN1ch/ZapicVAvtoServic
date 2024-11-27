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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using ZapicVAvtoServic.UsersDataSetTableAdapters;

namespace ZapicVAvtoServic
{
    public partial class Form4 : Form
    {
        public static string connectionStringJob = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = Jobs.accdb";
        private OleDbConnection myConnectionJob;
        public string date="24.11",type,timeJ,user;
        
        public Form4()
        {
            InitializeComponent();
            myConnectionJob = new OleDbConnection(connectionStringJob);
            myConnectionJob.Open();

        }
        
        public void Check()
        {
            if (numericUpDown2.Value == 11)
            {
                numericUpDown1.Maximum = 30;
            }
            if (numericUpDown2.Value == 12)
            {
                numericUpDown1.Maximum = 31;
            }
            date=numericUpDown1.Value.ToString()+"."+ numericUpDown2.Value.ToString();
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "usersDataSet.UsersTable". При необходимости она может быть перемещена или удалена.
            this.usersTableTableAdapter.Fill(this.usersDataSet.UsersTable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "jobsDataSet.JobTable". При необходимости она может быть перемещена или удалена.
            this.jobTableTableAdapter.Fill(this.jobsDataSet.JobTable);
            string query = "SELECT JobData,JobTime FROM JobTable ORDER BY Код";
            OleDbCommand command = new OleDbCommand(query, myConnectionJob);
            OleDbDataReader reader = command.ExecuteReader();
            listBox1.Items.Clear();
            while (reader.Read())
            {
                listBox1.Items.Add(reader[0].ToString()+ reader[1].ToString());
            }
            reader.Close();
            comboBox1.Text = "9:00";
            foreach (var item in comboBox2.Items)
            { 
                listBox2.Items.Add(item.ToString());
            }
            comboBox2.Text = "Шиномонтаж";
            user = Form1.userName;
            
            
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnectionJob.Close();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            string text=comboBox1.Text.ToString();
            if (text!="9:00" )
            {
                if(text != "10:30")
                {
                    if (text != "12:30")
                    {
                        if (text != "14:20")
                        {
                            if (text != "15:40")
                            {
                                if (text != "17:00")
                                {
                                    MessageBox.Show("Время можно выбрать лишь изпредложенных вариантов");
                                    comboBox1.Text = "9:00";
                                }
                            }
                        }
                    }
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dateAndTime = date + comboBox1.Text.ToString();
            
            foreach (var zap in listBox1.Items)
            {
                if (zap.ToString() == dateAndTime)
                {
                    MessageBox.Show("На эту дату и время записан другой клиент\nПодберите другую");
                    break;
                }
                else
                {
                    timeJ= comboBox1.Text.ToString();
                    
                    label2.Text= "Шаг 2 из 2";
                    label3.Text = "Укажите вид работы:";
                    label4.Visible = false;
                    label6.Visible = false;
                    numericUpDown1.Visible = false;
                    numericUpDown2.Visible = false;
                    comboBox1.Visible = false;
                    button1.Visible = false;
                    button2.Visible = true;
                    comboBox2.Visible = true;
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string data = date;
            string time = timeJ;
            string typeJ = type;
            string UserName1=Form1.userName;
            string query = "INSERT INTO JobTable (JobData,UserName,JobTime,JobType) VALUES " + "('" + data + "','" + UserName1 + "','" + time + "','" + typeJ + "')";
            OleDbCommand command = new OleDbCommand(query, myConnectionJob);
            command.ExecuteNonQuery();
            MessageBox.Show("Заявка принята");
            jobTableBindingSource.EndEdit();
           jobTableTableAdapter.Update(jobsDataSet);
            this.Close();
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            int cheker = 0;
            string text = comboBox2.Text;
            foreach (var zap in listBox2.Items)
            {
                if (text == zap.ToString())
                {
                    cheker=1;
                }
            }
            if (cheker != 1)
            {
                MessageBox.Show("Сделайте выбор из предложенных вариантов");
                comboBox2.Text = "Шиномонтаж";
            }
            else
            {
            type = comboBox2.Text;
            }
        }
    }
}
