namespace Group8b
{
    partial class ConfirmBooking
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
            this.lblsportname = new System.Windows.Forms.Label();
            this.lblfacility = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblnoofpeople = new System.Windows.Forms.Label();
            this.txtmemname = new System.Windows.Forms.TextBox();
            this.txtsportname = new System.Windows.Forms.TextBox();
            this.txtnoofpeople = new System.Windows.Forms.TextBox();
            this.txttime = new System.Windows.Forms.TextBox();
            this.txtcourtname = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblsportname
            // 
            this.lblsportname.AutoSize = true;
            this.lblsportname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsportname.Location = new System.Drawing.Point(40, 66);
            this.lblsportname.Name = "lblsportname";
            this.lblsportname.Size = new System.Drawing.Size(89, 16);
            this.lblsportname.TabIndex = 0;
            this.lblsportname.Text = "Sport Name : ";
            // 
            // lblfacility
            // 
            this.lblfacility.AutoSize = true;
            this.lblfacility.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfacility.Location = new System.Drawing.Point(40, 110);
            this.lblfacility.Name = "lblfacility";
            this.lblfacility.Size = new System.Drawing.Size(88, 16);
            this.lblfacility.TabIndex = 1;
            this.lblfacility.Text = "Court Name : ";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.Location = new System.Drawing.Point(40, 195);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(48, 16);
            this.lbltime.TabIndex = 2;
            this.lbltime.Text = "Time : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Member Name : ";
            // 
            // lblnoofpeople
            // 
            this.lblnoofpeople.AutoSize = true;
            this.lblnoofpeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnoofpeople.Location = new System.Drawing.Point(40, 232);
            this.lblnoofpeople.Name = "lblnoofpeople";
            this.lblnoofpeople.Size = new System.Drawing.Size(89, 16);
            this.lblnoofpeople.TabIndex = 4;
            this.lblnoofpeople.Text = "No. of people";
            // 
            // txtmemname
            // 
            this.txtmemname.Location = new System.Drawing.Point(181, 21);
            this.txtmemname.Name = "txtmemname";
            this.txtmemname.ReadOnly = true;
            this.txtmemname.Size = new System.Drawing.Size(226, 20);
            this.txtmemname.TabIndex = 5;
            // 
            // txtsportname
            // 
            this.txtsportname.Location = new System.Drawing.Point(181, 66);
            this.txtsportname.Name = "txtsportname";
            this.txtsportname.ReadOnly = true;
            this.txtsportname.Size = new System.Drawing.Size(226, 20);
            this.txtsportname.TabIndex = 6;
            // 
            // txtnoofpeople
            // 
            this.txtnoofpeople.Location = new System.Drawing.Point(181, 231);
            this.txtnoofpeople.Name = "txtnoofpeople";
            this.txtnoofpeople.ReadOnly = true;
            this.txtnoofpeople.Size = new System.Drawing.Size(84, 20);
            this.txtnoofpeople.TabIndex = 8;
            // 
            // txttime
            // 
            this.txttime.Location = new System.Drawing.Point(181, 195);
            this.txttime.Name = "txttime";
            this.txttime.ReadOnly = true;
            this.txttime.Size = new System.Drawing.Size(123, 20);
            this.txttime.TabIndex = 9;
            // 
            // txtcourtname
            // 
            this.txtcourtname.Location = new System.Drawing.Point(181, 110);
            this.txtcourtname.Name = "txtcourtname";
            this.txtcourtname.ReadOnly = true;
            this.txtcourtname.Size = new System.Drawing.Size(158, 20);
            this.txtcourtname.TabIndex = 10;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(248, 19);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 11;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(76, 19);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblsportname);
            this.groupBox1.Controls.Add(this.lblfacility);
            this.groupBox1.Controls.Add(this.lbltime);
            this.groupBox1.Controls.Add(this.txtcourtname);
            this.groupBox1.Controls.Add(this.lblnoofpeople);
            this.groupBox1.Controls.Add(this.txttime);
            this.groupBox1.Controls.Add(this.txtmemname);
            this.groupBox1.Controls.Add(this.txtnoofpeople);
            this.groupBox1.Controls.Add(this.txtsportname);
            this.groupBox1.Location = new System.Drawing.Point(61, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 268);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(40, 151);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(46, 16);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "Date : ";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(181, 151);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(123, 20);
            this.txtDate.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBack);
            this.groupBox2.Controls.Add(this.btnConfirm);
            this.groupBox2.Location = new System.Drawing.Point(104, 306);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 63);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // ConfirmBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 404);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConfirmBooking";
            this.Text = "Confirm Booking";
            this.Load += new System.EventHandler(this.ConfirmBooking_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblsportname;
        private System.Windows.Forms.Label lblfacility;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblnoofpeople;
        private System.Windows.Forms.TextBox txtmemname;
        private System.Windows.Forms.TextBox txtsportname;
        private System.Windows.Forms.TextBox txtnoofpeople;
        private System.Windows.Forms.TextBox txttime;
        private System.Windows.Forms.TextBox txtcourtname;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtDate;
    }
}