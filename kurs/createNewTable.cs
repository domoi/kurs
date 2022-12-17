using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kurs
{
    public partial class createNewTable : Form
    {
        public static string connectString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\lvlal\OneDrive\Рабочий стол\курсовая\kursovaia\kursovaia\bin\Debug\kurs1.accdb";
        public OleDbConnection myConnection;

        public createNewTable()
        {
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string col1 = txtCol.Text;
            string col2 = txtCol2.Text;
            string col3 = txtCol3.Text;
            string col4 = txtCol5.Text;
            string query = "CREATE TABLE [" + title + "](["+ col1 +"] "+ comboBox1.SelectedItem.ToString() +" PRIMARY KEY, [" + col2 + "] "+ comboBox2.SelectedItem.ToString() + ", ["+ col3 +"] "+ comboBox3.SelectedItem.ToString() + ", [" + col4 + "] "+ comboBox4.SelectedItem.ToString() + ");";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
        }
    }
}
