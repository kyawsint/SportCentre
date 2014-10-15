namespace Group8b
{
    partial class EditSport
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
            this.cbType = new System.Windows.Forms.ComboBox();
            this.tbnSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbnDes = new System.Windows.Forms.TextBox();
            this.tbnName = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.tbnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbType
            // 
            this.cbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Indoor",
            "Outdoor"});
            this.cbType.Location = new System.Drawing.Point(243, 117);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 24);
            this.cbType.TabIndex = 32;
            // 
            // tbnSize
            // 
            this.tbnSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnSize.Location = new System.Drawing.Point(243, 178);
            this.tbnSize.Name = "tbnSize";
            this.tbnSize.Size = new System.Drawing.Size(100, 22);
            this.tbnSize.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Type";
            // 
            // tbnDes
            // 
            this.tbnDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnDes.Location = new System.Drawing.Point(243, 251);
            this.tbnDes.Multiline = true;
            this.tbnDes.Name = "tbnDes";
            this.tbnDes.Size = new System.Drawing.Size(226, 88);
            this.tbnDes.TabIndex = 28;
            // 
            // tbnName
            // 
            this.tbnName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnName.Location = new System.Drawing.Point(243, 54);
            this.tbnName.Name = "tbnName";
            this.tbnName.Size = new System.Drawing.Size(100, 22);
            this.tbnName.TabIndex = 27;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(153, 240);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(76, 16);
            this.Description.TabIndex = 25;
            this.Description.Text = "Description";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(153, 54);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(45, 16);
            this.lblname.TabIndex = 24;
            this.lblname.Text = "Name";
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(350, 399);
            this.btncancel.Margin = new System.Windows.Forms.Padding(4);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(91, 36);
            this.btncancel.TabIndex = 41;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // tbnSave
            // 
            this.tbnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnSave.Location = new System.Drawing.Point(174, 399);
            this.tbnSave.Margin = new System.Windows.Forms.Padding(4);
            this.tbnSave.Name = "tbnSave";
            this.tbnSave.Size = new System.Drawing.Size(87, 36);
            this.tbnSave.TabIndex = 40;
            this.tbnSave.Text = "Save";
            this.tbnSave.UseVisualStyleBackColor = true;
            this.tbnSave.Click += new System.EventHandler(this.tbnSave_Click);
            // 
            // EditSport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 521);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.tbnSave);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.tbnSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbnDes);
            this.Controls.Add(this.tbnName);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.lblname);
            this.Name = "EditSport";
            this.Text = "Edit Sport";
            this.Load += new System.EventHandler(this.EditSport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.TextBox tbnSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbnDes;
        private System.Windows.Forms.TextBox tbnName;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button tbnSave;
    }
}