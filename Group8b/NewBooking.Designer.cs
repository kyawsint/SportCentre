namespace Group8b
{
    partial class NewBooking
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
            this.lblSportName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ddlSportName = new System.Windows.Forms.ComboBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblnopeople = new System.Windows.Forms.Label();
            this.lblmemname = new System.Windows.Forms.Label();
            this.txtmemname = new System.Windows.Forms.TextBox();
            this.btnmemname = new System.Windows.Forms.Button();
            this.gb1.SuspendLayout();
            this.gb2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSportName
            // 
            this.lblSportName.AutoSize = true;
            this.lblSportName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSportName.Location = new System.Drawing.Point(61, 95);
            this.lblSportName.Name = "lblSportName";
            this.lblSportName.Size = new System.Drawing.Size(86, 16);
            this.lblSportName.TabIndex = 0;
            this.lblSportName.Text = "Sport Name :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(61, 144);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(46, 16);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date : ";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(61, 194);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(155, 16);
            this.lblSize.TabIndex = 3;
            this.lblSize.Text = "Maximum no. of people : ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(310, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(102, 20);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "New Booking";
            // 
            // ddlSportName
            // 
            this.ddlSportName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSportName.FormattingEnabled = true;
            this.ddlSportName.Location = new System.Drawing.Point(233, 95);
            this.ddlSportName.Name = "ddlSportName";
            this.ddlSportName.Size = new System.Drawing.Size(209, 21);
            this.ddlSportName.TabIndex = 4;
            this.ddlSportName.SelectedIndexChanged += new System.EventHandler(this.ddlSportName_SelectedIndexChanged);
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(233, 190);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(100, 20);
            this.txtSize.TabIndex = 6;
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(45, 28);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(75, 23);
            this.btnContinue.TabIndex = 7;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(188, 28);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.btnmemname);
            this.gb1.Controls.Add(this.txtmemname);
            this.gb1.Controls.Add(this.lblmemname);
            this.gb1.Controls.Add(this.lblnopeople);
            this.gb1.Controls.Add(this.lblSportName);
            this.gb1.Controls.Add(this.lblDate);
            this.gb1.Controls.Add(this.lblSize);
            this.gb1.Controls.Add(this.txtSize);
            this.gb1.Controls.Add(this.ddlSportName);
            this.gb1.Controls.Add(this.dtpDate);
            this.gb1.Location = new System.Drawing.Point(93, 77);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(516, 263);
            this.gb1.TabIndex = 9;
            this.gb1.TabStop = false;
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.btnContinue);
            this.gb2.Controls.Add(this.btnReset);
            this.gb2.Location = new System.Drawing.Point(184, 346);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(302, 69);
            this.gb2.TabIndex = 10;
            this.gb2.TabStop = false;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(233, 144);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(130, 20);
            this.dtpDate.TabIndex = 5;
            // 
            // lblnopeople
            // 
            this.lblnopeople.AutoSize = true;
            this.lblnopeople.Location = new System.Drawing.Point(340, 194);
            this.lblnopeople.Name = "lblnopeople";
            this.lblnopeople.Size = new System.Drawing.Size(35, 13);
            this.lblnopeople.TabIndex = 7;
            this.lblnopeople.Text = "label1";
            this.lblnopeople.Visible = false;
            // 
            // lblmemname
            // 
            this.lblmemname.AutoSize = true;
            this.lblmemname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmemname.Location = new System.Drawing.Point(61, 43);
            this.lblmemname.Name = "lblmemname";
            this.lblmemname.Size = new System.Drawing.Size(107, 16);
            this.lblmemname.TabIndex = 8;
            this.lblmemname.Text = "Member Name : ";
            // 
            // txtmemname
            // 
            this.txtmemname.Location = new System.Drawing.Point(233, 43);
            this.txtmemname.Name = "txtmemname";
            this.txtmemname.Size = new System.Drawing.Size(209, 20);
            this.txtmemname.TabIndex = 9;
            // 
            // btnmemname
            // 
            this.btnmemname.Location = new System.Drawing.Point(448, 41);
            this.btnmemname.Name = "btnmemname";
            this.btnmemname.Size = new System.Drawing.Size(34, 23);
            this.btnmemname.TabIndex = 10;
            this.btnmemname.Text = "...";
            this.btnmemname.UseVisualStyleBackColor = true;
            // 
            // NewBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.lblTitle);
            this.KeyPreview = true;
            this.Name = "NewBooking";
            this.Text = "New Booking";
            this.Load += new System.EventHandler(this.NewBooking_Load);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.gb2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSportName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox ddlSportName;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblnopeople;
        private System.Windows.Forms.Button btnmemname;
        private System.Windows.Forms.TextBox txtmemname;
        private System.Windows.Forms.Label lblmemname;
    }
}