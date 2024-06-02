using System;
using System.Collections;
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
        string query1 = "SELECT c.Id AS [ID], b.[Производитель] AS [Производитель],i.[Модель] AS [Модель], m.[Производитель процессора] AS [Производитель процессора], f.[Серия процессора] AS [Серия процессора],  [ОЗУ],[Объем SSD], x.[Диагональ экрана] AS [Диагональ экрана],[Вес],[Цена],q.[Статус] AS [Статус],p.[Цвет] AS [Цвет]" +
             " FROM ((((((([Ноутбуки] AS c" +
             " INNER JOIN [Производители] AS b ON c.[Производитель] = b.[ID])" +
                " INNER JOIN [Модели] AS i ON c.[Модель] = i.[ID])" +
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
        string query3 = "SELECT c.Id AS [ID], [Фамилия Ответственного],[Имя ответственного],[Отчество ответственного],[Номер ответственного], f.[Должность ответственного] AS [Должность ответственного]" +
      " FROM ([Ответственные] AS c" +
      " INNER JOIN [Должности ответственных] AS f ON c.[Должность ответственного] = f.[ID])";
        string query4 = "SELECT c.Id AS [ID],  [Фамилия поставщика],[Имя поставщика],[Отчество поставщика],[Телефон поставщика], f.[Email поставщика] AS [Email поставщика],[Дата поставки],[Количество поставки]" +
      " FROM ([Поставщики] AS c" +
      " INNER JOIN [Электронные почты поставщиков] AS f ON c.[Email поставщика] = f.[ID])";
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
            comboBox1.Items.AddRange(new string[] { "Город", "Улица", "Дом" });

            // Установка обработчика события изменения выбранного значения в комбобоксе
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            comboBox2.Items.AddRange(new string[] { "Производитель", "Модель", "Производитель процессора", "Серия процессора", "ОЗУ", "Объем SSD", "Диагональ экрана", "Цена", "Статус", "Цвет" });

            // Установка обработчика события изменения выбранных элементов в ListBox
            comboBox2.SelectedIndexChanged += ComboBox2_SelectedIndexChanged;
            comboBox3.Items.AddRange(new string[] { "Дата поставки", "Количество поставки", "Фамилия поставщика" });

            // Установка обработчика события изменения выбранного значения в комбобоксе
            comboBox3.SelectedIndexChanged += ComboBox3_SelectedIndexChanged;
            comboBox4.Items.AddRange(new string[] { "Фамилия Ответственного", "Должность ответственного" });

            // Установка обработчика события изменения выбранного значения в комбобоксе
            comboBox4.SelectedIndexChanged += ComboBox4_SelectedIndexChanged;
            comboBox6.Items.AddRange(new string[] { "Производители", "Модели", "Производители процессоров", "Серии процессоров", "Диагонали экранов", "Статусы", "Цвета" });

            // Установка обработчика события изменения выбранного значения в комбобоксе
            comboBox6.SelectedIndexChanged += ComboBox6_SelectedIndexChanged;
            comboBox5.Items.AddRange(new string[] { "Больше", "Меньше", "Равно" });

            // Установка обработчика события изменения выбранного значения в комбобоксе
            comboBox5.SelectedIndexChanged += ComboBox5_SelectedIndexChanged;
            comboBox7.Items.AddRange(new string[] { "Города", "Улицы", "Электронные почты" });

            // Установка обработчика события изменения выбранного значения в комбобоксе
            comboBox7.SelectedIndexChanged += ComboBox7_SelectedIndexChanged;
            comboBox8.Items.AddRange(new string[] { "Больше", "Меньше", "Равно" });

            // Установка обработчика события изменения выбранного значения в комбобоксе
            comboBox8.SelectedIndexChanged += ComboBox8_SelectedIndexChanged;
            comboBox9.Items.AddRange(new string[] { "Заведующий", "Консультант", "Менеджер" });

            // Установка обработчика события изменения выбранного значения в комбобоксе
            comboBox9.SelectedIndexChanged += ComboBox9_SelectedIndexChanged;
            comboBox10.Items.AddRange(new string[] { "Объем SSD", "ОЗУ", "Диагональ экрана", "Вес", "Цена" });
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
        public void LoadData(string databasePath)
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

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Город");
            comboBox1.Items.Add("Улица");
            comboBox1.Items.Add("Дом");
        }
        public void LoadDataFromTable(string tableName)
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
            Form3 fr = new Form3(_con);
            fr.Show();
            LoadData(Path.Combine(Application.StartupPath, "LapTop.mdb"));
        }
        //обновить таблицу
        private void button2_Click(object sender, EventArgs e)
        {
            // Обновление данных в таблице
            LoadData(Path.Combine(Application.StartupPath, "LapTop.mdb"));
        }
        private void delInTab(string table, string pole, DataGridView dg)
        {
            if (_con != null && _con.State == ConnectionState.Open)
            {
                _con.Close();
            }
            // Получаем индекс выбранной строки в DataGridView
            int rowIndex = dg.CurrentRow.Index;

            // Получаем значение из столбца, содержащего ключ (например, идентификатор)
            string keyValue = dg.Rows[rowIndex].Cells[pole].Value.ToString();

            // Формируем запрос на удаление строки с полученным значением ключа
            string query = $"DELETE FROM {table} WHERE [{pole}] = '{keyValue}'";

            DialogResult dr = MessageBox.Show("Вы увиерены что хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
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

                        LoadData(Path.Combine(Application.StartupPath, "LapTop.mdb"));
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
        //изменение в таблицах
        private void updateInTab(string table, string pole, string newValue, DataGridView dg)
        {
            if (_con != null && _con.State == ConnectionState.Open)
            {
                _con.Close();
            }

            // Получаем индекс выбранной строки в DataGridView
            int rowIndex = dg.CurrentRow.Index;

            // Получаем значение из столбца, содержащего ключ (например, идентификатор)
            string keyValue = dg.Rows[rowIndex].Cells[pole].Value.ToString();

            // Формируем запрос на обновление значения в столбце с полученным значением ключа
            string query = $"UPDATE [{table}] SET [{pole}] = '{newValue}' WHERE [{pole}] = '{keyValue}'";

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
                    MessageBox.Show("Значение успешно изменено.");

                    LoadData(Path.Combine(Application.StartupPath, "LapTop.mdb"));
                }
                else
                {
                    MessageBox.Show("Значение не было изменено.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при изменении значения: " + ex.Message);
            }
            finally
            {
                // Закрываем подключение к базе данных
                _con.Close();
            }
        }

        //Удаление из ноутбуков
        private void button3_Click(object sender, EventArgs e)
        {
            DeleteSelectedRow(_con, "Ноутбуки", dataGridView1);
        }
        //удаление элкментов из таблицы
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

                DialogResult dr = MessageBox.Show("Вы увиерены что хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
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
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления.");
            }
            LoadData(Path.Combine(Application.StartupPath, "LapTop.mdb"));
        }
        //Сортировка в магазинах
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem.ToString();
            string desc = "";
            if (checkBox1.Checked)
                desc = "DESC";
            switch (selectedValue)
            {
                case "Город":
                    LoadDataFromTable2("b.[Город]", dataGridView8, query2, desc);
                    break;
                case "Улица":
                    LoadDataFromTable2("m.[Улица]", dataGridView8, query2, desc);
                    break;
                case "Дом":
                    LoadDataFromTable2("[Дом]", dataGridView8, query2, desc);
                    break;

                default:
                    MessageBox.Show("ошибка");
                    break;
            }
        }
        //Сортировка в ноутбуках
        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox2.SelectedItem.ToString();
            string desc = "";
            if (checkBox2.Checked)
                desc = "DESC";
            switch (selectedValue)
            {
                case "Производитель":
                    LoadDataFromTable2("b.[Производитель]", dataGridView1, query1, desc);
                    break;
                case "Модель":
                    LoadDataFromTable2("i.[Модель]", dataGridView1, query1, desc);
                    break;
                case "Производитель процессора":
                    LoadDataFromTable2("m.[Производитель процессора]", dataGridView1, query1, desc);
                    break;
                case "Серия процессора":
                    LoadDataFromTable2("d.[Серия процессора]", dataGridView1, query1, desc);
                    break;
                case "ОЗУ":
                    LoadDataFromTable2("[ОЗУ]", dataGridView1, query1, desc);
                    break;
                case "Объем SSD":
                    LoadDataFromTable2("[Объем SSD]", dataGridView1, query1, desc);
                    break;
                case "Диагональ экрана":
                    LoadDataFromTable2("x.[Диагональ экрана]", dataGridView1, query1, desc);
                    break;
                case "Цена":
                    LoadDataFromTable2("[Цена]", dataGridView1, query1, desc);
                    break;
                case "Статус":
                    LoadDataFromTable2("q.[Статус]", dataGridView1, query1, desc);
                    break;
                case "Цвет":
                    LoadDataFromTable2("p.[Цвет]", dataGridView1, query1, desc);
                    break;

                default:
                    MessageBox.Show("ошибка");
                    break;
            }
        }
        //Работа с маленькими таблицами ноутбуков
        private void ComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox6.SelectedItem.ToString();
            Form2 frm2 = new Form2(_con); //Form2 - название  формы
            switch (selectedValue)
            {

                case "Производители":
                    frm2.data("Производители", "Производитель");
                    frm2.Show();
                    break;
                case "Модели":
                    frm2.data("Производители", "Производитель");
                    frm2.Show();
                    break;
                case "Производители процессоров":
                    frm2.data("[Производители процессоров]", "[Производитель процессора]");
                    frm2.Show();
                    break;
                case "Серии процессоров":
                    frm2.data("[Серии процессоров]", "[Серия процессора]");
                    frm2.Show();
                    break;

                case "Диагонали экранов":
                    frm2.data("[Диагонали экранов]", "[Диагональ экрана]");
                    frm2.Show();
                    break;
                case "Статусы":
                    frm2.data("Статусы", "Статус");
                    frm2.Show();
                    break;
                case "Цвета":
                    frm2.data("Цвета", "Цвет");
                    frm2.Show();
                    break;
                default:
                    MessageBox.Show("ошибка");
                    break;
            }
        }
        //Сортировка ответственных
        private void ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox4.SelectedItem.ToString();
            string desc = "";
            if (checkBox4.Checked)
                desc = "DESC";
            switch (selectedValue)
            {

                case "Фамилия Ответственного":
                    LoadDataFromTable2("[Фамилия Ответственного]", dataGridView9, query3, desc);
                    break;
                case "Должность ответственного":
                    LoadDataFromTable2("f.[Должность ответственного]", dataGridView9, query3, desc);
                    break;

                default:
                    MessageBox.Show("ошибка");
                    break;
            }
        }
        //Выборки у ноутбуков
        private void ComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox5.SelectedItem.ToString();
            string Value = comboBox10.SelectedItem == null ? "" : comboBox10.SelectedItem.ToString();
            string znach = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(Value) || string.IsNullOrEmpty(znach))
            {
                MessageBox.Show("Ошибка: Не выбрано поле и не указано значение.");
                return;
            }

            if (Value == "Диагональ экрана")
            {
                Value = "x.[Диагональ экрана]";
            }

            switch (selectedValue)
            {
                case "Больше":
                    LoadDataFromTable3(Value, dataGridView1, query1, znach, ">");
                    break;
                case "Меньше":
                    LoadDataFromTable3(Value, dataGridView1, query1, znach, "<");
                    break;
                case "Равно":
                    LoadDataFromTable3(Value, dataGridView1, query1, znach, "=");
                    break;
                default:
                    MessageBox.Show("ошибка");
                    break;
            }
        }
        //Сортировка поставщиков
        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox3.SelectedItem.ToString();
            string desc = "";
            if (checkBox3.Checked)
                desc = "DESC";
            switch (selectedValue)
            {
                case "Дата поставки":
                    LoadDataFromTable2("[Дата поставки]", dataGridView10, query4, desc);
                    break;
                case "Количество поставки":
                    LoadDataFromTable2("[Количество поставки]", dataGridView10, query4, desc);
                    break;
                case "Фамилия поставщика":
                    LoadDataFromTable2("[Фамилия поставщика]", dataGridView10, query4, desc);
                    break;

                default:
                    MessageBox.Show("ошибка");
                    break;
            }
        }
        private void ComboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox7.SelectedItem.ToString();
            Form2 frm2 = new Form2(_con); //Form2 - название  формы
            switch (selectedValue)
            {
                case "Города":
                    frm2.data("[Города]", "[Город]");
                    frm2.Show();
                    break;
                case "Улицы":
                    frm2.data("[Улицы]", "[Улица]");
                    frm2.Show();
                    break;
                case "Электронные почты":
                    frm2.data("[Электронные почты]", "Email");
                    frm2.Show();
                    break;
                default:
                    MessageBox.Show("ошибка");
                    break;
            }
        }
        //выборка по дате у поставщиков
        private void ComboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox8.SelectedItem.ToString();
            string znach = "#" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "#"; ;

            string Value = "[Дата поставки]";



            switch (selectedValue)
            {

                case "Больше":
                    LoadDataFromTable3(Value, dataGridView10, query4, znach, ">");
                    break;
                case "Меньше":
                    LoadDataFromTable3(Value, dataGridView10, query4, znach, "<");
                    break;
                case "Равно":
                    LoadDataFromTable3(Value, dataGridView10, query4, znach, "=");
                    break;
                default:
                    MessageBox.Show("ошибка");
                    break;
            }
        }
        private void ComboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox9.SelectedItem.ToString();
            string znach = "'" + comboBox9.Text + "'";
            switch (selectedValue)
            {
                case "Заведующий":
                    LoadDataFromTable3("f.[Должность ответственного]", dataGridView9, query3, znach, "=");
                    break;
                case "Менеджер":
                    LoadDataFromTable3("f.[Должность ответственного]", dataGridView9, query3, znach, "=");
                    break;
                case "Консультант":
                    LoadDataFromTable3("f.[Должность ответственного]", dataGridView9, query3, znach, "=");
                    break;

                default:
                    MessageBox.Show("ошибка");
                    break;
            }
        }
        private void LoadDataFromTable2(string tableName, DataGridView dataGridVieww, string querry, string desc)
        {

            string query = $"{querry} ORDER BY {tableName} {desc}";
            OleDbCommand command = new OleDbCommand(query, _con);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridVieww.DataSource = dataTable;


        }
        private void LoadDataFromTable3(string tableName, DataGridView dataGridVieww, string querry, string znach, string znak)
        {
            LoadData(Path.Combine(Application.StartupPath, "LapTop.mdb"));
            string query = $"{querry} WHERE {tableName}{znak}{znach}";
            OleDbCommand command = new OleDbCommand(query, _con);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridVieww.DataSource = dataTable;


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

        private void button17_Click(object sender, EventArgs e)
        {
            string query = $"{query1} WHERE q.[Статус] = 'В наличии'";
            OleDbCommand command = new OleDbCommand(query, _con);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
        }



        private void button30_Click(object sender, EventArgs e)
        {
            delInTab("Города", "Город", dataGridView11);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            delInTab("Улицы", "Улица", dataGridView12);
        }
        private void button34_Click(object sender, EventArgs e)
        {
            delInTab("[Электронные почты]", "Email", dataGridView13);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            delInTab("Производители", "производитель", dataGridView2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            delInTab("Модели", "Модель", dataGridView3);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            delInTab("[Производители процессоров]", "Производитель процессора", dataGridView4);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            delInTab("[Серии процессоров]", "Серия процессора", dataGridView5);
        }



        private void button18_Click(object sender, EventArgs e)
        {
            delInTab("[Диагонали экранов]", "Диагональ экрана", dataGridView6);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            delInTab("Цвета", "Цвет", dataGridView16);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            delInTab("Статусы", "Статус", dataGridView7);

        }

        private void button29_Click(object sender, EventArgs e)
        {
            delInTab("[Электронные почты поставщиков]", "Email поставщика", dataGridView14);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            delInTab("[Должности ответственных]", "Должность ответственного", dataGridView15);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(_con); //Form2 - название  формы

            frm2.data("[Должности ответственных]", "[Должность ответственного]");
            frm2.Show();
            LoadData(Path.Combine(Application.StartupPath, "LapTop.mdb"));
        }

        private void button43_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(_con); //Form2 - название  формы

            frm2.data("[Электронные почты поставщиков]", "[Email поставщика]");
            frm2.Show();
            LoadData(Path.Combine(Application.StartupPath, "LapTop.mdb"));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form4 fr = new Form4(_con);
            fr.Show();
            LoadData(Path.Combine(Application.StartupPath, "LapTop.mdb"));
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form6 fr = new Form6(_con);
            fr.Show();
            LoadData(Path.Combine(Application.StartupPath, "LapTop.mdb"));
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form5 fr = new Form5(_con);
            fr.Show();
            LoadData(Path.Combine(Application.StartupPath, "LapTop.mdb"));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LoadData(Path.Combine(Application.StartupPath, "LapTop.mdb"));
        }

        private void button12_Click(object sender, EventArgs e)
        {
            LoadData(Path.Combine(Application.StartupPath, "LapTop.mdb"));
        }

        private void button15_Click(object sender, EventArgs e)
        {
            LoadData(Path.Combine(Application.StartupPath, "LapTop.mdb"));
        }

        private void button31_Click(object sender, EventArgs e)
        {
            // Получаем индекс выбранной строки в DataGridView
            int rowIndex = dataGridView11.CurrentRow.Index;

            // Получаем значение из первой ячейки в выбранной строке
           
           //string cv = dataGridView11.Rows[rowIndex].Cells["Город"].Value.ToString();
            MessageBox.Show("Данные измененены ");
            //updateInTab("Города", "Город", cv, dataGridView11);

        }
    }
}
