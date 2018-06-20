namespace LicentaCristeaClaudiu
{
    partial class StatisticsRegressionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxIndependentVariable = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDependentVariable = new System.Windows.Forms.ComboBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Independent variable:";
            // 
            // comboBoxIndependentVariable
            // 
            this.comboBoxIndependentVariable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxIndependentVariable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIndependentVariable.FormattingEnabled = true;
            this.comboBoxIndependentVariable.Location = new System.Drawing.Point(16, 34);
            this.comboBoxIndependentVariable.Name = "comboBoxIndependentVariable";
            this.comboBoxIndependentVariable.Size = new System.Drawing.Size(254, 24);
            this.comboBoxIndependentVariable.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dependent variable:";
            // 
            // comboBoxDependentVariable
            // 
            this.comboBoxDependentVariable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxDependentVariable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDependentVariable.FormattingEnabled = true;
            this.comboBoxDependentVariable.Location = new System.Drawing.Point(16, 86);
            this.comboBoxDependentVariable.Name = "comboBoxDependentVariable";
            this.comboBoxDependentVariable.Size = new System.Drawing.Size(254, 24);
            this.comboBoxDependentVariable.TabIndex = 3;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(195, 124);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // StatisticsRegressionForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 159);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.comboBoxDependentVariable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxIndependentVariable);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "StatisticsRegressionForm";
            this.Text = "Regression";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxIndependentVariable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDependentVariable;
        private System.Windows.Forms.Button buttonOK;
    }
}