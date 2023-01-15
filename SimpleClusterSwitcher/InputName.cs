using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleClusterSwitcher
{
    public partial class InputName : Form
    {
        public string path;
        public bool success = false;
        public InputName(string str)
        {
            InitializeComponent();
            textBox1.Text = str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] invalidChars = Path.GetInvalidFileNameChars();
            if (!(textBox1.Text.IndexOfAny(invalidChars) >= 0) && 0 < textBox1.Text.Length && textBox1.Text.Length < 31)
            {
                path = textBox1.Text;
                success = true;
                this.Close();
            }
            else
            {
                DialogResult result = MessageBox.Show("ファイル名に使えない文字が含まれているか文字数が30を超えています", "確認", MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
