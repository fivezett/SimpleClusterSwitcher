namespace SimpleClusterSwitcher
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.accountList = new System.Windows.Forms.ListBox();
            this.delBtn = new System.Windows.Forms.Button();
            this.renameBtn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.launchBtn = new System.Windows.Forms.Button();
            this.changeAccBtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accountList
            // 
            this.accountList.FormattingEnabled = true;
            this.accountList.ItemHeight = 15;
            this.accountList.Location = new System.Drawing.Point(12, 41);
            this.accountList.Name = "accountList";
            this.accountList.Size = new System.Drawing.Size(255, 289);
            this.accountList.TabIndex = 0;
            // 
            // delBtn
            // 
            this.delBtn.Enabled = false;
            this.delBtn.Location = new System.Drawing.Point(12, 448);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(123, 23);
            this.delBtn.TabIndex = 1;
            this.delBtn.Text = "削除";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // renameBtn
            // 
            this.renameBtn.Enabled = false;
            this.renameBtn.Location = new System.Drawing.Point(144, 448);
            this.renameBtn.Name = "renameBtn";
            this.renameBtn.Size = new System.Drawing.Size(123, 23);
            this.renameBtn.TabIndex = 2;
            this.renameBtn.Text = "名前を変更";
            this.renameBtn.UseVisualStyleBackColor = true;
            this.renameBtn.Click += new System.EventHandler(this.renameBtn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 423);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 19);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "削除・変更を許可";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // launchBtn
            // 
            this.launchBtn.Location = new System.Drawing.Point(12, 365);
            this.launchBtn.Name = "launchBtn";
            this.launchBtn.Size = new System.Drawing.Size(255, 23);
            this.launchBtn.TabIndex = 5;
            this.launchBtn.Text = "起動";
            this.launchBtn.UseVisualStyleBackColor = true;
            this.launchBtn.Click += new System.EventHandler(this.launchBtn_Click);
            // 
            // changeAccBtn
            // 
            this.changeAccBtn.Location = new System.Drawing.Point(12, 336);
            this.changeAccBtn.Name = "changeAccBtn";
            this.changeAccBtn.Size = new System.Drawing.Size(123, 23);
            this.changeAccBtn.TabIndex = 6;
            this.changeAccBtn.Text = "切り替え";
            this.changeAccBtn.UseVisualStyleBackColor = true;
            this.changeAccBtn.Click += new System.EventHandler(this.changeAccBtn_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(144, 336);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "ログアウト";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(255, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "現在のアカウントデータを追加";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.addAccountBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "切り替え＆起動";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 477);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.changeAccBtn);
            this.Controls.Add(this.launchBtn);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.renameBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.accountList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "SimpleClusterSwitcher";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox accountList;
        private Button delBtn;
        private Button renameBtn;
        private CheckBox checkBox1;
        private Button launchBtn;
        private Button changeAccBtn;
        private Button button5;
        private Button button6;
        private Button button1;
    }
}