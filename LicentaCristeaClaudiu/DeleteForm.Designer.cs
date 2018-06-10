namespace LicentaCristeaClaudiu
{
    partial class DeleteForm
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
            this.sqlDeleteFormOK = new System.Windows.Forms.Button();
            this.sqlDeleteFormCancel = new System.Windows.Forms.Button();
            this.buttonDisplayDeleteCommand = new System.Windows.Forms.Button();
            this.buttonNewDeleteCommand = new System.Windows.Forms.Button();
            this.labelDeleteTable = new System.Windows.Forms.Label();
            this.listBoxDeleteTabela = new System.Windows.Forms.ListBox();
            this.listBoxDelete = new System.Windows.Forms.ListBox();
            this.labelSelectItems = new System.Windows.Forms.Label();
            this.listBoxDeleteComparator = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonColumnInput = new System.Windows.Forms.RadioButton();
            this.labelWhereDeleteInput = new System.Windows.Forms.Label();
            this.textBoxWhereDeleteInput = new System.Windows.Forms.TextBox();
            this.buttonOrDeleteCondition = new System.Windows.Forms.Button();
            this.buttonAndDeleteCondition = new System.Windows.Forms.Button();
            this.buttonAddDeleteCondition = new System.Windows.Forms.Button();
            this.textBoxDeleteSQL = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sqlDeleteFormOK
            // 
            this.sqlDeleteFormOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sqlDeleteFormOK.Location = new System.Drawing.Point(535, 535);
            this.sqlDeleteFormOK.Name = "sqlDeleteFormOK";
            this.sqlDeleteFormOK.Size = new System.Drawing.Size(75, 46);
            this.sqlDeleteFormOK.TabIndex = 14;
            this.sqlDeleteFormOK.Text = "OK";
            this.sqlDeleteFormOK.UseVisualStyleBackColor = true;
            this.sqlDeleteFormOK.Click += new System.EventHandler(this.sqlDeleteFormOK_Click);
            // 
            // sqlDeleteFormCancel
            // 
            this.sqlDeleteFormCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sqlDeleteFormCancel.Location = new System.Drawing.Point(12, 535);
            this.sqlDeleteFormCancel.Name = "sqlDeleteFormCancel";
            this.sqlDeleteFormCancel.Size = new System.Drawing.Size(75, 46);
            this.sqlDeleteFormCancel.TabIndex = 15;
            this.sqlDeleteFormCancel.Text = "Cancel";
            this.sqlDeleteFormCancel.UseVisualStyleBackColor = true;
            this.sqlDeleteFormCancel.Click += new System.EventHandler(this.sqlDeleteFormCancel_Click);
            // 
            // buttonDisplayDeleteCommand
            // 
            this.buttonDisplayDeleteCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDisplayDeleteCommand.Location = new System.Drawing.Point(379, 535);
            this.buttonDisplayDeleteCommand.Name = "buttonDisplayDeleteCommand";
            this.buttonDisplayDeleteCommand.Size = new System.Drawing.Size(150, 46);
            this.buttonDisplayDeleteCommand.TabIndex = 16;
            this.buttonDisplayDeleteCommand.Text = "Refresh";
            this.buttonDisplayDeleteCommand.UseVisualStyleBackColor = true;
            this.buttonDisplayDeleteCommand.Click += new System.EventHandler(this.buttonDisplayDeleteCommand_Click);
            // 
            // buttonNewDeleteCommand
            // 
            this.buttonNewDeleteCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonNewDeleteCommand.Location = new System.Drawing.Point(93, 535);
            this.buttonNewDeleteCommand.Name = "buttonNewDeleteCommand";
            this.buttonNewDeleteCommand.Size = new System.Drawing.Size(150, 46);
            this.buttonNewDeleteCommand.TabIndex = 17;
            this.buttonNewDeleteCommand.Text = "Reset";
            this.buttonNewDeleteCommand.UseVisualStyleBackColor = true;
            this.buttonNewDeleteCommand.Click += new System.EventHandler(this.buttonNewDeleteCommand_Click);
            // 
            // labelDeleteTable
            // 
            this.labelDeleteTable.AutoSize = true;
            this.labelDeleteTable.Location = new System.Drawing.Point(12, 9);
            this.labelDeleteTable.Name = "labelDeleteTable";
            this.labelDeleteTable.Size = new System.Drawing.Size(44, 17);
            this.labelDeleteTable.TabIndex = 18;
            this.labelDeleteTable.Text = "Table";
            // 
            // listBoxDeleteTabela
            // 
            this.listBoxDeleteTabela.FormattingEnabled = true;
            this.listBoxDeleteTabela.ItemHeight = 16;
            this.listBoxDeleteTabela.Location = new System.Drawing.Point(15, 29);
            this.listBoxDeleteTabela.Name = "listBoxDeleteTabela";
            this.listBoxDeleteTabela.Size = new System.Drawing.Size(243, 100);
            this.listBoxDeleteTabela.TabIndex = 19;
            this.listBoxDeleteTabela.SelectedValueChanged += new System.EventHandler(this.listBoxDeleteTabela_SelectedValueChanged);
            // 
            // listBoxDelete
            // 
            this.listBoxDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxDelete.FormattingEnabled = true;
            this.listBoxDelete.ItemHeight = 16;
            this.listBoxDelete.Location = new System.Drawing.Point(264, 29);
            this.listBoxDelete.Name = "listBoxDelete";
            this.listBoxDelete.Size = new System.Drawing.Size(346, 100);
            this.listBoxDelete.TabIndex = 21;
            // 
            // labelSelectItems
            // 
            this.labelSelectItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSelectItems.AutoSize = true;
            this.labelSelectItems.Location = new System.Drawing.Point(261, 9);
            this.labelSelectItems.Name = "labelSelectItems";
            this.labelSelectItems.Size = new System.Drawing.Size(98, 17);
            this.labelSelectItems.TabIndex = 20;
            this.labelSelectItems.Text = "Select Column";
            // 
            // listBoxDeleteComparator
            // 
            this.listBoxDeleteComparator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxDeleteComparator.FormattingEnabled = true;
            this.listBoxDeleteComparator.ItemHeight = 16;
            this.listBoxDeleteComparator.Location = new System.Drawing.Point(264, 135);
            this.listBoxDeleteComparator.Name = "listBoxDeleteComparator";
            this.listBoxDeleteComparator.Size = new System.Drawing.Size(346, 68);
            this.listBoxDeleteComparator.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonColumnInput);
            this.panel1.Location = new System.Drawing.Point(15, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 68);
            this.panel1.TabIndex = 22;
            // 
            // radioButtonColumnInput
            // 
            this.radioButtonColumnInput.AutoSize = true;
            this.radioButtonColumnInput.Checked = true;
            this.radioButtonColumnInput.Location = new System.Drawing.Point(4, 4);
            this.radioButtonColumnInput.Name = "radioButtonColumnInput";
            this.radioButtonColumnInput.Size = new System.Drawing.Size(135, 21);
            this.radioButtonColumnInput.TabIndex = 0;
            this.radioButtonColumnInput.TabStop = true;
            this.radioButtonColumnInput.Text = "Column 1 = Input";
            this.radioButtonColumnInput.UseVisualStyleBackColor = true;
            // 
            // labelWhereDeleteInput
            // 
            this.labelWhereDeleteInput.AutoSize = true;
            this.labelWhereDeleteInput.Location = new System.Drawing.Point(16, 212);
            this.labelWhereDeleteInput.Name = "labelWhereDeleteInput";
            this.labelWhereDeleteInput.Size = new System.Drawing.Size(51, 17);
            this.labelWhereDeleteInput.TabIndex = 25;
            this.labelWhereDeleteInput.Text = "Input =";
            // 
            // textBoxWhereDeleteInput
            // 
            this.textBoxWhereDeleteInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWhereDeleteInput.Location = new System.Drawing.Point(73, 209);
            this.textBoxWhereDeleteInput.Name = "textBoxWhereDeleteInput";
            this.textBoxWhereDeleteInput.Size = new System.Drawing.Size(537, 22);
            this.textBoxWhereDeleteInput.TabIndex = 24;
            // 
            // buttonOrDeleteCondition
            // 
            this.buttonOrDeleteCondition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOrDeleteCondition.Location = new System.Drawing.Point(373, 411);
            this.buttonOrDeleteCondition.Name = "buttonOrDeleteCondition";
            this.buttonOrDeleteCondition.Size = new System.Drawing.Size(75, 46);
            this.buttonOrDeleteCondition.TabIndex = 29;
            this.buttonOrDeleteCondition.Text = "Or";
            this.buttonOrDeleteCondition.UseVisualStyleBackColor = true;
            this.buttonOrDeleteCondition.Click += new System.EventHandler(this.buttonOrDeleteCondition_Click);
            // 
            // buttonAndDeleteCondition
            // 
            this.buttonAndDeleteCondition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAndDeleteCondition.Location = new System.Drawing.Point(454, 411);
            this.buttonAndDeleteCondition.Name = "buttonAndDeleteCondition";
            this.buttonAndDeleteCondition.Size = new System.Drawing.Size(75, 46);
            this.buttonAndDeleteCondition.TabIndex = 28;
            this.buttonAndDeleteCondition.Text = "And";
            this.buttonAndDeleteCondition.UseVisualStyleBackColor = true;
            this.buttonAndDeleteCondition.Click += new System.EventHandler(this.buttonAndDeleteCondition_Click);
            // 
            // buttonAddDeleteCondition
            // 
            this.buttonAddDeleteCondition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddDeleteCondition.Location = new System.Drawing.Point(535, 411);
            this.buttonAddDeleteCondition.Name = "buttonAddDeleteCondition";
            this.buttonAddDeleteCondition.Size = new System.Drawing.Size(75, 46);
            this.buttonAddDeleteCondition.TabIndex = 27;
            this.buttonAddDeleteCondition.Text = "Add";
            this.buttonAddDeleteCondition.UseVisualStyleBackColor = true;
            this.buttonAddDeleteCondition.Click += new System.EventHandler(this.buttonAddDeleteCondition_Click);
            // 
            // textBoxDeleteSQL
            // 
            this.textBoxDeleteSQL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDeleteSQL.Location = new System.Drawing.Point(12, 463);
            this.textBoxDeleteSQL.Multiline = true;
            this.textBoxDeleteSQL.Name = "textBoxDeleteSQL";
            this.textBoxDeleteSQL.ReadOnly = true;
            this.textBoxDeleteSQL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDeleteSQL.Size = new System.Drawing.Size(598, 66);
            this.textBoxDeleteSQL.TabIndex = 30;
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 593);
            this.Controls.Add(this.textBoxDeleteSQL);
            this.Controls.Add(this.buttonOrDeleteCondition);
            this.Controls.Add(this.buttonAndDeleteCondition);
            this.Controls.Add(this.buttonAddDeleteCondition);
            this.Controls.Add(this.labelWhereDeleteInput);
            this.Controls.Add(this.textBoxWhereDeleteInput);
            this.Controls.Add(this.listBoxDeleteComparator);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBoxDelete);
            this.Controls.Add(this.labelSelectItems);
            this.Controls.Add(this.labelDeleteTable);
            this.Controls.Add(this.listBoxDeleteTabela);
            this.Controls.Add(this.buttonNewDeleteCommand);
            this.Controls.Add(this.buttonDisplayDeleteCommand);
            this.Controls.Add(this.sqlDeleteFormCancel);
            this.Controls.Add(this.sqlDeleteFormOK);
            this.Name = "DeleteForm";
            this.Text = "DeleteForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button sqlDeleteFormOK;
        private System.Windows.Forms.Button sqlDeleteFormCancel;
        private System.Windows.Forms.Button buttonDisplayDeleteCommand;
        private System.Windows.Forms.Button buttonNewDeleteCommand;
        private System.Windows.Forms.Label labelDeleteTable;
        private System.Windows.Forms.ListBox listBoxDeleteTabela;
        private System.Windows.Forms.ListBox listBoxDelete;
        private System.Windows.Forms.Label labelSelectItems;
        private System.Windows.Forms.ListBox listBoxDeleteComparator;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonColumnInput;
        private System.Windows.Forms.Label labelWhereDeleteInput;
        private System.Windows.Forms.TextBox textBoxWhereDeleteInput;
        private System.Windows.Forms.Button buttonOrDeleteCondition;
        private System.Windows.Forms.Button buttonAndDeleteCondition;
        private System.Windows.Forms.Button buttonAddDeleteCondition;
        private System.Windows.Forms.TextBox textBoxDeleteSQL;
    }
}