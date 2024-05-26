using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace LapTop
{
    public partial class Form2 : Form
    {
        private OleDbConnection _con;

        public Form2(OleDbConnection connection)
        {
            InitializeComponent();
            _con = connection;
        }

      

        private void button1_Click_1(object sender, EventArgs e)
        {

            string znach = textBox1.Text;
            string query = "INSERT INTO Модели (Модель) VALUES('" + znach + "')";

            try
            {
                using (OleDbCommand command = new OleDbCommand(query, _con))
                {
                    int rowsAffected = command.ExecuteNonQuery();

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
            finally
            {
                _con.Close(); // Закрываем подключение в блоке finally
            }
        }
    }
}
