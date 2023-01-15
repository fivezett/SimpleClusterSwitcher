using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SimpleClusterSwitcher
{
    internal class InitMG
    {
        public static bool init()
        {
            if (!(File.Exists("path.txt") && File.Exists(File.ReadAllText("path.txt").Trim())))
            {
                string path = getClusterPath();
                if (path.Length == 0)
                {
                    return false;
                }
                File.WriteAllText("path.txt", path);
                return true;
            }
            return true;
        }

        public static string getPath()
        {
            if (!init()) return "";
            return File.ReadAllText("path.txt").Trim();
        }

        public static string getClusterPath()
        {
            while (true)
            {
                DialogResult result = MessageBox.Show("clusterの実行ファイルが見つかりませんでした\r\nclusterが起動した状態ではいを押してください\r\nいいえで終了します", "確認", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return "";
                }   

                Process[] processes = Process.GetProcesses();
                foreach (Process process in processes)
                {
                    string processName = process.ProcessName;
                    if (processName.IndexOf("cluster") == 0)
                    {
                        Debug.WriteLine(processName);
                        string processPath = process.MainModule.FileName;
                        DialogResult result2 = MessageBox.Show(processPath + "\r\nが見つかりました。これがclusterの実行ファイルでよろしいですか？", "確認", MessageBoxButtons.YesNo);
                        if (result2 == DialogResult.Yes)
                            return processPath;
                    }
                }
            }
        }

        public static bool isClusterRunning()
        {
            string path = getPath();
            Process[] processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                try
                {
                    if (process.ProcessName.Equals("cluster", StringComparison.OrdinalIgnoreCase))
                    {
                        if (process.MainModule.FileName.Equals(path))
                            return true;
                    }
                }
                catch (Exception e)
                {

                }
            }
            return false;
        }
    }
}