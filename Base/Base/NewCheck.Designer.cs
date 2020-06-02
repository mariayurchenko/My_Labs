namespace Base
{
    partial class NewCheck
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
            System.Windows.Forms.Label dataStartLabel;
            System.Windows.Forms.Label dataEndLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label dataVisitLabel;
            System.Windows.Forms.Label valueLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.numberLabel = new System.Windows.Forms.Label();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.dataStartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataEndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.dataVisitDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            dataStartLabel = new System.Windows.Forms.Label();
            dataEndLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            dataVisitLabel = new System.Windows.Forms.Label();
            valueLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(122)))), ((int)(((byte)(172)))));
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 52);
            this.panel1.TabIndex = 17;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(122)))), ((int)(((byte)(172)))));
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(676, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(35, 36);
            this.close.TabIndex = 7;
            this.close.Text = "x";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseEnter += new System.EventHandler(this.close_MouseEnter);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(221, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Нова квитанція";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.LightSeaGreen;
            this.login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.login.FlatAppearance.BorderSize = 3;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.ForeColor = System.Drawing.Color.MintCream;
            this.login.Location = new System.Drawing.Point(512, 464);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(170, 50);
            this.login.TabIndex = 41;
            this.login.Text = "Додати";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.numberLabel.Location = new System.Drawing.Point(265, 72);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(172, 29);
            this.numberLabel.TabIndex = 79;
            this.numberLabel.Text = "Квитанція №";
            this.numberLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonNo.Location = new System.Drawing.Point(495, 364);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(185, 33);
            this.radioButtonNo.TabIndex = 94;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "Не оплачено";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonYes.Location = new System.Drawing.Point(327, 364);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(153, 33);
            this.radioButtonYes.TabIndex = 93;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "Оплачено";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            // 
            // dataStartTimePicker
            // 
            this.dataStartTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataStartTimePicker.Location = new System.Drawing.Point(404, 244);
            this.dataStartTimePicker.Name = "dataStartTimePicker";
            this.dataStartTimePicker.Size = new System.Drawing.Size(278, 34);
            this.dataStartTimePicker.TabIndex = 92;
            // 
            // dataEndTimePicker
            // 
            this.dataEndTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataEndTimePicker.Location = new System.Drawing.Point(404, 284);
            this.dataEndTimePicker.Name = "dataEndTimePicker";
            this.dataEndTimePicker.Size = new System.Drawing.Size(278, 34);
            this.dataEndTimePicker.TabIndex = 91;
            // 
            // dataStartLabel
            // 
            dataStartLabel.AutoSize = true;
            dataStartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataStartLabel.Location = new System.Drawing.Point(34, 248);
            dataStartLabel.Name = "dataStartLabel";
            dataStartLabel.Size = new System.Drawing.Size(183, 29);
            dataStartLabel.TabIndex = 90;
            dataStartLabel.Text = "Дата початку:";
            // 
            // dataEndLabel
            // 
            dataEndLabel.AutoSize = true;
            dataEndLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataEndLabel.Location = new System.Drawing.Point(34, 288);
            dataEndLabel.Name = "dataEndLabel";
            dataEndLabel.Size = new System.Drawing.Size(152, 29);
            dataEndLabel.TabIndex = 89;
            dataEndLabel.Text = "Дата кінця:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            idLabel.Location = new System.Drawing.Point(34, 168);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(42, 29);
            idLabel.TabIndex = 80;
            idLabel.Text = "id:";
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idTextBox.Location = new System.Drawing.Point(404, 164);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(278, 34);
            this.idTextBox.TabIndex = 81;
            this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            statusLabel.Location = new System.Drawing.Point(34, 368);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(103, 29);
            statusLabel.TabIndex = 86;
            statusLabel.Text = "Статус:";
            // 
            // dataVisitLabel
            // 
            dataVisitLabel.AutoSize = true;
            dataVisitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataVisitLabel.Location = new System.Drawing.Point(34, 208);
            dataVisitLabel.Name = "dataVisitLabel";
            dataVisitLabel.Size = new System.Drawing.Size(161, 29);
            dataVisitLabel.TabIndex = 82;
            dataVisitLabel.Text = "Дата візиту:";
            // 
            // valueTextBox
            // 
            this.valueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueTextBox.Location = new System.Drawing.Point(404, 324);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(278, 34);
            this.valueTextBox.TabIndex = 85;
            // 
            // dataVisitDateTimePicker
            // 
            this.dataVisitDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataVisitDateTimePicker.Location = new System.Drawing.Point(404, 204);
            this.dataVisitDateTimePicker.Name = "dataVisitDateTimePicker";
            this.dataVisitDateTimePicker.Size = new System.Drawing.Size(278, 34);
            this.dataVisitDateTimePicker.TabIndex = 83;
            // 
            // valueLabel
            // 
            valueLabel.AutoSize = true;
            valueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            valueLabel.Location = new System.Drawing.Point(34, 328);
            valueLabel.Name = "valueLabel";
            valueLabel.Size = new System.Drawing.Size(106, 29);
            valueLabel.TabIndex = 84;
            valueLabel.Text = "Всього:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.nameLabel.Location = new System.Drawing.Point(34, 125);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(61, 29);
            this.nameLabel.TabIndex = 95;
            this.nameLabel.Text = "ПІБ:";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(34, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 29);
            this.label2.TabIndex = 96;
            this.label2.Text = "Адміністратор:";
            // 
            // NewCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(206)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(711, 544);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.radioButtonNo);
            this.Controls.Add(this.radioButtonYes);
            this.Controls.Add(this.dataStartTimePicker);
            this.Controls.Add(this.dataEndTimePicker);
            this.Controls.Add(dataStartLabel);
            this.Controls.Add(dataEndLabel);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(dataVisitLabel);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.dataVisitDateTimePicker);
            this.Controls.Add(valueLabel);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewCheck";
            this.Text = "NewCheck";
            this.Load += new System.EventHandler(this.NewCheck_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.DateTimePicker dataStartTimePicker;
        private System.Windows.Forms.DateTimePicker dataEndTimePicker;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.DateTimePicker dataVisitDateTimePicker;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label2;
    }
}