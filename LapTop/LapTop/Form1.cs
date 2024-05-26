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

            // ������ ������������� ����� ���� ������, �������������� � �������
            string databasePath = Path.Combine(Application.StartupPath, "LapTop.mdb");
            LoadData(databasePath);

            // ���������� �������� � ���������
            comboBox1.Items.AddRange(new string[] { "�������������", "��������", "������" });

            // ��������� ����������� ������� ��������� ���������� �������� � ����������
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
        }

        private void LoadData(string databasePath)
        {
            // �������� ����������� �����������, ���� ��� ����������
            if (_con != null && _con.State == ConnectionState.Open)
            {
                _con.Close();
            }

            // �������� ����������� � ���� ������
            _con = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={databasePath}");

            try
            {
                _con.Open();
                string query = "SELECT * FROM ��������";
                OleDbCommand command = new OleDbCommand(query, _con);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // ���������, ��� dataGridView1 ��������������� � ��������� �� tabPage1
                if (tabPage1.Controls.Contains(dataGridView1))
                {
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("DataGridView �� ������ �� tabPage1");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("������ ��� ����������� � ���� ������: " + ex.Message);
            }
        }

        // ���������� ������� ��������� ���������� �������� � ����������
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem.ToString();

            switch (selectedValue)
            {
                case "�������������":
                    LoadDataFromTable("�������������");
                    break;
                case "��������":
                    LoadDataFromTable("��������");
                    break;
                case "������":
                    LoadDataFromTable("������");
                    break;
                default:
                    MessageBox.Show("��������� �������� �� ����������");
                    break;
            }
        }

        // ����� ��� �������� ������ �� ��������� �������
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
                MessageBox.Show($"������ ��� �������� ������ �� ������� {tableName}: " + ex.Message);
            }
        }

        private void knopka_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(_con); //��� Form2 - �������� ����� �����
            frm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ���������� ������ � �������
            LoadData(Path.Combine(Application.StartupPath, "LapTop.mdb"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // �������� ������ ��������� ������ � DataGridView
            int rowIndex = dataGridView1.CurrentRow.Index;

            // �������� �������� �� �������, ����������� ���� (��������, �������������)
            string keyValue = dataGridView1.Rows[rowIndex].Cells["������"].Value.ToString();

            // ��������� ������ �� �������� ������ � ���������� ��������� �����
            string query = $"DELETE FROM ������ WHERE ������ = '{keyValue}'";

            try
            {
                // ������� ������� ��� ���������� SQL-�������
                OleDbCommand command = new OleDbCommand(query, _con);

                // ��������� ����������� � ���� ������
                _con.Open();

                // ��������� ������, ������� �� ���������� ����������
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("������ ������� �������.");

                    // ��������� ������ � DataGridView
                    LoadDataFromTable("������");
                }
                else
                {
                    MessageBox.Show("������ �� ���� �������.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("������ ��� �������� ������: " + ex.Message);
            }
            finally
            {
                // ��������� ����������� � ���� ������
                _con.Close();
            }
        }

    }
}
