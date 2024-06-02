namespace LapTop
{
    partial class Form4
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
            dataGridView2 = new DataGridView();
            dataGridView3 = new DataGridView();
            groupBox1 = new GroupBox();
            button2 = new Button();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            comboBox6 = new ComboBox();
            textBox1 = new TextBox();
            comboBox4 = new ComboBox();
            comboBox3 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(240, 116);
            dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 161);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(240, 116);
            dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(12, 302);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(240, 116);
            dataGridView3.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox6);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(comboBox4);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Location = new Point(291, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 406);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Поля";
            // 
            // button2
            // 
            button2.Location = new Point(40, 228);
            button2.Name = "button2";
            button2.Size = new Size(106, 48);
            button2.TabIndex = 38;
            button2.Text = "Добавить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(70, 157);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 27;
            label6.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 113);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 25;
            label4.Text = "Дом";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 67);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 24;
            label3.Text = "Улица";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 19);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 23;
            label2.Text = "Город";
            // 
            // comboBox6
            // 
            comboBox6.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(14, 175);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(167, 23);
            comboBox6.TabIndex = 21;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(17, 131);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Номер дома";
            textBox1.Size = new Size(167, 23);
            textBox1.TabIndex = 20;
            // 
            // comboBox4
            // 
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(17, 85);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(167, 23);
            comboBox4.TabIndex = 19;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(17, 37);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(167, 23);
            comboBox3.TabIndex = 18;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 450);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView3);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form4";
            Text = "Добавление магазина";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private GroupBox groupBox1;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox comboBox6;
        private TextBox textBox1;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private Button button2;
    }
}