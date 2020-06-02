namespace Base
{
    partial class BD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BD));
            this.close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.adminName = new System.Windows.Forms.Label();
            this.fitnes = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVisitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.mailing = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.Birthday = new System.Windows.Forms.TabPage();
            this.birthTable = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.scanBirth = new System.Windows.Forms.Button();
            this.invite = new System.Windows.Forms.TabPage();
            this.visitTable = new System.Windows.Forms.ListView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dateVisitTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateVisitTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.scanVisit = new System.Windows.Forms.Button();
            this.Check = new System.Windows.Forms.TabPage();
            this.checkTable = new System.Windows.Forms.ListView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.updateCheck = new System.Windows.Forms.Button();
            this.deleteCheck = new System.Windows.Forms.Button();
            this.refreshCheck = new System.Windows.Forms.Button();
            this.addCheck = new System.Windows.Forms.Button();
            this.scanCheck = new System.Windows.Forms.Button();
            this.textBoxCheck = new System.Windows.Forms.TextBox();
            this.Clients = new System.Windows.Forms.TabPage();
            this.clientsTable = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.updateClient = new System.Windows.Forms.Button();
            this.deleteClient = new System.Windows.Forms.Button();
            this.refreshClients = new System.Windows.Forms.Button();
            this.addClient = new System.Windows.Forms.Button();
            this.scanClient = new System.Windows.Forms.Button();
            this.textBoxClients = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            this.mailing.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.Birthday.SuspendLayout();
            this.panel2.SuspendLayout();
            this.invite.SuspendLayout();
            this.panel5.SuspendLayout();
            this.Check.SuspendLayout();
            this.panel4.SuspendLayout();
            this.Clients.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(122)))), ((int)(((byte)(172)))));
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(1108, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(35, 37);
            this.close.TabIndex = 8;
            this.close.Text = "x";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseEnter += new System.EventHandler(this.close_MouseEnter);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(122)))), ((int)(((byte)(172)))));
            this.panel1.Controls.Add(this.adminName);
            this.panel1.Controls.Add(this.fitnes);
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 73);
            this.panel1.TabIndex = 0;
            // 
            // adminName
            // 
            this.adminName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.adminName.AutoSize = true;
            this.adminName.Font = new System.Drawing.Font("Constantia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminName.ForeColor = System.Drawing.SystemColors.Control;
            this.adminName.Location = new System.Drawing.Point(697, 29);
            this.adminName.Name = "adminName";
            this.adminName.Size = new System.Drawing.Size(270, 40);
            this.adminName.TabIndex = 11;
            this.adminName.Text = "Адміністратор: ";
            // 
            // fitnes
            // 
            this.fitnes.AutoSize = true;
            this.fitnes.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fitnes.ForeColor = System.Drawing.SystemColors.Control;
            this.fitnes.Location = new System.Drawing.Point(12, 9);
            this.fitnes.Name = "fitnes";
            this.fitnes.Size = new System.Drawing.Size(681, 49);
            this.fitnes.TabIndex = 9;
            this.fitnes.Text = "Фітнес-центр «УКЕНЕРГОПРОМ»";
            this.fitnes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // dataVisitDataGridViewTextBoxColumn
            // 
            this.dataVisitDataGridViewTextBoxColumn.DataPropertyName = "dataVisit";
            this.dataVisitDataGridViewTextBoxColumn.HeaderText = "dataVisit";
            this.dataVisitDataGridViewTextBoxColumn.Name = "dataVisitDataGridViewTextBoxColumn";
            // 
            // dataStartDataGridViewTextBoxColumn
            // 
            this.dataStartDataGridViewTextBoxColumn.DataPropertyName = "dataStart";
            this.dataStartDataGridViewTextBoxColumn.HeaderText = "dataStart";
            this.dataStartDataGridViewTextBoxColumn.Name = "dataStartDataGridViewTextBoxColumn";
            // 
            // dataEndDataGridViewTextBoxColumn
            // 
            this.dataEndDataGridViewTextBoxColumn.DataPropertyName = "dataEnd";
            this.dataEndDataGridViewTextBoxColumn.HeaderText = "dataEnd";
            this.dataEndDataGridViewTextBoxColumn.Name = "dataEndDataGridViewTextBoxColumn";
            this.dataEndDataGridViewTextBoxColumn.Width = 200;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "phoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "phoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "dateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "dateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // mailing
            // 
            this.mailing.Controls.Add(this.tabControl2);
            this.mailing.Location = new System.Drawing.Point(4, 38);
            this.mailing.Name = "mailing";
            this.mailing.Padding = new System.Windows.Forms.Padding(3);
            this.mailing.Size = new System.Drawing.Size(1135, 588);
            this.mailing.TabIndex = 2;
            this.mailing.Text = "Розсилка";
            this.mailing.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.Birthday);
            this.tabControl2.Controls.Add(this.invite);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1129, 582);
            this.tabControl2.TabIndex = 0;
            // 
            // Birthday
            // 
            this.Birthday.Controls.Add(this.birthTable);
            this.Birthday.Controls.Add(this.panel2);
            this.Birthday.Location = new System.Drawing.Point(4, 38);
            this.Birthday.Name = "Birthday";
            this.Birthday.Padding = new System.Windows.Forms.Padding(3);
            this.Birthday.Size = new System.Drawing.Size(1121, 540);
            this.Birthday.TabIndex = 0;
            this.Birthday.Text = "День нарождення";
            this.Birthday.UseVisualStyleBackColor = true;
            // 
            // birthTable
            // 
            this.birthTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.birthTable.HideSelection = false;
            this.birthTable.Location = new System.Drawing.Point(3, 3);
            this.birthTable.Name = "birthTable";
            this.birthTable.Size = new System.Drawing.Size(1115, 470);
            this.birthTable.TabIndex = 6;
            this.birthTable.UseCompatibleStateImageBehavior = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.dataBirthDateTimePicker);
            this.panel2.Controls.Add(this.scanBirth);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 473);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1115, 64);
            this.panel2.TabIndex = 5;
            // 
            // dataBirthDateTimePicker
            // 
            this.dataBirthDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataBirthDateTimePicker.Location = new System.Drawing.Point(39, 13);
            this.dataBirthDateTimePicker.Name = "dataBirthDateTimePicker";
            this.dataBirthDateTimePicker.Size = new System.Drawing.Size(278, 34);
            this.dataBirthDateTimePicker.TabIndex = 46;
            // 
            // scanBirth
            // 
            this.scanBirth.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("scanBirth.BackgroundImage")));
            this.scanBirth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.scanBirth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scanBirth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scanBirth.Location = new System.Drawing.Point(376, 10);
            this.scanBirth.Name = "scanBirth";
            this.scanBirth.Size = new System.Drawing.Size(45, 45);
            this.scanBirth.TabIndex = 1;
            this.scanBirth.UseVisualStyleBackColor = true;
            this.scanBirth.Click += new System.EventHandler(this.scanBirth_Click);
            // 
            // invite
            // 
            this.invite.Controls.Add(this.visitTable);
            this.invite.Controls.Add(this.panel5);
            this.invite.Location = new System.Drawing.Point(4, 38);
            this.invite.Name = "invite";
            this.invite.Padding = new System.Windows.Forms.Padding(3);
            this.invite.Size = new System.Drawing.Size(1121, 540);
            this.invite.TabIndex = 1;
            this.invite.Text = "Запрошення";
            this.invite.UseVisualStyleBackColor = true;
            // 
            // visitTable
            // 
            this.visitTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visitTable.HideSelection = false;
            this.visitTable.Location = new System.Drawing.Point(3, 3);
            this.visitTable.Name = "visitTable";
            this.visitTable.Size = new System.Drawing.Size(1115, 470);
            this.visitTable.TabIndex = 7;
            this.visitTable.UseCompatibleStateImageBehavior = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGray;
            this.panel5.Controls.Add(this.dateVisitTimePicker2);
            this.panel5.Controls.Add(this.dateVisitTimePicker1);
            this.panel5.Controls.Add(this.scanVisit);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(3, 473);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1115, 64);
            this.panel5.TabIndex = 6;
            // 
            // dateVisitTimePicker2
            // 
            this.dateVisitTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateVisitTimePicker2.Location = new System.Drawing.Point(353, 13);
            this.dateVisitTimePicker2.Name = "dateVisitTimePicker2";
            this.dateVisitTimePicker2.Size = new System.Drawing.Size(278, 34);
            this.dateVisitTimePicker2.TabIndex = 47;
            // 
            // dateVisitTimePicker1
            // 
            this.dateVisitTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateVisitTimePicker1.Location = new System.Drawing.Point(39, 13);
            this.dateVisitTimePicker1.Name = "dateVisitTimePicker1";
            this.dateVisitTimePicker1.Size = new System.Drawing.Size(278, 34);
            this.dateVisitTimePicker1.TabIndex = 46;
            // 
            // scanVisit
            // 
            this.scanVisit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("scanVisit.BackgroundImage")));
            this.scanVisit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.scanVisit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scanVisit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scanVisit.Location = new System.Drawing.Point(662, 10);
            this.scanVisit.Name = "scanVisit";
            this.scanVisit.Size = new System.Drawing.Size(45, 45);
            this.scanVisit.TabIndex = 1;
            this.scanVisit.UseVisualStyleBackColor = true;
            this.scanVisit.Click += new System.EventHandler(this.scanVisit_Click);
            // 
            // Check
            // 
            this.Check.Controls.Add(this.checkTable);
            this.Check.Controls.Add(this.panel4);
            this.Check.Location = new System.Drawing.Point(4, 38);
            this.Check.Name = "Check";
            this.Check.Padding = new System.Windows.Forms.Padding(3);
            this.Check.Size = new System.Drawing.Size(1135, 588);
            this.Check.TabIndex = 1;
            this.Check.Text = "Рахунки";
            this.Check.UseVisualStyleBackColor = true;
            // 
            // checkTable
            // 
            this.checkTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkTable.HideSelection = false;
            this.checkTable.Location = new System.Drawing.Point(3, 3);
            this.checkTable.Name = "checkTable";
            this.checkTable.Size = new System.Drawing.Size(1129, 518);
            this.checkTable.TabIndex = 6;
            this.checkTable.UseCompatibleStateImageBehavior = false;
            this.checkTable.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.checkTable_ItemSelectionChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Controls.Add(this.updateCheck);
            this.panel4.Controls.Add(this.deleteCheck);
            this.panel4.Controls.Add(this.refreshCheck);
            this.panel4.Controls.Add(this.addCheck);
            this.panel4.Controls.Add(this.scanCheck);
            this.panel4.Controls.Add(this.textBoxCheck);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 521);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1129, 64);
            this.panel4.TabIndex = 4;
            // 
            // updateCheck
            // 
            this.updateCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateCheck.BackgroundImage")));
            this.updateCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.updateCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateCheck.Location = new System.Drawing.Point(1014, 10);
            this.updateCheck.Name = "updateCheck";
            this.updateCheck.Size = new System.Drawing.Size(45, 45);
            this.updateCheck.TabIndex = 6;
            this.updateCheck.UseVisualStyleBackColor = true;
            this.updateCheck.Click += new System.EventHandler(this.updateCheck_Click);
            // 
            // deleteCheck
            // 
            this.deleteCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteCheck.BackgroundImage")));
            this.deleteCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCheck.Location = new System.Drawing.Point(1065, 10);
            this.deleteCheck.Name = "deleteCheck";
            this.deleteCheck.Size = new System.Drawing.Size(45, 45);
            this.deleteCheck.TabIndex = 4;
            this.deleteCheck.UseVisualStyleBackColor = true;
            this.deleteCheck.Click += new System.EventHandler(this.deleteCheck_Click);
            // 
            // refreshCheck
            // 
            this.refreshCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshCheck.BackgroundImage")));
            this.refreshCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refreshCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshCheck.Location = new System.Drawing.Point(427, 10);
            this.refreshCheck.Name = "refreshCheck";
            this.refreshCheck.Size = new System.Drawing.Size(45, 45);
            this.refreshCheck.TabIndex = 3;
            this.refreshCheck.UseVisualStyleBackColor = true;
            this.refreshCheck.Click += new System.EventHandler(this.refreshCheck_Click);
            // 
            // addCheck
            // 
            this.addCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addCheck.BackgroundImage")));
            this.addCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCheck.Location = new System.Drawing.Point(478, 10);
            this.addCheck.Name = "addCheck";
            this.addCheck.Size = new System.Drawing.Size(45, 45);
            this.addCheck.TabIndex = 2;
            this.addCheck.UseVisualStyleBackColor = true;
            this.addCheck.Click += new System.EventHandler(this.addCheck_Click);
            // 
            // scanCheck
            // 
            this.scanCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("scanCheck.BackgroundImage")));
            this.scanCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.scanCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scanCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scanCheck.Location = new System.Drawing.Point(376, 10);
            this.scanCheck.Name = "scanCheck";
            this.scanCheck.Size = new System.Drawing.Size(45, 45);
            this.scanCheck.TabIndex = 1;
            this.scanCheck.UseVisualStyleBackColor = true;
            this.scanCheck.Click += new System.EventHandler(this.scanCheck_Click);
            // 
            // textBoxCheck
            // 
            this.textBoxCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCheck.Location = new System.Drawing.Point(31, 12);
            this.textBoxCheck.Name = "textBoxCheck";
            this.textBoxCheck.Size = new System.Drawing.Size(315, 38);
            this.textBoxCheck.TabIndex = 0;
            // 
            // Clients
            // 
            this.Clients.AutoScroll = true;
            this.Clients.Controls.Add(this.clientsTable);
            this.Clients.Controls.Add(this.panel3);
            this.Clients.Location = new System.Drawing.Point(4, 38);
            this.Clients.Name = "Clients";
            this.Clients.Padding = new System.Windows.Forms.Padding(3);
            this.Clients.Size = new System.Drawing.Size(1135, 588);
            this.Clients.TabIndex = 0;
            this.Clients.Text = "Клієнти";
            this.Clients.UseVisualStyleBackColor = true;
            // 
            // clientsTable
            // 
            this.clientsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientsTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientsTable.HideSelection = false;
            this.clientsTable.Location = new System.Drawing.Point(3, 3);
            this.clientsTable.Name = "clientsTable";
            this.clientsTable.Size = new System.Drawing.Size(1129, 518);
            this.clientsTable.TabIndex = 5;
            this.clientsTable.UseCompatibleStateImageBehavior = false;
            this.clientsTable.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.clientsTable_ItemSelectionChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.updateClient);
            this.panel3.Controls.Add(this.deleteClient);
            this.panel3.Controls.Add(this.refreshClients);
            this.panel3.Controls.Add(this.addClient);
            this.panel3.Controls.Add(this.scanClient);
            this.panel3.Controls.Add(this.textBoxClients);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 521);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1129, 64);
            this.panel3.TabIndex = 3;
            // 
            // updateClient
            // 
            this.updateClient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateClient.BackgroundImage")));
            this.updateClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.updateClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateClient.Location = new System.Drawing.Point(1014, 10);
            this.updateClient.Name = "updateClient";
            this.updateClient.Size = new System.Drawing.Size(45, 45);
            this.updateClient.TabIndex = 6;
            this.updateClient.UseVisualStyleBackColor = true;
            this.updateClient.Click += new System.EventHandler(this.updateClient_Click);
            // 
            // deleteClient
            // 
            this.deleteClient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteClient.BackgroundImage")));
            this.deleteClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteClient.Location = new System.Drawing.Point(1065, 10);
            this.deleteClient.Name = "deleteClient";
            this.deleteClient.Size = new System.Drawing.Size(45, 45);
            this.deleteClient.TabIndex = 4;
            this.deleteClient.UseVisualStyleBackColor = true;
            this.deleteClient.Click += new System.EventHandler(this.deleteClient_Click);
            // 
            // refreshClients
            // 
            this.refreshClients.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshClients.BackgroundImage")));
            this.refreshClients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refreshClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshClients.Location = new System.Drawing.Point(427, 10);
            this.refreshClients.Name = "refreshClients";
            this.refreshClients.Size = new System.Drawing.Size(45, 45);
            this.refreshClients.TabIndex = 3;
            this.refreshClients.UseVisualStyleBackColor = true;
            this.refreshClients.Click += new System.EventHandler(this.refreshClients_Click);
            // 
            // addClient
            // 
            this.addClient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addClient.BackgroundImage")));
            this.addClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addClient.Location = new System.Drawing.Point(478, 10);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(45, 45);
            this.addClient.TabIndex = 2;
            this.addClient.UseVisualStyleBackColor = true;
            this.addClient.Click += new System.EventHandler(this.addClient_Click);
            // 
            // scanClient
            // 
            this.scanClient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("scanClient.BackgroundImage")));
            this.scanClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.scanClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scanClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scanClient.Location = new System.Drawing.Point(376, 10);
            this.scanClient.Name = "scanClient";
            this.scanClient.Size = new System.Drawing.Size(45, 45);
            this.scanClient.TabIndex = 1;
            this.scanClient.UseVisualStyleBackColor = true;
            this.scanClient.Click += new System.EventHandler(this.scanClient_Click);
            // 
            // textBoxClients
            // 
            this.textBoxClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxClients.Location = new System.Drawing.Point(31, 12);
            this.textBoxClients.Name = "textBoxClients";
            this.textBoxClients.Size = new System.Drawing.Size(315, 38);
            this.textBoxClients.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Clients);
            this.tabControl1.Controls.Add(this.Check);
            this.tabControl1.Controls.Add(this.mailing);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 73);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1143, 630);
            this.tabControl1.TabIndex = 3;
            // 
            // BD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 703);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BD";
            this.Text = "BD";
            this.Load += new System.EventHandler(this.BD_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mailing.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.Birthday.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.invite.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.Check.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.Clients.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label fitnes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVisitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label adminName;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TabPage mailing;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage Birthday;
        private System.Windows.Forms.ListView birthTable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dataBirthDateTimePicker;
        private System.Windows.Forms.Button scanBirth;
        private System.Windows.Forms.TabPage invite;
        private System.Windows.Forms.ListView visitTable;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker dateVisitTimePicker2;
        private System.Windows.Forms.DateTimePicker dateVisitTimePicker1;
        private System.Windows.Forms.Button scanVisit;
        private System.Windows.Forms.TabPage Check;
        private System.Windows.Forms.ListView checkTable;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button updateCheck;
        private System.Windows.Forms.Button deleteCheck;
        private System.Windows.Forms.Button refreshCheck;
        private System.Windows.Forms.Button addCheck;
        private System.Windows.Forms.Button scanCheck;
        private System.Windows.Forms.TextBox textBoxCheck;
        private System.Windows.Forms.TabPage Clients;
        private System.Windows.Forms.ListView clientsTable;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button updateClient;
        private System.Windows.Forms.Button deleteClient;
        private System.Windows.Forms.Button refreshClients;
        private System.Windows.Forms.Button addClient;
        private System.Windows.Forms.Button scanClient;
        private System.Windows.Forms.TextBox textBoxClients;
        private System.Windows.Forms.TabControl tabControl1;
    }
}