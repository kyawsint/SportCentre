namespace Group8b
{
    partial class BookingForm
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
            this.btnBack = new System.Windows.Forms.Button();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.lblSportName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.ddlCCourt = new System.Windows.Forms.ComboBox();
            this.lblCCourt = new System.Windows.Forms.Label();
            this.dgvslot = new System.Windows.Forms.DataGridView();
            this.dgvavailable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblmemname = new System.Windows.Forms.Label();
            this.txtmemname = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.txtnoofpeople = new System.Windows.Forms.TextBox();
            this.txtsportname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gb2.SuspendLayout();
            this.gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvslot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvavailable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(54, 30);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.btnContinue);
            this.gb2.Controls.Add(this.btnBack);
            this.gb2.Location = new System.Drawing.Point(230, 450);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(303, 69);
            this.gb2.TabIndex = 12;
            this.gb2.TabStop = false;
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(176, 30);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(75, 23);
            this.btnContinue.TabIndex = 7;
            this.btnContinue.Text = "Booking";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.txtsportname);
            this.gb1.Controls.Add(this.txtnoofpeople);
            this.gb1.Controls.Add(this.txtdate);
            this.gb1.Controls.Add(this.txtmemname);
            this.gb1.Controls.Add(this.lblmemname);
            this.gb1.Controls.Add(this.lblSportName);
            this.gb1.Controls.Add(this.lblDate);
            this.gb1.Controls.Add(this.lblSize);
            this.gb1.Location = new System.Drawing.Point(124, 2);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(477, 134);
            this.gb1.TabIndex = 11;
            this.gb1.TabStop = false;
            // 
            // lblSportName
            // 
            this.lblSportName.AutoSize = true;
            this.lblSportName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSportName.Location = new System.Drawing.Point(20, 47);
            this.lblSportName.Name = "lblSportName";
            this.lblSportName.Size = new System.Drawing.Size(86, 16);
            this.lblSportName.TabIndex = 0;
            this.lblSportName.Text = "Sport Name :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(20, 77);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(46, 16);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date : ";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(17, 102);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(98, 16);
            this.lblSize.TabIndex = 3;
            this.lblSize.Text = "No. of people : ";
            // 
            // ddlCCourt
            // 
            this.ddlCCourt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlCCourt.FormattingEnabled = true;
            this.ddlCCourt.Location = new System.Drawing.Point(236, 153);
            this.ddlCCourt.Name = "ddlCCourt";
            this.ddlCCourt.Size = new System.Drawing.Size(196, 21);
            this.ddlCCourt.TabIndex = 13;
            this.ddlCCourt.SelectedIndexChanged += new System.EventHandler(this.ddlCCourt_SelectedIndexChanged);
            // 
            // lblCCourt
            // 
            this.lblCCourt.AutoSize = true;
            this.lblCCourt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCourt.Location = new System.Drawing.Point(132, 154);
            this.lblCCourt.Name = "lblCCourt";
            this.lblCCourt.Size = new System.Drawing.Size(98, 16);
            this.lblCCourt.TabIndex = 14;
            this.lblCCourt.Text = "Choose Court : ";
            // 
            // dgvslot
            // 
            this.dgvslot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvslot.Location = new System.Drawing.Point(475, 206);
            this.dgvslot.Name = "dgvslot";
            this.dgvslot.ReadOnly = true;
            this.dgvslot.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvslot.Size = new System.Drawing.Size(243, 248);
            this.dgvslot.TabIndex = 15;
            // 
            // dgvavailable
            // 
            this.dgvavailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvavailable.Location = new System.Drawing.Point(75, 206);
            this.dgvavailable.Name = "dgvavailable";
            this.dgvavailable.ReadOnly = true;
            this.dgvavailable.Size = new System.Drawing.Size(243, 248);
            this.dgvavailable.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Available Booking";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(513, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 18;
            // 
            // lblmemname
            // 
            this.lblmemname.AutoSize = true;
            this.lblmemname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmemname.Location = new System.Drawing.Point(20, 16);
            this.lblmemname.Name = "lblmemname";
            this.lblmemname.Size = new System.Drawing.Size(107, 16);
            this.lblmemname.TabIndex = 8;
            this.lblmemname.Text = "Member Name : ";
            // 
            // txtmemname
            // 
            this.txtmemname.Location = new System.Drawing.Point(145, 16);
            this.txtmemname.Name = "txtmemname";
            this.txtmemname.ReadOnly = true;
            this.txtmemname.Size = new System.Drawing.Size(220, 20);
            this.txtmemname.TabIndex = 9;
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(145, 73);
            this.txtdate.Name = "txtdate";
            this.txtdate.ReadOnly = true;
            this.txtdate.Size = new System.Drawing.Size(163, 20);
            this.txtdate.TabIndex = 10;
            // 
            // txtnoofpeople
            // 
            this.txtnoofpeople.Location = new System.Drawing.Point(145, 102);
            this.txtnoofpeople.Name = "txtnoofpeople";
            this.txtnoofpeople.ReadOnly = true;
            this.txtnoofpeople.Size = new System.Drawing.Size(72, 20);
            this.txtnoofpeople.TabIndex = 11;
            // 
            // txtsportname
            // 
            this.txtsportname.Location = new System.Drawing.Point(145, 47);
            this.txtsportname.Name = "txtsportname";
            this.txtsportname.ReadOnly = true;
            this.txtsportname.Size = new System.Drawing.Size(220, 20);
            this.txtsportname.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "label3";
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvavailable);
            this.Controls.Add(this.dgvslot);
            this.Controls.Add(this.lblCCourt);
            this.Controls.Add(this.ddlCCourt);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gb1);
            this.Name = "BookingForm";
            this.Text = "Booking Form";
            this.Load += new System.EventHandler(this.BookingForm_Load);
            this.gb2.ResumeLayout(false);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvslot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvavailable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Label lblSportName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.ComboBox ddlCCourt;
        private System.Windows.Forms.Label lblCCourt;
        private System.Windows.Forms.DataGridView dgvslot;
        private System.Windows.Forms.DataGridView dgvavailable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblmemname;
        private System.Windows.Forms.TextBox txtsportname;
        private System.Windows.Forms.TextBox txtnoofpeople;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.TextBox txtmemname;
        private System.Windows.Forms.Label label3;
    }
}