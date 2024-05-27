namespace LapTop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            knopka = new Button();
            entity = new TabControl();
            shops = new TabPage();
            tabControl2 = new TabControl();
            shop = new TabPage();
            dataGridView8 = new DataGridView();
            allParamShop = new TabPage();
            dataGridView13 = new DataGridView();
            dataGridView12 = new DataGridView();
            dataGridView11 = new DataGridView();
            laptops = new TabPage();
            tabControl3 = new TabControl();
            laptop = new TabPage();
            comboBox1 = new ComboBox();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            allParamLap = new TabPage();
            dataGridView5 = new DataGridView();
            dataGridView6 = new DataGridView();
            dataGridView7 = new DataGridView();
            button5 = new Button();
            button4 = new Button();
            button1 = new Button();
            dataGridView4 = new DataGridView();
            dataGridView3 = new DataGridView();
            dataGridView2 = new DataGridView();
            providers = new TabPage();
            tabControl4 = new TabControl();
            allParamProv = new TabPage();
            dataGridView10 = new DataGridView();
            emailProv = new TabPage();
            dataGridView14 = new DataGridView();
            responsible = new TabPage();
            tabControl5 = new TabControl();
            respons = new TabPage();
            dataGridView9 = new DataGridView();
            allParamRes = new TabPage();
            dataGridView15 = new DataGridView();
            entity.SuspendLayout();
            shops.SuspendLayout();
            tabControl2.SuspendLayout();
            shop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView8).BeginInit();
            allParamShop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView11).BeginInit();
            laptops.SuspendLayout();
            tabControl3.SuspendLayout();
            laptop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            allParamLap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            providers.SuspendLayout();
            tabControl4.SuspendLayout();
            allParamProv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView10).BeginInit();
            emailProv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView14).BeginInit();
            responsible.SuspendLayout();
            tabControl5.SuspendLayout();
            respons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView9).BeginInit();
            allParamRes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView15).BeginInit();
            SuspendLayout();
            // 
            // knopka
            // 
            knopka.Location = new Point(868, 172);
            knopka.Name = "knopka";
            knopka.Size = new Size(148, 21);
            knopka.TabIndex = 0;
            knopka.Text = "Добавить запись";
            knopka.UseVisualStyleBackColor = true;
            knopka.Click += knopka_Click;
            // 
            // entity
            // 
            entity.Controls.Add(shops);
            entity.Controls.Add(laptops);
            entity.Controls.Add(providers);
            entity.Controls.Add(responsible);
            entity.Location = new Point(12, 12);
            entity.Name = "entity";
            entity.SelectedIndex = 0;
            entity.Size = new Size(1067, 521);
            entity.TabIndex = 1;
            // 
            // shops
            // 
            shops.Controls.Add(tabControl2);
            shops.Location = new Point(4, 24);
            shops.Name = "shops";
            shops.Padding = new Padding(3);
            shops.Size = new Size(1059, 493);
            shops.TabIndex = 0;
            shops.Text = "Магазины";
            shops.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(shop);
            tabControl2.Controls.Add(allParamShop);
            tabControl2.Location = new Point(3, 3);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(1050, 490);
            tabControl2.TabIndex = 0;
            // 
            // shop
            // 
            shop.Controls.Add(dataGridView8);
            shop.Location = new Point(4, 24);
            shop.Name = "shop";
            shop.Padding = new Padding(3);
            shop.Size = new Size(1042, 462);
            shop.TabIndex = 2;
            shop.Text = "Магазин";
            shop.UseVisualStyleBackColor = true;
            // 
            // dataGridView8
            // 
            dataGridView8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView8.Location = new Point(6, 6);
            dataGridView8.Name = "dataGridView8";
            dataGridView8.RowTemplate.Height = 25;
            dataGridView8.Size = new Size(856, 388);
            dataGridView8.TabIndex = 2;
            // 
            // allParamShop
            // 
            allParamShop.Controls.Add(dataGridView13);
            allParamShop.Controls.Add(dataGridView12);
            allParamShop.Controls.Add(dataGridView11);
            allParamShop.Location = new Point(4, 24);
            allParamShop.Name = "allParamShop";
            allParamShop.Padding = new Padding(3);
            allParamShop.Size = new Size(1042, 462);
            allParamShop.TabIndex = 3;
            allParamShop.Text = "Сведения о магазинах";
            allParamShop.UseVisualStyleBackColor = true;
            // 
            // dataGridView13
            // 
            dataGridView13.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView13.Location = new Point(21, 230);
            dataGridView13.Name = "dataGridView13";
            dataGridView13.RowTemplate.Height = 25;
            dataGridView13.Size = new Size(238, 144);
            dataGridView13.TabIndex = 3;
            // 
            // dataGridView12
            // 
            dataGridView12.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView12.Location = new Point(308, 21);
            dataGridView12.Name = "dataGridView12";
            dataGridView12.RowTemplate.Height = 25;
            dataGridView12.Size = new Size(238, 144);
            dataGridView12.TabIndex = 2;
            // 
            // dataGridView11
            // 
            dataGridView11.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView11.Location = new Point(21, 21);
            dataGridView11.Name = "dataGridView11";
            dataGridView11.RowTemplate.Height = 25;
            dataGridView11.Size = new Size(238, 144);
            dataGridView11.TabIndex = 1;
            // 
            // laptops
            // 
            laptops.Controls.Add(tabControl3);
            laptops.Location = new Point(4, 24);
            laptops.Name = "laptops";
            laptops.Padding = new Padding(3);
            laptops.Size = new Size(1059, 493);
            laptops.TabIndex = 1;
            laptops.Text = "Ноутбуки";
            laptops.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            tabControl3.Controls.Add(laptop);
            tabControl3.Controls.Add(allParamLap);
            tabControl3.Location = new Point(3, 3);
            tabControl3.Name = "tabControl3";
            tabControl3.SelectedIndex = 0;
            tabControl3.Size = new Size(1050, 487);
            tabControl3.TabIndex = 0;
            // 
            // laptop
            // 
            laptop.Controls.Add(comboBox1);
            laptop.Controls.Add(knopka);
            laptop.Controls.Add(button2);
            laptop.Controls.Add(dataGridView1);
            laptop.Controls.Add(button3);
            laptop.Location = new Point(4, 24);
            laptop.Name = "laptop";
            laptop.Padding = new Padding(3);
            laptop.Size = new Size(1042, 459);
            laptop.TabIndex = 0;
            laptop.Text = "Ноутбуки";
            laptop.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(868, 73);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(149, 23);
            comboBox1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(868, 120);
            button2.Name = "button2";
            button2.Size = new Size(148, 23);
            button2.TabIndex = 3;
            button2.Text = "Обновить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(856, 388);
            dataGridView1.TabIndex = 1;
            // 
            // button3
            // 
            button3.Location = new Point(868, 230);
            button3.Name = "button3";
            button3.Size = new Size(148, 23);
            button3.TabIndex = 5;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
           
            // 
            // allParamLap
            // 
            allParamLap.Controls.Add(dataGridView5);
            allParamLap.Controls.Add(dataGridView6);
            allParamLap.Controls.Add(dataGridView7);
            allParamLap.Controls.Add(button5);
            allParamLap.Controls.Add(button4);
            allParamLap.Controls.Add(button1);
            allParamLap.Controls.Add(dataGridView4);
            allParamLap.Controls.Add(dataGridView3);
            allParamLap.Controls.Add(dataGridView2);
            allParamLap.Location = new Point(4, 24);
            allParamLap.Name = "allParamLap";
            allParamLap.Padding = new Padding(3);
            allParamLap.Size = new Size(1042, 459);
            allParamLap.TabIndex = 1;
            allParamLap.Text = "Сведения о ноутбуках";
            allParamLap.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Location = new Point(568, 237);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.RowTemplate.Height = 25;
            dataGridView5.Size = new Size(240, 144);
            dataGridView5.TabIndex = 8;
            // 
            // dataGridView6
            // 
            dataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView6.Location = new Point(287, 237);
            dataGridView6.Name = "dataGridView6";
            dataGridView6.RowTemplate.Height = 25;
            dataGridView6.Size = new Size(240, 144);
            dataGridView6.TabIndex = 7;
            // 
            // dataGridView7
            // 
            dataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView7.Location = new Point(16, 237);
            dataGridView7.Name = "dataGridView7";
            dataGridView7.RowTemplate.Height = 25;
            dataGridView7.Size = new Size(238, 144);
            dataGridView7.TabIndex = 6;
            // 
            // button5
            // 
            button5.Location = new Point(645, 184);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 5;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(351, 184);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(82, 184);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(568, 16);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowTemplate.Height = 25;
            dataGridView4.Size = new Size(240, 144);
            dataGridView4.TabIndex = 2;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(287, 16);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(240, 144);
            dataGridView3.TabIndex = 1;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(16, 16);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(238, 144);
            dataGridView2.TabIndex = 0;
            // 
            // providers
            // 
            providers.Controls.Add(tabControl4);
            providers.Location = new Point(4, 24);
            providers.Name = "providers";
            providers.Padding = new Padding(3);
            providers.Size = new Size(1059, 493);
            providers.TabIndex = 2;
            providers.Text = "Поставщики";
            providers.UseVisualStyleBackColor = true;
            // 
            // tabControl4
            // 
            tabControl4.Controls.Add(allParamProv);
            tabControl4.Controls.Add(emailProv);
            tabControl4.Location = new Point(3, 3);
            tabControl4.Name = "tabControl4";
            tabControl4.SelectedIndex = 0;
            tabControl4.Size = new Size(1050, 490);
            tabControl4.TabIndex = 0;
            // 
            // allParamProv
            // 
            allParamProv.Controls.Add(dataGridView10);
            allParamProv.Location = new Point(4, 24);
            allParamProv.Name = "allParamProv";
            allParamProv.Padding = new Padding(3);
            allParamProv.Size = new Size(1042, 462);
            allParamProv.TabIndex = 0;
            allParamProv.Text = "Сведения о поставщиках";
            allParamProv.UseVisualStyleBackColor = true;
            // 
            // dataGridView10
            // 
            dataGridView10.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView10.Location = new Point(6, 6);
            dataGridView10.Name = "dataGridView10";
            dataGridView10.RowTemplate.Height = 25;
            dataGridView10.Size = new Size(856, 388);
            dataGridView10.TabIndex = 2;
            // 
            // emailProv
            // 
            emailProv.Controls.Add(dataGridView14);
            emailProv.Location = new Point(4, 24);
            emailProv.Name = "emailProv";
            emailProv.Padding = new Padding(3);
            emailProv.Size = new Size(1042, 462);
            emailProv.TabIndex = 1;
            emailProv.Text = "Электронные почты поставщиков";
            emailProv.UseVisualStyleBackColor = true;
            // 
            // dataGridView14
            // 
            dataGridView14.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView14.Location = new Point(149, 35);
            dataGridView14.Name = "dataGridView14";
            dataGridView14.RowTemplate.Height = 25;
            dataGridView14.Size = new Size(377, 281);
            dataGridView14.TabIndex = 1;
            // 
            // responsible
            // 
            responsible.Controls.Add(tabControl5);
            responsible.Location = new Point(4, 24);
            responsible.Name = "responsible";
            responsible.Padding = new Padding(3);
            responsible.Size = new Size(1059, 493);
            responsible.TabIndex = 3;
            responsible.Text = "Ответственные";
            responsible.UseVisualStyleBackColor = true;
            // 
            // tabControl5
            // 
            tabControl5.Controls.Add(respons);
            tabControl5.Controls.Add(allParamRes);
            tabControl5.Location = new Point(3, 3);
            tabControl5.Name = "tabControl5";
            tabControl5.SelectedIndex = 0;
            tabControl5.Size = new Size(1050, 490);
            tabControl5.TabIndex = 0;
            // 
            // respons
            // 
            respons.Controls.Add(dataGridView9);
            respons.Location = new Point(4, 24);
            respons.Name = "respons";
            respons.Padding = new Padding(3);
            respons.Size = new Size(1042, 462);
            respons.TabIndex = 0;
            respons.Text = "Ответственные";
            respons.UseVisualStyleBackColor = true;
            // 
            // dataGridView9
            // 
            dataGridView9.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView9.Location = new Point(6, 6);
            dataGridView9.Name = "dataGridView9";
            dataGridView9.RowTemplate.Height = 25;
            dataGridView9.Size = new Size(856, 388);
            dataGridView9.TabIndex = 2;
            // 
            // allParamRes
            // 
            allParamRes.Controls.Add(dataGridView15);
            allParamRes.Location = new Point(4, 24);
            allParamRes.Name = "allParamRes";
            allParamRes.Padding = new Padding(3);
            allParamRes.Size = new Size(1042, 462);
            allParamRes.TabIndex = 1;
            allParamRes.Text = "Сведения об ответственных";
            allParamRes.UseVisualStyleBackColor = true;
            // 
            // dataGridView15
            // 
            dataGridView15.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView15.Location = new Point(150, 39);
            dataGridView15.Name = "dataGridView15";
            dataGridView15.RowTemplate.Height = 25;
            dataGridView15.Size = new Size(377, 281);
            dataGridView15.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 531);
            Controls.Add(entity);
            Name = "Form1";
            Text = "Form1";
            entity.ResumeLayout(false);
            shops.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            shop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView8).EndInit();
            allParamShop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView13).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView12).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView11).EndInit();
            laptops.ResumeLayout(false);
            tabControl3.ResumeLayout(false);
            laptop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            allParamLap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView7).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            providers.ResumeLayout(false);
            tabControl4.ResumeLayout(false);
            allParamProv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView10).EndInit();
            emailProv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView14).EndInit();
            responsible.ResumeLayout(false);
            tabControl5.ResumeLayout(false);
            respons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView9).EndInit();
            allParamRes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView15).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button knopka;
        private TabControl entity;
        private TabPage shops;
        private TabPage laptops;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private TabControl tabControl3;
        private TabPage laptop;
        private TabPage allParamLap;
        private TabPage providers;
        private TabControl tabControl4;
        private TabPage allParamProv;
        private TabPage emailProv;
        private TabPage responsible;
        private TabControl tabControl5;
        private TabPage respons;
        private TabPage allParamRes;
        private TabControl tabControl2;
        private TabPage shop;
        private TabPage allParamShop;
        private DataGridView dataGridView2;
        private DataGridView dataGridView4;
        private DataGridView dataGridView3;
        private Button button5;
        private Button button4;
        private Button button1;
        private DataGridView dataGridView5;
        private DataGridView dataGridView6;
        private DataGridView dataGridView7;
        private DataGridView dataGridView8;
        private DataGridView dataGridView13;
        private DataGridView dataGridView12;
        private DataGridView dataGridView11;
        private DataGridView dataGridView10;
        private DataGridView dataGridView14;
        private DataGridView dataGridView9;
        private DataGridView dataGridView15;
    }
}
