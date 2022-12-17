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
using Excel = Microsoft.Office.Interop.Excel;



namespace kurs
{
    public partial class Form1 : Form
    {
        public static string connectString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\lvlal\OneDrive\Рабочий стол\курсовая\kursovaia\kursovaia\bin\Debug\kurs1.accdb";
        // добавление
        string query = "INSERT INTO clients ([FullName], [Passport],[City],[PhoneNumber],[Size],[Old],[SerialNumber]) VALUES (?,?,?,?,?,?,?)";

        string insertsubject = "INSERT INTO subject ([Title], [Cost], [Description]) VALUES (?,?,?)";

        string insertorder = "INSERT INTO [order] ([FullName], [Passport], [SerialNumber]) VALUES (?,?,?)";
        // все
        string queryAll = "SELECT * FROM clients";

        string queryAllSubject = "SELECT * FROM subject";
        // изменение
        string updateDataInMSAccessDatabase = "UPDATE clients SET [FullName] = ?, [Passport] = ?,[City] = ?,[PhoneNumber] = ?,[Size] = ?,[Old] = ?,[SerialNumber] = ? WHERE [ID] = ?";

        string updatesubjectDataInMSAccessDatabase = "UPDATE subject SET [Title] = ?, [Cost] = ?, [Description] = ? WHERE [ID] = ?";
        string updatesubject = "UPDATE subject SET [Title] = ?, [Cost] = ?,[Description] = ? WHERE [ID] = ?";


        string updateorder = "UPDATE [order] SET [FullName] = ?, [Passport] = ?, [SerialNumber] = ? WHERE [ID] = ?";
        // удаление
        string deleterows = "DELETE FROM clients WHERE [ID] = ?";

        string deletesubject = "DELETE FROM subject WHERE [ID] = ?";

        string deleteorder = "DELETE FROM [order] WHERE [ID] = ?";

        public OleDbConnection myConnection;

        public Form1()
        {
            // Подключение к бд
            myConnection = new OleDbConnection(connectString);
            InitializeComponent();
            // Подключаемся
            myConnection.Open();
            FillComboBoxTablesNames(comboBox1);
            FillComboBoxTablesNames(comboBox2);

            comboBox1.SelectedItem = "clients";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommand insertDataIntoMSAccessDataBaseOleDbCommand = new OleDbCommand(query, myConnection);
            insertDataIntoMSAccessDataBaseOleDbCommand.Parameters.AddWithValue("FullName", OleDbType.VarChar).Value = txtFullName.Text;
            insertDataIntoMSAccessDataBaseOleDbCommand.Parameters.AddWithValue("Passport", OleDbType.VarChar).Value = txtPassport.Text;
            insertDataIntoMSAccessDataBaseOleDbCommand.Parameters.AddWithValue("City", OleDbType.VarChar).Value = txtCity.Text;
            insertDataIntoMSAccessDataBaseOleDbCommand.Parameters.AddWithValue("PhoneNumber", OleDbType.Integer).Value = txtPhoneNumber.Text;
            insertDataIntoMSAccessDataBaseOleDbCommand.Parameters.AddWithValue("Size", OleDbType.Integer).Value = txtSize.Text;
            insertDataIntoMSAccessDataBaseOleDbCommand.Parameters.AddWithValue("Old", OleDbType.Integer).Value = txtOld.Text;
            insertDataIntoMSAccessDataBaseOleDbCommand.Parameters.AddWithValue("SerialNumber", OleDbType.Integer).Value = txtSerialNumber.Text;


            int insertDataToAccessDatabase = insertDataIntoMSAccessDataBaseOleDbCommand.ExecuteNonQuery();
            //If data Has been inserted to the database output the following message
            if (insertDataToAccessDatabase > 0)
            {
                MessageBox.Show("Data Inserted To MS-Access Database Susccessfully.........");
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowTemplate.Height = 40;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtID.Text == String.Empty)
            {
                MessageBox.Show("First Click On DatagridView Row Cell Or Make Sure ID Field Is Not Empty.......");
            }
            else
            {
                //Check If One Or More Fields Are Empty
                if (txtFullName.Text == String.Empty || txtPassport.Text == String.Empty || txtPhoneNumber.Text == String.Empty || txtCity.Text == String.Empty || txtSize.Text == String.Empty || txtOld.Text == String.Empty)
                {
                    MessageBox.Show("One Or More Empty Field Make sure all fields are filled............");
                }
                else
                {
                    OleDbCommand updateDataInMSAccessDatabaseOleDbCommand = new OleDbCommand(updateDataInMSAccessDatabase, myConnection);
                    updateDataInMSAccessDatabaseOleDbCommand.Parameters.AddWithValue("FullName", OleDbType.VarChar).Value = txtFullName.Text;
                    updateDataInMSAccessDatabaseOleDbCommand.Parameters.AddWithValue("Passport", OleDbType.VarChar).Value = txtPassport.Text;
                    updateDataInMSAccessDatabaseOleDbCommand.Parameters.AddWithValue("City", OleDbType.VarChar).Value = txtCity.Text;
                    updateDataInMSAccessDatabaseOleDbCommand.Parameters.AddWithValue("PhoneNumber", OleDbType.Integer).Value = txtPhoneNumber.Text;
                    updateDataInMSAccessDatabaseOleDbCommand.Parameters.AddWithValue("Size", OleDbType.Integer).Value = txtSize.Text;
                    updateDataInMSAccessDatabaseOleDbCommand.Parameters.AddWithValue("Old", OleDbType.Integer).Value = txtOld.Text;
                    updateDataInMSAccessDatabaseOleDbCommand.Parameters.AddWithValue("ID", OleDbType.Integer).Value = Convert.ToInt32(txtID.Text);
                    updateDataInMSAccessDatabaseOleDbCommand.Parameters.AddWithValue("SerialNumber", OleDbType.Integer).Value = txtSerialNumber.Text;

                    //Opening Access Database Connection
                    int insertDataToAccessDatabase = updateDataInMSAccessDatabaseOleDbCommand.ExecuteNonQuery();
                    dataGridView1.Refresh();

                }
            }

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if(comboBox1.SelectedItem.ToString() == "clients")
            {
                DataGridViewRow datagridviewrow = dataGridView1.Rows[e.RowIndex];
                //Assigning Textboxes and picturebox with values

                txtID.Text = datagridviewrow.Cells[0].Value.ToString();
                txtFullName.Text = datagridviewrow.Cells[1].Value.ToString();
                txtPassport.Text = datagridviewrow.Cells[2].Value.ToString();
                txtCity.Text = datagridviewrow.Cells[3].Value.ToString();
                txtPhoneNumber.Text = datagridviewrow.Cells[4].Value.ToString();
                txtSize.Text = datagridviewrow.Cells[5].Value.ToString();
                txtOld.Text = datagridviewrow.Cells[6].Value.ToString();
                txtSerialNumber.Text = datagridviewrow.Cells[7].Value.ToString();

            }
            else if(comboBox1.SelectedItem.ToString() == "subject")
            {
                DataGridViewRow datagridviewrow = dataGridView1.Rows[e.RowIndex];
                txtID1.Text = datagridviewrow.Cells[0].Value.ToString();
                txtTitle.Text = datagridviewrow.Cells[1].Value.ToString();
                txtCost.Text = datagridviewrow.Cells[2].Value.ToString();
                txtDescription.Text = datagridviewrow.Cells[3].Value.ToString();
            }
            else if (comboBox1.SelectedItem.ToString() == "order")
            {
                DataGridViewRow datagridviewrow = dataGridView1.Rows[e.RowIndex];
                txtID2.Text = datagridviewrow.Cells[0].Value.ToString();
                txtFullNameOrder.Text = datagridviewrow.Cells[1].Value.ToString();
                txtPassportOrder.Text = datagridviewrow.Cells[2].Value.ToString();
                txtSerialNumberOrder.Text = datagridviewrow.Cells[3].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbCommand deleteDataFromMSAccessDatabaseOleDbCommand = new OleDbCommand(deleterows, myConnection);
            deleteDataFromMSAccessDatabaseOleDbCommand.Parameters.AddWithValue("ID", OleDbType.Integer).Value = Convert.ToInt32(txtID.Text);
            //Opening Access Database Connection
            int deleteDataFromMSAccessDatabase = deleteDataFromMSAccessDatabaseOleDbCommand.ExecuteNonQuery();
        }

        public void clearInputFields()
        {
            //Clearing Textfields
            txtID.Text = String.Empty;
            txtFullName.Text = String.Empty;
            txtPassport.Text = String.Empty;
            txtPhoneNumber.Text = String.Empty;
            txtCity.Text = String.Empty;
            txtSize.Text = String.Empty;
            txtOld.Text = String.Empty;
            txtTitle.Text = String.Empty;
            txtID1.Text = String.Empty; 
            txtCost.Text = String.Empty;
            txtSerialNumber.Text = String.Empty;
            txtSerialNumberOrder.Text = String.Empty;
            txtFullNameOrder.Text = String.Empty;
            txtID2.Text = String.Empty;
            txtPassportOrder.Text = String.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clearInputFields();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Excel.Application excelapp = new Excel.Application();
            Excel.Workbook workbook = excelapp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.ActiveSheet;

            for (int i = 1; i < dataGridView1.RowCount + 1; i++)
            {
                for (int j = 1; j < dataGridView1.ColumnCount + 1; j++)
                {
                    worksheet.Rows[i].Columns[j] = dataGridView1.Rows[i - 1].Cells[j - 1].Value;
                }
            }

            excelapp.AlertBeforeOverwriting = false;
            workbook.SaveAs(@"C:\Users\lvlal\OneDrive\Рабочий стол\excel");
            excelapp.Quit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tableName = comboBox1.SelectedItem.ToString();
            string query = "SELECT * FROM [" + tableName + "]";
            ShowTable(query);
        }

        public void ShowTable(string query)
        {
            OleDbDataAdapter command = new OleDbDataAdapter(query, myConnection);
            DataTable dataTable = new DataTable();
            command.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        public void FillComboBoxTablesNames(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            DataTable tbis = myConnection.GetSchema("Tables", new string[] { null, null, null, "TABLE" });
            foreach (DataRow row in tbis.Rows)
            {
                string TableName = row["Table_NAME"].ToString();
                comboBox.Items.Add(TableName);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OleDbCommand insertDataIntoMSAccessDataBaseOleDbCommand = new OleDbCommand(insertsubject, myConnection);
            insertDataIntoMSAccessDataBaseOleDbCommand.Parameters.AddWithValue("Title", OleDbType.VarChar).Value = txtTitle.Text;
            insertDataIntoMSAccessDataBaseOleDbCommand.Parameters.AddWithValue("Cost", OleDbType.Integer).Value = txtCost.Text;
            insertDataIntoMSAccessDataBaseOleDbCommand.Parameters.AddWithValue("Description", OleDbType.VarChar).Value = txtDescription.Text;

            int insertDataToAccessDatabase = insertDataIntoMSAccessDataBaseOleDbCommand.ExecuteNonQuery();
            //If data Has been inserted to the database output the following message
            if (insertDataToAccessDatabase > 0)
            {
                MessageBox.Show("Data Inserted To MS-Access Database Susccessfully.........");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Owner = this;
            f2.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            OleDbCommand updateDataInMSAccessDatabaseOleDbCommand = new OleDbCommand(updatesubject, myConnection);
            updateDataInMSAccessDatabaseOleDbCommand.Parameters.AddWithValue("Title", OleDbType.VarChar).Value = txtTitle.Text;
            updateDataInMSAccessDatabaseOleDbCommand.Parameters.AddWithValue("Cost", OleDbType.Integer).Value = txtCost.Text;
            updateDataInMSAccessDatabaseOleDbCommand.Parameters.AddWithValue("Description", OleDbType.VarChar).Value = txtDescription.Text;
            updateDataInMSAccessDatabaseOleDbCommand.Parameters.AddWithValue("ID", OleDbType.Integer).Value = Convert.ToInt32(txtID1.Text);


            //Opening Access Database Connection
            int insertDataToAccessDatabase = updateDataInMSAccessDatabaseOleDbCommand.ExecuteNonQuery();
            dataGridView1.Refresh();
    
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OleDbCommand deleteDataFromMSAccessDatabaseOleDbCommand = new OleDbCommand(deletesubject, myConnection);
            deleteDataFromMSAccessDatabaseOleDbCommand.Parameters.AddWithValue("ID", OleDbType.Integer).Value = Convert.ToInt32(txtID1.Text);
            //Opening Access Database Connection
            int deleteDataFromMSAccessDatabase = deleteDataFromMSAccessDatabaseOleDbCommand.ExecuteNonQuery();
        }

        private void поИмениToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientsSortName f2 = new clientsSortName();
            f2.Owner = this;
            f2.Show();
        }

        private void поРазмеруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientsSortSize f2 = new clientsSortSize();
            f2.Owner = this;
            f2.Show();
        }

        private void поГородуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientsSortCity f2 = new clientsSortCity();
            f2.Owner = this;
            f2.Show();
        }

        private void поВозрастуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientsSortOld f2 = new clientsSortOld();
            f2.Owner = this;
            f2.Show();
        }

        private void поЦенеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            subjectSortCost f2 = new subjectSortCost();
            f2.Owner = this;
            f2.Show();
        }

        private void поНазваниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            subjectSortTitle f2 = new subjectSortTitle();
            f2.Owner = this;
            f2.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            createNewTable f2 = new createNewTable();
            f2.Owner = this;
            f2.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string query = "DROP TABLE ["+ comboBox2.SelectedItem.ToString() + "]";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            comboBox2.Items.Clear();
            comboBox1.Items.Clear();
            FillComboBoxTablesNames(comboBox2);
            FillComboBoxTablesNames(comboBox1);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            printDialog.UseEXDialog = true;
            //Print document
            if (DialogResult.OK == printDialog.ShowDialog())
            {
                //Document Name
                printDocument1.DocumentName = "Printing DataGridView";
                //Print Function
                printDocument1.Print();
                MessageBox.Show("Document Printed!!!.......");
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new System.Drawing.Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tableName = comboBox1.SelectedItem.ToString();
            string query = "SELECT * FROM [" + tableName + "]";
            ShowTable(query);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            OleDbCommand insert = new OleDbCommand(insertorder, myConnection);
            insert.Parameters.AddWithValue("FullName", OleDbType.VarChar).Value = txtFullNameOrder.Text;
            insert.Parameters.AddWithValue("Passport", OleDbType.VarChar).Value = txtPassportOrder.Text;
            insert.Parameters.AddWithValue("SerialNumber", OleDbType.Integer).Value = Convert.ToInt32(txtSerialNumberOrder.Text);



            int insertDataToAccessDatabase = insert.ExecuteNonQuery();
            //If data Has been inserted to the database output the following message
            if (insertDataToAccessDatabase > 0)
            {
                MessageBox.Show("Data Inserted To MS-Access Database Susccessfully.........");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            OleDbCommand delete = new OleDbCommand(deleteorder, myConnection);
            delete.Parameters.AddWithValue("ID", OleDbType.Integer).Value = Convert.ToInt32(txtID2.Text);
            //Opening Access Database Connection
            int deleteDataFromMSAccessDatabase = delete.ExecuteNonQuery();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OleDbCommand update = new OleDbCommand(updateorder, myConnection);
            update.Parameters.AddWithValue("FullName", OleDbType.VarChar).Value = txtFullNameOrder.Text;
            update.Parameters.AddWithValue("Passport", OleDbType.VarChar).Value = txtPassportOrder.Text;
            update.Parameters.AddWithValue("SerialNumber", OleDbType.Integer).Value = Convert.ToInt32(txtSerialNumberOrder.Text);
            update.Parameters.AddWithValue("ID", OleDbType.Integer).Value = Convert.ToInt32(txtID2.Text);

            int insertDataToAccessDatabase = update.ExecuteNonQuery();
            //If data Has been inserted to the database output the following message
            if (insertDataToAccessDatabase > 0)
            {
                MessageBox.Show("Data Inserted To MS-Access Database Susccessfully.........");
            }
        }
    }
}
