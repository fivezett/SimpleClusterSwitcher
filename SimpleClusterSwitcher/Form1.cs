using Microsoft.Win32;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace SimpleClusterSwitcher
{
    public partial class Form1 : Form
    {
        private string word = "5ZWarehouse_SCS_Account_";
        public Form1()
        {
            InitializeComponent();
            reload();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (accountList.SelectedIndex == -1)
                return;
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Cluster, Inc.\cluster", true);
            if (key != null)
            {
                key.DeleteValue(word + accountList.SelectedItem.ToString());
                key.Close();
                reload();
            }

        }

        private void addAccountBtn_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Cluster, Inc.\cluster");
            if (key != null)
            {
                try
                {
                    // 値を取得
                    byte[] st = (byte[])key.GetValue("FirebaseCredential_h2643998819");
                    string value = Encoding.ASCII.GetString(st);
                    Debug.WriteLine(value);

                    var nameForm = new InputName("");
                    nameForm.ShowDialog();
                    if (!nameForm.success)
                        return;
                    string name = nameForm.path;
                    key.Close();
                    var writeKey = Registry.CurrentUser.CreateSubKey(@"Software\Cluster, Inc.\cluster");
                    writeKey.SetValue("5ZWarehouse_SCS_Account_" + name, st);
                    writeKey.Close();
                    reload();
                    MessageBox.Show("アカウントを追加しました", "確認", MessageBoxButtons.OK);
                }
                catch (Exception ee)
                {
                    MessageBox.Show("失敗しました", "確認", MessageBoxButtons.OK);
                }
            }
        }

        public void reload()
        {
            var ans = new List<string>();
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Cluster, Inc.\cluster");
            foreach (var k in key.GetValueNames())
            {
                if (k.IndexOf(word) == 0)
                    ans.Add(k.Substring(word.Length));
            }
            key.Close();
            accountList.Items.Clear();
            accountList.Items.AddRange(ans.ToArray());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (InitMG.isClusterRunning())
            {
                MessageBox.Show("Clusterが起動しています。終了してから実行してください。", "エラー", MessageBoxButtons.OK);
                return;
            }
            var msg = MessageBox.Show("ログアウトしますか？", "確認", MessageBoxButtons.OKCancel);
            if (msg == DialogResult.OK)
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Cluster, Inc.\cluster", true);
                if (key != null)
                {
                    key.DeleteValue("FirebaseCredential_h2643998819");
                    key.Close();
                }
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            renameBtn.Enabled = checkBox1.Checked;
            delBtn.Enabled = checkBox1.Checked;
        }

        private void launchBtn_Click(object sender, EventArgs e)
        {
            string path = InitMG.getPath();
            if (path.Length == 0)
                return;
            Process.Start(path);
        }

        private void renameBtn_Click(object sender, EventArgs e)
        {
            if (accountList.SelectedIndex == -1)
                return;
            var nameForm = new InputName(accountList.SelectedItem.ToString());
            nameForm.ShowDialog();
            if (!nameForm.success)
                return;
            string name = word + nameForm.path;
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Cluster, Inc.\cluster", true);
            key.SetValue(name, key.GetValue(word + accountList.SelectedItem.ToString()));
            key.DeleteValue(word + accountList.SelectedItem.ToString());
            key.Close();
            reload();
        }

        private void changeAccBtn_Click(object sender, EventArgs e)
        {
            if (accountList.SelectedIndex == -1)
                return;
            if (InitMG.isClusterRunning())
            {
                MessageBox.Show("Clusterが起動しています。終了してから実行してください。", "エラー", MessageBoxButtons.OK);
                return;
            }
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Cluster, Inc.\cluster", true);
            key.SetValue("FirebaseCredential_h2643998819", key.GetValue(word + accountList.SelectedItem.ToString()));
            key.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (accountList.SelectedIndex == -1)
                return;
            if (InitMG.isClusterRunning())
            {
                MessageBox.Show("Clusterが起動しています。終了してから実行してください。", "エラー", MessageBoxButtons.OK);
                return;
            }
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Cluster, Inc.\cluster", true);
            key.SetValue("FirebaseCredential_h2643998819", key.GetValue(word + accountList.SelectedItem.ToString()));
            key.Close();
            launchBtn_Click(sender, e);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (!InitMG.init())
            {
                Application.Exit();
            }
        }
    }
}