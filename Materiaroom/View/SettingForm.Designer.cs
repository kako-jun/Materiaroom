namespace Materiaroom
{
    partial class SettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelDirPath = new System.Windows.Forms.Label();
            this.textBoxDirPath = new System.Windows.Forms.TextBox();
            this.buttonDirPath = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            resources.ApplyResources(this.buttonOk, "buttonOk");
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelDirPath
            // 
            resources.ApplyResources(this.labelDirPath, "labelDirPath");
            this.labelDirPath.Name = "labelDirPath";
            // 
            // textBoxDirPath
            // 
            resources.ApplyResources(this.textBoxDirPath, "textBoxDirPath");
            this.textBoxDirPath.Name = "textBoxDirPath";
            this.textBoxDirPath.TextChanged += new System.EventHandler(this.textBoxDirPath_TextChanged);
            // 
            // buttonDirPath
            // 
            resources.ApplyResources(this.buttonDirPath, "buttonDirPath");
            this.buttonDirPath.Name = "buttonDirPath";
            this.buttonDirPath.UseVisualStyleBackColor = true;
            this.buttonDirPath.Click += new System.EventHandler(this.buttonDirPath_Click);
            // 
            // buttonCancel
            // 
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // SettingForm
            // 
            this.AcceptButton = this.buttonOk;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDirPath);
            this.Controls.Add(this.textBoxDirPath);
            this.Controls.Add(this.labelDirPath);
            this.Controls.Add(this.buttonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingForm";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelDirPath;
        private System.Windows.Forms.TextBox textBoxDirPath;
        private System.Windows.Forms.Button buttonDirPath;
        private System.Windows.Forms.Button buttonCancel;
    }
}