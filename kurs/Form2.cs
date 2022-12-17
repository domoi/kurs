using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kurs
{

    public partial class Form2 : Form
    {
        public static string connectString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\lvlal\OneDrive\Рабочий стол\курсовая\kursovaia\kursovaia\bin\Debug\kurs1.accdb";

        string query = "INSERT INTO clients ([FullName], [Passport],[City],[PhoneNumber],[Size],[Old],[SerialNumber]) VALUES (?,?,?,?,?,?,?)";

        string queryorder = "INSERT INTO [order] ([FullName], [Passport], [SerialNumber], [DateTime]) VALUES (?,?,?,?)";

        string selectAllSubject = "SELECT * FROM subject";

        public OleDbConnection myConnection;

        public Form2()
        {
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();

            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            populateDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommand insertDataIntoMSAccessDataBaseOleDbCommand = new OleDbCommand(query, myConnection);
            OleDbCommand insertDataorder = new OleDbCommand(queryorder, myConnection);
            DateTime dateTime= DateTime.Now;

            insertDataIntoMSAccessDataBaseOleDbCommand.Parameters.AddWithValue("FullName", OleDbType.VarChar).Value = txtFullName.Text;
            insertDataIntoMSAccessDataBaseOleDbCommand.Parameters.AddWithValue("Passport", OleDbType.VarChar).Value = txtPassport.Text;
            insertDataIntoMSAccessDataBaseOleDbCommand.Parameters.AddWithValue("City", OleDbType.VarChar).Value = txtCity.Text;
            insertDataIntoMSAccessDataBaseOleDbCommand.Parameters.AddWithValue("PhoneNumber", OleDbType.Integer).Value = txtPhoneNumber.Text;
            insertDataIntoMSAccessDataBaseOleDbCommand.Parameters.AddWithValue("Size", OleDbType.Integer).Value = txtSize.Text;
            insertDataIntoMSAccessDataBaseOleDbCommand.Parameters.AddWithValue("Old", OleDbType.Integer).Value = txtOld.Text;
            insertDataIntoMSAccessDataBaseOleDbCommand.Parameters.AddWithValue("SerialNumber", OleDbType.Integer).Value = txtSerialNumber.Text;

            insertDataorder.Parameters.AddWithValue("FullName", OleDbType.VarChar).Value = txtFullName.Text;
            insertDataorder.Parameters.AddWithValue("Passport", OleDbType.VarChar).Value = txtPassport.Text;
            insertDataorder.Parameters.AddWithValue("SerialNumber", OleDbType.Integer).Value = txtSerialNumber.Text;
            insertDataorder.Parameters.AddWithValue("DateTime", OleDbType.DBTimeStamp).Value = dateTime.ToString();


            int insertDataToAccessDatabase = insertDataIntoMSAccessDataBaseOleDbCommand.ExecuteNonQuery();
            insertDataorder.ExecuteNonQuery();
            //If data Has been inserted to the database output the following message
            if (insertDataToAccessDatabase > 0)
            {
                MessageBox.Show("Data Inserted To MS-Access Database Susccessfully.........");
            }
        }

        public void populateDataGridView()
        {
            //OleDbDataAdapter adapter = new OleDbDataAdapter(sqlQuery, acceddDatabaseConnection);
            OleDbCommand command = new OleDbCommand(selectAllSubject, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString());
            }
            reader.Close();
        }

        private void поЦенеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SortCost f2 = new SortCost();
            f2.Owner = this;
            f2.Show();
        }

        private void поНазваниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SortName f2 = new SortName();
            f2.Owner = this;
            f2.Show();
        }
    }
}
