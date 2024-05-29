﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LapTop
{
    public partial class Form3 : Form
    {
        private OleDbConnection _con;
        public Form3(OleDbConnection connection)
        {

            InitializeComponent();
            _con = connection;
            LoadIdComboBox("Производители", comboBox1, dataGridView1);
            LoadIdComboBox("Модели", comboBox2, dataGridView2);
            LoadIdComboBox("Производители процессоров", comboBox3, dataGridView3);
            LoadIdComboBox("Серии процессоров", comboBox4, dataGridView4);
            LoadIdComboBox("Диагонали экранов", comboBox6, dataGridView7);
            LoadIdComboBox("Статусы", comboBox5, dataGridView6);
            LoadIdComboBox("Цвета", comboBox7, dataGridView5);
        }
        private void LoadIdComboBox(string entity, System.Windows.Forms.ComboBox idComboBox, DataGridView dataGridView)
        {
            if (_con == null || _con.State != ConnectionState.Open)
            {
                _con.Open();
            }

            // Загружаем значения ID в ComboBox
            string queryId = $"SELECT Id FROM [{entity}]";

            try
            {
                using (OleDbCommand commandId = new OleDbCommand(queryId, _con))
                {
                    // _con.Open(); // Эту строку нужно удалить

                    using (OleDbDataReader readerId = commandId.ExecuteReader())
                    {
                        while (readerId.Read())
                        {
                            int id = readerId.GetInt32(0);
                            idComboBox.Items.Add(id); // Добавляем значение ID в ComboBox
                        }
                    }

                    _con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке значений ID: " + ex.Message);
            }

            // Загружаем данные из таблицы в DataGridView
            string queryData = $"SELECT * FROM [{entity}]";

            try
            {
                using (OleDbCommand commandData = new OleDbCommand(queryData, _con))
                {
                    _con.Open();

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(commandData))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView.DataSource = dataTable; // Устанавливаем источник данных для DataGridView
                    }

                    _con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных из таблицы: " + ex.Message);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (_con == null || _con.State != ConnectionState.Open)
            {
                _con.Open();
            }
           
                string query = "INSERT INTO [Ноутбуки] ([Производитель], [Модель], [Производитель процессора], [Серия процессора],[ОЗУ], [Объем SSD], [Диагональ экрана], [Вес], [Цена], [Статус], [Цвет]) " +
                $"VALUES ({comboBox1.Text}, {comboBox2.Text}, {comboBox3.Text}, {comboBox4.Text}, {textBox1.Text}, {textBox2.Text}, {comboBox6.Text}, {textBox3.Text}, {textBox4.Text}, {comboBox5.Text}, {comboBox7.Text})";
            try
            {
                using (OleDbCommand command = new OleDbCommand(query, _con))
                {
                    // _con.Open(); // Эту строку нужно удалить
                    int rowsAffected = command.ExecuteNonQuery();
                    _con.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Запись успешно добавлена.");
                    }
                    else
                    {
                        MessageBox.Show("Запись не была добавлена.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении записи: " + ex.Message);
            }
           
        }

       
    }
}
