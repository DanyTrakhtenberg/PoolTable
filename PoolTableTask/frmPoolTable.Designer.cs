namespace PoolTableTask
{
    partial class formPoolTable
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPoolTable));
            this.picBoxPoolTable = new System.Windows.Forms.PictureBox();
            this.picBlackBall = new System.Windows.Forms.PictureBox();
            this.picRedball = new System.Windows.Forms.PictureBox();
            this.timerPoolBalls = new System.Windows.Forms.Timer(this.components);
            this.picBorderPool = new System.Windows.Forms.PictureBox();
            this.grpbxConfig = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblWindowSize = new System.Windows.Forms.Label();
            this.cmbWindowSize = new System.Windows.Forms.ComboBox();
            this.lblTableColor = new System.Windows.Forms.Label();
            this.cmbTableColor = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbBlackBallSize = new System.Windows.Forms.ComboBox();
            this.cmbRedBallSize = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRedSize = new System.Windows.Forms.Label();
            this.trackBallSpeed = new System.Windows.Forms.TrackBar();
            this.lblBallSpeed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPoolTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlackBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRedball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorderPool)).BeginInit();
            this.grpbxConfig.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBallSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxPoolTable
            // 
            this.picBoxPoolTable.BackgroundImage = global::PoolTableTask.Properties.Resources.PoolBackground;
            this.picBoxPoolTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxPoolTable.Location = new System.Drawing.Point(0, 0);
            this.picBoxPoolTable.Name = "picBoxPoolTable";
            this.picBoxPoolTable.Size = new System.Drawing.Size(584, 323);
            this.picBoxPoolTable.TabIndex = 0;
            this.picBoxPoolTable.TabStop = false;
            // 
            // picBlackBall
            // 
            this.picBlackBall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBlackBall.BackgroundImage")));
            this.picBlackBall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBlackBall.Location = new System.Drawing.Point(219, 86);
            this.picBlackBall.Name = "picBlackBall";
            this.picBlackBall.Size = new System.Drawing.Size(40, 40);
            this.picBlackBall.TabIndex = 1;
            this.picBlackBall.TabStop = false;
            // 
            // picRedball
            // 
            this.picRedball.BackColor = System.Drawing.SystemColors.InfoText;
            this.picRedball.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picRedball.BackgroundImage")));
            this.picRedball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRedball.Location = new System.Drawing.Point(59, 51);
            this.picRedball.Name = "picRedball";
            this.picRedball.Size = new System.Drawing.Size(40, 40);
            this.picRedball.TabIndex = 2;
            this.picRedball.TabStop = false;
            // 
            // timerPoolBalls
            // 
            this.timerPoolBalls.Enabled = true;
            this.timerPoolBalls.Interval = 50;
            this.timerPoolBalls.Tick += new System.EventHandler(this.timerRedBall_Tick);
            // 
            // picBorderPool
            // 
            this.picBorderPool.BackColor = System.Drawing.Color.Silver;
            this.picBorderPool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBorderPool.Enabled = false;
            this.picBorderPool.Location = new System.Drawing.Point(46, 53);
            this.picBorderPool.Name = "picBorderPool";
            this.picBorderPool.Size = new System.Drawing.Size(493, 220);
            this.picBorderPool.TabIndex = 3;
            this.picBorderPool.TabStop = false;
            // 
            // grpbxConfig
            // 
            this.grpbxConfig.Controls.Add(this.tabControl1);
            this.grpbxConfig.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbxConfig.Font = new System.Drawing.Font("Miriam Fixed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.grpbxConfig.Location = new System.Drawing.Point(0, 316);
            this.grpbxConfig.Name = "grpbxConfig";
            this.grpbxConfig.Size = new System.Drawing.Size(584, 145);
            this.grpbxConfig.TabIndex = 4;
            this.grpbxConfig.TabStop = false;
            this.grpbxConfig.Text = "Configurations";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Font = new System.Drawing.Font("Miriam Fixed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tabControl1.Location = new System.Drawing.Point(3, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(578, 116);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblWindowSize);
            this.tabPage1.Controls.Add(this.cmbWindowSize);
            this.tabPage1.Controls.Add(this.lblTableColor);
            this.tabPage1.Controls.Add(this.cmbTableColor);
            this.tabPage1.Font = new System.Drawing.Font("Miriam Fixed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(570, 86);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Table";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblWindowSize
            // 
            this.lblWindowSize.AutoSize = true;
            this.lblWindowSize.Font = new System.Drawing.Font("Miriam Fixed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblWindowSize.Location = new System.Drawing.Point(21, 14);
            this.lblWindowSize.Name = "lblWindowSize";
            this.lblWindowSize.Size = new System.Drawing.Size(129, 16);
            this.lblWindowSize.TabIndex = 2;
            this.lblWindowSize.Text = "Window size";
            // 
            // cmbWindowSize
            // 
            this.cmbWindowSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWindowSize.FormattingEnabled = true;
            this.cmbWindowSize.Items.AddRange(new object[] {
            "400X200",
            "600X500",
            "800X700",
            "1000X800"});
            this.cmbWindowSize.Location = new System.Drawing.Point(24, 50);
            this.cmbWindowSize.Name = "cmbWindowSize";
            this.cmbWindowSize.Size = new System.Drawing.Size(123, 24);
            this.cmbWindowSize.TabIndex = 3;
            this.cmbWindowSize.SelectedIndexChanged += new System.EventHandler(this.cmbWindowSize_SelectedIndexChanged);
            // 
            // lblTableColor
            // 
            this.lblTableColor.AutoSize = true;
            this.lblTableColor.Font = new System.Drawing.Font("Miriam Fixed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTableColor.Location = new System.Drawing.Point(207, 14);
            this.lblTableColor.Name = "lblTableColor";
            this.lblTableColor.Size = new System.Drawing.Size(129, 16);
            this.lblTableColor.TabIndex = 4;
            this.lblTableColor.Text = "Table color";
            // 
            // cmbTableColor
            // 
            this.cmbTableColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTableColor.FormattingEnabled = true;
            this.cmbTableColor.Items.AddRange(new object[] {
            "Original",
            "Sienna",
            "Orange",
            "Violet",
            "Silver"});
            this.cmbTableColor.Location = new System.Drawing.Point(210, 50);
            this.cmbTableColor.Name = "cmbTableColor";
            this.cmbTableColor.Size = new System.Drawing.Size(121, 24);
            this.cmbTableColor.TabIndex = 5;
            this.cmbTableColor.SelectedIndexChanged += new System.EventHandler(this.cmbTableColor_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmbBlackBallSize);
            this.tabPage2.Controls.Add(this.cmbRedBallSize);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.lblRedSize);
            this.tabPage2.Controls.Add(this.trackBallSpeed);
            this.tabPage2.Controls.Add(this.lblBallSpeed);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(570, 86);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Balls";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmbBlackBallSize
            // 
            this.cmbBlackBallSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBlackBallSize.FormattingEnabled = true;
            this.cmbBlackBallSize.Items.AddRange(new object[] {
            "40",
            "50",
            "60",
            "70"});
            this.cmbBlackBallSize.Location = new System.Drawing.Point(394, 35);
            this.cmbBlackBallSize.Name = "cmbBlackBallSize";
            this.cmbBlackBallSize.Size = new System.Drawing.Size(121, 24);
            this.cmbBlackBallSize.TabIndex = 5;
            this.cmbBlackBallSize.SelectedIndexChanged += new System.EventHandler(this.cmbBlackBallSize_SelectedIndexChanged);
            // 
            // cmbRedBallSize
            // 
            this.cmbRedBallSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRedBallSize.FormattingEnabled = true;
            this.cmbRedBallSize.Items.AddRange(new object[] {
            "40",
            "50",
            "60",
            "70"});
            this.cmbRedBallSize.Location = new System.Drawing.Point(221, 35);
            this.cmbRedBallSize.Name = "cmbRedBallSize";
            this.cmbRedBallSize.Size = new System.Drawing.Size(121, 24);
            this.cmbRedBallSize.TabIndex = 4;
            this.cmbRedBallSize.SelectedIndexChanged += new System.EventHandler(this.cmbRedBallSize_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Black ball size";
            // 
            // lblRedSize
            // 
            this.lblRedSize.AutoSize = true;
            this.lblRedSize.Location = new System.Drawing.Point(218, 3);
            this.lblRedSize.Name = "lblRedSize";
            this.lblRedSize.Size = new System.Drawing.Size(151, 16);
            this.lblRedSize.TabIndex = 2;
            this.lblRedSize.Text = "Red ball Size";
            // 
            // trackBallSpeed
            // 
            this.trackBallSpeed.Location = new System.Drawing.Point(39, 35);
            this.trackBallSpeed.Maximum = 100;
            this.trackBallSpeed.Minimum = 1;
            this.trackBallSpeed.Name = "trackBallSpeed";
            this.trackBallSpeed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBallSpeed.RightToLeftLayout = true;
            this.trackBallSpeed.Size = new System.Drawing.Size(167, 45);
            this.trackBallSpeed.TabIndex = 1;
            this.trackBallSpeed.TickFrequency = 10;
            this.trackBallSpeed.Value = 25;
            this.trackBallSpeed.ValueChanged += new System.EventHandler(this.trackBallSpeed_ValueChanged);
            // 
            // lblBallSpeed
            // 
            this.lblBallSpeed.AutoSize = true;
            this.lblBallSpeed.Font = new System.Drawing.Font("Miriam Fixed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblBallSpeed.Location = new System.Drawing.Point(36, 3);
            this.lblBallSpeed.Name = "lblBallSpeed";
            this.lblBallSpeed.Size = new System.Drawing.Size(129, 16);
            this.lblBallSpeed.TabIndex = 0;
            this.lblBallSpeed.Text = "Balls speed";
            // 
            // formPoolTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.grpbxConfig);
            this.Controls.Add(this.picRedball);
            this.Controls.Add(this.picBlackBall);
            this.Controls.Add(this.picBorderPool);
            this.Controls.Add(this.picBoxPoolTable);
            this.Name = "formPoolTable";
            this.Text = "Pool Table";
            this.Load += new System.EventHandler(this.formPoolTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPoolTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlackBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRedball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorderPool)).EndInit();
            this.grpbxConfig.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBallSpeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxPoolTable;
        private System.Windows.Forms.PictureBox picBlackBall;
        private System.Windows.Forms.PictureBox picRedball;
        private System.Windows.Forms.Timer timerPoolBalls;
        private System.Windows.Forms.PictureBox picBorderPool;
        private System.Windows.Forms.GroupBox grpbxConfig;
        private System.Windows.Forms.TrackBar trackBallSpeed;
        private System.Windows.Forms.Label lblBallSpeed;
        private System.Windows.Forms.Label lblWindowSize;
        private System.Windows.Forms.ComboBox cmbWindowSize;
        private System.Windows.Forms.ComboBox cmbTableColor;
        private System.Windows.Forms.Label lblTableColor;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cmbBlackBallSize;
        private System.Windows.Forms.ComboBox cmbRedBallSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRedSize;

    }
}

