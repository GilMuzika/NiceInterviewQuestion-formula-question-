namespace _24_06_20_NiceInterviewQueation_winForm
{
    partial class Form1
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
            this.txtFormula = new System.Windows.Forms.TextBox();
            this.txtSentence = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVerify = new System.Windows.Forms.Button();
            this.cmbPreparedSentences = new System.Windows.Forms.ComboBox();
            this.cmbpreparedFormulas = new System.Windows.Forms.ComboBox();
            this.chkDuplications = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtFormula
            // 
            this.txtFormula.Location = new System.Drawing.Point(12, 25);
            this.txtFormula.Name = "txtFormula";
            this.txtFormula.Size = new System.Drawing.Size(171, 20);
            this.txtFormula.TabIndex = 0;
            // 
            // txtSentence
            // 
            this.txtSentence.Location = new System.Drawing.Point(12, 116);
            this.txtSentence.Name = "txtSentence";
            this.txtSentence.Size = new System.Drawing.Size(171, 20);
            this.txtSentence.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Formula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sentence:";
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(108, 232);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(75, 23);
            this.btnVerify.TabIndex = 4;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = true;
            // 
            // cmbPreparedSentences
            // 
            this.cmbPreparedSentences.FormattingEnabled = true;
            this.cmbPreparedSentences.Location = new System.Drawing.Point(12, 162);
            this.cmbPreparedSentences.Name = "cmbPreparedSentences";
            this.cmbPreparedSentences.Size = new System.Drawing.Size(171, 21);
            this.cmbPreparedSentences.TabIndex = 5;
            this.cmbPreparedSentences.Text = "Or use prepared sentences";
            // 
            // cmbpreparedFormulas
            // 
            this.cmbpreparedFormulas.FormattingEnabled = true;
            this.cmbpreparedFormulas.Location = new System.Drawing.Point(12, 63);
            this.cmbpreparedFormulas.Name = "cmbpreparedFormulas";
            this.cmbpreparedFormulas.Size = new System.Drawing.Size(171, 21);
            this.cmbpreparedFormulas.TabIndex = 6;
            this.cmbpreparedFormulas.Text = "Or use prepared formulas";
            // 
            // chkDuplications
            // 
            this.chkDuplications.AutoSize = true;
            this.chkDuplications.Checked = true;
            this.chkDuplications.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDuplications.Location = new System.Drawing.Point(76, 200);
            this.chkDuplications.Name = "chkDuplications";
            this.chkDuplications.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkDuplications.Size = new System.Drawing.Size(102, 17);
            this.chkDuplications.TabIndex = 7;
            this.chkDuplications.Text = "מותר כפילויות";
            this.chkDuplications.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 271);
            this.Controls.Add(this.chkDuplications);
            this.Controls.Add(this.cmbpreparedFormulas);
            this.Controls.Add(this.cmbPreparedSentences);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSentence);
            this.Controls.Add(this.txtFormula);
            this.Name = "Form1";
            this.Text = "Nice Interview Queation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFormula;
        private System.Windows.Forms.TextBox txtSentence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.ComboBox cmbPreparedSentences;
        private System.Windows.Forms.ComboBox cmbpreparedFormulas;
        private System.Windows.Forms.CheckBox chkDuplications;
    }
}

