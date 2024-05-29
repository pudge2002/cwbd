using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace LapTop
{
    public partial class Form2 : Form
    {
        private OleDbConnection _con;
        static public string table;
        private string pole;

        public Form2(OleDbConnection connection)
        {
            InitializeComponent();
            _con = connection;
        }
        public void data(string x, string y) { 
            table = x;
            pole = y;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (_con == null || _con.State != ConnectionState.Open)
            {
                _con.Open();
            }

            string znach = textBox1.Text;
            string query = $"INSERT INTO {table} ({pole}) VALUES('" + znach + "')";
            string query2 = $"SELECT * FROM {table}";
            Form1 frm = new Form1(); //Form2 - название  формы

            try
            {
                using (OleDbCommand command = new OleDbCommand(query, _con))
                {
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Запись успешно добавлена.");

                        // Обновляем данные в таблице
                        frm.LoadData(Path.Combine(Application.StartupPath, "LapTop.mdb"));
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
            finally
            {
                // Закрываем подключение в блоке finally
                _con.Close();
            }
        }

    }
}
