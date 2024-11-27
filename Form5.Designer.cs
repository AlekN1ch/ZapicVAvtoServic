namespace ZapicVAvtoServic
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jobsDataSet = new ZapicVAvtoServic.JobsDataSet();
            this.jobTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobTableTableAdapter = new ZapicVAvtoServic.JobsDataSetTableAdapters.JobTableTableAdapter();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Location = new System.Drawing.Point(-4, 167);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(945, 493);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palace Script MT", 108F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(188, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(690, 167);
            this.label1.TabIndex = 6;
            this.label1.Text = " Guido\'s Avto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ZapicVAvtoServic.Properties.Resources.guido;
            this.pictureBox1.Location = new System.Drawing.Point(-30, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 28F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(206, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(511, 56);
            this.label5.TabIndex = 14;
            this.label5.Text = "Кабинет Администратора";
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.Color.LightGreen;
            this.listBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox3.Font = new System.Drawing.Font("Monotype Corsiva", 17F, System.Drawing.FontStyle.Italic);
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 34;
            this.listBox3.Location = new System.Drawing.Point(396, 309);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(535, 170);
            this.listBox3.TabIndex = 31;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.NavajoWhite;
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2.Font = new System.Drawing.Font("Monotype Corsiva", 17F, System.Drawing.FontStyle.Italic);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 34;
            this.listBox2.Location = new System.Drawing.Point(257, 309);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(295, 170);
            this.listBox2.TabIndex = 30;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.LightCoral;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Monotype Corsiva", 17.2F, System.Drawing.FontStyle.Italic);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 36;
            this.listBox1.Location = new System.Drawing.Point(137, 309);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(142, 180);
            this.listBox1.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.YellowGreen;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 22.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(396, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 47);
            this.label6.TabIndex = 28;
            this.label6.Text = "Вид услуги";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Khaki;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 23F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(257, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 47);
            this.label4.TabIndex = 27;
            this.label4.Text = "Время  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.IndianRed;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 23F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(129, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 47);
            this.label3.TabIndex = 26;
            this.label3.Text = "Дата  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 23F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(12, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 47);
            this.label2.TabIndex = 33;
            this.label2.Text = "Логин ";
            // 
            // listBox4
            // 
            this.listBox4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.listBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox4.Font = new System.Drawing.Font("Monotype Corsiva", 17.2F, System.Drawing.FontStyle.Italic);
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 36;
            this.listBox4.Location = new System.Drawing.Point(12, 309);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(127, 180);
            this.listBox4.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 98);
            this.button1.TabIndex = 35;
            this.button1.Text = "Обновить страницу";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.jobDataDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.jobTimeDataGridViewTextBoxColumn,
            this.jobTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.jobTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(821, 518);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(27, 29);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.Visible = false;
            // 
            // jobsDataSet
            // 
            this.jobsDataSet.DataSetName = "JobsDataSet";
            this.jobsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jobTableBindingSource
            // 
            this.jobTableBindingSource.DataMember = "JobTable";
            this.jobTableBindingSource.DataSource = this.jobsDataSet;
            // 
            // jobTableTableAdapter
            // 
            this.jobTableTableAdapter.ClearBeforeFill = true;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.Width = 125;
            // 
            // jobDataDataGridViewTextBoxColumn
            // 
            this.jobDataDataGridViewTextBoxColumn.DataPropertyName = "JobData";
            this.jobDataDataGridViewTextBoxColumn.HeaderText = "JobData";
            this.jobDataDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jobDataDataGridViewTextBoxColumn.Name = "jobDataDataGridViewTextBoxColumn";
            this.jobDataDataGridViewTextBoxColumn.Width = 125;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // jobTimeDataGridViewTextBoxColumn
            // 
            this.jobTimeDataGridViewTextBoxColumn.DataPropertyName = "JobTime";
            this.jobTimeDataGridViewTextBoxColumn.HeaderText = "JobTime";
            this.jobTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jobTimeDataGridViewTextBoxColumn.Name = "jobTimeDataGridViewTextBoxColumn";
            this.jobTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // jobTypeDataGridViewTextBoxColumn
            // 
            this.jobTypeDataGridViewTextBoxColumn.DataPropertyName = "JobType";
            this.jobTypeDataGridViewTextBoxColumn.HeaderText = "JobType";
            this.jobTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jobTypeDataGridViewTextBoxColumn.Name = "jobTypeDataGridViewTextBoxColumn";
            this.jobTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(933, 653);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(951, 700);
            this.Name = "Form5";
            this.Text = "Form5";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form5_FormClosing);
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private JobsDataSet jobsDataSet;
        private System.Windows.Forms.BindingSource jobTableBindingSource;
        private JobsDataSetTableAdapters.JobTableTableAdapter jobTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobTypeDataGridViewTextBoxColumn;
    }
}