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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LapTop
{
    public partial class Form5 : Form
    {
        private OleDbConnection _con;
        public Form5(OleDbConnection connection)
        {

            InitializeComponent();
            _con = connection;
            LoadIdComboBox("Должности ответственных", comboBox6, dataGridView1);


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
          
            
            string query = "INSERT INTO [Ответственные] ([Фамилия ответственного], [Имя ответственного], [Отчество ответственного], [Номер ответственного], [Должность ответственного]) " +
            $"VALUES ('{textBox3.Text}', '{textBox2.Text}', '{textBox1.Text}', '{textBox4.Text}', {comboBox6.Text})";
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
