namespace LicentaCristeaClaudiu
{
    partial class InsertForm
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
            this.comboBoxInsertTable = new System.Windows.Forms.ComboBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxInsertTable
            // 
            this.comboBoxInsertTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInsertTable.FormattingEnabled = true;
            this.comboBoxInsertTable.Location = new System.Drawing.Point(13, 13);
            this.comboBoxInsertTable.Name = "comboBoxInsertTable";
            this.comboBoxInsertTable.Size = new System.Drawing.Size(257, 24);
            this.comboBoxInsertTable.TabIndex = 0;
            this.comboBoxInsertTable.SelectionChangeCommitted += new System.EventHandler(this.comboBoxInsertTable_SelectionChangeCommitted);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(290, 12);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(83, 25);
            this.buttonInsert.TabIndex = 1;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // InsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(622, 593);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.comboBoxInsertTable);
            this.Name = "InsertForm";
            this.Text = "InsertForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxInsertTable;
        private System.Windows.Forms.Button buttonInsert;
    }
}