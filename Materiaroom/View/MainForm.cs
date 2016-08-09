using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Materiaroom
{
    public partial class MainForm : Form
    {
        private Setting _setting;

        private Dictionary<string, string> _srcs;
        private Dictionary<string, string> _exifs;
        private Dictionary<string, string> _dirs;
        private int _defaultHeight;

        public MainForm()
        {
            _setting = new Setting();
            _setting.load();

            _srcs = new Dictionary<string, string>();
            _exifs = new Dictionary<string, string>();
            _dirs = new Dictionary<string, string>();
            _defaultHeight = 0;

            InitializeComponent();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_setting != null)
            {
                _setting.save();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBoxSrc.DataSource = _srcs.Values.ToArray();
            comboBoxExif.DataSource = _exifs.Values.ToArray();
            comboBoxDir.DataSource = _dirs.Values.ToArray();

            _defaultHeight = comboBoxSrc.DropDownHeight;

            this.updateControls();

            // 
            string[] args;
            args = System.Environment.GetCommandLineArgs();

            if (args.Length > 1)
            {
                for (int i = 1; i < args.Length; i++)
                {
                    string filePath = args[i];

                    string dirPath = "";
                    if (System.IO.Directory.Exists(filePath))
                    {
                        dirPath = filePath;
                    }
                    else
                    {
                        dirPath = System.IO.Path.GetDirectoryName(filePath);
                    }

                    string dirPathSlash = dirPath.Replace(@"\", "/");

                    System.IO.FileInfo fi = new System.IO.FileInfo(dirPathSlash);
                    _srcs[dirPathSlash] = fi.Name;
                }

                this.updateControls();
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddSrc_Click(object sender, EventArgs e)
        {
            this.openDlgAndAddFiles(_srcs);

            this.updateControls();
        }

        private void comboBoxSrc_DragEnter(object sender, DragEventArgs e)
        {
            this.allowOnlyFile(e);
        }

        private void comboBoxSrc_DragDrop(object sender, DragEventArgs e)
        {
            this.dropAndAddFiles(e, _srcs);

            this.updateControls();
        }

        private void comboBoxSrc_KeyDown(object sender, KeyEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            if (comboBox.Items.Count > 0)
            {
                string fileName = (string)comboBox.SelectedValue;

                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        this.openFile(_srcs, fileName);
                        break;

                    case Keys.Delete:
                        this.removeFile(_srcs, fileName);
                        break;

                    default:
                        break;
                }
            }
        }

        private void comboBoxSrc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            if (comboBox.Items.Count > 0)
            {
                string fileName = (string)comboBox.SelectedValue;

                this.openFile(_srcs, fileName);
            }

            this.updateControls();
        }

        private void buttonAddExif_Click(object sender, EventArgs e)
        {
            this.openDlgAndAddFiles(_exifs);

            this.updateControls();
        }

        private void comboBoxExif_DragEnter(object sender, DragEventArgs e)
        {
            this.allowOnlyFile(e);
        }

        private void comboBoxExif_DragDrop(object sender, DragEventArgs e)
        {
            this.dropAndAddFiles(e, _exifs);

            this.updateControls();
        }

        private void comboBoxExif_KeyDown(object sender, KeyEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            if (comboBox.Items.Count > 0)
            {
                string fileName = (string)comboBox.SelectedValue;

                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        this.openFile(_exifs, fileName);
                        break;

                    case Keys.Delete:
                        this.removeFile(_exifs, fileName);
                        break;

                    default:
                        break;
                }
            }
        }

        private void comboBoxExif_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            if (comboBox.Items.Count > 0)
            {
                string fileName = (string)comboBox.SelectedValue;

                this.openFile(_exifs, fileName);
            }

            this.updateControls();
        }

        private void buttonAddDir_Click(object sender, EventArgs e)
        {
            this.openDlgAndAddFiles(_dirs);

            this.updateControls();
        }

        private void comboBoxDir_DragEnter(object sender, DragEventArgs e)
        {
            this.allowOnlyFile(e);
        }

        private void comboBoxDir_DragDrop(object sender, DragEventArgs e)
        {
            this.dropAndAddFiles(e, _dirs);

            this.updateControls();
        }

        private void comboBoxDir_KeyDown(object sender, KeyEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            if (comboBox.Items.Count > 0)
            {
                string fileName = (string)comboBox.SelectedValue;

                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        this.openFile(_dirs, fileName);
                        break;

                    case Keys.Delete:
                        this.removeFile(_dirs, fileName);
                        break;

                    default:
                        break;
                }
            }
        }

        private void comboBoxDir_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            if (comboBox.Items.Count > 0)
            {
                string fileName = (string)comboBox.SelectedValue;

                this.openFile(_dirs, fileName);
            }

            this.updateControls();
        }

        private void buttonExifSetting_Click(object sender, EventArgs e)
        {
            SettingForm form = new SettingForm(_setting, Setting.Kind.Exif);
            form.ShowDialog(this);

            this.updateControls();
        }

        private void buttonDirSetting_Click(object sender, EventArgs e)
        {
            SettingForm form = new SettingForm(_setting, Setting.Kind.Dir);
            form.ShowDialog(this);

            this.updateControls();
        }

        private void buttonToolSetting_Click(object sender, EventArgs e)
        {
            SettingForm form = new SettingForm(_setting, Setting.Kind.Tool);
            form.ShowDialog(this);

            this.updateControls();
        }

        private void buttonExif_Click(object sender, EventArgs e)
        {
            // 
            try
            {
                System.Diagnostics.Process.Start(_setting.exifPath);
            }
            catch (Exception)
            {
            }

            _exifs.Clear();

            foreach (KeyValuePair<string, string> pair in _srcs)
            {
                string dstDirPath = pair.Key;
                if (_setting.exifPath != "")
                {
                    dstDirPath = _setting.exifPath;
                }

                string dstDirPathSlash = dstDirPath.Replace(@"\", "/");

                string exe = "rename_by_exif.exe";
                string arg = "\"" + pair.Key + "\" \"" + dstDirPath + "\"";

                this.runScript(exe, arg);

                System.IO.FileInfo fi = new System.IO.FileInfo(dstDirPathSlash);
                _exifs[dstDirPathSlash] = fi.Name;

                _setting.level++;
            }

            this.updateControls();
        }

        private void buttonDir_Click(object sender, EventArgs e)
        {
            // 
            try
            {
                System.Diagnostics.Process.Start(_setting.dirPath);
            }
            catch (Exception)
            {
            }

            _dirs.Clear();

            foreach (KeyValuePair<string, string> pair in _exifs)
            {
                string dstDirPath = pair.Key;
                if (_setting.dirPath != "")
                {
                    dstDirPath = _setting.dirPath;
                }

                string dstDirPathSlash = dstDirPath.Replace(@"\", "/");

                string exe = "sort_photos_to_date_dirs.exe";
                string arg = "\"" + pair.Key + "\" \"" + dstDirPath + "\"";

                this.runScript(exe, arg);

                System.IO.FileInfo fi = new System.IO.FileInfo(dstDirPathSlash);
                _dirs[dstDirPathSlash] = fi.Name;

                _setting.level++;
            }

            this.updateControls();
        }

        private void buttonTool_Click(object sender, EventArgs e)
        {
            string toolPath = _setting.toolPath;
            if (toolPath == "")
            {
                return;
            }

            string toolPathSlash = toolPath.Replace(@"\", "/");

            string arg = "";
            foreach (KeyValuePair<string, string> pair in _dirs)
            {
                arg += "\"" + pair.Key + "\" ";
            }

            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = toolPath;
            p.StartInfo.Arguments = arg;
            p.StartInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(toolPath);
            //p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Minimized;
            //p.StartInfo.CreateNoWindow = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            try
            {
                p.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            _setting.level++;

            this.updateControls();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            _srcs.Clear();
            _exifs.Clear();
            _dirs.Clear();

            this.updateControls();
        }

        private void openDlgAndAddFiles(Dictionary<string, string> dic)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                string dirPath = dlg.SelectedPath;
                string dirPathSlash = dirPath.Replace(@"\", "/");

                System.IO.FileInfo fi = new System.IO.FileInfo(dirPathSlash);
                dic[dirPathSlash] = fi.Name;
            }
        }

        private void allowOnlyFile(DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void dropAndAddFiles(DragEventArgs e, Dictionary<string, string> dic)
        {
            string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            foreach (string filePath in filePaths)
            {
                string dirPath = "";
                if (System.IO.Directory.Exists(filePath))
                {
                    dirPath = filePath;
                }
                else
                {
                    dirPath = System.IO.Path.GetDirectoryName(filePath);
                }

                string dirPathSlash = dirPath.Replace(@"\", "/");

                System.IO.FileInfo fi = new System.IO.FileInfo(dirPathSlash);
                dic[dirPathSlash] = fi.Name;
            }
        }

        private void openFile(Dictionary<string, string> dic, string dirName)
        {
            foreach (KeyValuePair<string, string> pair in dic)
            {
                if (pair.Value == dirName)
                {
                    try
                    {
                        System.Diagnostics.Process.Start(pair.Key);
                    }
                    catch (Exception)
                    {
                    }
                    break;
                }
            }
        }

        private void removeFile(Dictionary<string, string> dic, string dirName)
        {
            foreach (KeyValuePair<string, string> pair in dic)
            {
                if (pair.Value == dirName)
                {
                    dic.Remove(pair.Key);
                    break;
                }
            }
        }

        private void runScript(string exe, string arg)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "cmd";
            p.StartInfo.Arguments = "/C " + exe + " " + arg;
            p.StartInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            //p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Minimized;
            //p.StartInfo.CreateNoWindow = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = false;
            p.StartInfo.RedirectStandardOutput = false;
            p.StartInfo.RedirectStandardError = false;
            try
            {
                p.Start();
                p.WaitForExit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            //string stdOut = p.StandardOutput.ReadToEnd();
            //string stdErrOut = p.StandardError.ReadToEnd();

            //if (stdOut != "" || stdErrOut != "")
            //{
            //    ResultForm form = new ResultForm(stdOut, stdErrOut);
            //    form.ShowDialog(this);
            //}
        }

        private void updateControls()
        {
            comboBoxSrc.DataSource = null;
            comboBoxSrc.DataSource = _srcs.Values.ToArray();
            comboBoxSrc.DropDownHeight = _defaultHeight;

            comboBoxExif.DataSource = null;
            comboBoxExif.DataSource = _exifs.Values.ToArray();
            comboBoxExif.DropDownHeight = _defaultHeight;

            comboBoxDir.DataSource = null;
            comboBoxDir.DataSource = _dirs.Values.ToArray();
            comboBoxDir.DropDownHeight = _defaultHeight;

            if (comboBoxSrc.Items.Count > 0)
            {
                if (_setting.exifPath != "")
                {
                    buttonExif.Enabled = true;
                }
                else
                {
                    buttonExif.Enabled = false;
                }
            }
            else
            {
                buttonExif.Enabled = false;
            }

            if (comboBoxExif.Items.Count > 0)
            {
                if (_setting.dirPath != "")
                {
                    buttonDir.Enabled = true;
                }
                else
                {
                    buttonDir.Enabled = false;
                }
            }
            else
            {
                buttonDir.Enabled = false;
            }

            if (comboBoxDir.Items.Count > 0)
            {
                if (_setting.toolPath != "")
                {
                    buttonTool.Enabled = true;
                }
                else
                {
                    buttonTool.Enabled = false;
                }
            }
            else
            {
                buttonTool.Enabled = false;
            }
        }
    }
}
