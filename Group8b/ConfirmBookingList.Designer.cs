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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCBooking)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblmemname
            // 
            this.lblmemname.AutoSize = true;
            this.lblmemname.Location = new System.Drawing.Point(31, 30);
            this.lblmemname.Name = "lblmemname";
            this.lblmemname.Size = new System.Drawing.Size(107, 16);
            this.lblmemname.TabIndex = 0;
            this.lblmemname.Text = "Member Name : ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(341, 33);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(46, 16);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date : ";
            // 
            // txtmemname
            // 
            this.txtmemname.Location = new System.Drawing.Point(144, 30);
            this.txtmemname.Name = "txtmemname";
            this.txtmemname.Size = new System.Drawing.Size(191, 22);
            this.txtmemname.TabIndex = 4;
            this.txtmemname.Leave += new System.EventHandler(this.txtmemname_Leave);
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(398, 30);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(124, 22);
            this.dtpDate.TabIndex = 5;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // dgvCBooking
            // 
            this.dgvCBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCBooking.Location = new System.Drawing.Point(29, 119);
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
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConfirm);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Location = new System.Drawing.Point(117, 429);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 57);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // lblnorecord
            // 
            this.lblnorecord.AutoSize = true;
            this.lblnorecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnorecord.Location = new System.Drawing.Point(171, 91);
            this.lblnorecord.Name = "lblnorecord";
            this.lblnorecord.Size = new System.Drawing.Size(45, 16);
            this.lblnorecord.TabIndex = 10;
            this.lblnorecord.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblmemname);
            this.groupBox2.Controls.Add(this.lblDate);
            this.groupBox2.Controls.Add(this.txtmemname);
            this.groupBox2.Controls.Add(this.dtpDate);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(99, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(567, 66);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search by : ";
            // 
            // ConfirmBookingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblnorecord);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCBooking);
            this.Name = "ConfirmBookingList";
            this.Text = "Confirm Booking";
            this.Load += new System.EventHandler(this.ConfirmBookingList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCBooking)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox2;
    }
}