namespace Group8b
{
    partial class ViewSlot
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
            this.txtCourtname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchSlot = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDeleteSlot = new System.Windows.Forms.Button();
            this.btnAddNewSlot = new System.Windows.Forms.Button();
            this.btnEditSlot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCourtname
            // 
            this.txtCourtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourtname.Location = new System.Drawing.Point(156, 49);
            this.txtCourtname.Name = "txtCourtname";
            this.txtCourtname.Size = new System.Drawing.Size(175, 22);
            this.txtCourtname.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Court Name : ";
            // 
            // btnSearchSlot
            // 
            this.btnSearchSlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchSlot.Location = new System.Drawing.Point(337, 49);
            this.btnSearchSlot.Name = "btnSearchSlot";
            this.btnSearchSlot.Size = new System.Drawing.Size(80, 23);
            this.btnSearchSlot.TabIndex = 15;
            this.btnSearchSlot.Text = "Search";
            this.btnSearchSlot.UseVisualStyleBackColor = true;
            this.btnSearchSlot.Click += new System.EventHandler(this.btnSearchSlot_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(75, 107);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(343, 266);
            this.dataGridView1.TabIndex = 14;
            // 
            // btnDeleteSlot
            // 
            this.btnDeleteSlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSlot.Location = new System.Drawing.Point(331, 402);
            this.btnDeleteSlot.Name = "btnDeleteSlot";
            this.btnDeleteSlot.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSlot.TabIndex = 13;
            this.btnDeleteSlot.Text = "Delete";
            this.btnDeleteSlot.UseVisualStyleBackColor = true;
            this.btnDeleteSlot.Click += new System.EventHandler(this.btnDeleteSlot_Click);
            // 
            // btnAddNewSlot
            // 
            this.btnAddNewSlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewSlot.Location = new System.Drawing.Point(80, 402);
            this.btnAddNewSlot.Name = "btnAddNewSlot";
            this.btnAddNewSlot.Size = new System.Drawing.Size(92, 23);
            this.btnAddNewSlot.TabIndex = 12;
            this.btnAddNewSlot.Text = "New Slot";
            this.btnAddNewSlot.UseVisualStyleBackColor = true;
            this.btnAddNewSlot.Click += new System.EventHandler(this.btnAddNewSlot_Click);
            // 
            // btnEditSlot
            // 
            this.btnEditSlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSlot.Location = new System.Drawing.Point(211, 402);
            this.btnEditSlot.Name = "btnEditSlot";
            this.btnEditSlot.Size = new System.Drawing.Size(75, 23);
            this.btnEditSlot.TabIndex = 11;
            this.btnEditSlot.Text = "Edit";
            this.btnEditSlot.UseVisualStyleBackColor = true;
            this.btnEditSlot.Click += new System.EventHandler(this.btnEditSlot_Click);
            // 
            // ViewSlot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 463);
            this.Controls.Add(this.txtCourtname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchSlot);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDeleteSlot);
            this.Controls.Add(this.btnAddNewSlot);
            this.Controls.Add(this.btnEditSlot);
            this.Name = "ViewSlot";
            this.Text = "Slot";
            this.Load += new System.EventHandler(this.Slot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCourtname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchSlot;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDeleteSlot;
        private System.Windows.Forms.Button btnAddNewSlot;
        private System.Windows.Forms.Button btnEditSlot;
    }
}