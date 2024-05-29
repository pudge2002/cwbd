namespace LapTop
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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            button2 = new Button();
            label1 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            comboBox6 = new ComboBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(240, 304);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox6);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(271, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 304);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Поля";
            // 
            // button2
            // 
            button2.Location = new Point(41, 248);
            button2.Name = "button2";
            button2.Size = new Size(106, 48);
            button2.TabIndex = 38;
            button2.Text = "Добавить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 157);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 31;
            label1.Text = "Номер телефона";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(17, 175);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Введите номер телефона";
            textBox4.Size = new Size(167, 23);
            textBox4.TabIndex = 30;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(17, 87);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Введите имя";
            textBox3.Size = new Size(167, 23);
            textBox3.TabIndex = 29;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(17, 41);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Введите фамилию";
            textBox2.Size = new Size(167, 23);
            textBox2.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 201);
            label6.Name = "label6";
            label6.Size = new Size(157, 15);
            label6.TabIndex = 27;
            label6.Text = "Должность ответственного";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 113);
            label4.Name = "label4";
            label4.Size = new Size(146, 15);
            label4.TabIndex = 25;
            label4.Text = "Отчество ответственного";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 67);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 24;
            label3.Text = "Имя ответственного";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 19);
            label2.Name = "label2";
            label2.Size = new Size(146, 15);
            label2.TabIndex = 23;
            label2.Text = "Фамилия ответственного";
            // 
            // comboBox6
            // 
            comboBox6.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(17, 219);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(167, 23);
            comboBox6.TabIndex = 21;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(17, 131);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Введите отчество";
            textBox1.Size = new Size(167, 23);
            textBox1.TabIndex = 20;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 349);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form5";
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox comboBox6;
        private TextBox textBox1;
        private Button button2;
    }
}