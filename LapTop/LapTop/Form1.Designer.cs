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
            comboBox1 = new ComboBox();
            label1 = new Label();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            dataGridView8 = new DataGridView();
            allParamShop = new TabPage();
            dataGridView13 = new DataGridView();
            dataGridView12 = new DataGridView();
            dataGridView11 = new DataGridView();
            laptops = new TabPage();
            tabControl3 = new TabControl();
            laptop = new TabPage();
            comboBox2 = new ComboBox();
            label2 = new Label();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            allParamLap = new TabPage();
            dataGridView16 = new DataGridView();
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
            comboBox3 = new ComboBox();
            label3 = new Label();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            dataGridView10 = new DataGridView();
            emailProv = new TabPage();
            dataGridView14 = new DataGridView();
            responsible = new TabPage();
            tabControl5 = new TabControl();
            respons = new TabPage();
            comboBox4 = new ComboBox();
            label4 = new Label();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            dataGridView9 = new DataGridView();
            allParamRes = new TabPage();
            dataGridView15 = new DataGridView();
            svo = new TabPage();
            button7 = new Button();
            button6 = new Button();
            dataGridView17 = new DataGridView();
            checkedListBox1 = new CheckedListBox();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView16).BeginInit();
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
            svo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView17).BeginInit();
            SuspendLayout();
            // 
            // knopka
            // 
            knopka.Location = new Point(888, 58);
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
            entity.Controls.Add(svo);
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
            shop.Controls.Add(comboBox1);
            shop.Controls.Add(label1);
            shop.Controls.Add(button8);
            shop.Controls.Add(button9);
            shop.Controls.Add(button10);
            shop.Controls.Add(dataGridView8);
            shop.Location = new Point(4, 24);
            shop.Name = "shop";
            shop.Padding = new Padding(3);
            shop.Size = new Size(1042, 462);
            shop.TabIndex = 2;
            shop.Text = "Магазин";
            shop.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(888, 193);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(148, 23);
            comboBox1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(888, 164);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 9;
            label1.Text = "Сортировка по";
            // 
            // button8
            // 
            button8.Location = new Point(888, 58);
            button8.Name = "button8";
            button8.Size = new Size(148, 21);
            button8.TabIndex = 6;
            button8.Text = "Добавить запись";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(888, 6);
            button9.Name = "button9";
            button9.Size = new Size(148, 23);
            button9.TabIndex = 7;
            button9.Text = "Обновить";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(888, 116);
            button10.Name = "button10";
            button10.Size = new Size(148, 23);
            button10.TabIndex = 8;
            button10.Text = "Удалить запись";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // dataGridView8
            // 
            dataGridView8.AllowUserToAddRows = false;
            dataGridView8.AllowUserToDeleteRows = false;
            dataGridView8.AllowUserToResizeRows = false;
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
            laptop.Controls.Add(checkedListBox1);
            laptop.Controls.Add(comboBox2);
            laptop.Controls.Add(label2);
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
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(888, 188);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(148, 23);
            comboBox2.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(888, 159);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 11;
            label2.Text = "Сортировка по";
            // 
            // button2
            // 
            button2.Location = new Point(888, 6);
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
            button3.Location = new Point(888, 116);
            button3.Name = "button3";
            button3.Size = new Size(148, 23);
            button3.TabIndex = 5;
            button3.Text = "Удалить запись";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // allParamLap
            // 
            allParamLap.Controls.Add(dataGridView16);
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
            // dataGridView16
            // 
            dataGridView16.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView16.Location = new Point(322, 287);
            dataGridView16.Name = "dataGridView16";
            dataGridView16.RowTemplate.Height = 25;
            dataGridView16.Size = new Size(221, 110);
            dataGridView16.TabIndex = 9;
            // 
            // dataGridView5
            // 
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Location = new Point(323, 159);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.RowTemplate.Height = 25;
            dataGridView5.Size = new Size(220, 106);
            dataGridView5.TabIndex = 8;
            // 
            // dataGridView6
            // 
            dataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView6.Location = new Point(16, 287);
            dataGridView6.Name = "dataGridView6";
            dataGridView6.RowTemplate.Height = 25;
            dataGridView6.Size = new Size(219, 110);
            dataGridView6.TabIndex = 7;
            // 
            // dataGridView7
            // 
            dataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView7.Location = new Point(16, 159);
            dataGridView7.Name = "dataGridView7";
            dataGridView7.RowTemplate.Height = 25;
            dataGridView7.Size = new Size(219, 106);
            dataGridView7.TabIndex = 6;
            // 
            // button5
            // 
            button5.Location = new Point(579, 194);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 5;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(782, 194);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(683, 194);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(583, 16);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowTemplate.Height = 25;
            dataGridView4.Size = new Size(220, 110);
            dataGridView4.TabIndex = 2;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(323, 16);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(220, 110);
            dataGridView3.TabIndex = 1;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(16, 16);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(219, 110);
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
            allParamProv.Controls.Add(comboBox3);
            allParamProv.Controls.Add(label3);
            allParamProv.Controls.Add(button11);
            allParamProv.Controls.Add(button12);
            allParamProv.Controls.Add(button13);
            allParamProv.Controls.Add(dataGridView10);
            allParamProv.Location = new Point(4, 24);
            allParamProv.Name = "allParamProv";
            allParamProv.Padding = new Padding(3);
            allParamProv.Size = new Size(1042, 462);
            allParamProv.TabIndex = 0;
            allParamProv.Text = "Сведения о поставщиках";
            allParamProv.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(888, 198);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(148, 23);
            comboBox3.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(888, 169);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 11;
            label3.Text = "Сортировка по";
            // 
            // button11
            // 
            button11.Location = new Point(888, 58);
            button11.Name = "button11";
            button11.Size = new Size(148, 21);
            button11.TabIndex = 6;
            button11.Text = "Добавить запись";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Location = new Point(888, 6);
            button12.Name = "button12";
            button12.Size = new Size(148, 23);
            button12.TabIndex = 7;
            button12.Text = "Обновить";
            button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.Location = new Point(888, 116);
            button13.Name = "button13";
            button13.Size = new Size(148, 23);
            button13.TabIndex = 8;
            button13.Text = "Удалить запись";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
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
            respons.Controls.Add(comboBox4);
            respons.Controls.Add(label4);
            respons.Controls.Add(button14);
            respons.Controls.Add(button15);
            respons.Controls.Add(button16);
            respons.Controls.Add(dataGridView9);
            respons.Location = new Point(4, 24);
            respons.Name = "respons";
            respons.Padding = new Padding(3);
            respons.Size = new Size(1042, 462);
            respons.TabIndex = 0;
            respons.Text = "Ответственные";
            respons.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(888, 202);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(148, 23);
            comboBox4.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(888, 173);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 11;
            label4.Text = "Сортировка по";
            // 
            // button14
            // 
            button14.Location = new Point(888, 58);
            button14.Name = "button14";
            button14.Size = new Size(148, 21);
            button14.TabIndex = 6;
            button14.Text = "Добавить запись";
            button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            button15.Location = new Point(888, 6);
            button15.Name = "button15";
            button15.Size = new Size(148, 23);
            button15.TabIndex = 7;
            button15.Text = "Обновить";
            button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            button16.Location = new Point(888, 116);
            button16.Name = "button16";
            button16.Size = new Size(148, 23);
            button16.TabIndex = 8;
            button16.Text = "Удалить запись";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
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
            // svo
            // 
            svo.Controls.Add(button7);
            svo.Controls.Add(button6);
            svo.Controls.Add(dataGridView17);
            svo.Location = new Point(4, 24);
            svo.Name = "svo";
            svo.Size = new Size(1059, 493);
            svo.TabIndex = 4;
            svo.Text = "Сводная таблица";
            svo.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(485, 421);
            button7.Name = "button7";
            button7.Size = new Size(110, 44);
            button7.TabIndex = 2;
            button7.Text = "Обновить таблицу";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(285, 421);
            button6.Name = "button6";
            button6.Size = new Size(140, 44);
            button6.TabIndex = 1;
            button6.Text = "Удалить запись";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // dataGridView17
            // 
            dataGridView17.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView17.Location = new Point(3, 34);
            dataGridView17.Name = "dataGridView17";
            dataGridView17.RowTemplate.Height = 25;
            dataGridView17.Size = new Size(1056, 365);
            dataGridView17.TabIndex = 0;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(888, 241);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(120, 94);
            checkedListBox1.TabIndex = 14;
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
            shop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView8).EndInit();
            allParamShop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView13).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView12).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView11).EndInit();
            laptops.ResumeLayout(false);
            tabControl3.ResumeLayout(false);
            laptop.ResumeLayout(false);
            laptop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            allParamLap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView16).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView7).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            providers.ResumeLayout(false);
            tabControl4.ResumeLayout(false);
            allParamProv.ResumeLayout(false);
            allParamProv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView10).EndInit();
            emailProv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView14).EndInit();
            responsible.ResumeLayout(false);
            tabControl5.ResumeLayout(false);
            respons.ResumeLayout(false);
            respons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView9).EndInit();
            allParamRes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView15).EndInit();
            svo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView17).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button knopka;
        private TabControl entity;
        private TabPage shops;
        private TabPage laptops;
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
        private DataGridView dataGridView16;
        private TabPage svo;
        private Button button7;
        private Button button6;
        private DataGridView dataGridView17;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private ComboBox comboBox1;
        private Label label1;
        private ComboBox comboBox2;
        private Label label2;
        private ComboBox comboBox3;
        private Label label3;
        private ComboBox comboBox4;
        private Label label4;
        private CheckedListBox checkedListBox1;
    }
}
