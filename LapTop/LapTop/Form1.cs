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
            "SELECT * FROM ��������",
            "SELECT * FROM �������������",
            "SELECT * FROM ������",
            "SELECT * FROM [������������� �����������]",
            "SELECT * FROM [����� �����������]",
            "SELECT * FROM [��������� �������]",
            "SELECT * FROM �������",
            "SELECT * FROM �����",
            "SELECT * FROM ��������",
            "SELECT * FROM ������",
            "SELECT * FROM �����",
            "SELECT * FROM [����������� �����]",
            "SELECT * FROM �������������",
            "SELECT * FROM [��������� �������������]",
            "SELECT * FROM ����������",
            "SELECT * FROM [����������� ����� �����������]"
                };
        DataTable provideTable ;
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
              
                string query1 = "SELECT c.Id AS [ID], b.[�������������] AS [�������������], m.[������������� ����������] AS [������������� ����������], f.[����� ����������] AS [����� ����������],  [���],[����� SSD], x.[��������� ������] AS [��������� ������],[���],[����],q.[������] AS [������],p.[����] AS [����]" +  // ��������)))))
              " FROM (((((([��������] AS c" +
              " INNER JOIN [�������������] AS b ON c.[�������������] = b.[ID])" +
              " INNER JOIN [������������� �����������] AS m ON c.[������������� ����������] = m.[ID])" +
              " INNER JOIN [����� �����������] AS f ON c.[����� ����������] = f.[ID])" +
              " INNER JOIN [��������� �������] AS x ON c.[��������� ������] = x.[ID])" +
              " INNER JOIN [�������] AS q ON c.[������] = q.[ID])" +
              " INNER JOIN [�����] AS p ON c.[����] = p.[ID])";
                string query2 = "SELECT c.Id AS [ID], b.[�������������] AS [�������������], m.[������������� ����������] AS [������������� ����������],[���], f.[����� ����������] AS [����� ����������]" +  // ��������)))))
              " FROM ((([��������] AS c" +
              " INNER JOIN [������] AS b ON c.[�����] = b.[ID])" +
              " INNER JOIN [�����] AS m ON c.[�����] = m.[ID])" +
              " INNER JOIN [����������� �����] AS f ON c.[Email] = f.[ID])";
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
                MessageBox.Show("������ �����������: " + ex.Message);
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
            Form2 frm2 = new Form2(_con); //Form2 - ��������  �����
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
