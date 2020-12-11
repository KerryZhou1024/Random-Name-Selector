namespace RandomNameSelecter
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnSelect = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnSelectMuti = new System.Windows.Forms.Button();
            this.btnOneTabClear = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.tbMutiNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInformation = new System.Windows.Forms.Button();
            this.tbHistoryName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChangeSize = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSelect.Font = new System.Drawing.Font("SimSun", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(618, 65);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(200, 208);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Call a name";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            this.btnSelect.MouseEnter += new System.EventHandler(this.btnSelect_MouseEnter);
            this.btnSelect.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.btnSelect.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // tbName
            // 
            this.tbName.Enabled = false;
            this.tbName.Font = new System.Drawing.Font("SimSun", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbName.Location = new System.Drawing.Point(4, 4);
            this.tbName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(598, 454);
            this.tbName.TabIndex = 1;
            // 
            // btnSelectMuti
            // 
            this.btnSelectMuti.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelectMuti.Location = new System.Drawing.Point(618, 285);
            this.btnSelectMuti.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSelectMuti.Name = "btnSelectMuti";
            this.btnSelectMuti.Size = new System.Drawing.Size(200, 115);
            this.btnSelectMuti.TabIndex = 2;
            this.btnSelectMuti.Text = "Mass Call";
            this.btnSelectMuti.UseVisualStyleBackColor = true;
            this.btnSelectMuti.Click += new System.EventHandler(this.BtnSelectMuti_Click);
            // 
            // btnOneTabClear
            // 
            this.btnOneTabClear.Location = new System.Drawing.Point(512, 496);
            this.btnOneTabClear.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnOneTabClear.Name = "btnOneTabClear";
            this.btnOneTabClear.Size = new System.Drawing.Size(126, 119);
            this.btnOneTabClear.TabIndex = 20;
            this.btnOneTabClear.Text = "Clear all";
            this.btnOneTabClear.UseVisualStyleBackColor = true;
            this.btnOneTabClear.Click += new System.EventHandler(this.BtnOneTabClear_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(650, 496);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(168, 119);
            this.btnSetting.TabIndex = 21;
            this.btnSetting.Text = "Setting";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // tbMutiNumber
            // 
            this.tbMutiNumber.Location = new System.Drawing.Point(684, 419);
            this.tbMutiNumber.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbMutiNumber.Name = "tbMutiNumber";
            this.tbMutiNumber.Size = new System.Drawing.Size(38, 31);
            this.tbMutiNumber.TabIndex = 10;
            this.tbMutiNumber.Text = "3";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(618, 425);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 44);
            this.label1.TabIndex = 11;
            this.label1.Text = "（点";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(738, 425);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 44);
            this.label2.TabIndex = 12;
            this.label2.Text = "个）";
            // 
            // btnInformation
            // 
            this.btnInformation.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnInformation.Location = new System.Drawing.Point(764, 4);
            this.btnInformation.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Size = new System.Drawing.Size(54, 48);
            this.btnInformation.TabIndex = 15;
            this.btnInformation.Text = "i";
            this.btnInformation.UseVisualStyleBackColor = true;
            this.btnInformation.Click += new System.EventHandler(this.BtnInformation_Click);
            this.btnInformation.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.btnInformation.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // tbHistoryName
            // 
            this.tbHistoryName.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbHistoryName.Location = new System.Drawing.Point(4, 496);
            this.tbHistoryName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbHistoryName.Multiline = true;
            this.tbHistoryName.Name = "tbHistoryName";
            this.tbHistoryName.ReadOnly = true;
            this.tbHistoryName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbHistoryName.Size = new System.Drawing.Size(492, 114);
            this.tbHistoryName.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 469);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "History";
            // 
            // btnChangeSize
            // 
            this.btnChangeSize.Location = new System.Drawing.Point(618, 4);
            this.btnChangeSize.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnChangeSize.Name = "btnChangeSize";
            this.btnChangeSize.Size = new System.Drawing.Size(134, 48);
            this.btnChangeSize.TabIndex = 19;
            this.btnChangeSize.Text = "PPT模式";
            this.btnChangeSize.UseVisualStyleBackColor = true;
            this.btnChangeSize.Click += new System.EventHandler(this.btnChangeSize_Click);
            this.btnChangeSize.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.btnChangeSize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // FormMain
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.SpinButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 621);
            this.Controls.Add(this.btnOneTabClear);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnChangeSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbHistoryName);
            this.Controls.Add(this.btnInformation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMutiNumber);
            this.Controls.Add(this.btnSelectMuti);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnSelect);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Name Selecter";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnSelectMuti;
        private System.Windows.Forms.TextBox tbMutiNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInformation;
        private System.Windows.Forms.TextBox tbHistoryName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOneTabClear;
        private System.Windows.Forms.Button btnChangeSize;
        private System.Windows.Forms.Button btnSetting;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
    }
}

