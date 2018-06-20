namespace LicentaCristeaClaudiu
{
    partial class StatisticsOneWayFreqForm
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
            this.labelOneWayFreqVariable = new System.Windows.Forms.Label();
            this.comboBoxOneWayFreqVariable = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelOneWayFreqVariable
            // 
            this.labelOneWayFreqVariable.AutoSize = true;
            this.labelOneWayFreqVariable.Location = new System.Drawing.Point(12, 9);
            this.labelOneWayFreqVariable.Name = "labelOneWayFreqVariable";
            this.labelOneWayFreqVariable.Size = new System.Drawing.Size(60, 17);
            this.labelOneWayFreqVariable.TabIndex = 0;
            this.labelOneWayFreqVariable.Text = "Variable";
            // 
            // comboBoxOneWayFreqVariable
            // 
            this.comboBoxOneWayFreqVariable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOneWayFreqVariable.FormattingEnabled = true;
            this.comboBoxOneWayFreqVariable.Location = new System.Drawing.Point(15, 29);
            this.comboBoxOneWayFreqVariable.Name = "comboBoxOneWayFreqVariable";
            this.comboBoxOneWayFreqVariable.Size = new System.Drawing.Size(255, 24);
            this.comboBoxOneWayFreqVariable.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StatisticsOneWayFreqForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 104);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxOneWayFreqVariable);
            this.Controls.Add(this.labelOneWayFreqVariable);
            this.Name = "StatisticsOneWayFreqForm";
            this.Text = "One-Way Freq";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOneWayFreqVariable;
        private System.Windows.Forms.ComboBox comboBoxOneWayFreqVariable;
        private System.Windows.Forms.Button button1;
    }
}