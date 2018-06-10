namespace LicentaCristeaClaudiu
{
    partial class ReportGraphForm
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
            this.buttonReportGraphOK = new System.Windows.Forms.Button();
            this.textBoxReportGraphX = new System.Windows.Forms.TextBox();
            this.textBoxReportGraphY = new System.Windows.Forms.TextBox();
            this.textBoxReportGraphWidth = new System.Windows.Forms.TextBox();
            this.textBoxReportGraphHeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonReportGraphOK
            // 
            this.buttonReportGraphOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonReportGraphOK.Location = new System.Drawing.Point(401, 175);
            this.buttonReportGraphOK.Name = "buttonReportGraphOK";
            this.buttonReportGraphOK.Size = new System.Drawing.Size(75, 23);
            this.buttonReportGraphOK.TabIndex = 0;
            this.buttonReportGraphOK.Text = "OK";
            this.buttonReportGraphOK.UseVisualStyleBackColor = true;
            this.buttonReportGraphOK.Click += new System.EventHandler(this.buttonReportGraphOK_Click);
            // 
            // textBoxReportGraphX
            // 
            this.textBoxReportGraphX.Location = new System.Drawing.Point(11, 45);
            this.textBoxReportGraphX.Name = "textBoxReportGraphX";
            this.textBoxReportGraphX.Size = new System.Drawing.Size(100, 22);
            this.textBoxReportGraphX.TabIndex = 1;
            // 
            // textBoxReportGraphY
            // 
            this.textBoxReportGraphY.Location = new System.Drawing.Point(11, 92);
            this.textBoxReportGraphY.Name = "textBoxReportGraphY";
            this.textBoxReportGraphY.Size = new System.Drawing.Size(100, 22);
            this.textBoxReportGraphY.TabIndex = 2;
            // 
            // textBoxReportGraphWidth
            // 
            this.textBoxReportGraphWidth.Location = new System.Drawing.Point(9, 47);
            this.textBoxReportGraphWidth.Name = "textBoxReportGraphWidth";
            this.textBoxReportGraphWidth.Size = new System.Drawing.Size(100, 22);
            this.textBoxReportGraphWidth.TabIndex = 3;
            // 
            // textBoxReportGraphHeight
            // 
            this.textBoxReportGraphHeight.Location = new System.Drawing.Point(115, 47);
            this.textBoxReportGraphHeight.Name = "textBoxReportGraphHeight";
            this.textBoxReportGraphHeight.Size = new System.Drawing.Size(100, 22);
            this.textBoxReportGraphHeight.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "X Axis Column (Number)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y Axis Column (Number)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Height";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 102);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Chart Type";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxReportGraphX);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxReportGraphY);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 152);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected columns";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxReportGraphWidth);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxReportGraphHeight);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 152);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chart properties";
            // 
            // ReportGraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 210);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonReportGraphOK);
            this.Name = "ReportGraphForm";
            this.Text = "Chart Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonReportGraphOK;
        private System.Windows.Forms.TextBox textBoxReportGraphX;
        private System.Windows.Forms.TextBox textBoxReportGraphY;
        private System.Windows.Forms.TextBox textBoxReportGraphWidth;
        private System.Windows.Forms.TextBox textBoxReportGraphHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}