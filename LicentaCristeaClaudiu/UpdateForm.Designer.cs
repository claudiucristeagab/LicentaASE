namespace LicentaCristeaClaudiu
{
    partial class UpdateForm
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
            this.comboBoxUpdateTable = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPageWhere = new System.Windows.Forms.TabPage();
            this.buttonOrCondition = new System.Windows.Forms.Button();
            this.buttonAndCondition = new System.Windows.Forms.Button();
            this.listBoxSelect2 = new System.Windows.Forms.ListBox();
            this.listBoxComparator = new System.Windows.Forms.ListBox();
            this.labelWhereInput = new System.Windows.Forms.Label();
            this.textBoxWhereInput = new System.Windows.Forms.TextBox();
            this.labelSelectItems2 = new System.Windows.Forms.Label();
            this.buttonAddCondition = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPageWhere.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxUpdateTable
            // 
            this.comboBoxUpdateTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUpdateTable.FormattingEnabled = true;
            this.comboBoxUpdateTable.Location = new System.Drawing.Point(6, 6);
            this.comboBoxUpdateTable.Name = "comboBoxUpdateTable";
            this.comboBoxUpdateTable.Size = new System.Drawing.Size(257, 24);
            this.comboBoxUpdateTable.TabIndex = 2;
            this.comboBoxUpdateTable.SelectionChangeCommitted += new System.EventHandler(this.comboBoxUpdateTable_SelectionChangeCommitted);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPageWhere);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(622, 441);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.comboBoxUpdateTable);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(614, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1. New data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPageWhere
            // 
            this.tabPageWhere.AutoScroll = true;
            this.tabPageWhere.Controls.Add(this.buttonUpdate);
            this.tabPageWhere.Controls.Add(this.buttonOrCondition);
            this.tabPageWhere.Controls.Add(this.buttonAndCondition);
            this.tabPageWhere.Controls.Add(this.listBoxSelect2);
            this.tabPageWhere.Controls.Add(this.listBoxComparator);
            this.tabPageWhere.Controls.Add(this.labelWhereInput);
            this.tabPageWhere.Controls.Add(this.textBoxWhereInput);
            this.tabPageWhere.Controls.Add(this.labelSelectItems2);
            this.tabPageWhere.Controls.Add(this.buttonAddCondition);
            this.tabPageWhere.Location = new System.Drawing.Point(4, 25);
            this.tabPageWhere.Name = "tabPageWhere";
            this.tabPageWhere.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWhere.Size = new System.Drawing.Size(614, 412);
            this.tabPageWhere.TabIndex = 2;
            this.tabPageWhere.Text = "2. Conditions";
            this.tabPageWhere.UseVisualStyleBackColor = true;
            // 
            // buttonOrCondition
            // 
            this.buttonOrCondition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOrCondition.Location = new System.Drawing.Point(87, 360);
            this.buttonOrCondition.Name = "buttonOrCondition";
            this.buttonOrCondition.Size = new System.Drawing.Size(75, 46);
            this.buttonOrCondition.TabIndex = 26;
            this.buttonOrCondition.Text = "Or";
            this.buttonOrCondition.UseVisualStyleBackColor = true;
            // 
            // buttonAndCondition
            // 
            this.buttonAndCondition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAndCondition.Location = new System.Drawing.Point(168, 360);
            this.buttonAndCondition.Name = "buttonAndCondition";
            this.buttonAndCondition.Size = new System.Drawing.Size(75, 46);
            this.buttonAndCondition.TabIndex = 25;
            this.buttonAndCondition.Text = "And";
            this.buttonAndCondition.UseVisualStyleBackColor = true;
            this.buttonAndCondition.Click += new System.EventHandler(this.buttonAndCondition_Click);
            // 
            // listBoxSelect2
            // 
            this.listBoxSelect2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxSelect2.FormattingEnabled = true;
            this.listBoxSelect2.ItemHeight = 16;
            this.listBoxSelect2.Location = new System.Drawing.Point(9, 23);
            this.listBoxSelect2.Name = "listBoxSelect2";
            this.listBoxSelect2.Size = new System.Drawing.Size(599, 100);
            this.listBoxSelect2.TabIndex = 23;
            // 
            // listBoxComparator
            // 
            this.listBoxComparator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxComparator.FormattingEnabled = true;
            this.listBoxComparator.ItemHeight = 16;
            this.listBoxComparator.Location = new System.Drawing.Point(9, 129);
            this.listBoxComparator.Name = "listBoxComparator";
            this.listBoxComparator.Size = new System.Drawing.Size(599, 68);
            this.listBoxComparator.TabIndex = 18;
            // 
            // labelWhereInput
            // 
            this.labelWhereInput.AutoSize = true;
            this.labelWhereInput.Location = new System.Drawing.Point(6, 330);
            this.labelWhereInput.Name = "labelWhereInput";
            this.labelWhereInput.Size = new System.Drawing.Size(51, 17);
            this.labelWhereInput.TabIndex = 17;
            this.labelWhereInput.Text = "Input =";
            // 
            // textBoxWhereInput
            // 
            this.textBoxWhereInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWhereInput.Location = new System.Drawing.Point(63, 327);
            this.textBoxWhereInput.Name = "textBoxWhereInput";
            this.textBoxWhereInput.Size = new System.Drawing.Size(545, 22);
            this.textBoxWhereInput.TabIndex = 16;
            // 
            // labelSelectItems2
            // 
            this.labelSelectItems2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSelectItems2.AutoSize = true;
            this.labelSelectItems2.Location = new System.Drawing.Point(8, 3);
            this.labelSelectItems2.Name = "labelSelectItems2";
            this.labelSelectItems2.Size = new System.Drawing.Size(98, 17);
            this.labelSelectItems2.TabIndex = 12;
            this.labelSelectItems2.Text = "Select Column";
            // 
            // buttonAddCondition
            // 
            this.buttonAddCondition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddCondition.Location = new System.Drawing.Point(533, 360);
            this.buttonAddCondition.Name = "buttonAddCondition";
            this.buttonAddCondition.Size = new System.Drawing.Size(75, 46);
            this.buttonAddCondition.TabIndex = 11;
            this.buttonAddCondition.Text = "Add";
            this.buttonAddCondition.UseVisualStyleBackColor = true;
            this.buttonAddCondition.Click += new System.EventHandler(this.buttonAddCondition_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(533, 277);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(73, 44);
            this.buttonUpdate.TabIndex = 27;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 441);
            this.Controls.Add(this.tabControl1);
            this.Name = "UpdateForm";
            this.Text = "Update Form";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPageWhere.ResumeLayout(false);
            this.tabPageWhere.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxUpdateTable;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPageWhere;
        private System.Windows.Forms.Button buttonOrCondition;
        private System.Windows.Forms.Button buttonAndCondition;
        private System.Windows.Forms.ListBox listBoxSelect2;
        private System.Windows.Forms.ListBox listBoxComparator;
        private System.Windows.Forms.Label labelWhereInput;
        private System.Windows.Forms.TextBox textBoxWhereInput;
        private System.Windows.Forms.Label labelSelectItems2;
        private System.Windows.Forms.Button buttonAddCondition;
        private System.Windows.Forms.Button buttonUpdate;
    }
}