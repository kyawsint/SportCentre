namespace Group8b
{
    partial class EditFacility
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
            this.cbCourtCode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDES = new System.Windows.Forms.TextBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.Description = new System.Windows.Forms.Label();
            this.lblcourtcode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbCourtCode
            // 
            this.cbCourtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCourtCode.FormattingEnabled = true;
            this.cbCourtCode.Location = new System.Drawing.Point(227, 121);
            this.cbCourtCode.Margin = new System.Windows.Forms.Padding(4);
            this.cbCourtCode.Name = "cbCourtCode";
            this.cbCourtCode.Size = new System.Drawing.Size(160, 24);
            this.cbCourtCode.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(141, 250);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 33;
            // 
            // tbCN
            // 
            this.tbCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCN.Location = new System.Drawing.Point(227, 182);
            this.tbCN.Margin = new System.Windows.Forms.Padding(4);
            this.tbCN.Name = "tbCN";
            this.tbCN.Size = new System.Drawing.Size(132, 22);
            this.tbCN.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "CourtName";
            // 
            // tbSID
            // 
            this.tbSID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSID.Location = new System.Drawing.Point(227, 54);
            this.tbSID.Margin = new System.Windows.Forms.Padding(4);
            this.tbSID.Name = "tbSID";
            this.tbSID.Size = new System.Drawing.Size(57, 22);
            this.tbSID.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "SportID";
            // 
            // tbDES
            // 
            this.tbDES.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDES.Location = new System.Drawing.Point(227, 239);
            this.tbDES.Margin = new System.Windows.Forms.Padding(4);
            this.tbDES.Multiline = true;
            this.tbDES.Name = "tbDES";
            this.tbDES.Size = new System.Drawing.Size(300, 107);
            this.tbDES.TabIndex = 28;
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(332, 394);
            this.btncancel.Margin = new System.Windows.Forms.Padding(4);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(86, 35);
            this.btncancel.TabIndex = 26;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(171, 394);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 35);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(141, 239);
            this.Description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(76, 16);
            this.Description.TabIndex = 24;
            this.Description.Text = "Description";
            // 
            // lblcourtcode
            // 
            this.lblcourtcode.AutoSize = true;
            this.lblcourtcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcourtcode.Location = new System.Drawing.Point(141, 121);
            this.lblcourtcode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcourtcode.Name = "lblcourtcode";
            this.lblcourtcode.Size = new System.Drawing.Size(72, 16);
            this.lblcourtcode.TabIndex = 23;
            this.lblcourtcode.Text = "CourtCode";
            // 
            // EditFacility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 521);
            this.Controls.Add(this.cbCourtCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDES);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.lblcourtcode);
            this.Name = "EditFacility";
            this.Text = "Edit Facility";
            this.Load += new System.EventHandler(this.EditFacility_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCourtCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDES;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label lblcourtcode;

    }
}