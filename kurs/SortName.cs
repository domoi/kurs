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
    public partial class SortName : Form
    {
        public static string connectString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\lvlal\OneDrive\Рабочий стол\курсовая\kursovaia\kursovaia\bin\Debug\kurs1.accdb";

        public OleDbConnection myConnection;

        public SortName()
        {
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string query = "SELECT [ID], [Title], [Cost] FROM subject WHERE Title LIKE '%" + name + "'";
            OleDbDataAdapter command = new OleDbDataAdapter(query, myConnection);
            DataTable dt = new DataTable();
            command.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
