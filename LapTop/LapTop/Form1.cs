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
        DataTable provideTable;
        public Form1()
        {
            InitializeComponent();

            // Пример использования файла базы данных, расположенного в проекте
            string databasePath = Path.Combine(Application.StartupPath, "LapTop.mdb");
            LoadData(databasePath);

            // Добавление значений в комбобокс
            //comboBox1.Items.AddRange(new string[] { "Производитель", "Ноутбуки", "Модели" });

            //// Установка обработчика события изменения выбранного значения в комбобоксе
            //comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
        }
        private void FillDataGridView(string query, DataGridView dataGridView)
        {
            OleDbCommand command = new OleDbCommand(query, _con);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
        }
        private void FillTable(string query, DataTable dataTable)
        {
            OleDbCommand command = new OleDbCommand(query, _con);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            adapter.Fill(dataTable);
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

                string query1 = "SELECT c.Id AS [ID], b.[Производитель] AS [Производитель], m.[Производитель процессора] AS [Производитель процессора], f.[Серия процессора] AS [Серия процессора],  [ОЗУ],[Объем SSD], x.[Диагональ экрана] AS [Диагональ экрана],[Вес],[Цена],q.[Статус] AS [Статус],p.[Цвет] AS [Цвет]" +
              " FROM (((((([Ноутбуки] AS c" +
              " INNER JOIN [Производители] AS b ON c.[Производитель] = b.[ID])" +
              " INNER JOIN [Производители процессоров] AS m ON c.[Производитель процессора] = m.[ID])" +
              " INNER JOIN [Серии процессоров] AS f ON c.[Серия процессора] = f.[ID])" +
              " INNER JOIN [Диагонали экранов] AS x ON c.[Диагональ экрана] = x.[ID])" +
              " INNER JOIN [Статусы] AS q ON c.[Статус] = q.[ID])" +
              " INNER JOIN [Цвета] AS p ON c.[Цвет] = p.[ID])";
                string query2 = "SELECT c.Id AS [ID], b.[Город] AS [Город], m.[Улица] AS [Улица],[Дом], f.[Email] AS [Email]" +
              " FROM ((([Магазины] AS c" +
              " INNER JOIN [Города] AS b ON c.[Город] = b.[ID])" +
              " INNER JOIN [Улицы] AS m ON c.[Улица] = m.[ID])" +
              " INNER JOIN [Электронные почты] AS f ON c.[Email] = f.[ID])";
                string query3 = "SELECT c.Id AS [ID], [Фамилия Ответственного],[Имя ответственного],[Отчество ответственного ],[Номер ответственного], f.[Должность ответственного] AS [Должность ответственного]" +
              " FROM ([Ответственные] AS c" +
              " INNER JOIN [Должности ответственных] AS f ON c.[Должность ответственного] = f.[ID])";
                string query4 = "SELECT c.Id AS [ID],  [Фамилия поставщика],[Имя поставщика],[Отчество поставщика],[Телефон поставщика], f.[Email поставщика] AS [Email поставщика],[Дата поставки],[Количество поставки]" +
              " FROM ([Поставщики] AS c" +
              " INNER JOIN [Электронные почты поставщиков] AS f ON c.[Email поставщика] = f.[ID])";


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
            "SELECT * FROM [Электронные почты поставщиков]",
            "SELECT * FROM [Сводная таблица]"
                };
                DataTable[] dataTables = new DataTable[queries.Length];
                for (int i = 0; i < queries.Length; i++)
                {
                    dataTables[i] = new DataTable();
                    FillTable(queries[i], dataTables[i]);
                }
                // Использование метода для заполнения каждой таблицы
                FillDataGridView(query1, dataGridView1);
                FillDataGridView(query2, dataGridView8);
                FillDataGridView(query3, dataGridView9);
                FillDataGridView(query4, dataGridView10);
                dataGridView2.DataSource = dataTables[1]; // Производители
                dataGridView3.DataSource = dataTables[2]; // 
                dataGridView4.DataSource = dataTables[3]; // 
                dataGridView5.DataSource = dataTables[4]; //
                dataGridView6.DataSource = dataTables[5]; // М
                dataGridView7.DataSource = dataTables[6]; //
                dataGridView16.DataSource = dataTables[7]; // 

                dataGridView11.DataSource = dataTables[9]; // 
                dataGridView12.DataSource = dataTables[10]; // 
                dataGridView13.DataSource = dataTables[11]; // 

                dataGridView15.DataSource = dataTables[13]; // 

                dataGridView14.DataSource = dataTables[15]; // 
                dataGridView17.DataSource = dataTables[16]; // 

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения: " + ex.Message);
            }
        }


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

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteSelectedRow(_con, "Ноутбуки", dataGridView1);
        }

        private void DeleteSelectedRow(OleDbConnection _con, string entity, DataGridView dataGridView)

        {
            if (_con != null && _con.State == ConnectionState.Open)
            {
                _con.Close();
            }
            if (dataGridView.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView.SelectedRows[0].Index;
                int idToDelete = Convert.ToInt32(dataGridView.Rows[selectedRowIndex].Cells["ID"].Value);

                string deleteQuery = $"DELETE FROM [{entity}] WHERE Id = {idToDelete}";

                try
                {
                    using (OleDbCommand command = new OleDbCommand(deleteQuery, _con))
                    {
                        _con.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        _con.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Запись успешно удалена.");
                        }
                        else
                        {
                            MessageBox.Show("Запись не была удалена.");
                        }
                    }
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Ошибка при удалении записи: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла непредвиденная ошибка: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления.");
            }
            LoadData(Path.Combine(Application.StartupPath, "LapTop.mdb"));
        }


        private void button6_Click(object sender, EventArgs e)
        {
            DeleteSelectedRow(_con, "Сводная таблица", dataGridView17);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LoadData(Path.Combine(Application.StartupPath, "LapTop.mdb"));
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DeleteSelectedRow(_con, "Магазины", dataGridView8);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DeleteSelectedRow(_con, "Поставщики", dataGridView10);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            DeleteSelectedRow(_con, "Ответственные", dataGridView9);
        }
    }
}
