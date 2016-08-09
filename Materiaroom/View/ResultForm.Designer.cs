namespace Materiaroom
{
    partial class ResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultForm));
            this.textBoxStdOut = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.textBoxStdErrOut = new System.Windows.Forms.TextBox();
            this.labelStdOut = new System.Windows.Forms.Label();
            this.labelStdErrOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxStdOut
            // 
            resources.ApplyResources(this.textBoxStdOut, "textBoxStdOut");
            this.textBoxStdOut.Name = "textBoxStdOut";
            this.textBoxStdOut.ReadOnly = true;
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.buttonOk, "buttonOk");
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // textBoxStdErrOut
            // 
            resources.ApplyResources(this.textBoxStdErrOut, "textBoxStdErrOut");
            this.textBoxStdErrOut.Name = "textBoxStdErrOut";
            this.textBoxStdErrOut.ReadOnly = true;
            // 
            // labelStdOut
            // 
            resources.ApplyResources(this.labelStdOut, "labelStdOut");
            this.labelStdOut.Name = "labelStdOut";
            // 
            // labelStdErrOut
            // 
            resources.ApplyResources(this.labelStdErrOut, "labelStdErrOut");
            this.labelStdErrOut.Name = "labelStdErrOut";
            // 
            // ResultForm
            // 
            this.AcceptButton = this.buttonOk;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelStdErrOut);
            this.Controls.Add(this.labelStdOut);
            this.Controls.Add(this.textBoxStdErrOut);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxStdOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ResultForm";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.ResultForm_Load);
            this.Shown += new System.EventHandler(this.ResultForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStdOut;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TextBox textBoxStdErrOut;
        private System.Windows.Forms.Label labelStdOut;
        private System.Windows.Forms.Label labelStdErrOut;
    }
}