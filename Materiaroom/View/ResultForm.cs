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
    public partial class ResultForm : Form
    {
        private string _stdOut;
        private string _stdErrOut;

        public ResultForm(string stdOut, string stdErrOut)
        {
            _stdOut = stdOut;
            _stdErrOut = stdErrOut;

            InitializeComponent();
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            textBoxStdOut.Text = _stdOut;
            textBoxStdErrOut.Text = _stdErrOut;
        }

        private void ResultForm_Shown(object sender, EventArgs e)
        {
            textBoxStdOut.Focus();
            textBoxStdOut.SelectionStart = textBoxStdOut.Text.Length;
            textBoxStdOut.ScrollToCaret();

            textBoxStdErrOut.Focus();
            textBoxStdErrOut.SelectionStart = textBoxStdErrOut.Text.Length;
            textBoxStdErrOut.ScrollToCaret();

            buttonOk.Focus();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
