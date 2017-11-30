namespace WordBook
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblWord = new System.Windows.Forms.Label();
            this.lblMeaning = new System.Windows.Forms.Label();
            this.lblPhonetic = new System.Windows.Forms.Label();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnManu = new System.Windows.Forms.Button();
            this.chkRandom = new System.Windows.Forms.CheckBox();
            this.tmrAuto = new System.Windows.Forms.Timer(this.components);
            this.ntfIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.nudSecond = new System.Windows.Forms.NumericUpDown();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblInterval = new System.Windows.Forms.Label();
            this.chkOnTheTop = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnInitial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecond)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(25, 23);
            this.lblWord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(186, 32);
            this.lblWord.TabIndex = 0;
            this.lblWord.Text = "democracy";
            // 
            // lblMeaning
            // 
            this.lblMeaning.AutoSize = true;
            this.lblMeaning.Font = new System.Drawing.Font("华文中宋", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMeaning.Location = new System.Drawing.Point(27, 93);
            this.lblMeaning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMeaning.Name = "lblMeaning";
            this.lblMeaning.Size = new System.Drawing.Size(143, 21);
            this.lblMeaning.TabIndex = 2;
            this.lblMeaning.Text = "n.民主，民主制";
            // 
            // lblPhonetic
            // 
            this.lblPhonetic.AutoSize = true;
            this.lblPhonetic.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhonetic.Location = new System.Drawing.Point(29, 65);
            this.lblPhonetic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhonetic.Name = "lblPhonetic";
            this.lblPhonetic.Size = new System.Drawing.Size(108, 20);
            this.lblPhonetic.TabIndex = 1;
            this.lblPhonetic.Text = "[di5mCkrEsi]";
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPrev.Enabled = false;
            this.btnPrev.Font = new System.Drawing.Font("华文细黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPrev.Location = new System.Drawing.Point(19, 135);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(117, 51);
            this.btnPrev.TabIndex = 3;
            this.btnPrev.Text = "上一个";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNext.Font = new System.Drawing.Font("华文细黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNext.Location = new System.Drawing.Point(143, 135);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(117, 51);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "下一个";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAuto.Font = new System.Drawing.Font("华文细黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAuto.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAuto.Location = new System.Drawing.Point(281, 135);
            this.btnAuto.Margin = new System.Windows.Forms.Padding(2);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(73, 51);
            this.btnAuto.TabIndex = 5;
            this.btnAuto.Text = "自动";
            this.btnAuto.UseVisualStyleBackColor = false;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // btnManu
            // 
            this.btnManu.BackColor = System.Drawing.Color.DarkRed;
            this.btnManu.Enabled = false;
            this.btnManu.Font = new System.Drawing.Font("华文细黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnManu.ForeColor = System.Drawing.SystemColors.Control;
            this.btnManu.Location = new System.Drawing.Point(281, 135);
            this.btnManu.Margin = new System.Windows.Forms.Padding(2);
            this.btnManu.Name = "btnManu";
            this.btnManu.Size = new System.Drawing.Size(73, 51);
            this.btnManu.TabIndex = 6;
            this.btnManu.Text = "手动";
            this.btnManu.UseVisualStyleBackColor = false;
            this.btnManu.Visible = false;
            this.btnManu.Click += new System.EventHandler(this.btnManu_Click);
            // 
            // chkRandom
            // 
            this.chkRandom.AutoSize = true;
            this.chkRandom.Enabled = false;
            this.chkRandom.Font = new System.Drawing.Font("华文细黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkRandom.Location = new System.Drawing.Point(21, 198);
            this.chkRandom.Margin = new System.Windows.Forms.Padding(2);
            this.chkRandom.Name = "chkRandom";
            this.chkRandom.Size = new System.Drawing.Size(95, 21);
            this.chkRandom.TabIndex = 7;
            this.chkRandom.Text = "随机单词";
            this.chkRandom.UseVisualStyleBackColor = true;
            this.chkRandom.CheckedChanged += new System.EventHandler(this.chkRandom_CheckedChanged);
            // 
            // tmrAuto
            // 
            this.tmrAuto.Interval = 10000;
            this.tmrAuto.Tick += new System.EventHandler(this.tmrAuto_Tick);
            // 
            // ntfIcon
            // 
            this.ntfIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfIcon.Icon")));
            this.ntfIcon.Text = "WordBook正在运行";
            this.ntfIcon.Visible = true;
            // 
            // nudSecond
            // 
            this.nudSecond.Enabled = false;
            this.nudSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSecond.Location = new System.Drawing.Point(275, 198);
            this.nudSecond.Margin = new System.Windows.Forms.Padding(2);
            this.nudSecond.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudSecond.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSecond.Name = "nudSecond";
            this.nudSecond.Size = new System.Drawing.Size(49, 26);
            this.nudSecond.TabIndex = 9;
            this.nudSecond.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSecond.ValueChanged += new System.EventHandler(this.nudSecond_ValueChanged);
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Enabled = false;
            this.lblSecond.Font = new System.Drawing.Font("华文细黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecond.Location = new System.Drawing.Point(327, 200);
            this.lblSecond.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(25, 17);
            this.lblSecond.TabIndex = 13;
            this.lblSecond.Text = "秒";
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Enabled = false;
            this.lblInterval.Font = new System.Drawing.Font("华文细黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterval.Location = new System.Drawing.Point(229, 200);
            this.lblInterval.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(42, 17);
            this.lblInterval.TabIndex = 12;
            this.lblInterval.Text = "间隔";
            // 
            // chkOnTheTop
            // 
            this.chkOnTheTop.AutoSize = true;
            this.chkOnTheTop.Font = new System.Drawing.Font("华文细黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnTheTop.Location = new System.Drawing.Point(21, 221);
            this.chkOnTheTop.Margin = new System.Windows.Forms.Padding(2);
            this.chkOnTheTop.Name = "chkOnTheTop";
            this.chkOnTheTop.Size = new System.Drawing.Size(163, 21);
            this.chkOnTheTop.TabIndex = 8;
            this.chkOnTheTop.Text = "保持窗口在最上方";
            this.chkOnTheTop.UseVisualStyleBackColor = true;
            this.chkOnTheTop.CheckedChanged += new System.EventHandler(this.chkOnTheTop_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("华文细黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Location = new System.Drawing.Point(19, 248);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 29);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "保存当前状态";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnInitial
            // 
            this.btnInitial.Font = new System.Drawing.Font("华文细黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInitial.Location = new System.Drawing.Point(204, 248);
            this.btnInitial.Margin = new System.Windows.Forms.Padding(2);
            this.btnInitial.Name = "btnInitial";
            this.btnInitial.Size = new System.Drawing.Size(148, 29);
            this.btnInitial.TabIndex = 11;
            this.btnInitial.Text = "恢复初始状态";
            this.btnInitial.UseVisualStyleBackColor = true;
            this.btnInitial.Click += new System.EventHandler(this.btnInitial_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(384, 321);
            this.Controls.Add(this.btnInitial);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkOnTheTop);
            this.Controls.Add(this.lblInterval);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.nudSecond);
            this.Controls.Add(this.chkRandom);
            this.Controls.Add(this.btnManu);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.lblPhonetic);
            this.Controls.Add(this.lblMeaning);
            this.Controls.Add(this.lblWord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "WordBook";
            ((System.ComponentModel.ISupportInitialize)(this.nudSecond)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblMeaning;
        private System.Windows.Forms.Label lblPhonetic;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnManu;
        private System.Windows.Forms.CheckBox chkRandom;
        private System.Windows.Forms.Timer tmrAuto;
        private System.Windows.Forms.NotifyIcon ntfIcon;
        private System.Windows.Forms.NumericUpDown nudSecond;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.CheckBox chkOnTheTop;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnInitial;
    }
}

