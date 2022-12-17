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
    public partial class clientsSortOld : Form
    {
        public static string connectString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\lvlal\OneDrive\Рабочий стол\курсовая\kursovaia\kursovaia\bin\Debug\kurs1.accdb";

        public OleDbConnection myConnection;

        public clientsSortOld()
        {
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string old = textBox1.Text;
            string query = "SELECT [ID], [FullName], [Passport],[City],[PhoneNumber],[Size],[Old] FROM clients WHERE Old LIKE '%" + old + "'";
            OleDbDataAdapter command = new OleDbDataAdapter(query, myConnection);
            DataTable dt = new DataTable();
            command.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
