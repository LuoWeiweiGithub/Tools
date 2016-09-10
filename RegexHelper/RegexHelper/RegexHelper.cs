using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Threading;

namespace RegexHelper
{
    public partial class RegexHelper : Form
    {
        private readonly string _regexFilePath;
        private const string SplitterDistance = "SplitterDistance";
        private const string Size = "Size";
        public RegexHelper()
        {
            InitializeComponent();
            _regexFilePath = AppSettingHelper.GetString("SaveRegexPath", string.Empty);
            if (string.IsNullOrWhiteSpace(_regexFilePath))
            {
                _regexFilePath = "Regex.txt";
            }

            //int splitterDistance = AppSettingHelper.GetInteger(SplitterDistance, splitContainer.SplitterDistance);
            //if (splitterDistance > 100 && splitterDistance < splitContainer.Width - 100)
            //    splitContainer.SplitterDistance = splitterDistance;
        }

        private void btnMatch_Click(object sender, EventArgs e)
        {
            string matchRegexStr = txtMatch.Text;
            string inputStr = rtxInput.Text;

            if (string.IsNullOrEmpty(matchRegexStr) || string.IsNullOrEmpty(inputStr))
                return;

            try
            {
                StringBuilder result = new StringBuilder();
                Regex regex = new Regex(matchRegexStr);
                MatchCollection matchs = regex.Matches(inputStr);
                foreach (Match match in matchs)
                {
                    result.AppendLine(match.Value);
                }
                rtxOutput.Text = result.ToString();
            }
            catch (Exception ex)
            {
                rtxOutput.Text = ex.ToString();
            }
        }

        private readonly Color _changedColor = Color.FromArgb(255, 192, 192);
        private void TextBoxTextChanged(object sender, EventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(txtBox.Text))
                txtBox.BackColor = Color.White;
            else
                txtBox.BackColor = _changedColor;
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            string matchRegexStr = txtMatch.Text;
            string inputStr = rtxInput.Text;
            string replaceRegexStr = txtReplace.Text;

            if (string.IsNullOrEmpty(matchRegexStr) || string.IsNullOrEmpty(inputStr) || string.IsNullOrEmpty(replaceRegexStr))
                return;

            try
            {
                StringBuilder result = new StringBuilder();
                Regex regex = new Regex(matchRegexStr);
                rtxOutput.Text = regex.Replace(inputStr, replaceRegexStr);
            }
            catch (Exception ex)
            {
                rtxOutput.Text = ex.ToString();
            }
        }

        private void KeyDown(object sender, KeyEventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            if (txtBox == null || string.IsNullOrWhiteSpace(txtBox.Text))
                return;

            if ((e.KeyData == (Keys.S | Keys.Control)))
            {
                AppendFile(_regexFilePath, txtBox.Text);
                txtBox.BackColor = Color.White;
            }
        }

        private void AppendFile(string filePath, string txt)
        {
            if (string.IsNullOrEmpty(filePath) || string.IsNullOrEmpty(txt))
                return;
            
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine(txt);
            }
        }

        private void splitContainer_SplitterMoved(object sender, SplitterEventArgs e)
        {
            AppSettingHelper.SetValue(SplitterDistance, splitContainer.SplitterDistance.ToString());
        }
    }
}
