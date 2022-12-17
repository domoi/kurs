namespace kurs
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtID1 = new System.Windows.Forms.MaskedTextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtPassport = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtOld = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблицаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поИмениToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поГородуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поРазмеруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поВозрастуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поЦенеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поНазваниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSerialNumberOrder = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtID2 = new System.Windows.Forms.MaskedTextBox();
            this.txtPassportOrder = new System.Windows.Forms.TextBox();
            this.txtFullNameOrder = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.button14 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 706);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1906, 332);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(316, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 63);
            this.button2.TabIndex = 17;
            this.button2.Text = "UPDATE CLIENTS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(316, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 63);
            this.button3.TabIndex = 18;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1743, 280);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 63);
            this.button4.TabIndex = 19;
            this.button4.Text = "CLEAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1743, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 63);
            this.button5.TabIndex = 20;
            this.button5.Text = "EXPORT EXCELL";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1693, 656);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(209, 28);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(769, 69);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(144, 63);
            this.button6.TabIndex = 22;
            this.button6.Text = "INSERT SUBJECTS";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(617, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 38;
            this.label9.Text = "Предметы";
            // 
            // txtID1
            // 
            this.txtID1.Location = new System.Drawing.Point(621, 106);
            this.txtID1.Name = "txtID1";
            this.txtID1.Size = new System.Drawing.Size(100, 26);
            this.txtID1.TabIndex = 37;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(621, 178);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(100, 26);
            this.txtCost.TabIndex = 32;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(621, 138);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 26);
            this.txtTitle.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(561, 184);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "Cost";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(565, 144);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 20);
            this.label15.TabIndex = 25;
            this.label15.Text = "Title";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(535, 112);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 20);
            this.label16.TabIndex = 24;
            this.label16.Text = "IDSubject";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1743, 103);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(144, 63);
            this.button7.TabIndex = 39;
            this.button7.Text = "Пользователь";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "FullName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Passport";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "PhoneNumber";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Size";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Old";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(142, 130);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(100, 26);
            this.txtFullName.TabIndex = 9;
            // 
            // txtPassport
            // 
            this.txtPassport.Location = new System.Drawing.Point(142, 170);
            this.txtPassport.Name = "txtPassport";
            this.txtPassport.Size = new System.Drawing.Size(100, 26);
            this.txtPassport.TabIndex = 10;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(142, 212);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 26);
            this.txtCity.TabIndex = 11;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(142, 253);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 26);
            this.txtPhoneNumber.TabIndex = 12;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(142, 298);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(100, 26);
            this.txtSize.TabIndex = 13;
            // 
            // txtOld
            // 
            this.txtOld.Location = new System.Drawing.Point(142, 335);
            this.txtOld.Name = "txtOld";
            this.txtOld.Size = new System.Drawing.Size(100, 26);
            this.txtOld.TabIndex = 14;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(142, 98);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 26);
            this.txtID.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(138, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Клиент";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(769, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 63);
            this.button1.TabIndex = 40;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(769, 238);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(144, 63);
            this.button8.TabIndex = 41;
            this.button8.Text = "UPDATE SUBJECT";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 33);
            this.menuStrip1.TabIndex = 42;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // таблицаToolStripMenuItem
            // 
            this.таблицаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsToolStripMenuItem,
            this.subjectToolStripMenuItem});
            this.таблицаToolStripMenuItem.Name = "таблицаToolStripMenuItem";
            this.таблицаToolStripMenuItem.Size = new System.Drawing.Size(205, 29);
            this.таблицаToolStripMenuItem.Text = "Сортировать таблицу";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поИмениToolStripMenuItem,
            this.поГородуToolStripMenuItem,
            this.поРазмеруToolStripMenuItem,
            this.поВозрастуToolStripMenuItem});
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(170, 34);
            this.clientsToolStripMenuItem.Text = "clients";
            // 
            // поИмениToolStripMenuItem
            // 
            this.поИмениToolStripMenuItem.Name = "поИмениToolStripMenuItem";
            this.поИмениToolStripMenuItem.Size = new System.Drawing.Size(213, 34);
            this.поИмениToolStripMenuItem.Text = "по имени";
            this.поИмениToolStripMenuItem.Click += new System.EventHandler(this.поИмениToolStripMenuItem_Click);
            // 
            // поГородуToolStripMenuItem
            // 
            this.поГородуToolStripMenuItem.Name = "поГородуToolStripMenuItem";
            this.поГородуToolStripMenuItem.Size = new System.Drawing.Size(213, 34);
            this.поГородуToolStripMenuItem.Text = "по городу";
            this.поГородуToolStripMenuItem.Click += new System.EventHandler(this.поГородуToolStripMenuItem_Click);
            // 
            // поРазмеруToolStripMenuItem
            // 
            this.поРазмеруToolStripMenuItem.Name = "поРазмеруToolStripMenuItem";
            this.поРазмеруToolStripMenuItem.Size = new System.Drawing.Size(213, 34);
            this.поРазмеруToolStripMenuItem.Text = "по размеру";
            this.поРазмеруToolStripMenuItem.Click += new System.EventHandler(this.поРазмеруToolStripMenuItem_Click);
            // 
            // поВозрастуToolStripMenuItem
            // 
            this.поВозрастуToolStripMenuItem.Name = "поВозрастуToolStripMenuItem";
            this.поВозрастуToolStripMenuItem.Size = new System.Drawing.Size(213, 34);
            this.поВозрастуToolStripMenuItem.Text = "по возрасту";
            this.поВозрастуToolStripMenuItem.Click += new System.EventHandler(this.поВозрастуToolStripMenuItem_Click);
            // 
            // subjectToolStripMenuItem
            // 
            this.subjectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поЦенеToolStripMenuItem,
            this.поНазваниюToolStripMenuItem});
            this.subjectToolStripMenuItem.Name = "subjectToolStripMenuItem";
            this.subjectToolStripMenuItem.Size = new System.Drawing.Size(170, 34);
            this.subjectToolStripMenuItem.Text = "subject";
            // 
            // поЦенеToolStripMenuItem
            // 
            this.поЦенеToolStripMenuItem.Name = "поЦенеToolStripMenuItem";
            this.поЦенеToolStripMenuItem.Size = new System.Drawing.Size(221, 34);
            this.поЦенеToolStripMenuItem.Text = "по цене";
            this.поЦенеToolStripMenuItem.Click += new System.EventHandler(this.поЦенеToolStripMenuItem_Click);
            // 
            // поНазваниюToolStripMenuItem
            // 
            this.поНазваниюToolStripMenuItem.Name = "поНазваниюToolStripMenuItem";
            this.поНазваниюToolStripMenuItem.Size = new System.Drawing.Size(221, 34);
            this.поНазваниюToolStripMenuItem.Text = "по названию";
            this.поНазваниюToolStripMenuItem.Click += new System.EventHandler(this.поНазваниюToolStripMenuItem_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(1471, 57);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(153, 61);
            this.button10.TabIndex = 44;
            this.button10.Text = "Добавить таблицу";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(1471, 184);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(153, 52);
            this.button11.TabIndex = 45;
            this.button11.Text = "Удалить таблицу";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(621, 238);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 26);
            this.txtDescription.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(526, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 20);
            this.label10.TabIndex = 48;
            this.label10.Text = "Description";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(1743, 194);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(144, 63);
            this.button12.TabIndex = 49;
            this.button12.Text = "PRINT";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 383);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 20);
            this.label11.TabIndex = 50;
            this.label11.Text = "SerialNumber";
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Location = new System.Drawing.Point(142, 383);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(100, 26);
            this.txtSerialNumber.TabIndex = 51;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(1471, 141);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(209, 28);
            this.comboBox2.TabIndex = 52;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(510, 548);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 20);
            this.label12.TabIndex = 64;
            this.label12.Text = "IDSubject";
            // 
            // txtSerialNumberOrder
            // 
            this.txtSerialNumberOrder.Location = new System.Drawing.Point(621, 545);
            this.txtSerialNumberOrder.Name = "txtSerialNumberOrder";
            this.txtSerialNumberOrder.Size = new System.Drawing.Size(100, 26);
            this.txtSerialNumberOrder.TabIndex = 63;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(769, 545);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(144, 63);
            this.button9.TabIndex = 62;
            this.button9.Text = "UPDATE ORDER";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(769, 459);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(144, 63);
            this.button13.TabIndex = 61;
            this.button13.Text = "DELETE";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(617, 372);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 20);
            this.label13.TabIndex = 60;
            this.label13.Text = "Заказ";
            // 
            // txtID2
            // 
            this.txtID2.Location = new System.Drawing.Point(621, 413);
            this.txtID2.Name = "txtID2";
            this.txtID2.Size = new System.Drawing.Size(100, 26);
            this.txtID2.TabIndex = 59;
            // 
            // txtPassportOrder
            // 
            this.txtPassportOrder.Location = new System.Drawing.Point(621, 485);
            this.txtPassportOrder.Name = "txtPassportOrder";
            this.txtPassportOrder.Size = new System.Drawing.Size(100, 26);
            this.txtPassportOrder.TabIndex = 58;
            // 
            // txtFullNameOrder
            // 
            this.txtFullNameOrder.Location = new System.Drawing.Point(621, 445);
            this.txtFullNameOrder.Name = "txtFullNameOrder";
            this.txtFullNameOrder.Size = new System.Drawing.Size(100, 26);
            this.txtFullNameOrder.TabIndex = 57;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(531, 491);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 20);
            this.label17.TabIndex = 56;
            this.label17.Text = "Passport";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(527, 451);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 20);
            this.label18.TabIndex = 55;
            this.label18.Text = "FullName";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(577, 419);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(26, 20);
            this.label19.TabIndex = 54;
            this.label19.Text = "ID";
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(769, 376);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(144, 63);
            this.button14.TabIndex = 53;
            this.button14.Text = "INSERT ORDER";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSerialNumberOrder);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtID2);
            this.Controls.Add(this.txtPassportOrder);
            this.Controls.Add(this.txtFullNameOrder);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.txtSerialNumber);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtID1);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtOld);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtPassport);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtID1;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtPassport;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtOld;
        private System.Windows.Forms.MaskedTextBox txtID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблицаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поИмениToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поГородуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поРазмеруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поВозрастуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поЦенеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поНазваниюToolStripMenuItem;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button12;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSerialNumberOrder;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox txtID2;
        private System.Windows.Forms.TextBox txtPassportOrder;
        private System.Windows.Forms.TextBox txtFullNameOrder;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button14;
        public System.Windows.Forms.ComboBox comboBox1;
    }
}

