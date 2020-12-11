namespace RandomNameSelecter
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.tbcSetting = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbSouEff = new System.Windows.Forms.CheckBox();
            this.cbSpeEff = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbtFormMini = new System.Windows.Forms.RadioButton();
            this.rbtFormOpacity = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnOneTabClear = new System.Windows.Forms.Button();
            this.btnClearHistory = new System.Windows.Forms.Button();
            this.btnClearMotationData = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtModeMotation = new System.Windows.Forms.RadioButton();
            this.rbtModeWeight = new System.Windows.Forms.RadioButton();
            this.rbtModeCommon = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvStu = new System.Windows.Forms.DataGridView();
            this.clStuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStuWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcSetting.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStu)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcSetting
            // 
            this.tbcSetting.Controls.Add(this.tabPage1);
            this.tbcSetting.Controls.Add(this.tabPage2);
            this.tbcSetting.Location = new System.Drawing.Point(1, 1);
            this.tbcSetting.Name = "tbcSetting";
            this.tbcSetting.SelectedIndex = 0;
            this.tbcSetting.Size = new System.Drawing.Size(459, 418);
            this.tbcSetting.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(451, 392);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "通用设置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cbSouEff);
            this.groupBox6.Controls.Add(this.cbSpeEff);
            this.groupBox6.Location = new System.Drawing.Point(215, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 100);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "其他设置";
            // 
            // cbSouEff
            // 
            this.cbSouEff.AutoSize = true;
            this.cbSouEff.Location = new System.Drawing.Point(6, 20);
            this.cbSouEff.Name = "cbSouEff";
            this.cbSouEff.Size = new System.Drawing.Size(72, 16);
            this.cbSouEff.TabIndex = 1;
            this.cbSouEff.Text = "开启声效";
            this.cbSouEff.UseVisualStyleBackColor = true;
            // 
            // cbSpeEff
            // 
            this.cbSpeEff.AutoSize = true;
            this.cbSpeEff.Location = new System.Drawing.Point(6, 42);
            this.cbSpeEff.Name = "cbSpeEff";
            this.cbSpeEff.Size = new System.Drawing.Size(120, 16);
            this.cbSpeEff.TabIndex = 0;
            this.cbSpeEff.Text = "开启单人点名动效";
            this.cbSpeEff.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbtFormMini);
            this.groupBox4.Controls.Add(this.rbtFormOpacity);
            this.groupBox4.Location = new System.Drawing.Point(6, 105);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(99, 70);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PPT模式";
            // 
            // rbtFormMini
            // 
            this.rbtFormMini.AutoSize = true;
            this.rbtFormMini.Location = new System.Drawing.Point(6, 43);
            this.rbtFormMini.Name = "rbtFormMini";
            this.rbtFormMini.Size = new System.Drawing.Size(71, 16);
            this.rbtFormMini.TabIndex = 1;
            this.rbtFormMini.Text = "迷你窗体";
            this.rbtFormMini.UseVisualStyleBackColor = true;
            this.rbtFormMini.CheckedChanged += new System.EventHandler(this.rbtFormMini_CheckedChanged);
            // 
            // rbtFormOpacity
            // 
            this.rbtFormOpacity.AutoSize = true;
            this.rbtFormOpacity.Location = new System.Drawing.Point(6, 20);
            this.rbtFormOpacity.Name = "rbtFormOpacity";
            this.rbtFormOpacity.Size = new System.Drawing.Size(71, 16);
            this.rbtFormOpacity.TabIndex = 0;
            this.rbtFormOpacity.Text = "窗体隐身";
            this.rbtFormOpacity.UseVisualStyleBackColor = true;
            this.rbtFormOpacity.CheckedChanged += new System.EventHandler(this.rbtFormOpacity_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnOneTabClear);
            this.groupBox3.Controls.Add(this.btnClearHistory);
            this.groupBox3.Controls.Add(this.btnClearMotationData);
            this.groupBox3.Location = new System.Drawing.Point(111, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(98, 169);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "设置";
            // 
            // btnOneTabClear
            // 
            this.btnOneTabClear.Location = new System.Drawing.Point(5, 117);
            this.btnOneTabClear.Name = "btnOneTabClear";
            this.btnOneTabClear.Size = new System.Drawing.Size(86, 41);
            this.btnOneTabClear.TabIndex = 20;
            this.btnOneTabClear.Text = "一键清空";
            this.btnOneTabClear.UseVisualStyleBackColor = true;
            this.btnOneTabClear.Click += new System.EventHandler(this.btnOneTabClear_Click);
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.Location = new System.Drawing.Point(5, 20);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.Size = new System.Drawing.Size(86, 39);
            this.btnClearHistory.TabIndex = 19;
            this.btnClearHistory.Text = "清除历史记录";
            this.btnClearHistory.UseVisualStyleBackColor = true;
            this.btnClearHistory.Click += new System.EventHandler(this.btnClearHistory_Click);
            // 
            // btnClearMotationData
            // 
            this.btnClearMotationData.Location = new System.Drawing.Point(6, 69);
            this.btnClearMotationData.Name = "btnClearMotationData";
            this.btnClearMotationData.Size = new System.Drawing.Size(86, 42);
            this.btnClearMotationData.TabIndex = 8;
            this.btnClearMotationData.Text = "清除轮替记录";
            this.btnClearMotationData.UseVisualStyleBackColor = true;
            this.btnClearMotationData.Click += new System.EventHandler(this.btnClearMotationData_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtModeMotation);
            this.groupBox2.Controls.Add(this.rbtModeWeight);
            this.groupBox2.Controls.Add(this.rbtModeCommon);
            this.groupBox2.Location = new System.Drawing.Point(7, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(98, 93);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "模式选项";
            // 
            // rbtModeMotation
            // 
            this.rbtModeMotation.AutoSize = true;
            this.rbtModeMotation.Location = new System.Drawing.Point(6, 65);
            this.rbtModeMotation.Name = "rbtModeMotation";
            this.rbtModeMotation.Size = new System.Drawing.Size(71, 16);
            this.rbtModeMotation.TabIndex = 2;
            this.rbtModeMotation.Text = "轮替模式";
            this.rbtModeMotation.UseVisualStyleBackColor = true;
            this.rbtModeMotation.CheckedChanged += new System.EventHandler(this.rbtModeMotation_CheckedChanged);
            // 
            // rbtModeWeight
            // 
            this.rbtModeWeight.AutoSize = true;
            this.rbtModeWeight.Location = new System.Drawing.Point(6, 43);
            this.rbtModeWeight.Name = "rbtModeWeight";
            this.rbtModeWeight.Size = new System.Drawing.Size(71, 16);
            this.rbtModeWeight.TabIndex = 1;
            this.rbtModeWeight.Text = "加权模式";
            this.rbtModeWeight.UseVisualStyleBackColor = true;
            this.rbtModeWeight.CheckedChanged += new System.EventHandler(this.rbtModeWeight_CheckedChanged);
            // 
            // rbtModeCommon
            // 
            this.rbtModeCommon.AutoSize = true;
            this.rbtModeCommon.Location = new System.Drawing.Point(7, 21);
            this.rbtModeCommon.Name = "rbtModeCommon";
            this.rbtModeCommon.Size = new System.Drawing.Size(71, 16);
            this.rbtModeCommon.TabIndex = 0;
            this.rbtModeCommon.Text = "普通模式";
            this.rbtModeCommon.UseVisualStyleBackColor = true;
            this.rbtModeCommon.CheckedChanged += new System.EventHandler(this.RbtModeCommon_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvStu);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(451, 392);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "加权设置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvStu
            // 
            this.dgvStu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clStuID,
            this.clStuName,
            this.clStuWeight});
            this.dgvStu.Location = new System.Drawing.Point(0, 0);
            this.dgvStu.Name = "dgvStu";
            this.dgvStu.RowTemplate.Height = 23;
            this.dgvStu.Size = new System.Drawing.Size(451, 364);
            this.dgvStu.TabIndex = 68;
            // 
            // clStuID
            // 
            this.clStuID.DataPropertyName = "ID";
            this.clStuID.HeaderText = "系统序号";
            this.clStuID.Name = "clStuID";
            // 
            // clStuName
            // 
            this.clStuName.DataPropertyName = "StuName";
            this.clStuName.HeaderText = "姓名";
            this.clStuName.Name = "clStuName";
            // 
            // clStuWeight
            // 
            this.clStuWeight.DataPropertyName = "StuWeight";
            this.clStuWeight.HeaderText = "权重";
            this.clStuWeight.Name = "clStuWeight";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(461, 420);
            this.Controls.Add(this.tbcSetting);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSettings";
            this.Text = "设置";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PasswordCheck_FormClosing);
            this.Load += new System.EventHandler(this.PasswordCheck_Load);
            this.tbcSetting.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tbcSetting;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtModeMotation;
        private System.Windows.Forms.RadioButton rbtModeWeight;
        private System.Windows.Forms.RadioButton rbtModeCommon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnOneTabClear;
        public System.Windows.Forms.Button btnClearHistory;
        public System.Windows.Forms.Button btnClearMotationData;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbtFormMini;
        private System.Windows.Forms.RadioButton rbtFormOpacity;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox cbSouEff;
        private System.Windows.Forms.CheckBox cbSpeEff;
        private System.Windows.Forms.DataGridView dgvStu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStuWeight;
    }
}