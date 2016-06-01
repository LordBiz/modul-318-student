namespace ÜBER_GUI
{
    partial class MainWindow
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
            this.StartStation = new System.Windows.Forms.TextBox();
            this.EndStation = new System.Windows.Forms.TextBox();
            this.ComboBoxAD = new System.Windows.Forms.ComboBox();
            this.ConnectionsListView = new System.Windows.Forms.ListView();
            this.Von = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Abfahrtszeit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ankunftszeit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dauer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SearchStation = new System.Windows.Forms.Button();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.SendMail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartStation
            // 
            this.StartStation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.StartStation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.StartStation.Location = new System.Drawing.Point(47, 19);
            this.StartStation.Name = "StartStation";
            this.StartStation.Size = new System.Drawing.Size(171, 20);
            this.StartStation.TabIndex = 0;
            this.StartStation.TextChanged += new System.EventHandler(this.StartStationChanged);
            // 
            // EndStation
            // 
            this.EndStation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.EndStation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.EndStation.Location = new System.Drawing.Point(273, 19);
            this.EndStation.Name = "EndStation";
            this.EndStation.Size = new System.Drawing.Size(172, 20);
            this.EndStation.TabIndex = 1;
            this.EndStation.TextChanged += new System.EventHandler(this.EndStationChanged);
            // 
            // ComboBoxAD
            // 
            this.ComboBoxAD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxAD.FormattingEnabled = true;
            this.ComboBoxAD.Items.AddRange(new object[] {
            "Abfahrt",
            "Ankunft"});
            this.ComboBoxAD.Location = new System.Drawing.Point(345, 45);
            this.ComboBoxAD.Name = "ComboBoxAD";
            this.ComboBoxAD.Size = new System.Drawing.Size(100, 21);
            this.ComboBoxAD.TabIndex = 3;
            ComboBoxAD.SelectedIndex = 0;
            this.ComboBoxAD.SelectedIndexChanged += new System.EventHandler(this.ComboBoxAD_SelectedIndexChanged);
            // 
            // ConnectionsListView
            // 
            this.ConnectionsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Von,
            this.Nach,
            this.Abfahrtszeit,
            this.Ankunftszeit,
            this.Dauer});
            this.ConnectionsListView.Location = new System.Drawing.Point(11, 131);
            this.ConnectionsListView.Name = "ConnectionsListView";
            this.ConnectionsListView.Size = new System.Drawing.Size(452, 257);
            this.ConnectionsListView.TabIndex = 4;
            this.ConnectionsListView.UseCompatibleStateImageBehavior = false;
            this.ConnectionsListView.View = System.Windows.Forms.View.Details;
            // 
            // Von
            // 
            this.Von.Text = "Von";
            // 
            // Nach
            // 
            this.Nach.Text = "Nach";
            // 
            // Abfahrtszeit
            // 
            this.Abfahrtszeit.Text = "Abfahrtszeit";
            // 
            // Ankunftszeit
            // 
            this.Ankunftszeit.Text = "Ankunftszeit";
            // 
            // Dauer
            // 
            this.Dauer.Text = "Dauer";
            // 
            // SearchStation
            // 
            this.SearchStation.Location = new System.Drawing.Point(370, 72);
            this.SearchStation.Name = "SearchStation";
            this.SearchStation.Size = new System.Drawing.Size(75, 23);
            this.SearchStation.TabIndex = 5;
            this.SearchStation.Text = "Suche";
            this.SearchStation.UseVisualStyleBackColor = true;
            this.SearchStation.Click += new System.EventHandler(this.Search_Click);
            // 
            // DatePicker
            // 
            this.DatePicker.CustomFormat = " dd.MM.yyyy";
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePicker.Location = new System.Drawing.Point(56, 45);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(162, 20);
            this.DatePicker.TabIndex = 6;
            this.DatePicker.ValueChanged += new System.EventHandler(this.DatePickerChanged);
            // 
            // TimePicker
            // 
            this.TimePicker.CustomFormat = " HH:mm";
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimePicker.Location = new System.Drawing.Point(273, 46);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.ShowUpDown = true;
            this.TimePicker.Size = new System.Drawing.Size(61, 20);
            this.TimePicker.TabIndex = 7;
            // 
            // SendMail
            // 
            this.SendMail.Location = new System.Drawing.Point(388, 394);
            this.SendMail.Name = "SendMail";
            this.SendMail.Size = new System.Drawing.Size(75, 23);
            this.SendMail.TabIndex = 8;
            this.SendMail.Text = "Send Mail";
            this.SendMail.UseVisualStyleBackColor = true;
            this.SendMail.Click += new System.EventHandler(this.SendMail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Von:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nach:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.EndStation);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.StartStation);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ComboBoxAD);
            this.groupBox1.Controls.Add(this.SearchStation);
            this.groupBox1.Controls.Add(this.TimePicker);
            this.groupBox1.Controls.Add(this.DatePicker);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 102);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Verbindung";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Uhrzeit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Datum";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 429);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SendMail);
            this.Controls.Add(this.ConnectionsListView);
            this.MaximumSize = new System.Drawing.Size(483, 456);
            this.MinimumSize = new System.Drawing.Size(483, 456);
            this.Name = "MainWindow";
            this.Text = "Fahrplan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox StartStation;
        private System.Windows.Forms.TextBox EndStation;
        private System.Windows.Forms.ComboBox ComboBoxAD;
        private System.Windows.Forms.ListView ConnectionsListView;
        private System.Windows.Forms.Button SearchStation;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.Button SendMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader Von;
        private System.Windows.Forms.ColumnHeader Nach;
        private System.Windows.Forms.ColumnHeader Abfahrtszeit;
        private System.Windows.Forms.ColumnHeader Ankunftszeit;
        private System.Windows.Forms.ColumnHeader Dauer;
    }
}

