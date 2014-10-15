namespace Group8b
{
    partial class FacilityLookUp
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
            this.btCancle = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.dgvfacility = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfacility)).BeginInit();
            this.SuspendLayout();
            // 
            // btCancle
            // 
            this.btCancle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btCancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancle.Location = new System.Drawing.Point(322, 346);
            this.btCancle.Name = "btCancle";
            this.btCancle.Size = new System.Drawing.Size(75, 23);
            this.btCancle.TabIndex = 5;
            this.btCancle.Text = "Cancel";
            this.btCancle.UseVisualStyleBackColor = true;
            // 
            // btOK
            // 
            this.btOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOK.Location = new System.Drawing.Point(130, 347);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 4;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // dgvfacility
            // 
            this.dgvfacility.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvfacility.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfacility.Location = new System.Drawing.Point(23, 37);
            this.dgvfacility.MultiSelect = false;
            this.dgvfacility.Name = "dgvfacility";
            this.dgvfacility.ReadOnly = true;
            this.dgvfacility.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvfacility.Size = new System.Drawing.Size(545, 276);
            this.dgvfacility.TabIndex = 3;
            // 
            // FacilityLookUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 414);
            this.Controls.Add(this.btCancle);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.dgvfacility);
            this.Name = "FacilityLookUp";
            this.Text = "FacilityLookUp";
            this.Load += new System.EventHandler(this.FacilityLookUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfacility)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCancle;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.DataGridView dgvfacility;
    }
}