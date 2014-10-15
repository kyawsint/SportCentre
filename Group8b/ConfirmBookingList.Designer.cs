namespace Group8b
{
    partial class ConfirmBookingList
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
            this.lblmemname = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtmemname = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dgvCBooking = new System.Windows.Forms.DataGridView();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblnorecord = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCBooking)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblmemname
            // 
            this.lblmemname.AutoSize = true;
            this.lblmemname.Location = new System.Drawing.Point(74, 32);
            this.lblmemname.Name = "lblmemname";
            this.lblmemname.Size = new System.Drawing.Size(85, 13);
            this.lblmemname.TabIndex = 0;
            this.lblmemname.Text = "Member Name : ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(372, 35);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(39, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date : ";
            // 
            // txtmemname
            // 
            this.txtmemname.Location = new System.Drawing.Point(175, 32);
            this.txtmemname.Name = "txtmemname";
            this.txtmemname.Size = new System.Drawing.Size(177, 20);
            this.txtmemname.TabIndex = 4;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(429, 32);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(124, 20);
            this.dtpDate.TabIndex = 5;
            // 
            // dgvCBooking
            // 
            this.dgvCBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCBooking.Location = new System.Drawing.Point(29, 98);
            this.dgvCBooking.MultiSelect = false;
            this.dgvCBooking.Name = "dgvCBooking";
            this.dgvCBooking.ReadOnly = true;
            this.dgvCBooking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCBooking.Size = new System.Drawing.Size(743, 304);
            this.dgvCBooking.TabIndex = 6;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(38, 19);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(175, 19);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConfirm);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Location = new System.Drawing.Point(117, 408);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 57);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // lblnorecord
            // 
            this.lblnorecord.AutoSize = true;
            this.lblnorecord.Location = new System.Drawing.Point(172, 55);
            this.lblnorecord.Name = "lblnorecord";
            this.lblnorecord.Size = new System.Drawing.Size(35, 13);
            this.lblnorecord.TabIndex = 10;
            this.lblnorecord.Text = "label1";
            // 
            // ConfirmBookingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.lblnorecord);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCBooking);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtmemname);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblmemname);
            this.Name = "ConfirmBookingList";
            this.Text = "Confirm Booking";
            this.Load += new System.EventHandler(this.ConfirmBookingList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCBooking)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmemname;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtmemname;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DataGridView dgvCBooking;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblnorecord;
    }
}