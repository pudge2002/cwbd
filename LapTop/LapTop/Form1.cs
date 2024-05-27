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
        string[] queries = new string[]
                {
            "SELECT * FROM Ноутбуки",
            "SELECT * FROM Производители",
            "SELECT * FROM Модели",
            "SELECT * FROM [Производители Процессоров]",
            "SELECT * FROM [Серии Процессоров]",
            "SELECT * FROM [Диагонали Экранов]",
            "SELECT * FROM Статусы",
            "SELECT * FROM Цвета",
            "SELECT * FROM Магазины",
            "SELECT * FROM Города",
            "SELECT * FROM Улицы",
            "SELECT * FROM [Электронные почты]",
            "SELECT * FROM Ответственные",
            "SELECT * FROM [Должности ответственных]",
            "SELECT * FROM Поставщики",
            "SELECT * FROM [Электронные почты поставщиков]"
                };
        DataTable provideTable ;
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
            // 
            if (_con != null && _con.State == ConnectionState.Open)
            {
                _con.Close();
            }

            // 
            _con = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={databasePath}");

            try
            {
                _con.Open();
              
                string query1 = "SELECT c.Id AS [ID], b.[Производитель] AS [Производитель], m.[Производитель процессора] AS [Производитель процессора], f.[Серия процессора] AS [Серия процессора],  [ОЗУ],[Объем SSD], x.[Диагональ экрана] AS [Диагональ экрана],[Вес],[Цена],q.[Статус] AS [Статус],p.[Цвет] AS [Цвет]" +  // работает)))))
              " FROM (((((([Ноутбуки] AS c" +
              " INNER JOIN [Производители] AS b ON c.[Производитель] = b.[ID])" +
              " INNER JOIN [Производители процессоров] AS m ON c.[Производитель процессора] = m.[ID])" +
              " INNER JOIN [Серии процессоров] AS f ON c.[Серия процессора] = f.[ID])" +
              " INNER JOIN [Диагонали экранов] AS x ON c.[Диагональ экрана] = x.[ID])" +
              " INNER JOIN [Статусы] AS q ON c.[Статус] = q.[ID])" +
              " INNER JOIN [Цвета] AS p ON c.[Цвет] = p.[ID])";
                string query2 = "SELECT c.Id AS [ID], b.[Производитель] AS [Производитель], m.[Производитель процессора] AS [Производитель процессора],[Дом], f.[Серия процессора] AS [Серия процессора]" +  // работает)))))
              " FROM ((([Ноутбуки] AS c" +
              " INNER JOIN [Города] AS b ON c.[Город] = b.[ID])" +
              " INNER JOIN [Улицы] AS m ON c.[Улица] = m.[ID])" +
              " INNER JOIN [Электронные почты] AS f ON c.[Email] = f.[ID])";
                OleDbCommand command = new OleDbCommand(query1, _con);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // 
                if (laptop.Controls.Contains(dataGridView1))
                {
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("DataGridView error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения: " + ex.Message);
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
            Form2 frm2 = new Form2(_con); //Form2 - название  формы
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
