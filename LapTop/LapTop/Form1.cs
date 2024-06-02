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
        string query1 = "SELECT c.Id AS [ID], b.[�������������] AS [�������������],i.[������] AS [������], m.[������������� ����������] AS [������������� ����������], f.[����� ����������] AS [����� ����������],  [���],[����� SSD], x.[��������� ������] AS [��������� ������],[���],[����],q.[������] AS [������],p.[����] AS [����]" +
             " FROM ((((((([��������] AS c" +
             " INNER JOIN [�������������] AS b ON c.[�������������] = b.[ID])" +
                " INNER JOIN [������] AS i ON c.[������] = i.[ID])" +
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
        string query3 = "SELECT c.Id AS [ID], [������� ��������������],[��� ��������������],[�������� ��������������],[����� ��������������], f.[��������� ��������������] AS [��������� ��������������]" +
      " FROM ([�������������] AS c" +
      " INNER JOIN [��������� �������������] AS f ON c.[��������� ��������������] = f.[ID])";
        string query4 = "SELECT c.Id AS [ID],  [������� ����������],[��� ����������],[�������� ����������],[������� ����������], f.[Email ����������] AS [Email ����������],[���� ��������],[���������� ��������]" +
      " FROM ([����������] AS c" +
      " INNER JOIN [����������� ����� �����������] AS f ON c.[Email ����������] = f.[ID])";
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
            comboBox1.Items.AddRange(new string[] { "�����", "�����", "���" });

            // ��������� ����������� ������� ��������� ���������� �������� � ����������
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            comboBox2.Items.AddRange(new string[] { "�������������", "������", "������������� ����������", "����� ����������", "���", "����� SSD", "��������� ������", "����", "������", "����" });

            // ��������� ����������� ������� ��������� ��������� ��������� � ListBox
            comboBox2.SelectedIndexChanged += ComboBox2_SelectedIndexChanged;
            comboBox3.Items.AddRange(new string[] { "���� ��������", "���������� ��������", "������� ����������" });

            // ��������� ����������� ������� ��������� ���������� �������� � ����������
            comboBox3.SelectedIndexChanged += ComboBox3_SelectedIndexChanged;
            comboBox4.Items.AddRange(new string[] { "������� ��������������", "��������� ��������������" });

            // ��������� ����������� ������� ��������� ���������� �������� � ����������
            comboBox4.SelectedIndexChanged += ComboBox4_SelectedIndexChanged;
            comboBox6.Items.AddRange(new string[] { "�������������", "������", "������������� �����������", "����� �����������", "��������� �������", "�������", "�����" });

            // ��������� ����������� ������� ��������� ���������� �������� � ����������
            comboBox6.SelectedIndexChanged += ComboBox6_SelectedIndexChanged;
            comboBox5.Items.AddRange(new string[] { "������", "������", "�����" });

            // ��������� ����������� ������� ��������� ���������� �������� � ����������
            comboBox5.SelectedIndexChanged += ComboBox5_SelectedIndexChanged;
            comboBox7.Items.AddRange(new string[] { "������", "�����", "����������� �����" });

            // ��������� ����������� ������� ��������� ���������� �������� � ����������
            comboBox7.SelectedIndexChanged += ComboBox7_SelectedIndexChanged;
            comboBox8.Items.AddRange(new string[] { "������", "������", "�����" });

            // ��������� ����������� ������� ��������� ���������� �������� � ����������
            comboBox8.SelectedIndexChanged += ComboBox8_SelectedIndexChanged;
            comboBox9.Items.AddRange(new string[] { "����������", "�����������", "��������" });

            // ��������� ����������� ������� ��������� ���������� �������� � ����������
            comboBox9.SelectedIndexChanged += ComboBox9_SelectedIndexChanged;
            comboBox10.Items.AddRange(new string[] { "����� SSD", "���", "��������� ������", "���", "����" });
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

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("�����");
            comboBox1.Items.Add("�����");
            comboBox1.Items.Add("���");
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
                MessageBox.Show($"������ ��� �������� ������ �� ������� {tableName}: " + ex.Message);
            }
        }

        private void knopka_Click(object sender, EventArgs e)
        {
            Form3 fr = new Form3(_con);
            fr.Show();
            LoadData(Path.Combine(Application.StartupPath, "LapTop.mdb"));
        }
        //�������� �������
        private void button2_Click(object sender, EventArgs e)
        {
            // ���������� ������ � �������
            LoadData(Path.Combine(Application.StartupPath, "LapTop.mdb"));
        }
        private void delInTab(string table, string pole, DataGridView dg)
        {
            if (_con != null && _con.State == ConnectionState.Open)
            {
                _con.Close();
            }
            // �������� ������ ��������� ������ � DataGridView
            int rowIndex = dg.CurrentRow.Index;

            // �������� �������� �� �������, ����������� ���� (��������, �������������)
            string keyValue = dg.Rows[rowIndex].Cells[pole].Value.ToString();

            // ��������� ������ �� �������� ������ � ���������� ��������� �����
            string query = $"DELETE FROM {table} WHERE [{pole}] = '{keyValue}'";

            DialogResult dr = MessageBox.Show("�� �������� ��� ������ ������� ������?", "������������� ��������", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
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

                        LoadData(Path.Combine(Application.StartupPath, "LapTop.mdb"));
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
        //��������� � ��������
        private void updateInTab(string table, string pole, string newValue, DataGridView dg)
        {
            if (_con != null && _con.State == ConnectionState.Open)
            {
                _con.Close();
            }

            // �������� ������ ��������� ������ � DataGridView
            int rowIndex = dg.CurrentRow.Index;

            // �������� �������� �� �������, ����������� ���� (��������, �������������)
            string keyValue = dg.Rows[rowIndex].Cells[pole].Value.ToString();

            // ��������� ������ �� ���������� �������� � ������� � ���������� ��������� �����
            string query = $"UPDATE [{table}] SET [{pole}] = '{newValue}' WHERE [{pole}] = '{keyValue}'";

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
                    MessageBox.Show("�������� ������� ��������.");

                    LoadData(Path.Combine(Application.StartupPath, "LapTop.mdb"));
                }
                else
                {
                    MessageBox.Show("�������� �� ���� ��������.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("������ ��� ��������� ��������: " + ex.Message);
            }
            finally
            {
                // ��������� ����������� � ���� ������
                _con.Close();
            }
        }

        //�������� �� ���������
        private void button3_Click(object sender, EventArgs e)
        {
            DeleteSelectedRow(_con, "��������", dataGridView1);
        }
        //�������� ��������� �� �������
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

                DialogResult dr = MessageBox.Show("�� �������� ��� ������ ������� ������?", "������������� ��������", MessageBoxButtons.YesNo);
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
            }
            else
            {
                MessageBox.Show("�������� ������ ��� ��������.");
            }
            LoadData(Path.Combine(Application.StartupPath, "LapTop.mdb"));
        }
        //���������� � ���������
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem.ToString();
            string desc = "";
            if (checkBox1.Checked)
                desc = "DESC";
            switch (selectedValue)
            {
                case "�����":
                    LoadDataFromTable2("b.[�����]", dataGridView8, query2, desc);
                    break;
                case "�����":
                    LoadDataFromTable2("m.[�����]", dataGridView8, query2, desc);
                    break;
                case "���":
                    LoadDataFromTable2("[���]", dataGridView8, query2, desc);
                    break;

                default:
                    MessageBox.Show("������");
                    break;
            }
        }
        //���������� � ���������
        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox2.SelectedItem.ToString();
            string desc = "";
            if (checkBox2.Checked)
                desc = "DESC";
            switch (selectedValue)
            {
                case "�������������":
                    LoadDataFromTable2("b.[�������������]", dataGridView1, query1, desc);
                    break;
                case "������":
                    LoadDataFromTable2("i.[������]", dataGridView1, query1, desc);
                    break;
                case "������������� ����������":
                    LoadDataFromTable2("m.[������������� ����������]", dataGridView1, query1, desc);
                    break;
                case "����� ����������":
                    LoadDataFromTable2("d.[����� ����������]", dataGridView1, query1, desc);
                    break;
                case "���":
                    LoadDataFromTable2("[���]", dataGridView1, query1, desc);
                    break;
                case "����� SSD":
                    LoadDataFromTable2("[����� SSD]", dataGridView1, query1, desc);
                    break;
                case "��������� ������":
                    LoadDataFromTable2("x.[��������� ������]", dataGridView1, query1, desc);
                    break;
                case "����":
                    LoadDataFromTable2("[����]", dataGridView1, query1, desc);
                    break;
                case "������":
                    LoadDataFromTable2("q.[������]", dataGridView1, query1, desc);
                    break;
                case "����":
                    LoadDataFromTable2("p.[����]", dataGridView1, query1, desc);
                    break;

                default:
                    MessageBox.Show("������");
                    break;
            }
        }
        //������ � ���������� ��������� ���������
        private void ComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox6.SelectedItem.ToString();
            Form2 frm2 = new Form2(_con); //Form2 - ��������  �����
            switch (selectedValue)
            {

                case "�������������":
                    frm2.data("�������������", "�������������");
                    frm2.Show();
                    break;
                case "������":
                    frm2.data("�������������", "�������������");
                    frm2.Show();
                    break;
                case "������������� �����������":
                    frm2.data("[������������� �����������]", "[������������� ����������]");
                    frm2.Show();
                    break;
                case "����� �����������":
                    frm2.data("[����� �����������]", "[����� ����������]");
                    frm2.Show();
                    break;

                case "��������� �������":
                    frm2.data("[��������� �������]", "[��������� ������]");
                    frm2.Show();
                    break;
                case "�������":
                    frm2.data("�������", "������");
                    frm2.Show();
                    break;
                case "�����":
                    frm2.data("�����", "����");
                    frm2.Show();
                    break;
                default:
                    MessageBox.Show("������");
                    break;
            }
        }
        //���������� �������������
        private void ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox4.SelectedItem.ToString();
            string desc = "";
            if (checkBox4.Checked)
                desc = "DESC";
            switch (selectedValue)
            {

                case "������� ��������������":
                    LoadDataFromTable2("[������� ��������������]", dataGridView9, query3, desc);
                    break;
                case "��������� ��������������":
                    LoadDataFromTable2("f.[��������� ��������������]", dataGridView9, query3, desc);
                    break;

                default:
                    MessageBox.Show("������");
                    break;
            }
        }
        //������� � ���������
        private void ComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox5.SelectedItem.ToString();
            string Value = comboBox10.SelectedItem == null ? "" : comboBox10.SelectedItem.ToString();
            string znach = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(Value) || string.IsNullOrEmpty(znach))
            {
                MessageBox.Show("������: �� ������� ���� � �� ������� ��������.");
                return;
            }

            if (Value == "��������� ������")
            {
                Value = "x.[��������� ������]";
            }

            switch (selectedValue)
            {
                case "������":
                    LoadDataFromTable3(Value, dataGridView1, query1, znach, ">");
                    break;
                case "������":
                    LoadDataFromTable3(Value, dataGridView1, query1, znach, "<");
                    break;
                case "�����":
                    LoadDataFromTable3(Value, dataGridView1, query1, znach, "=");
                    break;
                default:
                    MessageBox.Show("������");
                    break;
            }
        }
        //���������� �����������
        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox3.SelectedItem.ToString();
            string desc = "";
            if (checkBox3.Checked)
                desc = "DESC";
            switch (selectedValue)
            {
                case "���� ��������":
                    LoadDataFromTable2("[���� ��������]", dataGridView10, query4, desc);
                    break;
                case "���������� ��������":
                    LoadDataFromTable2("[���������� ��������]", dataGridView10, query4, desc);
                    break;
                case "������� ����������":
                    LoadDataFromTable2("[������� ����������]", dataGridView10, query4, desc);
                    break;

                default:
                    MessageBox.Show("������");
                    break;
            }
        }
        private void ComboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox7.SelectedItem.ToString();
            Form2 frm2 = new Form2(_con); //Form2 - ��������  �����
            switch (selectedValue)
            {
                case "������":
                    frm2.data("[������]", "[�����]");
                    frm2.Show();
                    break;
                case "�����":
                    frm2.data("[�����]", "[�����]");
                    frm2.Show();
                    break;
                case "����������� �����":
                    frm2.data("[����������� �����]", "Email");
                    frm2.Show();
                    break;
                default:
                    MessageBox.Show("������");
                    break;
            }
        }
        //������� �� ���� � �����������
        private void ComboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox8.SelectedItem.ToString();
            string znach = "#" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "#"; ;

            string Value = "[���� ��������]";



            switch (selectedValue)
            {

                case "������":
                    LoadDataFromTable3(Value, dataGridView10, query4, znach, ">");
                    break;
                case "������":
                    LoadDataFromTable3(Value, dataGridView10, query4, znach, "<");
                    break;
                case "�����":
                    LoadDataFromTable3(Value, dataGridView10, query4, znach, "=");
                    break;
                default:
                    MessageBox.Show("������");
                    break;
            }
        }
        private void ComboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox9.SelectedItem.ToString();
            string znach = "'" + comboBox9.Text + "'";
            switch (selectedValue)
            {
                case "����������":
                    LoadDataFromTable3("f.[��������� ��������������]", dataGridView9, query3, znach, "=");
                    break;
                case "��������":
                    LoadDataFromTable3("f.[��������� ��������������]", dataGridView9, query3, znach, "=");
                    break;
                case "�����������":
                    LoadDataFromTable3("f.[��������� ��������������]", dataGridView9, query3, znach, "=");
                    break;

                default:
                    MessageBox.Show("������");
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

        private void button17_Click(object sender, EventArgs e)
        {
            string query = $"{query1} WHERE q.[������] = '� �������'";
            OleDbCommand command = new OleDbCommand(query, _con);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
        }



        private void button30_Click(object sender, EventArgs e)
        {
            delInTab("������", "�����", dataGridView11);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            delInTab("�����", "�����", dataGridView12);
        }
        private void button34_Click(object sender, EventArgs e)
        {
            delInTab("[����������� �����]", "Email", dataGridView13);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            delInTab("�������������", "�������������", dataGridView2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            delInTab("������", "������", dataGridView3);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            delInTab("[������������� �����������]", "������������� ����������", dataGridView4);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            delInTab("[����� �����������]", "����� ����������", dataGridView5);
        }



        private void button18_Click(object sender, EventArgs e)
        {
            delInTab("[��������� �������]", "��������� ������", dataGridView6);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            delInTab("�����", "����", dataGridView16);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            delInTab("�������", "������", dataGridView7);

        }

        private void button29_Click(object sender, EventArgs e)
        {
            delInTab("[����������� ����� �����������]", "Email ����������", dataGridView14);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            delInTab("[��������� �������������]", "��������� ��������������", dataGridView15);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(_con); //Form2 - ��������  �����

            frm2.data("[��������� �������������]", "[��������� ��������������]");
            frm2.Show();
            LoadData(Path.Combine(Application.StartupPath, "LapTop.mdb"));
        }

        private void button43_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(_con); //Form2 - ��������  �����

            frm2.data("[����������� ����� �����������]", "[Email ����������]");
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
            // �������� ������ ��������� ������ � DataGridView
            int rowIndex = dataGridView11.CurrentRow.Index;

            // �������� �������� �� ������ ������ � ��������� ������
           
           //string cv = dataGridView11.Rows[rowIndex].Cells["�����"].Value.ToString();
            MessageBox.Show("������ ���������� ");
            //updateInTab("������", "�����", cv, dataGridView11);

        }
    }
}
