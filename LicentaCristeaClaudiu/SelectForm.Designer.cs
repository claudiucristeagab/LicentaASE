namespace LicentaCristeaClaudiu
{
    partial class SelectForm
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
            this.labelSelectItems = new System.Windows.Forms.Label();
            this.labelTable = new System.Windows.Forms.Label();
            this.listBoxTabela = new System.Windows.Forms.ListBox();
            this.sqlSelectFormOK = new System.Windows.Forms.Button();
            this.sqlSelectFormCancel = new System.Windows.Forms.Button();
            this.textBoxSQL = new System.Windows.Forms.TextBox();
            this.buttonAddSelectFrom = new System.Windows.Forms.Button();
            this.buttonDisplayCommand = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonColumnColumn = new System.Windows.Forms.RadioButton();
            this.radioButtonColumnInput = new System.Windows.Forms.RadioButton();
            this.buttonAddCondition = new System.Windows.Forms.Button();
            this.tabControlSelect = new System.Windows.Forms.TabControl();
            this.tabPageSelectFrom = new System.Windows.Forms.TabPage();
            this.textBoxAlias = new System.Windows.Forms.TextBox();
            this.labelAlias = new System.Windows.Forms.Label();
            this.checkBoxAggregator = new System.Windows.Forms.CheckBox();
            this.comboBoxAggregator = new System.Windows.Forms.ComboBox();
            this.listBoxSelect = new System.Windows.Forms.ListBox();
            this.tabPageWhere = new System.Windows.Forms.TabPage();
            this.buttonOrCondition = new System.Windows.Forms.Button();
            this.buttonAndCondition = new System.Windows.Forms.Button();
            this.listBoxSelect3 = new System.Windows.Forms.ListBox();
            this.listBoxSelect2 = new System.Windows.Forms.ListBox();
            this.labelTable3 = new System.Windows.Forms.Label();
            this.listBoxTabela3 = new System.Windows.Forms.ListBox();
            this.labelSelectItem3 = new System.Windows.Forms.Label();
            this.listBoxComparator = new System.Windows.Forms.ListBox();
            this.labelWhereInput = new System.Windows.Forms.Label();
            this.textBoxWhereInput = new System.Windows.Forms.TextBox();
            this.labelTable2 = new System.Windows.Forms.Label();
            this.listBoxTabela2 = new System.Windows.Forms.ListBox();
            this.labelSelectItems2 = new System.Windows.Forms.Label();
            this.tabPageGroupBy = new System.Windows.Forms.TabPage();
            this.buttonAddGroupBy = new System.Windows.Forms.Button();
            this.labelGroupBy = new System.Windows.Forms.Label();
            this.comboBoxGroupBy = new System.Windows.Forms.ComboBox();
            this.tabPageOrderBy = new System.Windows.Forms.TabPage();
            this.panelOrderBy = new System.Windows.Forms.Panel();
            this.radioButtonOrderByAsc = new System.Windows.Forms.RadioButton();
            this.radioButtonORderByDesc = new System.Windows.Forms.RadioButton();
            this.buttonAddOrderBy = new System.Windows.Forms.Button();
            this.labelOrderBy = new System.Windows.Forms.Label();
            this.comboBoxOrderBy = new System.Windows.Forms.ComboBox();
            this.tabPageSelections = new System.Windows.Forms.TabPage();
            this.buttonNewCommand = new System.Windows.Forms.Button();
            this.buttonTestCommand = new System.Windows.Forms.Button();
            this.tableLayoutPanelDelete = new System.Windows.Forms.TableLayoutPanel();
            this.listViewDeleteConditions = new System.Windows.Forms.ListView();
            this.listViewDeleteSelection = new System.Windows.Forms.ListView();
            this.labelDeleteConditions = new System.Windows.Forms.Label();
            this.labelDeleteSelect = new System.Windows.Forms.Label();
            this.labelDeleteGroups = new System.Windows.Forms.Label();
            this.laberDeleteOrdering = new System.Windows.Forms.Label();
            this.listViewDeleteGroups = new System.Windows.Forms.ListView();
            this.listViewDeleteOrdering = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.tabControlSelect.SuspendLayout();
            this.tabPageSelectFrom.SuspendLayout();
            this.tabPageWhere.SuspendLayout();
            this.tabPageGroupBy.SuspendLayout();
            this.tabPageOrderBy.SuspendLayout();
            this.panelOrderBy.SuspendLayout();
            this.tabPageSelections.SuspendLayout();
            this.tableLayoutPanelDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSelectItems
            // 
            this.labelSelectItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSelectItems.AutoSize = true;
            this.labelSelectItems.Location = new System.Drawing.Point(255, 3);
            this.labelSelectItems.Name = "labelSelectItems";
            this.labelSelectItems.Size = new System.Drawing.Size(98, 17);
            this.labelSelectItems.TabIndex = 0;
            this.labelSelectItems.Text = "Select Column";
            // 
            // labelTable
            // 
            this.labelTable.AutoSize = true;
            this.labelTable.Location = new System.Drawing.Point(6, 3);
            this.labelTable.Name = "labelTable";
            this.labelTable.Size = new System.Drawing.Size(44, 17);
            this.labelTable.TabIndex = 2;
            this.labelTable.Text = "Table";
            // 
            // listBoxTabela
            // 
            this.listBoxTabela.FormattingEnabled = true;
            this.listBoxTabela.ItemHeight = 16;
            this.listBoxTabela.Location = new System.Drawing.Point(9, 23);
            this.listBoxTabela.Name = "listBoxTabela";
            this.listBoxTabela.Size = new System.Drawing.Size(243, 276);
            this.listBoxTabela.TabIndex = 4;
            this.listBoxTabela.SelectedValueChanged += new System.EventHandler(this.listBoxTabela_SelectedValueChanged);
            // 
            // sqlSelectFormOK
            // 
            this.sqlSelectFormOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sqlSelectFormOK.Location = new System.Drawing.Point(535, 535);
            this.sqlSelectFormOK.Name = "sqlSelectFormOK";
            this.sqlSelectFormOK.Size = new System.Drawing.Size(75, 46);
            this.sqlSelectFormOK.TabIndex = 5;
            this.sqlSelectFormOK.Text = "OK";
            this.sqlSelectFormOK.UseVisualStyleBackColor = true;
            this.sqlSelectFormOK.Click += new System.EventHandler(this.sqlSelectFormOK_Click);
            // 
            // sqlSelectFormCancel
            // 
            this.sqlSelectFormCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sqlSelectFormCancel.Location = new System.Drawing.Point(12, 535);
            this.sqlSelectFormCancel.Name = "sqlSelectFormCancel";
            this.sqlSelectFormCancel.Size = new System.Drawing.Size(75, 46);
            this.sqlSelectFormCancel.TabIndex = 6;
            this.sqlSelectFormCancel.Text = "Cancel";
            this.sqlSelectFormCancel.UseVisualStyleBackColor = true;
            this.sqlSelectFormCancel.Click += new System.EventHandler(this.sqlSelectFormCancel_Click);
            // 
            // textBoxSQL
            // 
            this.textBoxSQL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSQL.Location = new System.Drawing.Point(12, 463);
            this.textBoxSQL.Multiline = true;
            this.textBoxSQL.Name = "textBoxSQL";
            this.textBoxSQL.ReadOnly = true;
            this.textBoxSQL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSQL.Size = new System.Drawing.Size(598, 66);
            this.textBoxSQL.TabIndex = 7;
            // 
            // buttonAddSelectFrom
            // 
            this.buttonAddSelectFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddSelectFrom.Location = new System.Drawing.Point(539, 23);
            this.buttonAddSelectFrom.Name = "buttonAddSelectFrom";
            this.buttonAddSelectFrom.Size = new System.Drawing.Size(45, 23);
            this.buttonAddSelectFrom.TabIndex = 8;
            this.buttonAddSelectFrom.Text = "+";
            this.buttonAddSelectFrom.UseVisualStyleBackColor = true;
            this.buttonAddSelectFrom.Click += new System.EventHandler(this.buttonAddSelectFrom_Click);
            // 
            // buttonDisplayCommand
            // 
            this.buttonDisplayCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDisplayCommand.Location = new System.Drawing.Point(379, 535);
            this.buttonDisplayCommand.Name = "buttonDisplayCommand";
            this.buttonDisplayCommand.Size = new System.Drawing.Size(150, 46);
            this.buttonDisplayCommand.TabIndex = 9;
            this.buttonDisplayCommand.Text = "Refresh";
            this.buttonDisplayCommand.UseVisualStyleBackColor = true;
            this.buttonDisplayCommand.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonColumnColumn);
            this.panel1.Controls.Add(this.radioButtonColumnInput);
            this.panel1.Location = new System.Drawing.Point(9, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 68);
            this.panel1.TabIndex = 10;
            // 
            // radioButtonColumnColumn
            // 
            this.radioButtonColumnColumn.AutoSize = true;
            this.radioButtonColumnColumn.Location = new System.Drawing.Point(4, 31);
            this.radioButtonColumnColumn.Name = "radioButtonColumnColumn";
            this.radioButtonColumnColumn.Size = new System.Drawing.Size(163, 21);
            this.radioButtonColumnColumn.TabIndex = 1;
            this.radioButtonColumnColumn.Text = "Column 1 = Column 2";
            this.radioButtonColumnColumn.UseVisualStyleBackColor = true;
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
            // buttonAddCondition
            // 
            this.buttonAddCondition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddCondition.Location = new System.Drawing.Point(509, 364);
            this.buttonAddCondition.Name = "buttonAddCondition";
            this.buttonAddCondition.Size = new System.Drawing.Size(75, 46);
            this.buttonAddCondition.TabIndex = 11;
            this.buttonAddCondition.Text = "Add";
            this.buttonAddCondition.UseVisualStyleBackColor = true;
            this.buttonAddCondition.Click += new System.EventHandler(this.buttonAddCondition_Click);
            // 
            // tabControlSelect
            // 
            this.tabControlSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlSelect.Controls.Add(this.tabPageSelectFrom);
            this.tabControlSelect.Controls.Add(this.tabPageWhere);
            this.tabControlSelect.Controls.Add(this.tabPageGroupBy);
            this.tabControlSelect.Controls.Add(this.tabPageOrderBy);
            this.tabControlSelect.Controls.Add(this.tabPageSelections);
            this.tabControlSelect.Location = new System.Drawing.Point(12, 12);
            this.tabControlSelect.Name = "tabControlSelect";
            this.tabControlSelect.SelectedIndex = 0;
            this.tabControlSelect.Size = new System.Drawing.Size(598, 445);
            this.tabControlSelect.TabIndex = 12;
            this.tabControlSelect.SelectedIndexChanged += new System.EventHandler(this.tabControlSelect_SelectedIndexChanged);
            this.tabControlSelect.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            this.tabControlSelect.TabIndexChanged += new System.EventHandler(this.tabControlSelect_TabIndexChanged);
            // 
            // tabPageSelectFrom
            // 
            this.tabPageSelectFrom.Controls.Add(this.textBoxAlias);
            this.tabPageSelectFrom.Controls.Add(this.labelAlias);
            this.tabPageSelectFrom.Controls.Add(this.checkBoxAggregator);
            this.tabPageSelectFrom.Controls.Add(this.comboBoxAggregator);
            this.tabPageSelectFrom.Controls.Add(this.listBoxSelect);
            this.tabPageSelectFrom.Controls.Add(this.labelTable);
            this.tabPageSelectFrom.Controls.Add(this.listBoxTabela);
            this.tabPageSelectFrom.Controls.Add(this.labelSelectItems);
            this.tabPageSelectFrom.Controls.Add(this.buttonAddSelectFrom);
            this.tabPageSelectFrom.Location = new System.Drawing.Point(4, 25);
            this.tabPageSelectFrom.Name = "tabPageSelectFrom";
            this.tabPageSelectFrom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSelectFrom.Size = new System.Drawing.Size(590, 416);
            this.tabPageSelectFrom.TabIndex = 0;
            this.tabPageSelectFrom.Text = "1. Selection";
            this.tabPageSelectFrom.UseVisualStyleBackColor = true;
            // 
            // textBoxAlias
            // 
            this.textBoxAlias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAlias.Location = new System.Drawing.Point(258, 335);
            this.textBoxAlias.Name = "textBoxAlias";
            this.textBoxAlias.Size = new System.Drawing.Size(275, 22);
            this.textBoxAlias.TabIndex = 15;
            // 
            // labelAlias
            // 
            this.labelAlias.AutoSize = true;
            this.labelAlias.Location = new System.Drawing.Point(255, 309);
            this.labelAlias.Name = "labelAlias";
            this.labelAlias.Size = new System.Drawing.Size(38, 17);
            this.labelAlias.TabIndex = 14;
            this.labelAlias.Text = "Alias";
            // 
            // checkBoxAggregator
            // 
            this.checkBoxAggregator.AutoSize = true;
            this.checkBoxAggregator.Location = new System.Drawing.Point(9, 308);
            this.checkBoxAggregator.Name = "checkBoxAggregator";
            this.checkBoxAggregator.Size = new System.Drawing.Size(178, 21);
            this.checkBoxAggregator.TabIndex = 13;
            this.checkBoxAggregator.Text = "Add aggregate function";
            this.checkBoxAggregator.UseVisualStyleBackColor = true;
            // 
            // comboBoxAggregator
            // 
            this.comboBoxAggregator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAggregator.FormattingEnabled = true;
            this.comboBoxAggregator.Location = new System.Drawing.Point(9, 335);
            this.comboBoxAggregator.Name = "comboBoxAggregator";
            this.comboBoxAggregator.Size = new System.Drawing.Size(121, 24);
            this.comboBoxAggregator.TabIndex = 12;
            // 
            // listBoxSelect
            // 
            this.listBoxSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxSelect.FormattingEnabled = true;
            this.listBoxSelect.ItemHeight = 16;
            this.listBoxSelect.Location = new System.Drawing.Point(258, 23);
            this.listBoxSelect.Name = "listBoxSelect";
            this.listBoxSelect.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxSelect.Size = new System.Drawing.Size(275, 276);
            this.listBoxSelect.TabIndex = 9;
            // 
            // tabPageWhere
            // 
            this.tabPageWhere.AutoScroll = true;
            this.tabPageWhere.Controls.Add(this.buttonOrCondition);
            this.tabPageWhere.Controls.Add(this.buttonAndCondition);
            this.tabPageWhere.Controls.Add(this.listBoxSelect3);
            this.tabPageWhere.Controls.Add(this.listBoxSelect2);
            this.tabPageWhere.Controls.Add(this.labelTable3);
            this.tabPageWhere.Controls.Add(this.listBoxTabela3);
            this.tabPageWhere.Controls.Add(this.labelSelectItem3);
            this.tabPageWhere.Controls.Add(this.listBoxComparator);
            this.tabPageWhere.Controls.Add(this.labelWhereInput);
            this.tabPageWhere.Controls.Add(this.textBoxWhereInput);
            this.tabPageWhere.Controls.Add(this.labelTable2);
            this.tabPageWhere.Controls.Add(this.listBoxTabela2);
            this.tabPageWhere.Controls.Add(this.labelSelectItems2);
            this.tabPageWhere.Controls.Add(this.panel1);
            this.tabPageWhere.Controls.Add(this.buttonAddCondition);
            this.tabPageWhere.Location = new System.Drawing.Point(4, 25);
            this.tabPageWhere.Name = "tabPageWhere";
            this.tabPageWhere.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWhere.Size = new System.Drawing.Size(590, 416);
            this.tabPageWhere.TabIndex = 1;
            this.tabPageWhere.Text = "2. Conditions";
            this.tabPageWhere.UseVisualStyleBackColor = true;
            // 
            // buttonOrCondition
            // 
            this.buttonOrCondition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOrCondition.Location = new System.Drawing.Point(63, 364);
            this.buttonOrCondition.Name = "buttonOrCondition";
            this.buttonOrCondition.Size = new System.Drawing.Size(75, 46);
            this.buttonOrCondition.TabIndex = 26;
            this.buttonOrCondition.Text = "Or";
            this.buttonOrCondition.UseVisualStyleBackColor = true;
            this.buttonOrCondition.Click += new System.EventHandler(this.buttonOrCondition_Click);
            // 
            // buttonAndCondition
            // 
            this.buttonAndCondition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAndCondition.Location = new System.Drawing.Point(144, 364);
            this.buttonAndCondition.Name = "buttonAndCondition";
            this.buttonAndCondition.Size = new System.Drawing.Size(75, 46);
            this.buttonAndCondition.TabIndex = 25;
            this.buttonAndCondition.Text = "And";
            this.buttonAndCondition.UseVisualStyleBackColor = true;
            this.buttonAndCondition.Click += new System.EventHandler(this.buttonAndCondition_Click);
            // 
            // listBoxSelect3
            // 
            this.listBoxSelect3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxSelect3.FormattingEnabled = true;
            this.listBoxSelect3.ItemHeight = 16;
            this.listBoxSelect3.Location = new System.Drawing.Point(258, 221);
            this.listBoxSelect3.Name = "listBoxSelect3";
            this.listBoxSelect3.Size = new System.Drawing.Size(326, 100);
            this.listBoxSelect3.TabIndex = 24;
            // 
            // listBoxSelect2
            // 
            this.listBoxSelect2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxSelect2.FormattingEnabled = true;
            this.listBoxSelect2.ItemHeight = 16;
            this.listBoxSelect2.Location = new System.Drawing.Point(258, 23);
            this.listBoxSelect2.Name = "listBoxSelect2";
            this.listBoxSelect2.Size = new System.Drawing.Size(326, 100);
            this.listBoxSelect2.TabIndex = 23;
            // 
            // labelTable3
            // 
            this.labelTable3.AutoSize = true;
            this.labelTable3.Location = new System.Drawing.Point(6, 201);
            this.labelTable3.Name = "labelTable3";
            this.labelTable3.Size = new System.Drawing.Size(56, 17);
            this.labelTable3.TabIndex = 21;
            this.labelTable3.Text = "Table 2";
            // 
            // listBoxTabela3
            // 
            this.listBoxTabela3.FormattingEnabled = true;
            this.listBoxTabela3.ItemHeight = 16;
            this.listBoxTabela3.Location = new System.Drawing.Point(9, 221);
            this.listBoxTabela3.Name = "listBoxTabela3";
            this.listBoxTabela3.Size = new System.Drawing.Size(243, 100);
            this.listBoxTabela3.TabIndex = 22;
            this.listBoxTabela3.SelectedValueChanged += new System.EventHandler(this.listBoxTabela3_SelectedValueChanged);
            // 
            // labelSelectItem3
            // 
            this.labelSelectItem3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSelectItem3.AutoSize = true;
            this.labelSelectItem3.Location = new System.Drawing.Point(255, 201);
            this.labelSelectItem3.Name = "labelSelectItem3";
            this.labelSelectItem3.Size = new System.Drawing.Size(110, 17);
            this.labelSelectItem3.TabIndex = 19;
            this.labelSelectItem3.Text = "Select Column 2";
            // 
            // listBoxComparator
            // 
            this.listBoxComparator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxComparator.FormattingEnabled = true;
            this.listBoxComparator.ItemHeight = 16;
            this.listBoxComparator.Location = new System.Drawing.Point(258, 129);
            this.listBoxComparator.Name = "listBoxComparator";
            this.listBoxComparator.Size = new System.Drawing.Size(326, 68);
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
            this.textBoxWhereInput.Size = new System.Drawing.Size(521, 22);
            this.textBoxWhereInput.TabIndex = 16;
            // 
            // labelTable2
            // 
            this.labelTable2.AutoSize = true;
            this.labelTable2.Location = new System.Drawing.Point(6, 3);
            this.labelTable2.Name = "labelTable2";
            this.labelTable2.Size = new System.Drawing.Size(56, 17);
            this.labelTable2.TabIndex = 14;
            this.labelTable2.Text = "Table 1";
            // 
            // listBoxTabela2
            // 
            this.listBoxTabela2.FormattingEnabled = true;
            this.listBoxTabela2.ItemHeight = 16;
            this.listBoxTabela2.Location = new System.Drawing.Point(9, 23);
            this.listBoxTabela2.Name = "listBoxTabela2";
            this.listBoxTabela2.Size = new System.Drawing.Size(243, 100);
            this.listBoxTabela2.TabIndex = 15;
            this.listBoxTabela2.SelectedValueChanged += new System.EventHandler(this.listBoxTabela2_SelectedValueChanged);
            // 
            // labelSelectItems2
            // 
            this.labelSelectItems2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSelectItems2.AutoSize = true;
            this.labelSelectItems2.Location = new System.Drawing.Point(255, 3);
            this.labelSelectItems2.Name = "labelSelectItems2";
            this.labelSelectItems2.Size = new System.Drawing.Size(110, 17);
            this.labelSelectItems2.TabIndex = 12;
            this.labelSelectItems2.Text = "Select Column 1";
            // 
            // tabPageGroupBy
            // 
            this.tabPageGroupBy.Controls.Add(this.buttonAddGroupBy);
            this.tabPageGroupBy.Controls.Add(this.labelGroupBy);
            this.tabPageGroupBy.Controls.Add(this.comboBoxGroupBy);
            this.tabPageGroupBy.Location = new System.Drawing.Point(4, 25);
            this.tabPageGroupBy.Name = "tabPageGroupBy";
            this.tabPageGroupBy.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGroupBy.Size = new System.Drawing.Size(590, 416);
            this.tabPageGroupBy.TabIndex = 3;
            this.tabPageGroupBy.Text = "3. Groups";
            this.tabPageGroupBy.UseVisualStyleBackColor = true;
            // 
            // buttonAddGroupBy
            // 
            this.buttonAddGroupBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddGroupBy.Location = new System.Drawing.Point(509, 364);
            this.buttonAddGroupBy.Name = "buttonAddGroupBy";
            this.buttonAddGroupBy.Size = new System.Drawing.Size(75, 46);
            this.buttonAddGroupBy.TabIndex = 4;
            this.buttonAddGroupBy.Text = "Add";
            this.buttonAddGroupBy.UseVisualStyleBackColor = true;
            this.buttonAddGroupBy.Click += new System.EventHandler(this.buttonAddGroupBy_Click);
            // 
            // labelGroupBy
            // 
            this.labelGroupBy.AutoSize = true;
            this.labelGroupBy.Location = new System.Drawing.Point(6, 9);
            this.labelGroupBy.Name = "labelGroupBy";
            this.labelGroupBy.Size = new System.Drawing.Size(71, 17);
            this.labelGroupBy.TabIndex = 3;
            this.labelGroupBy.Text = "Group by:";
            // 
            // comboBoxGroupBy
            // 
            this.comboBoxGroupBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxGroupBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGroupBy.FormattingEnabled = true;
            this.comboBoxGroupBy.Location = new System.Drawing.Point(134, 6);
            this.comboBoxGroupBy.Name = "comboBoxGroupBy";
            this.comboBoxGroupBy.Size = new System.Drawing.Size(453, 24);
            this.comboBoxGroupBy.TabIndex = 2;
            // 
            // tabPageOrderBy
            // 
            this.tabPageOrderBy.Controls.Add(this.panelOrderBy);
            this.tabPageOrderBy.Controls.Add(this.buttonAddOrderBy);
            this.tabPageOrderBy.Controls.Add(this.labelOrderBy);
            this.tabPageOrderBy.Controls.Add(this.comboBoxOrderBy);
            this.tabPageOrderBy.Location = new System.Drawing.Point(4, 25);
            this.tabPageOrderBy.Name = "tabPageOrderBy";
            this.tabPageOrderBy.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrderBy.Size = new System.Drawing.Size(590, 416);
            this.tabPageOrderBy.TabIndex = 2;
            this.tabPageOrderBy.Text = "4. Order";
            this.tabPageOrderBy.UseVisualStyleBackColor = true;
            // 
            // panelOrderBy
            // 
            this.panelOrderBy.Controls.Add(this.radioButtonOrderByAsc);
            this.panelOrderBy.Controls.Add(this.radioButtonORderByDesc);
            this.panelOrderBy.Location = new System.Drawing.Point(131, 36);
            this.panelOrderBy.Name = "panelOrderBy";
            this.panelOrderBy.Size = new System.Drawing.Size(453, 61);
            this.panelOrderBy.TabIndex = 5;
            // 
            // radioButtonOrderByAsc
            // 
            this.radioButtonOrderByAsc.AutoSize = true;
            this.radioButtonOrderByAsc.Location = new System.Drawing.Point(3, 3);
            this.radioButtonOrderByAsc.Name = "radioButtonOrderByAsc";
            this.radioButtonOrderByAsc.Size = new System.Drawing.Size(95, 21);
            this.radioButtonOrderByAsc.TabIndex = 3;
            this.radioButtonOrderByAsc.TabStop = true;
            this.radioButtonOrderByAsc.Text = "Ascending";
            this.radioButtonOrderByAsc.UseVisualStyleBackColor = true;
            // 
            // radioButtonORderByDesc
            // 
            this.radioButtonORderByDesc.AutoSize = true;
            this.radioButtonORderByDesc.Location = new System.Drawing.Point(3, 30);
            this.radioButtonORderByDesc.Name = "radioButtonORderByDesc";
            this.radioButtonORderByDesc.Size = new System.Drawing.Size(104, 21);
            this.radioButtonORderByDesc.TabIndex = 4;
            this.radioButtonORderByDesc.TabStop = true;
            this.radioButtonORderByDesc.Text = "Descending";
            this.radioButtonORderByDesc.UseVisualStyleBackColor = true;
            // 
            // buttonAddOrderBy
            // 
            this.buttonAddOrderBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddOrderBy.Location = new System.Drawing.Point(509, 364);
            this.buttonAddOrderBy.Name = "buttonAddOrderBy";
            this.buttonAddOrderBy.Size = new System.Drawing.Size(75, 46);
            this.buttonAddOrderBy.TabIndex = 2;
            this.buttonAddOrderBy.Text = "Add";
            this.buttonAddOrderBy.UseVisualStyleBackColor = true;
            this.buttonAddOrderBy.Click += new System.EventHandler(this.buttonAddOrderBy_Click);
            // 
            // labelOrderBy
            // 
            this.labelOrderBy.AutoSize = true;
            this.labelOrderBy.Location = new System.Drawing.Point(6, 9);
            this.labelOrderBy.Name = "labelOrderBy";
            this.labelOrderBy.Size = new System.Drawing.Size(57, 17);
            this.labelOrderBy.TabIndex = 1;
            this.labelOrderBy.Text = "Sort by:";
            // 
            // comboBoxOrderBy
            // 
            this.comboBoxOrderBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrderBy.FormattingEnabled = true;
            this.comboBoxOrderBy.Location = new System.Drawing.Point(131, 6);
            this.comboBoxOrderBy.Name = "comboBoxOrderBy";
            this.comboBoxOrderBy.Size = new System.Drawing.Size(453, 24);
            this.comboBoxOrderBy.TabIndex = 0;
            // 
            // tabPageSelections
            // 
            this.tabPageSelections.AutoScroll = true;
            this.tabPageSelections.Controls.Add(this.tableLayoutPanelDelete);
            this.tabPageSelections.Location = new System.Drawing.Point(4, 25);
            this.tabPageSelections.Name = "tabPageSelections";
            this.tabPageSelections.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSelections.Size = new System.Drawing.Size(590, 416);
            this.tabPageSelections.TabIndex = 4;
            this.tabPageSelections.Text = "Selections";
            this.tabPageSelections.UseVisualStyleBackColor = true;
            // 
            // buttonNewCommand
            // 
            this.buttonNewCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonNewCommand.Location = new System.Drawing.Point(93, 535);
            this.buttonNewCommand.Name = "buttonNewCommand";
            this.buttonNewCommand.Size = new System.Drawing.Size(150, 46);
            this.buttonNewCommand.TabIndex = 13;
            this.buttonNewCommand.Text = "Reset";
            this.buttonNewCommand.UseVisualStyleBackColor = true;
            this.buttonNewCommand.Click += new System.EventHandler(this.buttonNewCommand_Click);
            // 
            // buttonTestCommand
            // 
            this.buttonTestCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTestCommand.Location = new System.Drawing.Point(250, 535);
            this.buttonTestCommand.Name = "buttonTestCommand";
            this.buttonTestCommand.Size = new System.Drawing.Size(123, 46);
            this.buttonTestCommand.TabIndex = 14;
            this.buttonTestCommand.Text = "Test";
            this.buttonTestCommand.UseVisualStyleBackColor = true;
            this.buttonTestCommand.Click += new System.EventHandler(this.buttonTestCommand_Click);
            // 
            // tableLayoutPanelDelete
            // 
            this.tableLayoutPanelDelete.ColumnCount = 2;
            this.tableLayoutPanelDelete.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDelete.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDelete.Controls.Add(this.listViewDeleteConditions, 1, 1);
            this.tableLayoutPanelDelete.Controls.Add(this.listViewDeleteSelection, 0, 1);
            this.tableLayoutPanelDelete.Controls.Add(this.labelDeleteConditions, 1, 0);
            this.tableLayoutPanelDelete.Controls.Add(this.labelDeleteSelect, 0, 0);
            this.tableLayoutPanelDelete.Controls.Add(this.labelDeleteGroups, 0, 2);
            this.tableLayoutPanelDelete.Controls.Add(this.laberDeleteOrdering, 1, 2);
            this.tableLayoutPanelDelete.Controls.Add(this.listViewDeleteGroups, 0, 3);
            this.tableLayoutPanelDelete.Controls.Add(this.listViewDeleteOrdering, 1, 3);
            this.tableLayoutPanelDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDelete.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanelDelete.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelDelete.Name = "tableLayoutPanelDelete";
            this.tableLayoutPanelDelete.RowCount = 4;
            this.tableLayoutPanelDelete.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelDelete.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDelete.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelDelete.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDelete.Size = new System.Drawing.Size(584, 410);
            this.tableLayoutPanelDelete.TabIndex = 1;
            // 
            // listViewDeleteConditions
            // 
            this.listViewDeleteConditions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewDeleteConditions.Location = new System.Drawing.Point(295, 33);
            this.listViewDeleteConditions.Name = "listViewDeleteConditions";
            this.listViewDeleteConditions.Size = new System.Drawing.Size(286, 169);
            this.listViewDeleteConditions.TabIndex = 30;
            this.listViewDeleteConditions.UseCompatibleStateImageBehavior = false;
            this.listViewDeleteConditions.View = System.Windows.Forms.View.List;
            this.listViewDeleteConditions.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewDeleteConditions_KeyDown);
            // 
            // listViewDeleteSelection
            // 
            this.listViewDeleteSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewDeleteSelection.Location = new System.Drawing.Point(3, 33);
            this.listViewDeleteSelection.Name = "listViewDeleteSelection";
            this.listViewDeleteSelection.Size = new System.Drawing.Size(286, 169);
            this.listViewDeleteSelection.TabIndex = 29;
            this.listViewDeleteSelection.UseCompatibleStateImageBehavior = false;
            this.listViewDeleteSelection.View = System.Windows.Forms.View.List;
            this.listViewDeleteSelection.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewDeleteSelection_KeyDown);
            // 
            // labelDeleteConditions
            // 
            this.labelDeleteConditions.AutoSize = true;
            this.labelDeleteConditions.Location = new System.Drawing.Point(295, 0);
            this.labelDeleteConditions.Name = "labelDeleteConditions";
            this.labelDeleteConditions.Size = new System.Drawing.Size(133, 17);
            this.labelDeleteConditions.TabIndex = 28;
            this.labelDeleteConditions.Text = "Selected Conditions";
            // 
            // labelDeleteSelect
            // 
            this.labelDeleteSelect.AutoSize = true;
            this.labelDeleteSelect.Location = new System.Drawing.Point(3, 0);
            this.labelDeleteSelect.Name = "labelDeleteSelect";
            this.labelDeleteSelect.Size = new System.Drawing.Size(121, 17);
            this.labelDeleteSelect.TabIndex = 27;
            this.labelDeleteSelect.Text = "Selected Columns";
            // 
            // labelDeleteGroups
            // 
            this.labelDeleteGroups.AutoSize = true;
            this.labelDeleteGroups.Location = new System.Drawing.Point(3, 205);
            this.labelDeleteGroups.Name = "labelDeleteGroups";
            this.labelDeleteGroups.Size = new System.Drawing.Size(114, 17);
            this.labelDeleteGroups.TabIndex = 31;
            this.labelDeleteGroups.Text = "Selected Groups";
            // 
            // laberDeleteOrdering
            // 
            this.laberDeleteOrdering.AutoSize = true;
            this.laberDeleteOrdering.Location = new System.Drawing.Point(295, 205);
            this.laberDeleteOrdering.Name = "laberDeleteOrdering";
            this.laberDeleteOrdering.Size = new System.Drawing.Size(123, 17);
            this.laberDeleteOrdering.TabIndex = 32;
            this.laberDeleteOrdering.Text = "Selected Ordering";
            // 
            // listViewDeleteGroups
            // 
            this.listViewDeleteGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewDeleteGroups.Location = new System.Drawing.Point(3, 238);
            this.listViewDeleteGroups.Name = "listViewDeleteGroups";
            this.listViewDeleteGroups.Size = new System.Drawing.Size(286, 169);
            this.listViewDeleteGroups.TabIndex = 33;
            this.listViewDeleteGroups.UseCompatibleStateImageBehavior = false;
            this.listViewDeleteGroups.View = System.Windows.Forms.View.List;
            this.listViewDeleteGroups.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewDeleteGroups_KeyDown);
            // 
            // listViewDeleteOrdering
            // 
            this.listViewDeleteOrdering.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewDeleteOrdering.Location = new System.Drawing.Point(295, 238);
            this.listViewDeleteOrdering.Name = "listViewDeleteOrdering";
            this.listViewDeleteOrdering.Size = new System.Drawing.Size(286, 169);
            this.listViewDeleteOrdering.TabIndex = 34;
            this.listViewDeleteOrdering.UseCompatibleStateImageBehavior = false;
            this.listViewDeleteOrdering.View = System.Windows.Forms.View.List;
            this.listViewDeleteOrdering.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewDeleteOrdering_KeyDown);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 593);
            this.Controls.Add(this.buttonTestCommand);
            this.Controls.Add(this.buttonNewCommand);
            this.Controls.Add(this.tabControlSelect);
            this.Controls.Add(this.buttonDisplayCommand);
            this.Controls.Add(this.textBoxSQL);
            this.Controls.Add(this.sqlSelectFormCancel);
            this.Controls.Add(this.sqlSelectFormOK);
            this.Name = "SelectForm";
            this.Text = "SELECT Builder";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControlSelect.ResumeLayout(false);
            this.tabPageSelectFrom.ResumeLayout(false);
            this.tabPageSelectFrom.PerformLayout();
            this.tabPageWhere.ResumeLayout(false);
            this.tabPageWhere.PerformLayout();
            this.tabPageGroupBy.ResumeLayout(false);
            this.tabPageGroupBy.PerformLayout();
            this.tabPageOrderBy.ResumeLayout(false);
            this.tabPageOrderBy.PerformLayout();
            this.panelOrderBy.ResumeLayout(false);
            this.panelOrderBy.PerformLayout();
            this.tabPageSelections.ResumeLayout(false);
            this.tableLayoutPanelDelete.ResumeLayout(false);
            this.tableLayoutPanelDelete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSelectItems;
        private System.Windows.Forms.Label labelTable;
        private System.Windows.Forms.ListBox listBoxTabela;
        private System.Windows.Forms.Button sqlSelectFormOK;
        private System.Windows.Forms.Button sqlSelectFormCancel;
        private System.Windows.Forms.TextBox textBoxSQL;
        private System.Windows.Forms.Button buttonAddSelectFrom;
        private System.Windows.Forms.Button buttonDisplayCommand;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonColumnInput;
        private System.Windows.Forms.Button buttonAddCondition;
        private System.Windows.Forms.TabControl tabControlSelect;
        private System.Windows.Forms.TabPage tabPageSelectFrom;
        private System.Windows.Forms.TabPage tabPageWhere;
        private System.Windows.Forms.Label labelTable2;
        private System.Windows.Forms.ListBox listBoxTabela2;
        private System.Windows.Forms.Label labelSelectItems2;
        private System.Windows.Forms.RadioButton radioButtonColumnColumn;
        private System.Windows.Forms.Label labelWhereInput;
        private System.Windows.Forms.TextBox textBoxWhereInput;
        private System.Windows.Forms.ListBox listBoxComparator;
        private System.Windows.Forms.Label labelTable3;
        private System.Windows.Forms.ListBox listBoxTabela3;
        private System.Windows.Forms.Label labelSelectItem3;
        private System.Windows.Forms.Button buttonNewCommand;
        private System.Windows.Forms.ListBox listBoxSelect2;
        private System.Windows.Forms.ListBox listBoxSelect3;
        private System.Windows.Forms.ListBox listBoxSelect;
        private System.Windows.Forms.TabPage tabPageOrderBy;
        private System.Windows.Forms.Button buttonAndCondition;
        private System.Windows.Forms.Button buttonOrCondition;
        private System.Windows.Forms.ComboBox comboBoxOrderBy;
        private System.Windows.Forms.Label labelOrderBy;
        private System.Windows.Forms.Button buttonAddOrderBy;
        private System.Windows.Forms.RadioButton radioButtonORderByDesc;
        private System.Windows.Forms.RadioButton radioButtonOrderByAsc;
        private System.Windows.Forms.Panel panelOrderBy;
        private System.Windows.Forms.ComboBox comboBoxAggregator;
        private System.Windows.Forms.CheckBox checkBoxAggregator;
        private System.Windows.Forms.TextBox textBoxAlias;
        private System.Windows.Forms.Label labelAlias;
        private System.Windows.Forms.Button buttonTestCommand;
        private System.Windows.Forms.TabPage tabPageGroupBy;
        private System.Windows.Forms.Button buttonAddGroupBy;
        private System.Windows.Forms.Label labelGroupBy;
        private System.Windows.Forms.ComboBox comboBoxGroupBy;
        private System.Windows.Forms.TabPage tabPageSelections;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDelete;
        private System.Windows.Forms.ListView listViewDeleteConditions;
        private System.Windows.Forms.ListView listViewDeleteSelection;
        private System.Windows.Forms.Label labelDeleteConditions;
        private System.Windows.Forms.Label labelDeleteSelect;
        private System.Windows.Forms.Label labelDeleteGroups;
        private System.Windows.Forms.Label laberDeleteOrdering;
        private System.Windows.Forms.ListView listViewDeleteGroups;
        private System.Windows.Forms.ListView listViewDeleteOrdering;
    }
}