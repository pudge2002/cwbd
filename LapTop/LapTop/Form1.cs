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
        DataTable provideTable;
        public Form1()
        {
            InitializeComponent();

            // ������ ������������� ����� ���� ������, �������������� � �������
            string databasePath = Path.Combine(Application.StartupPath, "LapTop.mdb");
            LoadData(databasePath);

            // ���������� �������� � ���������
            //comboBox1.Items.AddRange(new string[] { "�������������", "��������", "������" });

            //// ��������� ����������� ������� ��������� ���������� �������� � ����������
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

                string query1 = "SELECT c.Id AS [ID], b.[�������������] AS [�������������], m.[������������� ����������] AS [������������� ����������], f.[����� ����������] AS [����� ����������],  [���],[����� SSD], x.[��������� ������] AS [��������� ������],[���],[����],q.[������] AS [������],p.[����] AS [����]" +
              " FROM (((((([��������] AS c" +
              " INNER JOIN [�������������] AS b ON c.[�������������] = b.[ID])" +
              " INNER JOIN [������������� �����������] AS m ON c.[������������� ����������] = m.[ID])" +
              " INNER JOIN [����� �����������] AS f ON c.[����� ����������] = f.[ID])" +
              " INNER JOIN [��������� �������] AS x ON c.[��������� ������] = x.[ID])" +
              " INNER JOIN [�������] AS q ON c.[������] = q.[ID])" +
              " INNER JOIN [�����] AS p ON c.[����] = p.[ID])";
                string query2 = "SELECT c.Id AS [ID], b.[�����] AS [�����], m.[�����] AS [�����],[���], f.[Email] AS [Email]" +
              " FROM ((([��������] AS c" +
              " INNER JOIN [������] AS b ON c.[�����] = b.[ID])" +
              " INNER JOIN [�����] AS m ON c.[�����] = m.[ID])" +
              " INNER JOIN [����������� �����] AS f ON c.[Email] = f.[ID])";
                string query3 = "SELECT c.Id AS [ID], [������� ��������������],[��� ��������������],[�������� �������������� ],[����� ��������������], f.[��������� ��������������] AS [��������� ��������������]" +
              " FROM ([�������������] AS c" +
              " INNER JOIN [��������� �������������] AS f ON c.[��������� ��������������] = f.[ID])";
                string query4 = "SELECT c.Id AS [ID],  [������� ����������],[��� ����������],[�������� ����������],[������� ����������], f.[Email ����������] AS [Email ����������],[���� ��������],[���������� ��������]" +
              " FROM ([����������] AS c" +
              " INNER JOIN [����������� ����� �����������] AS f ON c.[Email ����������] = f.[ID])";


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
            "SELECT * FROM [����������� ����� �����������]",
            "SELECT * FROM [������� �������]"
                };
                DataTable[] dataTables = new DataTable[queries.Length];
                for (int i = 0; i < queries.Length; i++)
                {
                    dataTables[i] = new DataTable();
                    FillTable(queries[i], dataTables[i]);
                }
                // ������������� ������ ��� ���������� ������ �������
                FillDataGridView(query1, dataGridView1);
                FillDataGridView(query2, dataGridView8);
                FillDataGridView(query3, dataGridView9);
                FillDataGridView(query4, dataGridView10);
                dataGridView2.DataSource = dataTables[1]; // �������������
                dataGridView3.DataSource = dataTables[2]; // 
                dataGridView4.DataSource = dataTables[3]; // 
                dataGridView5.DataSource = dataTables[4]; //
                dataGridView6.DataSource = dataTables[5]; // �
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
                MessageBox.Show("������ �����������: " + ex.Message);
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

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteSelectedRow(_con, "��������", dataGridView1);
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
                            MessageBox.Show("������ ������� �������.");
                        }
                        else
                        {
                            MessageBox.Show("������ �� ���� �������.");
                        }
                    }
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("������ ��� �������� ������: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("��������� �������������� ������: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("�������� ������ ��� ��������.");
            }
            LoadData(Path.Combine(Application.StartupPath, "LapTop.mdb"));
        }


        private void button6_Click(object sender, EventArgs e)
        {
            DeleteSelectedRow(_con, "������� �������", dataGridView17);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LoadData(Path.Combine(Application.StartupPath, "LapTop.mdb"));
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DeleteSelectedRow(_con, "��������", dataGridView8);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DeleteSelectedRow(_con, "����������", dataGridView10);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            DeleteSelectedRow(_con, "�������������", dataGridView9);
        }
    }
}
