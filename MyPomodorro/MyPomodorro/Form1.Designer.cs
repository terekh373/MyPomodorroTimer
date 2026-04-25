namespace MyPomodorro
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblCycle = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lblNextBreak = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.ctxtMnStpMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tlStpMnItmOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tlStpMnItmClose = new System.Windows.Forms.ToolStripMenuItem();
            this.tlStpMnItmTimer = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHide = new System.Windows.Forms.Button();
            this.nmrUpDnCycles = new System.Windows.Forms.NumericUpDown();
            this.nmrUpDnCycleLength = new System.Windows.Forms.NumericUpDown();
            this.nmrUpDnLongBreak = new System.Windows.Forms.NumericUpDown();
            this.nmrUpDnShortBreak = new System.Windows.Forms.NumericUpDown();
            this.ntfIcMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.lbl8 = new System.Windows.Forms.Label();
            this.lblPhase = new System.Windows.Forms.Label();
            this.ctxtMnStpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUpDnCycles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUpDnCycleLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUpDnLongBreak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUpDnShortBreak)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTimer.Location = new System.Drawing.Point(97, 174);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(76, 25);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "<timer>";
            // 
            // lblCycle
            // 
            this.lblCycle.AutoSize = true;
            this.lblCycle.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCycle.Location = new System.Drawing.Point(374, 209);
            this.lblCycle.Name = "lblCycle";
            this.lblCycle.Size = new System.Drawing.Size(72, 25);
            this.lblCycle.TabIndex = 1;
            this.lblCycle.Text = "<cycle>";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl6.Location = new System.Drawing.Point(306, 209);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(60, 25);
            this.lbl6.TabIndex = 3;
            this.lbl6.Text = "Цикл:";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl5.Location = new System.Drawing.Point(8, 174);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(81, 25);
            this.lbl5.TabIndex = 2;
            this.lbl5.Text = "Таймер:";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl7.Location = new System.Drawing.Point(306, 174);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(199, 25);
            this.lbl7.TabIndex = 4;
            this.lbl7.Text = "Следующий перерыв:";
            // 
            // lblNextBreak
            // 
            this.lblNextBreak.AutoSize = true;
            this.lblNextBreak.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNextBreak.Location = new System.Drawing.Point(513, 174);
            this.lblNextBreak.Name = "lblNextBreak";
            this.lblNextBreak.Size = new System.Drawing.Size(63, 25);
            this.lblNextBreak.TabIndex = 5;
            this.lblNextBreak.Text = "<min>";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.ForestGreen;
            this.btnStart.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(204, 102);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(80, 40);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Crimson;
            this.btnStop.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStop.Location = new System.Drawing.Point(316, 102);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(80, 40);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Стоп";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl1.Location = new System.Drawing.Point(8, 10);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(182, 25);
            this.lbl1.TabIndex = 8;
            this.lbl1.Text = "Количество циклов:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl3.Location = new System.Drawing.Point(306, 10);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(179, 25);
            this.lbl3.TabIndex = 9;
            this.lbl3.Text = "Короткий перерыв:";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl4.Location = new System.Drawing.Point(306, 43);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(176, 25);
            this.lbl4.TabIndex = 10;
            this.lbl4.Text = "Длинный перерыв:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl2.Location = new System.Drawing.Point(8, 45);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(127, 25);
            this.lbl2.TabIndex = 11;
            this.lbl2.Text = "Длина цикла:";
            // 
            // ctxtMnStpMain
            // 
            this.ctxtMnStpMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlStpMnItmOpen,
            this.tlStpMnItmClose,
            this.tlStpMnItmTimer});
            this.ctxtMnStpMain.Name = "ctxtMnStpMain";
            this.ctxtMnStpMain.Size = new System.Drawing.Size(139, 70);
            // 
            // tlStpMnItmOpen
            // 
            this.tlStpMnItmOpen.Name = "tlStpMnItmOpen";
            this.tlStpMnItmOpen.Size = new System.Drawing.Size(138, 22);
            this.tlStpMnItmOpen.Text = "Открыть";
            this.tlStpMnItmOpen.Click += new System.EventHandler(this.tlStpMnItmOpen_Click);
            // 
            // tlStpMnItmClose
            // 
            this.tlStpMnItmClose.Name = "tlStpMnItmClose";
            this.tlStpMnItmClose.Size = new System.Drawing.Size(138, 22);
            this.tlStpMnItmClose.Text = "Выключить";
            this.tlStpMnItmClose.Click += new System.EventHandler(this.tlStpMnItmClose_Click);
            // 
            // tlStpMnItmTimer
            // 
            this.tlStpMnItmTimer.Name = "tlStpMnItmTimer";
            this.tlStpMnItmTimer.Size = new System.Drawing.Size(138, 22);
            this.tlStpMnItmTimer.Text = "<timer>";
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.DimGray;
            this.btnHide.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHide.ForeColor = System.Drawing.Color.White;
            this.btnHide.Location = new System.Drawing.Point(561, 209);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(32, 32);
            this.btnHide.TabIndex = 13;
            this.btnHide.Text = "🔽";
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // nmrUpDnCycles
            // 
            this.nmrUpDnCycles.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nmrUpDnCycles.Location = new System.Drawing.Point(198, 8);
            this.nmrUpDnCycles.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nmrUpDnCycles.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrUpDnCycles.Name = "nmrUpDnCycles";
            this.nmrUpDnCycles.Size = new System.Drawing.Size(100, 27);
            this.nmrUpDnCycles.TabIndex = 14;
            this.nmrUpDnCycles.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nmrUpDnCycles.ValueChanged += new System.EventHandler(this.nmrCycles_ValueChanged);
            // 
            // nmrUpDnCycleLength
            // 
            this.nmrUpDnCycleLength.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nmrUpDnCycleLength.Location = new System.Drawing.Point(198, 43);
            this.nmrUpDnCycleLength.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nmrUpDnCycleLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrUpDnCycleLength.Name = "nmrUpDnCycleLength";
            this.nmrUpDnCycleLength.Size = new System.Drawing.Size(100, 27);
            this.nmrUpDnCycleLength.TabIndex = 15;
            this.nmrUpDnCycleLength.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nmrUpDnCycleLength.ValueChanged += new System.EventHandler(this.nmrCycleLength_ValueChanged);
            // 
            // nmrUpDnLongBreak
            // 
            this.nmrUpDnLongBreak.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nmrUpDnLongBreak.Location = new System.Drawing.Point(493, 43);
            this.nmrUpDnLongBreak.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nmrUpDnLongBreak.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrUpDnLongBreak.Name = "nmrUpDnLongBreak";
            this.nmrUpDnLongBreak.Size = new System.Drawing.Size(100, 27);
            this.nmrUpDnLongBreak.TabIndex = 17;
            this.nmrUpDnLongBreak.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nmrUpDnLongBreak.ValueChanged += new System.EventHandler(this.nmrLongBreak_ValueChanged);
            // 
            // nmrUpDnShortBreak
            // 
            this.nmrUpDnShortBreak.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nmrUpDnShortBreak.Location = new System.Drawing.Point(493, 8);
            this.nmrUpDnShortBreak.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nmrUpDnShortBreak.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrUpDnShortBreak.Name = "nmrUpDnShortBreak";
            this.nmrUpDnShortBreak.Size = new System.Drawing.Size(100, 27);
            this.nmrUpDnShortBreak.TabIndex = 16;
            this.nmrUpDnShortBreak.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nmrUpDnShortBreak.ValueChanged += new System.EventHandler(this.nmrShortBreak_ValueChanged);
            // 
            // ntfIcMain
            // 
            this.ntfIcMain.ContextMenuStrip = this.ctxtMnStpMain;
            this.ntfIcMain.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfIcMain.Icon")));
            this.ntfIcMain.Text = "MyPomodorro";
            this.ntfIcMain.Visible = true;
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl8.Location = new System.Drawing.Point(8, 209);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(60, 25);
            this.lbl8.TabIndex = 19;
            this.lbl8.Text = "Фаза:";
            // 
            // lblPhase
            // 
            this.lblPhase.AutoSize = true;
            this.lblPhase.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPhase.Location = new System.Drawing.Point(97, 209);
            this.lblPhase.Name = "lblPhase";
            this.lblPhase.Size = new System.Drawing.Size(63, 25);
            this.lblPhase.TabIndex = 18;
            this.lblPhase.Text = "<text>";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 249);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.lblPhase);
            this.Controls.Add(this.nmrUpDnLongBreak);
            this.Controls.Add(this.nmrUpDnShortBreak);
            this.Controls.Add(this.nmrUpDnCycleLength);
            this.Controls.Add(this.nmrUpDnCycles);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblNextBreak);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lblCycle);
            this.Controls.Add(this.lblTimer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(601, 249);
            this.MinimumSize = new System.Drawing.Size(601, 249);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pomodorro";
            this.ctxtMnStpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmrUpDnCycles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUpDnCycleLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUpDnLongBreak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUpDnShortBreak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblCycle;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lblNextBreak;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.ContextMenuStrip ctxtMnStpMain;
        private System.Windows.Forms.ToolStripMenuItem tlStpMnItmOpen;
        private System.Windows.Forms.ToolStripMenuItem tlStpMnItmClose;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.NumericUpDown nmrUpDnCycles;
        private System.Windows.Forms.NumericUpDown nmrUpDnCycleLength;
        private System.Windows.Forms.NumericUpDown nmrUpDnLongBreak;
        private System.Windows.Forms.NumericUpDown nmrUpDnShortBreak;
        private System.Windows.Forms.NotifyIcon ntfIcMain;
        private System.Windows.Forms.ToolStripMenuItem tlStpMnItmTimer;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lblPhase;
    }
}

