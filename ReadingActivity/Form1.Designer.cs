namespace ReadingActivity
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RegistrationGroupBox = new System.Windows.Forms.GroupBox();
            this.quotationLbl = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.GetReaderBtn = new System.Windows.Forms.Button();
            this.RaffleResultLbl = new System.Windows.Forms.Label();
            this.RaffleBtn = new System.Windows.Forms.Button();
            this.EnterCodeTxtBx = new System.Windows.Forms.TextBox();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.BookGenreCmbBx = new System.Windows.Forms.ComboBox();
            this.BookAuthorTxtBx = new System.Windows.Forms.TextBox();
            this.BookNameTxtBx = new System.Windows.Forms.TextBox();
            this.ReaderGenderCmbBx = new System.Windows.Forms.ComboBox();
            this.ReaderAgeTxtBx = new System.Windows.Forms.TextBox();
            this.ReaderNameTxtBx = new System.Windows.Forms.TextBox();
            this.BookGenreLbl = new System.Windows.Forms.Label();
            this.BookAuthorLbl = new System.Windows.Forms.Label();
            this.BookNameLbl = new System.Windows.Forms.Label();
            this.ReaderGenderLbl = new System.Windows.Forms.Label();
            this.ReaderAgeLbl = new System.Windows.Forms.Label();
            this.ReaderNameLbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ReaderCountLbl = new System.Windows.Forms.Label();
            this.RefreshButton = new RoundButton();
            this.RegistrationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // RegistrationGroupBox
            // 
            this.RegistrationGroupBox.BackColor = System.Drawing.Color.PapayaWhip;
            this.RegistrationGroupBox.Controls.Add(this.quotationLbl);
            this.RegistrationGroupBox.Controls.Add(this.ClearBtn);
            this.RegistrationGroupBox.Controls.Add(this.GetReaderBtn);
            this.RegistrationGroupBox.Controls.Add(this.RaffleResultLbl);
            this.RegistrationGroupBox.Controls.Add(this.RaffleBtn);
            this.RegistrationGroupBox.Controls.Add(this.EnterCodeTxtBx);
            this.RegistrationGroupBox.Controls.Add(this.EditBtn);
            this.RegistrationGroupBox.Controls.Add(this.DeleteBtn);
            this.RegistrationGroupBox.Controls.Add(this.AddBtn);
            this.RegistrationGroupBox.Controls.Add(this.BookGenreCmbBx);
            this.RegistrationGroupBox.Controls.Add(this.BookAuthorTxtBx);
            this.RegistrationGroupBox.Controls.Add(this.BookNameTxtBx);
            this.RegistrationGroupBox.Controls.Add(this.ReaderGenderCmbBx);
            this.RegistrationGroupBox.Controls.Add(this.ReaderAgeTxtBx);
            this.RegistrationGroupBox.Controls.Add(this.ReaderNameTxtBx);
            this.RegistrationGroupBox.Controls.Add(this.BookGenreLbl);
            this.RegistrationGroupBox.Controls.Add(this.BookAuthorLbl);
            this.RegistrationGroupBox.Controls.Add(this.BookNameLbl);
            this.RegistrationGroupBox.Controls.Add(this.ReaderGenderLbl);
            this.RegistrationGroupBox.Controls.Add(this.ReaderAgeLbl);
            this.RegistrationGroupBox.Controls.Add(this.ReaderNameLbl);
            this.RegistrationGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrationGroupBox.ForeColor = System.Drawing.Color.SaddleBrown;
            this.RegistrationGroupBox.Location = new System.Drawing.Point(21, 36);
            this.RegistrationGroupBox.Name = "RegistrationGroupBox";
            this.RegistrationGroupBox.Size = new System.Drawing.Size(1253, 383);
            this.RegistrationGroupBox.TabIndex = 1;
            this.RegistrationGroupBox.TabStop = false;
            this.RegistrationGroupBox.Text = "REGISTRATION";
            // 
            // quotationLbl
            // 
            this.quotationLbl.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.quotationLbl.Location = new System.Drawing.Point(399, 265);
            this.quotationLbl.Name = "quotationLbl";
            this.quotationLbl.Size = new System.Drawing.Size(831, 115);
            this.quotationLbl.TabIndex = 23;
            this.quotationLbl.Text = "\"Books are the quietest and most constant of friends; they are the most accessibl" +
    "e and wisest of counselors, and the most patient of teachers.\"\n - Charles Willia" +
    "m Eliot";
            this.quotationLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.Red;
            this.ClearBtn.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ClearBtn.ForeColor = System.Drawing.Color.SeaShell;
            this.ClearBtn.Location = new System.Drawing.Point(440, 180);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(119, 32);
            this.ClearBtn.TabIndex = 22;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // GetReaderBtn
            // 
            this.GetReaderBtn.BackColor = System.Drawing.Color.PowderBlue;
            this.GetReaderBtn.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GetReaderBtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.GetReaderBtn.Location = new System.Drawing.Point(440, 143);
            this.GetReaderBtn.Name = "GetReaderBtn";
            this.GetReaderBtn.Size = new System.Drawing.Size(119, 30);
            this.GetReaderBtn.TabIndex = 21;
            this.GetReaderBtn.Text = "Get Reader";
            this.GetReaderBtn.UseVisualStyleBackColor = false;
            this.GetReaderBtn.Click += new System.EventHandler(this.GetReaderBtn_Click);
            // 
            // RaffleResultLbl
            // 
            this.RaffleResultLbl.BackColor = System.Drawing.Color.LightPink;
            this.RaffleResultLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RaffleResultLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RaffleResultLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RaffleResultLbl.ForeColor = System.Drawing.Color.Crimson;
            this.RaffleResultLbl.Location = new System.Drawing.Point(663, 150);
            this.RaffleResultLbl.Name = "RaffleResultLbl";
            this.RaffleResultLbl.Size = new System.Drawing.Size(516, 62);
            this.RaffleResultLbl.TabIndex = 20;
            this.RaffleResultLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RaffleBtn
            // 
            this.RaffleBtn.BackColor = System.Drawing.Color.Pink;
            this.RaffleBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RaffleBtn.BackgroundImage")));
            this.RaffleBtn.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RaffleBtn.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.RaffleBtn.Location = new System.Drawing.Point(789, 43);
            this.RaffleBtn.Name = "RaffleBtn";
            this.RaffleBtn.Size = new System.Drawing.Size(240, 94);
            this.RaffleBtn.TabIndex = 19;
            this.RaffleBtn.Text = "Start Raffle!!";
            this.RaffleBtn.UseVisualStyleBackColor = false;
            this.RaffleBtn.Click += new System.EventHandler(this.RaffleBtn_Click_1);
            // 
            // EnterCodeTxtBx
            // 
            this.EnterCodeTxtBx.BackColor = System.Drawing.SystemColors.HighlightText;
            this.EnterCodeTxtBx.Font = new System.Drawing.Font("Candara Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EnterCodeTxtBx.ForeColor = System.Drawing.Color.DarkRed;
            this.EnterCodeTxtBx.Location = new System.Drawing.Point(404, 43);
            this.EnterCodeTxtBx.Multiline = true;
            this.EnterCodeTxtBx.Name = "EnterCodeTxtBx";
            this.EnterCodeTxtBx.Size = new System.Drawing.Size(192, 41);
            this.EnterCodeTxtBx.TabIndex = 18;
            this.EnterCodeTxtBx.Text = "Enter Reader Code:";
            this.EnterCodeTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EnterCodeTxtBx.Click += new System.EventHandler(this.EnterCodeTxtBx_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.Yellow;
            this.EditBtn.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EditBtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.EditBtn.Location = new System.Drawing.Point(503, 99);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(93, 38);
            this.EditBtn.TabIndex = 14;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Orange;
            this.DeleteBtn.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.DeleteBtn.Location = new System.Drawing.Point(404, 99);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(93, 38);
            this.DeleteBtn.TabIndex = 13;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Lime;
            this.AddBtn.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.AddBtn.Location = new System.Drawing.Point(187, 270);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(143, 62);
            this.AddBtn.TabIndex = 12;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // BookGenreCmbBx
            // 
            this.BookGenreCmbBx.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BookGenreCmbBx.ForeColor = System.Drawing.Color.SaddleBrown;
            this.BookGenreCmbBx.FormattingEnabled = true;
            this.BookGenreCmbBx.Location = new System.Drawing.Point(187, 223);
            this.BookGenreCmbBx.Name = "BookGenreCmbBx";
            this.BookGenreCmbBx.Size = new System.Drawing.Size(143, 24);
            this.BookGenreCmbBx.TabIndex = 11;
            this.BookGenreCmbBx.Text = " Choice...";
            // 
            // BookAuthorTxtBx
            // 
            this.BookAuthorTxtBx.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BookAuthorTxtBx.ForeColor = System.Drawing.Color.SaddleBrown;
            this.BookAuthorTxtBx.Location = new System.Drawing.Point(187, 186);
            this.BookAuthorTxtBx.Name = "BookAuthorTxtBx";
            this.BookAuthorTxtBx.Size = new System.Drawing.Size(143, 22);
            this.BookAuthorTxtBx.TabIndex = 10;
            // 
            // BookNameTxtBx
            // 
            this.BookNameTxtBx.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BookNameTxtBx.ForeColor = System.Drawing.Color.SaddleBrown;
            this.BookNameTxtBx.Location = new System.Drawing.Point(187, 150);
            this.BookNameTxtBx.Name = "BookNameTxtBx";
            this.BookNameTxtBx.Size = new System.Drawing.Size(143, 22);
            this.BookNameTxtBx.TabIndex = 9;
            // 
            // ReaderGenderCmbBx
            // 
            this.ReaderGenderCmbBx.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ReaderGenderCmbBx.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ReaderGenderCmbBx.FormattingEnabled = true;
            this.ReaderGenderCmbBx.Location = new System.Drawing.Point(187, 114);
            this.ReaderGenderCmbBx.Name = "ReaderGenderCmbBx";
            this.ReaderGenderCmbBx.Size = new System.Drawing.Size(143, 24);
            this.ReaderGenderCmbBx.TabIndex = 8;
            this.ReaderGenderCmbBx.Text = " Choice...";
            // 
            // ReaderAgeTxtBx
            // 
            this.ReaderAgeTxtBx.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ReaderAgeTxtBx.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ReaderAgeTxtBx.Location = new System.Drawing.Point(187, 77);
            this.ReaderAgeTxtBx.Name = "ReaderAgeTxtBx";
            this.ReaderAgeTxtBx.Size = new System.Drawing.Size(143, 22);
            this.ReaderAgeTxtBx.TabIndex = 7;
            // 
            // ReaderNameTxtBx
            // 
            this.ReaderNameTxtBx.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ReaderNameTxtBx.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ReaderNameTxtBx.Location = new System.Drawing.Point(187, 44);
            this.ReaderNameTxtBx.Name = "ReaderNameTxtBx";
            this.ReaderNameTxtBx.Size = new System.Drawing.Size(143, 22);
            this.ReaderNameTxtBx.TabIndex = 6;
            // 
            // BookGenreLbl
            // 
            this.BookGenreLbl.AutoSize = true;
            this.BookGenreLbl.BackColor = System.Drawing.Color.Transparent;
            this.BookGenreLbl.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BookGenreLbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.BookGenreLbl.Location = new System.Drawing.Point(69, 228);
            this.BookGenreLbl.Name = "BookGenreLbl";
            this.BookGenreLbl.Size = new System.Drawing.Size(86, 18);
            this.BookGenreLbl.TabIndex = 5;
            this.BookGenreLbl.Text = "Book Genre:";
            // 
            // BookAuthorLbl
            // 
            this.BookAuthorLbl.AutoSize = true;
            this.BookAuthorLbl.BackColor = System.Drawing.Color.Transparent;
            this.BookAuthorLbl.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BookAuthorLbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.BookAuthorLbl.Location = new System.Drawing.Point(69, 192);
            this.BookAuthorLbl.Name = "BookAuthorLbl";
            this.BookAuthorLbl.Size = new System.Drawing.Size(92, 18);
            this.BookAuthorLbl.TabIndex = 4;
            this.BookAuthorLbl.Text = "Book Author:";
            // 
            // BookNameLbl
            // 
            this.BookNameLbl.AutoSize = true;
            this.BookNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.BookNameLbl.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BookNameLbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.BookNameLbl.Location = new System.Drawing.Point(71, 156);
            this.BookNameLbl.Name = "BookNameLbl";
            this.BookNameLbl.Size = new System.Drawing.Size(88, 18);
            this.BookNameLbl.TabIndex = 3;
            this.BookNameLbl.Text = "Book Name:";
            // 
            // ReaderGenderLbl
            // 
            this.ReaderGenderLbl.AutoSize = true;
            this.ReaderGenderLbl.BackColor = System.Drawing.Color.Transparent;
            this.ReaderGenderLbl.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ReaderGenderLbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ReaderGenderLbl.Location = new System.Drawing.Point(49, 122);
            this.ReaderGenderLbl.Name = "ReaderGenderLbl";
            this.ReaderGenderLbl.Size = new System.Drawing.Size(107, 18);
            this.ReaderGenderLbl.TabIndex = 2;
            this.ReaderGenderLbl.Text = "Reader Gender:";
            // 
            // ReaderAgeLbl
            // 
            this.ReaderAgeLbl.AutoSize = true;
            this.ReaderAgeLbl.BackColor = System.Drawing.Color.Transparent;
            this.ReaderAgeLbl.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ReaderAgeLbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ReaderAgeLbl.Location = new System.Drawing.Point(69, 83);
            this.ReaderAgeLbl.Name = "ReaderAgeLbl";
            this.ReaderAgeLbl.Size = new System.Drawing.Size(86, 18);
            this.ReaderAgeLbl.TabIndex = 1;
            this.ReaderAgeLbl.Text = "Reader Age:";
            // 
            // ReaderNameLbl
            // 
            this.ReaderNameLbl.AutoSize = true;
            this.ReaderNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.ReaderNameLbl.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ReaderNameLbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ReaderNameLbl.Location = new System.Drawing.Point(57, 50);
            this.ReaderNameLbl.Name = "ReaderNameLbl";
            this.ReaderNameLbl.Size = new System.Drawing.Size(101, 18);
            this.ReaderNameLbl.TabIndex = 0;
            this.ReaderNameLbl.Text = "Reader Name:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Beige;
            this.dataGridView1.Location = new System.Drawing.Point(21, 437);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1253, 238);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ReaderCountLbl
            // 
            this.ReaderCountLbl.BackColor = System.Drawing.Color.Wheat;
            this.ReaderCountLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ReaderCountLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReaderCountLbl.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ReaderCountLbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ReaderCountLbl.Location = new System.Drawing.Point(1156, 452);
            this.ReaderCountLbl.Name = "ReaderCountLbl";
            this.ReaderCountLbl.Size = new System.Drawing.Size(102, 41);
            this.ReaderCountLbl.TabIndex = 4;
            this.ReaderCountLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.Wheat;
            this.RefreshButton.FlatAppearance.BorderSize = 0;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.ForeColor = System.Drawing.Color.Black;
            this.RefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton.Image")));
            this.RefreshButton.Location = new System.Drawing.Point(1100, 452);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(41, 41);
            this.RefreshButton.TabIndex = 5;
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1309, 716);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.ReaderCountLbl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RegistrationGroupBox);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Reading Activity Registration System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.RegistrationGroupBox.ResumeLayout(false);
            this.RegistrationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.ComboBox BookGenreCmbBx;
        private System.Windows.Forms.TextBox BookAuthorTxtBx;
        private System.Windows.Forms.TextBox BookNameTxtBx;
        private System.Windows.Forms.ComboBox ReaderGenderCmbBx;
        private System.Windows.Forms.TextBox ReaderAgeTxtBx;
        private System.Windows.Forms.TextBox ReaderNameTxtBx;
        private System.Windows.Forms.Label BookGenreLbl;
        private System.Windows.Forms.Label BookAuthorLbl;
        private System.Windows.Forms.Label BookNameLbl;
        private System.Windows.Forms.Label ReaderGenderLbl;
        private System.Windows.Forms.Label ReaderAgeLbl;
        private System.Windows.Forms.Label ReaderNameLbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox EnterCodeTxtBx;
        private System.Windows.Forms.Label RaffleResultLbl;
        private System.Windows.Forms.Button RaffleBtn;
        private System.Windows.Forms.Label ReaderCountLbl;
        private System.Windows.Forms.Button GetReaderBtn;
        private RoundButton RefreshButton;
        private System.Windows.Forms.GroupBox RegistrationGroupBox;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Label quotationLbl;
    }
}

