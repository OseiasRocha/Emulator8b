
namespace SimpleHLE {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.textBoxOpcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxInstruction = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxProgramCounter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxALU = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxR01 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxR02 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxR03 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxSRZero = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxClock = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxBus = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxUnityControl0 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxUnityControl1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxUnityControl2 = new System.Windows.Forms.TextBox();
            this.buttonCompile = new System.Windows.Forms.Button();
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonClock = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxR04 = new System.Windows.Forms.TextBox();
            this.OUTPUT1P0 = new System.Windows.Forms.CheckBox();
            this.OUTPUT1P7 = new System.Windows.Forms.CheckBox();
            this.OUTPUT1P6 = new System.Windows.Forms.CheckBox();
            this.OUTPUT1P5 = new System.Windows.Forms.CheckBox();
            this.OUTPUT1P4 = new System.Windows.Forms.CheckBox();
            this.OUTPUT1P3 = new System.Windows.Forms.CheckBox();
            this.OUTPUT1P2 = new System.Windows.Forms.CheckBox();
            this.OUTPUT1P1 = new System.Windows.Forms.CheckBox();
            this.OUTPUT2P1 = new System.Windows.Forms.CheckBox();
            this.OUTPUT2P2 = new System.Windows.Forms.CheckBox();
            this.OUTPUT2P3 = new System.Windows.Forms.CheckBox();
            this.OUTPUT2P4 = new System.Windows.Forms.CheckBox();
            this.OUTPUT2P5 = new System.Windows.Forms.CheckBox();
            this.OUTPUT2P6 = new System.Windows.Forms.CheckBox();
            this.OUTPUT2P7 = new System.Windows.Forms.CheckBox();
            this.OUTPUT2P0 = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.repoOnGithubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creatorOseiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creatorGabrielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creatorHenriqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonHelp = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxCode
            // 
            this.textBoxCode.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCode.Location = new System.Drawing.Point(17, 64);
            this.textBoxCode.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCode.Multiline = true;
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxCode.Size = new System.Drawing.Size(227, 477);
            this.textBoxCode.TabIndex = 0;
            this.textBoxCode.Text = "MOV R01, 10\r\nMOV R02, 20\r\nSTO R01\r\nINC R01\r\nDEC R02\r\nCMP R02, R03\r\nINC R04\r\nJNZ A" +
    "\r\nOUT O01, R01\r\nOUT O02, R02\r\nHLT\r\n";
            this.textBoxCode.TextChanged += new System.EventHandler(this.textBoxCode_TextChanged);
            // 
            // textBoxOpcode
            // 
            this.textBoxOpcode.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOpcode.Location = new System.Drawing.Point(253, 64);
            this.textBoxOpcode.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOpcode.Multiline = true;
            this.textBoxOpcode.Name = "textBoxOpcode";
            this.textBoxOpcode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxOpcode.Size = new System.Drawing.Size(227, 477);
            this.textBoxOpcode.TabIndex = 0;
            this.textBoxOpcode.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(525, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "INTR";
            // 
            // textBoxInstruction
            // 
            this.textBoxInstruction.Location = new System.Drawing.Point(579, 64);
            this.textBoxInstruction.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxInstruction.Name = "textBoxInstruction";
            this.textBoxInstruction.ReadOnly = true;
            this.textBoxInstruction.Size = new System.Drawing.Size(148, 22);
            this.textBoxInstruction.TabIndex = 2;
            this.textBoxInstruction.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(541, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "PC";
            // 
            // textBoxProgramCounter
            // 
            this.textBoxProgramCounter.Location = new System.Drawing.Point(579, 96);
            this.textBoxProgramCounter.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxProgramCounter.Name = "textBoxProgramCounter";
            this.textBoxProgramCounter.ReadOnly = true;
            this.textBoxProgramCounter.Size = new System.Drawing.Size(148, 22);
            this.textBoxProgramCounter.TabIndex = 2;
            this.textBoxProgramCounter.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "ALU";
            // 
            // textBoxALU
            // 
            this.textBoxALU.Location = new System.Drawing.Point(579, 128);
            this.textBoxALU.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxALU.Name = "textBoxALU";
            this.textBoxALU.ReadOnly = true;
            this.textBoxALU.Size = new System.Drawing.Size(148, 22);
            this.textBoxALU.TabIndex = 2;
            this.textBoxALU.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(533, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "R01";
            // 
            // textBoxR01
            // 
            this.textBoxR01.Location = new System.Drawing.Point(579, 160);
            this.textBoxR01.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxR01.Name = "textBoxR01";
            this.textBoxR01.ReadOnly = true;
            this.textBoxR01.Size = new System.Drawing.Size(148, 22);
            this.textBoxR01.TabIndex = 2;
            this.textBoxR01.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(533, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "R02";
            // 
            // textBoxR02
            // 
            this.textBoxR02.Location = new System.Drawing.Point(579, 192);
            this.textBoxR02.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxR02.Name = "textBoxR02";
            this.textBoxR02.ReadOnly = true;
            this.textBoxR02.Size = new System.Drawing.Size(148, 22);
            this.textBoxR02.TabIndex = 2;
            this.textBoxR02.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(533, 228);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "R03";
            // 
            // textBoxR03
            // 
            this.textBoxR03.Location = new System.Drawing.Point(579, 224);
            this.textBoxR03.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxR03.Name = "textBoxR03";
            this.textBoxR03.ReadOnly = true;
            this.textBoxR03.Size = new System.Drawing.Size(148, 22);
            this.textBoxR03.TabIndex = 2;
            this.textBoxR03.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(492, 300);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "OUTPUT1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(576, 368);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "ALU = R01 + R02";
            // 
            // checkBoxSRZero
            // 
            this.checkBoxSRZero.AutoCheck = false;
            this.checkBoxSRZero.AutoSize = true;
            this.checkBoxSRZero.Location = new System.Drawing.Point(579, 401);
            this.checkBoxSRZero.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxSRZero.Name = "checkBoxSRZero";
            this.checkBoxSRZero.Size = new System.Drawing.Size(69, 21);
            this.checkBoxSRZero.TabIndex = 3;
            this.checkBoxSRZero.TabStop = false;
            this.checkBoxSRZero.Text = "ZERO";
            this.checkBoxSRZero.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(533, 433);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "CLK";
            // 
            // textBoxClock
            // 
            this.textBoxClock.Location = new System.Drawing.Point(579, 430);
            this.textBoxClock.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxClock.Name = "textBoxClock";
            this.textBoxClock.ReadOnly = true;
            this.textBoxClock.Size = new System.Drawing.Size(148, 22);
            this.textBoxClock.TabIndex = 2;
            this.textBoxClock.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(531, 465);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "BUS";
            // 
            // textBoxBus
            // 
            this.textBoxBus.Location = new System.Drawing.Point(579, 462);
            this.textBoxBus.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBus.Name = "textBoxBus";
            this.textBoxBus.ReadOnly = true;
            this.textBoxBus.Size = new System.Drawing.Size(148, 22);
            this.textBoxBus.TabIndex = 2;
            this.textBoxBus.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(532, 497);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "UC0";
            // 
            // textBoxUnityControl0
            // 
            this.textBoxUnityControl0.Location = new System.Drawing.Point(579, 494);
            this.textBoxUnityControl0.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUnityControl0.Name = "textBoxUnityControl0";
            this.textBoxUnityControl0.ReadOnly = true;
            this.textBoxUnityControl0.Size = new System.Drawing.Size(148, 22);
            this.textBoxUnityControl0.TabIndex = 2;
            this.textBoxUnityControl0.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(532, 529);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "UC1";
            // 
            // textBoxUnityControl1
            // 
            this.textBoxUnityControl1.Location = new System.Drawing.Point(579, 526);
            this.textBoxUnityControl1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUnityControl1.Name = "textBoxUnityControl1";
            this.textBoxUnityControl1.ReadOnly = true;
            this.textBoxUnityControl1.Size = new System.Drawing.Size(148, 22);
            this.textBoxUnityControl1.TabIndex = 2;
            this.textBoxUnityControl1.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(532, 561);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "UC2";
            // 
            // textBoxUnityControl2
            // 
            this.textBoxUnityControl2.Location = new System.Drawing.Point(579, 558);
            this.textBoxUnityControl2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUnityControl2.Name = "textBoxUnityControl2";
            this.textBoxUnityControl2.ReadOnly = true;
            this.textBoxUnityControl2.Size = new System.Drawing.Size(148, 22);
            this.textBoxUnityControl2.TabIndex = 2;
            this.textBoxUnityControl2.TabStop = false;
            // 
            // buttonCompile
            // 
            this.buttonCompile.Location = new System.Drawing.Point(17, 549);
            this.buttonCompile.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCompile.Name = "buttonCompile";
            this.buttonCompile.Size = new System.Drawing.Size(100, 28);
            this.buttonCompile.TabIndex = 1;
            this.buttonCompile.Text = "COMPILE";
            this.buttonCompile.UseVisualStyleBackColor = true;
            this.buttonCompile.Click += new System.EventHandler(this.buttonCompile_Click);
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(125, 549);
            this.buttonRun.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(100, 28);
            this.buttonRun.TabIndex = 2;
            this.buttonRun.Text = "RUN";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(233, 549);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(100, 28);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Text = "RESET";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonClock
            // 
            this.buttonClock.Location = new System.Drawing.Point(341, 549);
            this.buttonClock.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClock.Name = "buttonClock";
            this.buttonClock.Size = new System.Drawing.Size(100, 28);
            this.buttonClock.TabIndex = 4;
            this.buttonClock.Text = "CLOCK";
            this.buttonClock.UseVisualStyleBackColor = true;
            this.buttonClock.Click += new System.EventHandler(this.buttonClock_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(492, 332);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 17);
            this.label14.TabIndex = 5;
            this.label14.Text = "OUTPUT2";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(533, 260);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 17);
            this.label15.TabIndex = 1;
            this.label15.Text = "R04";
            // 
            // textBoxR04
            // 
            this.textBoxR04.Location = new System.Drawing.Point(579, 256);
            this.textBoxR04.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxR04.Name = "textBoxR04";
            this.textBoxR04.ReadOnly = true;
            this.textBoxR04.Size = new System.Drawing.Size(148, 22);
            this.textBoxR04.TabIndex = 2;
            this.textBoxR04.TabStop = false;
            // 
            // OUTPUT1P0
            // 
            this.OUTPUT1P0.AutoCheck = false;
            this.OUTPUT1P0.AutoSize = true;
            this.OUTPUT1P0.Location = new System.Drawing.Point(713, 300);
            this.OUTPUT1P0.Margin = new System.Windows.Forms.Padding(0);
            this.OUTPUT1P0.Name = "OUTPUT1P0";
            this.OUTPUT1P0.Size = new System.Drawing.Size(18, 17);
            this.OUTPUT1P0.TabIndex = 6;
            this.OUTPUT1P0.UseVisualStyleBackColor = true;
            // 
            // OUTPUT1P7
            // 
            this.OUTPUT1P7.AutoCheck = false;
            this.OUTPUT1P7.AutoSize = true;
            this.OUTPUT1P7.Location = new System.Drawing.Point(573, 300);
            this.OUTPUT1P7.Margin = new System.Windows.Forms.Padding(0);
            this.OUTPUT1P7.Name = "OUTPUT1P7";
            this.OUTPUT1P7.Size = new System.Drawing.Size(18, 17);
            this.OUTPUT1P7.TabIndex = 7;
            this.OUTPUT1P7.UseVisualStyleBackColor = true;
            // 
            // OUTPUT1P6
            // 
            this.OUTPUT1P6.AutoCheck = false;
            this.OUTPUT1P6.AutoSize = true;
            this.OUTPUT1P6.Location = new System.Drawing.Point(593, 300);
            this.OUTPUT1P6.Margin = new System.Windows.Forms.Padding(0);
            this.OUTPUT1P6.Name = "OUTPUT1P6";
            this.OUTPUT1P6.Size = new System.Drawing.Size(18, 17);
            this.OUTPUT1P6.TabIndex = 8;
            this.OUTPUT1P6.UseVisualStyleBackColor = true;
            // 
            // OUTPUT1P5
            // 
            this.OUTPUT1P5.AutoCheck = false;
            this.OUTPUT1P5.AutoSize = true;
            this.OUTPUT1P5.Location = new System.Drawing.Point(613, 300);
            this.OUTPUT1P5.Margin = new System.Windows.Forms.Padding(0);
            this.OUTPUT1P5.Name = "OUTPUT1P5";
            this.OUTPUT1P5.Size = new System.Drawing.Size(18, 17);
            this.OUTPUT1P5.TabIndex = 9;
            this.OUTPUT1P5.UseVisualStyleBackColor = true;
            // 
            // OUTPUT1P4
            // 
            this.OUTPUT1P4.AutoCheck = false;
            this.OUTPUT1P4.AutoSize = true;
            this.OUTPUT1P4.Location = new System.Drawing.Point(633, 300);
            this.OUTPUT1P4.Margin = new System.Windows.Forms.Padding(0);
            this.OUTPUT1P4.Name = "OUTPUT1P4";
            this.OUTPUT1P4.Size = new System.Drawing.Size(18, 17);
            this.OUTPUT1P4.TabIndex = 10;
            this.OUTPUT1P4.UseVisualStyleBackColor = true;
            // 
            // OUTPUT1P3
            // 
            this.OUTPUT1P3.AutoCheck = false;
            this.OUTPUT1P3.AutoSize = true;
            this.OUTPUT1P3.Location = new System.Drawing.Point(653, 300);
            this.OUTPUT1P3.Margin = new System.Windows.Forms.Padding(0);
            this.OUTPUT1P3.Name = "OUTPUT1P3";
            this.OUTPUT1P3.Size = new System.Drawing.Size(18, 17);
            this.OUTPUT1P3.TabIndex = 11;
            this.OUTPUT1P3.UseVisualStyleBackColor = true;
            // 
            // OUTPUT1P2
            // 
            this.OUTPUT1P2.AutoCheck = false;
            this.OUTPUT1P2.AutoSize = true;
            this.OUTPUT1P2.Location = new System.Drawing.Point(673, 300);
            this.OUTPUT1P2.Margin = new System.Windows.Forms.Padding(0);
            this.OUTPUT1P2.Name = "OUTPUT1P2";
            this.OUTPUT1P2.Size = new System.Drawing.Size(18, 17);
            this.OUTPUT1P2.TabIndex = 12;
            this.OUTPUT1P2.UseVisualStyleBackColor = true;
            // 
            // OUTPUT1P1
            // 
            this.OUTPUT1P1.AutoCheck = false;
            this.OUTPUT1P1.AutoSize = true;
            this.OUTPUT1P1.Location = new System.Drawing.Point(693, 300);
            this.OUTPUT1P1.Margin = new System.Windows.Forms.Padding(0);
            this.OUTPUT1P1.Name = "OUTPUT1P1";
            this.OUTPUT1P1.Size = new System.Drawing.Size(18, 17);
            this.OUTPUT1P1.TabIndex = 13;
            this.OUTPUT1P1.UseVisualStyleBackColor = true;
            // 
            // OUTPUT2P1
            // 
            this.OUTPUT2P1.AutoCheck = false;
            this.OUTPUT2P1.AutoSize = true;
            this.OUTPUT2P1.Location = new System.Drawing.Point(693, 331);
            this.OUTPUT2P1.Margin = new System.Windows.Forms.Padding(0);
            this.OUTPUT2P1.Name = "OUTPUT2P1";
            this.OUTPUT2P1.Size = new System.Drawing.Size(18, 17);
            this.OUTPUT2P1.TabIndex = 21;
            this.OUTPUT2P1.UseVisualStyleBackColor = true;
            // 
            // OUTPUT2P2
            // 
            this.OUTPUT2P2.AutoCheck = false;
            this.OUTPUT2P2.AutoSize = true;
            this.OUTPUT2P2.Location = new System.Drawing.Point(673, 331);
            this.OUTPUT2P2.Margin = new System.Windows.Forms.Padding(0);
            this.OUTPUT2P2.Name = "OUTPUT2P2";
            this.OUTPUT2P2.Size = new System.Drawing.Size(18, 17);
            this.OUTPUT2P2.TabIndex = 20;
            this.OUTPUT2P2.UseVisualStyleBackColor = true;
            // 
            // OUTPUT2P3
            // 
            this.OUTPUT2P3.AutoCheck = false;
            this.OUTPUT2P3.AutoSize = true;
            this.OUTPUT2P3.Location = new System.Drawing.Point(653, 331);
            this.OUTPUT2P3.Margin = new System.Windows.Forms.Padding(0);
            this.OUTPUT2P3.Name = "OUTPUT2P3";
            this.OUTPUT2P3.Size = new System.Drawing.Size(18, 17);
            this.OUTPUT2P3.TabIndex = 19;
            this.OUTPUT2P3.UseVisualStyleBackColor = true;
            // 
            // OUTPUT2P4
            // 
            this.OUTPUT2P4.AutoCheck = false;
            this.OUTPUT2P4.AutoSize = true;
            this.OUTPUT2P4.Location = new System.Drawing.Point(633, 331);
            this.OUTPUT2P4.Margin = new System.Windows.Forms.Padding(0);
            this.OUTPUT2P4.Name = "OUTPUT2P4";
            this.OUTPUT2P4.Size = new System.Drawing.Size(18, 17);
            this.OUTPUT2P4.TabIndex = 18;
            this.OUTPUT2P4.UseVisualStyleBackColor = true;
            // 
            // OUTPUT2P5
            // 
            this.OUTPUT2P5.AutoCheck = false;
            this.OUTPUT2P5.AutoSize = true;
            this.OUTPUT2P5.Location = new System.Drawing.Point(613, 331);
            this.OUTPUT2P5.Margin = new System.Windows.Forms.Padding(0);
            this.OUTPUT2P5.Name = "OUTPUT2P5";
            this.OUTPUT2P5.Size = new System.Drawing.Size(18, 17);
            this.OUTPUT2P5.TabIndex = 17;
            this.OUTPUT2P5.UseVisualStyleBackColor = true;
            // 
            // OUTPUT2P6
            // 
            this.OUTPUT2P6.AutoCheck = false;
            this.OUTPUT2P6.AutoSize = true;
            this.OUTPUT2P6.Location = new System.Drawing.Point(593, 331);
            this.OUTPUT2P6.Margin = new System.Windows.Forms.Padding(0);
            this.OUTPUT2P6.Name = "OUTPUT2P6";
            this.OUTPUT2P6.Size = new System.Drawing.Size(18, 17);
            this.OUTPUT2P6.TabIndex = 16;
            this.OUTPUT2P6.UseVisualStyleBackColor = true;
            // 
            // OUTPUT2P7
            // 
            this.OUTPUT2P7.AutoCheck = false;
            this.OUTPUT2P7.AutoSize = true;
            this.OUTPUT2P7.Location = new System.Drawing.Point(573, 331);
            this.OUTPUT2P7.Margin = new System.Windows.Forms.Padding(0);
            this.OUTPUT2P7.Name = "OUTPUT2P7";
            this.OUTPUT2P7.Size = new System.Drawing.Size(18, 17);
            this.OUTPUT2P7.TabIndex = 15;
            this.OUTPUT2P7.UseVisualStyleBackColor = true;
            // 
            // OUTPUT2P0
            // 
            this.OUTPUT2P0.AutoCheck = false;
            this.OUTPUT2P0.AutoSize = true;
            this.OUTPUT2P0.Location = new System.Drawing.Point(713, 331);
            this.OUTPUT2P0.Margin = new System.Windows.Forms.Padding(0);
            this.OUTPUT2P0.Name = "OUTPUT2P0";
            this.OUTPUT2P0.Size = new System.Drawing.Size(18, 17);
            this.OUTPUT2P0.TabIndex = 14;
            this.OUTPUT2P0.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripButtonHelp});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(755, 27);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(268, 36);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(191, 29);
            this.label16.TabIndex = 23;
            this.label16.Text = "PROGRAM MEMORY";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(59, 36);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(128, 29);
            this.label17.TabIndex = 23;
            this.label17.Text = "TEXT EDITOR";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.repoOnGithubToolStripMenuItem,
            this.creatorOseiasToolStripMenuItem,
            this.creatorGabrielToolStripMenuItem,
            this.creatorHenriqueToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(64, 24);
            this.toolStripDropDownButton1.Text = "About";
            // 
            // repoOnGithubToolStripMenuItem
            // 
            this.repoOnGithubToolStripMenuItem.Name = "repoOnGithubToolStripMenuItem";
            this.repoOnGithubToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.repoOnGithubToolStripMenuItem.Text = "Repo on Github";
            this.repoOnGithubToolStripMenuItem.Click += new System.EventHandler(this.repoOnGithubToolStripMenuItem_Click);
            // 
            // creatorOseiasToolStripMenuItem
            // 
            this.creatorOseiasToolStripMenuItem.Name = "creatorOseiasToolStripMenuItem";
            this.creatorOseiasToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.creatorOseiasToolStripMenuItem.Text = "Creator: Oseias";
            this.creatorOseiasToolStripMenuItem.Click += new System.EventHandler(this.creatorOseiasToolStripMenuItem_Click);
            // 
            // creatorGabrielToolStripMenuItem
            // 
            this.creatorGabrielToolStripMenuItem.Name = "creatorGabrielToolStripMenuItem";
            this.creatorGabrielToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.creatorGabrielToolStripMenuItem.Text = "Creator: Gabriel";
            this.creatorGabrielToolStripMenuItem.Click += new System.EventHandler(this.creatorGabrielToolStripMenuItem_Click);
            // 
            // creatorHenriqueToolStripMenuItem
            // 
            this.creatorHenriqueToolStripMenuItem.Name = "creatorHenriqueToolStripMenuItem";
            this.creatorHenriqueToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.creatorHenriqueToolStripMenuItem.Text = "Creator: Henrique";
            this.creatorHenriqueToolStripMenuItem.Click += new System.EventHandler(this.creatorHenriqueToolStripMenuItem_Click);
            // 
            // toolStripButtonHelp
            // 
            this.toolStripButtonHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonHelp.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonHelp.Image")));
            this.toolStripButtonHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonHelp.Name = "toolStripButtonHelp";
            this.toolStripButtonHelp.Size = new System.Drawing.Size(52, 24);
            this.toolStripButtonHelp.Text = "Help?";
            this.toolStripButtonHelp.Click += new System.EventHandler(this.toolStripButtonHelp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 592);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.OUTPUT2P1);
            this.Controls.Add(this.OUTPUT2P2);
            this.Controls.Add(this.OUTPUT2P3);
            this.Controls.Add(this.OUTPUT2P4);
            this.Controls.Add(this.OUTPUT2P5);
            this.Controls.Add(this.OUTPUT2P6);
            this.Controls.Add(this.OUTPUT2P7);
            this.Controls.Add(this.OUTPUT2P0);
            this.Controls.Add(this.OUTPUT1P1);
            this.Controls.Add(this.OUTPUT1P2);
            this.Controls.Add(this.OUTPUT1P3);
            this.Controls.Add(this.OUTPUT1P4);
            this.Controls.Add(this.OUTPUT1P5);
            this.Controls.Add(this.OUTPUT1P6);
            this.Controls.Add(this.OUTPUT1P7);
            this.Controls.Add(this.OUTPUT1P0);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.buttonClock);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.buttonCompile);
            this.Controls.Add(this.checkBoxSRZero);
            this.Controls.Add(this.textBoxUnityControl2);
            this.Controls.Add(this.textBoxUnityControl1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxUnityControl0);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxBus);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxClock);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxR04);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBoxR03);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxR02);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxR01);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxALU);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxProgramCounter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxInstruction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOpcode);
            this.Controls.Add(this.textBoxCode);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleHLE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.TextBox textBoxOpcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxInstruction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxProgramCounter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxALU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxR01;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxR02;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxR03;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBoxSRZero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxClock;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxBus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxUnityControl0;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxUnityControl1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxUnityControl2;
        private System.Windows.Forms.Button buttonCompile;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonClock;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxR04;
        private System.Windows.Forms.CheckBox OUTPUT1P0;
        private System.Windows.Forms.CheckBox OUTPUT1P7;
        private System.Windows.Forms.CheckBox OUTPUT1P6;
        private System.Windows.Forms.CheckBox OUTPUT1P5;
        private System.Windows.Forms.CheckBox OUTPUT1P4;
        private System.Windows.Forms.CheckBox OUTPUT1P3;
        private System.Windows.Forms.CheckBox OUTPUT1P2;
        private System.Windows.Forms.CheckBox OUTPUT1P1;
        private System.Windows.Forms.CheckBox OUTPUT2P1;
        private System.Windows.Forms.CheckBox OUTPUT2P2;
        private System.Windows.Forms.CheckBox OUTPUT2P3;
        private System.Windows.Forms.CheckBox OUTPUT2P4;
        private System.Windows.Forms.CheckBox OUTPUT2P5;
        private System.Windows.Forms.CheckBox OUTPUT2P6;
        private System.Windows.Forms.CheckBox OUTPUT2P7;
        private System.Windows.Forms.CheckBox OUTPUT2P0;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem repoOnGithubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creatorOseiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creatorGabrielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creatorHenriqueToolStripMenuItem;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ToolStripButton toolStripButtonHelp;
        private System.Windows.Forms.Label label17;
    }
}

