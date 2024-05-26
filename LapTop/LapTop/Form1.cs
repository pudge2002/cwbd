using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace LapTop
{
    public partial class Form1 : Form
    {
        private OleDbConnection _con;

        public Form1()
        {
            InitializeComponent();

            // Пример использования файла базы данных, расположенного в проекте
            string databasePath = Path.Combine(Application.StartupPath, "LapTop.mdb");
            LoadData(databasePath);

            // Добавление значений в комбобокс
            comboBox1.Items.AddRange(new string[] { "Производитель", "Ноутбуки", "Модели" });

            // Установка обработчика события изменения выбранного значения в комбобоксе
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
        }

        private void LoadData(string databasePath)
        {
            // Закрытие предыдущего подключения, если оно существует
            if (_con != null && _con.State == ConnectionState.Open)
            {
                _con.Close();
            }

            // Создание подключения к базе данных
            _con = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={databasePath}");

            try
            {
                _con.Open();
                string query = "SELECT * FROM Ноутбуки";
                OleDbCommand command = new OleDbCommand(query, _con);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Убедитесь, что dataGridView1 инициализирован и находится на tabPage1
                if (tabPage1.Controls.Contains(dataGridView1))
                {
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("DataGridView не найден на tabPage1");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при подключении к базе данных: " + ex.Message);
            }
        }

        // Обработчик события изменения выбранного значения в комбобоксе
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem.ToString();

            switch (selectedValue)
            {
                case "Производитель":
                    LoadDataFromTable("Производители");
                    break;
                case "Ноутбуки":
                    LoadDataFromTable("Ноутбуки");
                    break;
                case "Модели":
                    LoadDataFromTable("Модели");
                    break;
                default:
                    MessageBox.Show("Выбранное значение не распознано");
                    break;
            }
        }

        // Метод для загрузки данных из указанной таблицы
        private void LoadDataFromTable(string tableName)
        {
            try
            {
                string query = $"SELECT * FROM {tableName}";
                OleDbCommand command = new OleDbCommand(query, _con);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных из таблицы {tableName}: " + ex.Message);
            }
        }

        private void knopka_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(_con); //где Form2 - название вашей формы
            frm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Обновление данных в таблице
            LoadData(Path.Combine(Application.StartupPath, "LapTop.mdb"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получаем индекс выбранной строки в DataGridView
            int rowIndex = dataGridView1.CurrentRow.Index;

            // Получаем значение из столбца, содержащего ключ (например, идентификатор)
            string keyValue = dataGridView1.Rows[rowIndex].Cells["Модель"].Value.ToString();

            // Формируем запрос на удаление строки с полученным значением ключа
            string query = $"DELETE FROM Модели WHERE Модель = '{keyValue}'";

            try
            {
                // Создаем команду для выполнения SQL-запроса
                OleDbCommand command = new OleDbCommand(query, _con);

                // Открываем подключение к базе данных
                _con.Open();

                // Выполняем запрос, который не возвращает результаты
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Запись успешно удалена.");

                    // Обновляем данные в DataGridView
                    LoadDataFromTable("Модели");
                }
                else
                {
                    MessageBox.Show("Запись не была удалена.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении записи: " + ex.Message);
            }
            finally
            {
                // Закрываем подключение к базе данных
                _con.Close();
            }
        }

    }
}
