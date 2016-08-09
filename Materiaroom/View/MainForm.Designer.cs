namespace Materiaroom
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonOk = new System.Windows.Forms.Button();
            this.groupBoxExif = new System.Windows.Forms.GroupBox();
            this.comboBoxExif = new System.Windows.Forms.ComboBox();
            this.labelExif = new System.Windows.Forms.Label();
            this.buttonAddExif = new System.Windows.Forms.Button();
            this.groupBoxDir = new System.Windows.Forms.GroupBox();
            this.comboBoxDir = new System.Windows.Forms.ComboBox();
            this.labelDir = new System.Windows.Forms.Label();
            this.buttonAddDir = new System.Windows.Forms.Button();
            this.groupBoxTool = new System.Windows.Forms.GroupBox();
            this.labelTool = new System.Windows.Forms.Label();
            this.groupBoxSrc = new System.Windows.Forms.GroupBox();
            this.comboBoxSrc = new System.Windows.Forms.ComboBox();
            this.buttonAddSrc = new System.Windows.Forms.Button();
            this.buttonExif = new System.Windows.Forms.Button();
            this.buttonDir = new System.Windows.Forms.Button();
            this.buttonTool = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExifSetting = new System.Windows.Forms.Button();
            this.buttonDirSetting = new System.Windows.Forms.Button();
            this.buttonToolSetting = new System.Windows.Forms.Button();
            this.groupBoxExif.SuspendLayout();
            this.groupBoxDir.SuspendLayout();
            this.groupBoxTool.SuspendLayout();
            this.groupBoxSrc.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            resources.ApplyResources(this.buttonOk, "buttonOk");
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // groupBoxExif
            // 
            this.groupBoxExif.Controls.Add(this.comboBoxExif);
            this.groupBoxExif.Controls.Add(this.labelExif);
            this.groupBoxExif.Controls.Add(this.buttonAddExif);
            resources.ApplyResources(this.groupBoxExif, "groupBoxExif");
            this.groupBoxExif.Name = "groupBoxExif";
            this.groupBoxExif.TabStop = false;
            // 
            // comboBoxExif
            // 
            this.comboBoxExif.AllowDrop = true;
            this.comboBoxExif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExif.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxExif, "comboBoxExif");
            this.comboBoxExif.Name = "comboBoxExif";
            this.comboBoxExif.SelectionChangeCommitted += new System.EventHandler(this.comboBoxExif_SelectionChangeCommitted);
            this.comboBoxExif.DragDrop += new System.Windows.Forms.DragEventHandler(this.comboBoxExif_DragDrop);
            this.comboBoxExif.DragEnter += new System.Windows.Forms.DragEventHandler(this.comboBoxExif_DragEnter);
            this.comboBoxExif.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxExif_KeyDown);
            // 
            // labelExif
            // 
            resources.ApplyResources(this.labelExif, "labelExif");
            this.labelExif.Name = "labelExif";
            // 
            // buttonAddExif
            // 
            resources.ApplyResources(this.buttonAddExif, "buttonAddExif");
            this.buttonAddExif.Name = "buttonAddExif";
            this.buttonAddExif.UseVisualStyleBackColor = true;
            this.buttonAddExif.Click += new System.EventHandler(this.buttonAddExif_Click);
            // 
            // groupBoxDir
            // 
            this.groupBoxDir.Controls.Add(this.comboBoxDir);
            this.groupBoxDir.Controls.Add(this.labelDir);
            this.groupBoxDir.Controls.Add(this.buttonAddDir);
            resources.ApplyResources(this.groupBoxDir, "groupBoxDir");
            this.groupBoxDir.Name = "groupBoxDir";
            this.groupBoxDir.TabStop = false;
            // 
            // comboBoxDir
            // 
            this.comboBoxDir.AllowDrop = true;
            this.comboBoxDir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDir.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxDir, "comboBoxDir");
            this.comboBoxDir.Name = "comboBoxDir";
            this.comboBoxDir.SelectionChangeCommitted += new System.EventHandler(this.comboBoxDir_SelectionChangeCommitted);
            this.comboBoxDir.DragDrop += new System.Windows.Forms.DragEventHandler(this.comboBoxDir_DragDrop);
            this.comboBoxDir.DragEnter += new System.Windows.Forms.DragEventHandler(this.comboBoxDir_DragEnter);
            this.comboBoxDir.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxDir_KeyDown);
            // 
            // labelDir
            // 
            resources.ApplyResources(this.labelDir, "labelDir");
            this.labelDir.Name = "labelDir";
            // 
            // buttonAddDir
            // 
            resources.ApplyResources(this.buttonAddDir, "buttonAddDir");
            this.buttonAddDir.Name = "buttonAddDir";
            this.buttonAddDir.UseVisualStyleBackColor = true;
            this.buttonAddDir.Click += new System.EventHandler(this.buttonAddDir_Click);
            // 
            // groupBoxTool
            // 
            this.groupBoxTool.Controls.Add(this.labelTool);
            resources.ApplyResources(this.groupBoxTool, "groupBoxTool");
            this.groupBoxTool.Name = "groupBoxTool";
            this.groupBoxTool.TabStop = false;
            // 
            // labelTool
            // 
            resources.ApplyResources(this.labelTool, "labelTool");
            this.labelTool.Name = "labelTool";
            // 
            // groupBoxSrc
            // 
            this.groupBoxSrc.Controls.Add(this.comboBoxSrc);
            this.groupBoxSrc.Controls.Add(this.buttonAddSrc);
            resources.ApplyResources(this.groupBoxSrc, "groupBoxSrc");
            this.groupBoxSrc.Name = "groupBoxSrc";
            this.groupBoxSrc.TabStop = false;
            // 
            // comboBoxSrc
            // 
            this.comboBoxSrc.AllowDrop = true;
            this.comboBoxSrc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSrc.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxSrc, "comboBoxSrc");
            this.comboBoxSrc.Name = "comboBoxSrc";
            this.comboBoxSrc.SelectionChangeCommitted += new System.EventHandler(this.comboBoxSrc_SelectionChangeCommitted);
            this.comboBoxSrc.DragDrop += new System.Windows.Forms.DragEventHandler(this.comboBoxSrc_DragDrop);
            this.comboBoxSrc.DragEnter += new System.Windows.Forms.DragEventHandler(this.comboBoxSrc_DragEnter);
            this.comboBoxSrc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxSrc_KeyDown);
            // 
            // buttonAddSrc
            // 
            resources.ApplyResources(this.buttonAddSrc, "buttonAddSrc");
            this.buttonAddSrc.Name = "buttonAddSrc";
            this.buttonAddSrc.UseVisualStyleBackColor = true;
            this.buttonAddSrc.Click += new System.EventHandler(this.buttonAddSrc_Click);
            // 
            // buttonExif
            // 
            resources.ApplyResources(this.buttonExif, "buttonExif");
            this.buttonExif.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonExif.Name = "buttonExif";
            this.buttonExif.UseVisualStyleBackColor = true;
            this.buttonExif.Click += new System.EventHandler(this.buttonExif_Click);
            // 
            // buttonDir
            // 
            resources.ApplyResources(this.buttonDir, "buttonDir");
            this.buttonDir.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDir.Name = "buttonDir";
            this.buttonDir.UseVisualStyleBackColor = true;
            this.buttonDir.Click += new System.EventHandler(this.buttonDir_Click);
            // 
            // buttonTool
            // 
            resources.ApplyResources(this.buttonTool, "buttonTool");
            this.buttonTool.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonTool.Name = "buttonTool";
            this.buttonTool.UseVisualStyleBackColor = true;
            this.buttonTool.Click += new System.EventHandler(this.buttonTool_Click);
            // 
            // buttonClear
            // 
            resources.ApplyResources(this.buttonClear, "buttonClear");
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExifSetting
            // 
            resources.ApplyResources(this.buttonExifSetting, "buttonExifSetting");
            this.buttonExifSetting.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonExifSetting.Name = "buttonExifSetting";
            this.buttonExifSetting.UseVisualStyleBackColor = true;
            this.buttonExifSetting.Click += new System.EventHandler(this.buttonExifSetting_Click);
            // 
            // buttonDirSetting
            // 
            resources.ApplyResources(this.buttonDirSetting, "buttonDirSetting");
            this.buttonDirSetting.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDirSetting.Name = "buttonDirSetting";
            this.buttonDirSetting.UseVisualStyleBackColor = true;
            this.buttonDirSetting.Click += new System.EventHandler(this.buttonDirSetting_Click);
            // 
            // buttonToolSetting
            // 
            resources.ApplyResources(this.buttonToolSetting, "buttonToolSetting");
            this.buttonToolSetting.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonToolSetting.Name = "buttonToolSetting";
            this.buttonToolSetting.UseVisualStyleBackColor = true;
            this.buttonToolSetting.Click += new System.EventHandler(this.buttonToolSetting_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonToolSetting);
            this.Controls.Add(this.buttonDirSetting);
            this.Controls.Add(this.buttonExifSetting);
            this.Controls.Add(this.buttonTool);
            this.Controls.Add(this.buttonDir);
            this.Controls.Add(this.buttonExif);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.groupBoxSrc);
            this.Controls.Add(this.groupBoxTool);
            this.Controls.Add(this.groupBoxDir);
            this.Controls.Add(this.groupBoxExif);
            this.Controls.Add(this.buttonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxExif.ResumeLayout(false);
            this.groupBoxExif.PerformLayout();
            this.groupBoxDir.ResumeLayout(false);
            this.groupBoxDir.PerformLayout();
            this.groupBoxTool.ResumeLayout(false);
            this.groupBoxTool.PerformLayout();
            this.groupBoxSrc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.GroupBox groupBoxExif;
        private System.Windows.Forms.Button buttonAddExif;
        private System.Windows.Forms.ComboBox comboBoxExif;
        private System.Windows.Forms.Label labelExif;
        private System.Windows.Forms.GroupBox groupBoxDir;
        private System.Windows.Forms.ComboBox comboBoxDir;
        private System.Windows.Forms.Label labelDir;
        private System.Windows.Forms.Button buttonAddDir;
        private System.Windows.Forms.GroupBox groupBoxTool;
        private System.Windows.Forms.Label labelTool;
        private System.Windows.Forms.GroupBox groupBoxSrc;
        private System.Windows.Forms.ComboBox comboBoxSrc;
        private System.Windows.Forms.Button buttonAddSrc;
        private System.Windows.Forms.Button buttonExif;
        private System.Windows.Forms.Button buttonDir;
        private System.Windows.Forms.Button buttonTool;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExifSetting;
        private System.Windows.Forms.Button buttonDirSetting;
        private System.Windows.Forms.Button buttonToolSetting;
    }
}

