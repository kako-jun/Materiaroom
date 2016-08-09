using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Materiaroom
{
    public partial class SettingForm : Form
    {
        private Setting _setting;
        private Setting.Kind _kind;

        public SettingForm(Setting setting, Setting.Kind kind)
        {
            _setting = setting;
            _kind = kind;

            InitializeComponent();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            switch (_kind)
            {
                case Setting.Kind.Exif:
                    textBoxDirPath.Text = _setting.exifPath;
                    break;

                case Setting.Kind.Dir:
                    textBoxDirPath.Text = _setting.dirPath;
                    break;

                case Setting.Kind.Tool:
                    labelDirPath.Text = Materiaroom.Properties.Resources.toolPath + " :";
                    textBoxDirPath.Text = _setting.toolPath;
                    break;
                default:
                    break;
            }

            this.updateControls();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            switch (_kind)
            {
                case Setting.Kind.Exif:
                    _setting.exifPath = textBoxDirPath.Text;
                    break;

                case Setting.Kind.Dir:
                    _setting.dirPath = textBoxDirPath.Text;
                    break;

                case Setting.Kind.Tool:
                    _setting.toolPath = textBoxDirPath.Text;
                    break;
                default:
                    break;
            }

            _setting.save();
        }

        private void textBoxDirPath_TextChanged(object sender, EventArgs e)
        {
            this.updateControls();
        }

        private void buttonDirPath_Click(object sender, EventArgs e)
        {
            switch (_kind)
            {
                case Setting.Kind.Exif:
                case Setting.Kind.Dir:
                    {
                        FolderBrowserDialog dlg = new FolderBrowserDialog();
                        if (dlg.ShowDialog(this) == DialogResult.OK)
                        {
                            string dirPath = dlg.SelectedPath;
                            string dirPathSlash = dirPath.Replace(@"\", "/");

                            textBoxDirPath.Text = dirPathSlash;
                        }
                        break;
                    }
                case Setting.Kind.Tool:
                    {
                        OpenFileDialog dlg = new OpenFileDialog();
                        if (dlg.ShowDialog(this) == DialogResult.OK)
                        {
                            string filePath = dlg.FileName;
                            string filePathSlash = filePath.Replace(@"\", "/");

                            textBoxDirPath.Text = filePathSlash;
                        }
                        break;
                    }
                default:
                    break;
            }
        }

        private void updateControls()
        {
            if (textBoxDirPath.Text == "")
            {
                buttonOk.Enabled = false;
            }
            else
            {
                buttonOk.Enabled = true;
            }
        }
    }
}
