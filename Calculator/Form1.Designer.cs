namespace Calculator
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scientificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radiansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.degreesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.complexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox = new System.Windows.Forms.TextBox();
            this.ButtonPercent = new System.Windows.Forms.Button();
            this.ButtonCE = new System.Windows.Forms.Button();
            this.ButtonC = new System.Windows.Forms.Button();
            this.ButtonBS = new System.Windows.Forms.Button();
            this.ButtonInverse = new System.Windows.Forms.Button();
            this.ButtonSquare = new System.Windows.Forms.Button();
            this.ButtonSqrt = new System.Windows.Forms.Button();
            this.ButtonDivide = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.ButtonMultiply = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.ButtonMinus = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.ButtonPlus = new System.Windows.Forms.Button();
            this.ButtonPM = new System.Windows.Forms.Button();
            this.Button0 = new System.Windows.Forms.Button();
            this.ButtonComma = new System.Windows.Forms.Button();
            this.ButtonEquals = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.ButtonPi = new System.Windows.Forms.Button();
            this.ButtonE = new System.Windows.Forms.Button();
            this.ButtonAbs = new System.Windows.Forms.Button();
            this.ButtonMod = new System.Windows.Forms.Button();
            this.ButtonFact = new System.Windows.Forms.Button();
            this.ButtonP1 = new System.Windows.Forms.Button();
            this.ButtonP2 = new System.Windows.Forms.Button();
            this.ButtonExp = new System.Windows.Forms.Button();
            this.ButtonSin = new System.Windows.Forms.Button();
            this.ButtonSinh = new System.Windows.Forms.Button();
            this.ButtonCos = new System.Windows.Forms.Button();
            this.ButtonCosh = new System.Windows.Forms.Button();
            this.ButtonCot = new System.Windows.Forms.Button();
            this.ButtonTan = new System.Windows.Forms.Button();
            this.ButtonAcos = new System.Windows.Forms.Button();
            this.ButtonAsin = new System.Windows.Forms.Button();
            this.Button2Powx = new System.Windows.Forms.Button();
            this.ButtonAtan = new System.Windows.Forms.Button();
            this.ButtonxYroot = new System.Windows.Forms.Button();
            this.ButtonxPowy = new System.Windows.Forms.Button();
            this.ButtonePowx = new System.Windows.Forms.Button();
            this.ButtonLogxy = new System.Windows.Forms.Button();
            this.ButtonLn = new System.Windows.Forms.Button();
            this.ButtonLg = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(787, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardToolStripMenuItem,
            this.scientificToolStripMenuItem,
            this.complexToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // standardToolStripMenuItem
            // 
            this.standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            this.standardToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.standardToolStripMenuItem.Text = "Standard";
            this.standardToolStripMenuItem.Click += new System.EventHandler(this.StandardToolStripMenuItem_Click);
            // 
            // scientificToolStripMenuItem
            // 
            this.scientificToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.radiansToolStripMenuItem,
            this.degreesToolStripMenuItem});
            this.scientificToolStripMenuItem.Name = "scientificToolStripMenuItem";
            this.scientificToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.scientificToolStripMenuItem.Text = "Scientific";
            this.scientificToolStripMenuItem.Click += new System.EventHandler(this.ScientificToolStripMenuItem_Click);
            // 
            // radiansToolStripMenuItem
            // 
            this.radiansToolStripMenuItem.Name = "radiansToolStripMenuItem";
            this.radiansToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.radiansToolStripMenuItem.Text = "Radians";
            this.radiansToolStripMenuItem.Click += new System.EventHandler(this.RadiansToolStripMenuItem_Click);
            // 
            // degreesToolStripMenuItem
            // 
            this.degreesToolStripMenuItem.Name = "degreesToolStripMenuItem";
            this.degreesToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.degreesToolStripMenuItem.Text = "Degrees";
            this.degreesToolStripMenuItem.Click += new System.EventHandler(this.DegreesToolStripMenuItem_Click);
            // 
            // complexToolStripMenuItem
            // 
            this.complexToolStripMenuItem.Name = "complexToolStripMenuItem";
            this.complexToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.complexToolStripMenuItem.Text = "Complex";
            this.complexToolStripMenuItem.Click += new System.EventHandler(this.complexToolStripMenuItem_Click);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox.Location = new System.Drawing.Point(12, 31);
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox.Size = new System.Drawing.Size(762, 51);
            this.textBox.TabIndex = 1;
            this.textBox.Text = "0";
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ButtonPercent
            // 
            this.ButtonPercent.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonPercent.Location = new System.Drawing.Point(12, 98);
            this.ButtonPercent.Name = "ButtonPercent";
            this.ButtonPercent.Size = new System.Drawing.Size(90, 70);
            this.ButtonPercent.TabIndex = 2;
            this.ButtonPercent.Text = "%";
            this.ButtonPercent.UseVisualStyleBackColor = true;
            this.ButtonPercent.Click += new System.EventHandler(this.ButtonPercent_Click);
            // 
            // ButtonCE
            // 
            this.ButtonCE.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonCE.Location = new System.Drawing.Point(108, 99);
            this.ButtonCE.Name = "ButtonCE";
            this.ButtonCE.Size = new System.Drawing.Size(90, 70);
            this.ButtonCE.TabIndex = 3;
            this.ButtonCE.Text = "CE";
            this.ButtonCE.UseVisualStyleBackColor = true;
            this.ButtonCE.Click += new System.EventHandler(this.ButtonCE_Click);
            // 
            // ButtonC
            // 
            this.ButtonC.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonC.Location = new System.Drawing.Point(204, 99);
            this.ButtonC.Name = "ButtonC";
            this.ButtonC.Size = new System.Drawing.Size(90, 70);
            this.ButtonC.TabIndex = 4;
            this.ButtonC.Text = "C";
            this.ButtonC.UseVisualStyleBackColor = true;
            this.ButtonC.Click += new System.EventHandler(this.ButtonC_Click);
            // 
            // ButtonBS
            // 
            this.ButtonBS.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonBS.Location = new System.Drawing.Point(300, 98);
            this.ButtonBS.Name = "ButtonBS";
            this.ButtonBS.Size = new System.Drawing.Size(90, 70);
            this.ButtonBS.TabIndex = 5;
            this.ButtonBS.Text = "⌫";
            this.ButtonBS.UseVisualStyleBackColor = true;
            this.ButtonBS.Click += new System.EventHandler(this.ButtonBS_Click);
            // 
            // ButtonInverse
            // 
            this.ButtonInverse.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonInverse.Location = new System.Drawing.Point(12, 174);
            this.ButtonInverse.Name = "ButtonInverse";
            this.ButtonInverse.Size = new System.Drawing.Size(90, 70);
            this.ButtonInverse.TabIndex = 6;
            this.ButtonInverse.Text = "1/x";
            this.ButtonInverse.UseVisualStyleBackColor = true;
            this.ButtonInverse.Click += new System.EventHandler(this.ButtonInverse_Click);
            // 
            // ButtonSquare
            // 
            this.ButtonSquare.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonSquare.Location = new System.Drawing.Point(108, 174);
            this.ButtonSquare.Name = "ButtonSquare";
            this.ButtonSquare.Size = new System.Drawing.Size(90, 70);
            this.ButtonSquare.TabIndex = 7;
            this.ButtonSquare.Text = "x²";
            this.ButtonSquare.UseVisualStyleBackColor = true;
            this.ButtonSquare.Click += new System.EventHandler(this.ButtonSquare_Click);
            // 
            // ButtonSqrt
            // 
            this.ButtonSqrt.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonSqrt.Location = new System.Drawing.Point(204, 174);
            this.ButtonSqrt.Name = "ButtonSqrt";
            this.ButtonSqrt.Size = new System.Drawing.Size(90, 70);
            this.ButtonSqrt.TabIndex = 8;
            this.ButtonSqrt.Text = "√x";
            this.ButtonSqrt.UseVisualStyleBackColor = true;
            this.ButtonSqrt.Click += new System.EventHandler(this.ButtonSqrt_Click);
            // 
            // ButtonDivide
            // 
            this.ButtonDivide.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonDivide.Location = new System.Drawing.Point(300, 173);
            this.ButtonDivide.Name = "ButtonDivide";
            this.ButtonDivide.Size = new System.Drawing.Size(90, 70);
            this.ButtonDivide.TabIndex = 9;
            this.ButtonDivide.Text = "/";
            this.ButtonDivide.UseVisualStyleBackColor = true;
            this.ButtonDivide.Click += new System.EventHandler(this.Operators_Click);
            // 
            // Button7
            // 
            this.Button7.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button7.Location = new System.Drawing.Point(12, 250);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(90, 70);
            this.Button7.TabIndex = 13;
            this.Button7.Text = "7";
            this.Button7.UseVisualStyleBackColor = true;
            this.Button7.Click += new System.EventHandler(this.ButtonsNumC_Click);
            // 
            // Button8
            // 
            this.Button8.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button8.Location = new System.Drawing.Point(108, 250);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(90, 70);
            this.Button8.TabIndex = 12;
            this.Button8.Text = "8";
            this.Button8.UseVisualStyleBackColor = true;
            this.Button8.Click += new System.EventHandler(this.ButtonsNumC_Click);
            // 
            // Button9
            // 
            this.Button9.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button9.Location = new System.Drawing.Point(204, 250);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(90, 70);
            this.Button9.TabIndex = 11;
            this.Button9.Text = "9";
            this.Button9.UseVisualStyleBackColor = true;
            this.Button9.Click += new System.EventHandler(this.ButtonsNumC_Click);
            // 
            // ButtonMultiply
            // 
            this.ButtonMultiply.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonMultiply.Location = new System.Drawing.Point(300, 249);
            this.ButtonMultiply.Name = "ButtonMultiply";
            this.ButtonMultiply.Size = new System.Drawing.Size(90, 70);
            this.ButtonMultiply.TabIndex = 10;
            this.ButtonMultiply.Text = "*";
            this.ButtonMultiply.UseVisualStyleBackColor = true;
            this.ButtonMultiply.Click += new System.EventHandler(this.Operators_Click);
            // 
            // Button4
            // 
            this.Button4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button4.Location = new System.Drawing.Point(12, 325);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(90, 70);
            this.Button4.TabIndex = 17;
            this.Button4.Text = "4";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.ButtonsNumC_Click);
            // 
            // Button5
            // 
            this.Button5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button5.Location = new System.Drawing.Point(108, 325);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(90, 70);
            this.Button5.TabIndex = 16;
            this.Button5.Text = "5";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.ButtonsNumC_Click);
            // 
            // Button6
            // 
            this.Button6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button6.Location = new System.Drawing.Point(204, 325);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(90, 70);
            this.Button6.TabIndex = 15;
            this.Button6.Text = "6";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.ButtonsNumC_Click);
            // 
            // ButtonMinus
            // 
            this.ButtonMinus.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonMinus.Location = new System.Drawing.Point(300, 325);
            this.ButtonMinus.Name = "ButtonMinus";
            this.ButtonMinus.Size = new System.Drawing.Size(90, 70);
            this.ButtonMinus.TabIndex = 14;
            this.ButtonMinus.Text = "-";
            this.ButtonMinus.UseVisualStyleBackColor = true;
            this.ButtonMinus.Click += new System.EventHandler(this.Operators_Click);
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button1.Location = new System.Drawing.Point(12, 400);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(90, 70);
            this.Button1.TabIndex = 21;
            this.Button1.Text = "1";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.ButtonsNumC_Click);
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button2.Location = new System.Drawing.Point(108, 400);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(90, 70);
            this.Button2.TabIndex = 20;
            this.Button2.Text = "2";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.ButtonsNumC_Click);
            // 
            // Button3
            // 
            this.Button3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button3.Location = new System.Drawing.Point(204, 400);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(90, 70);
            this.Button3.TabIndex = 19;
            this.Button3.Text = "3";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.ButtonsNumC_Click);
            // 
            // ButtonPlus
            // 
            this.ButtonPlus.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonPlus.Location = new System.Drawing.Point(300, 401);
            this.ButtonPlus.Name = "ButtonPlus";
            this.ButtonPlus.Size = new System.Drawing.Size(90, 70);
            this.ButtonPlus.TabIndex = 18;
            this.ButtonPlus.Text = "+";
            this.ButtonPlus.UseVisualStyleBackColor = true;
            this.ButtonPlus.Click += new System.EventHandler(this.Operators_Click);
            // 
            // ButtonPM
            // 
            this.ButtonPM.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonPM.Location = new System.Drawing.Point(12, 475);
            this.ButtonPM.Name = "ButtonPM";
            this.ButtonPM.Size = new System.Drawing.Size(90, 70);
            this.ButtonPM.TabIndex = 25;
            this.ButtonPM.Text = "±";
            this.ButtonPM.UseVisualStyleBackColor = true;
            this.ButtonPM.Click += new System.EventHandler(this.ButtonPM_Click);
            // 
            // Button0
            // 
            this.Button0.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button0.Location = new System.Drawing.Point(108, 475);
            this.Button0.Name = "Button0";
            this.Button0.Size = new System.Drawing.Size(90, 70);
            this.Button0.TabIndex = 24;
            this.Button0.Text = "0";
            this.Button0.UseVisualStyleBackColor = true;
            this.Button0.Click += new System.EventHandler(this.ButtonsNumC_Click);
            // 
            // ButtonComma
            // 
            this.ButtonComma.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonComma.Location = new System.Drawing.Point(204, 475);
            this.ButtonComma.Name = "ButtonComma";
            this.ButtonComma.Size = new System.Drawing.Size(90, 70);
            this.ButtonComma.TabIndex = 23;
            this.ButtonComma.Text = ",";
            this.ButtonComma.UseVisualStyleBackColor = true;
            this.ButtonComma.Click += new System.EventHandler(this.ButtonsNumC_Click);
            // 
            // ButtonEquals
            // 
            this.ButtonEquals.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonEquals.Location = new System.Drawing.Point(300, 477);
            this.ButtonEquals.Name = "ButtonEquals";
            this.ButtonEquals.Size = new System.Drawing.Size(90, 70);
            this.ButtonEquals.TabIndex = 22;
            this.ButtonEquals.Text = "=";
            this.ButtonEquals.UseVisualStyleBackColor = true;
            this.ButtonEquals.Click += new System.EventHandler(this.ButtonEquals_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 31);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 20);
            this.label.TabIndex = 26;
            // 
            // ButtonPi
            // 
            this.ButtonPi.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonPi.Location = new System.Drawing.Point(396, 99);
            this.ButtonPi.Name = "ButtonPi";
            this.ButtonPi.Size = new System.Drawing.Size(90, 70);
            this.ButtonPi.TabIndex = 27;
            this.ButtonPi.Text = "π";
            this.ButtonPi.UseVisualStyleBackColor = true;
            this.ButtonPi.Click += new System.EventHandler(this.ButtonPi_Click);
            // 
            // ButtonE
            // 
            this.ButtonE.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonE.Location = new System.Drawing.Point(492, 99);
            this.ButtonE.Name = "ButtonE";
            this.ButtonE.Size = new System.Drawing.Size(90, 70);
            this.ButtonE.TabIndex = 28;
            this.ButtonE.Text = "e";
            this.ButtonE.UseVisualStyleBackColor = true;
            this.ButtonE.Click += new System.EventHandler(this.ButtonE_Click);
            // 
            // ButtonAbs
            // 
            this.ButtonAbs.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonAbs.Location = new System.Drawing.Point(588, 99);
            this.ButtonAbs.Name = "ButtonAbs";
            this.ButtonAbs.Size = new System.Drawing.Size(90, 70);
            this.ButtonAbs.TabIndex = 29;
            this.ButtonAbs.Text = "|x|";
            this.ButtonAbs.UseVisualStyleBackColor = true;
            this.ButtonAbs.Click += new System.EventHandler(this.ButtonAbs_Click);
            // 
            // ButtonMod
            // 
            this.ButtonMod.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonMod.Location = new System.Drawing.Point(684, 99);
            this.ButtonMod.Name = "ButtonMod";
            this.ButtonMod.Size = new System.Drawing.Size(90, 70);
            this.ButtonMod.TabIndex = 30;
            this.ButtonMod.Text = "Mod";
            this.ButtonMod.UseVisualStyleBackColor = true;
            this.ButtonMod.Click += new System.EventHandler(this.Operators_Click);
            // 
            // ButtonFact
            // 
            this.ButtonFact.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonFact.Location = new System.Drawing.Point(396, 175);
            this.ButtonFact.Name = "ButtonFact";
            this.ButtonFact.Size = new System.Drawing.Size(90, 70);
            this.ButtonFact.TabIndex = 31;
            this.ButtonFact.Text = "x!";
            this.ButtonFact.UseVisualStyleBackColor = true;
            this.ButtonFact.Click += new System.EventHandler(this.ButtonFact_Click);
            // 
            // ButtonP1
            // 
            this.ButtonP1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonP1.Location = new System.Drawing.Point(492, 175);
            this.ButtonP1.Name = "ButtonP1";
            this.ButtonP1.Size = new System.Drawing.Size(90, 70);
            this.ButtonP1.TabIndex = 32;
            this.ButtonP1.Text = "(";
            this.ButtonP1.UseVisualStyleBackColor = true;
            this.ButtonP1.Click += new System.EventHandler(this.ButtonP1_Click);
            // 
            // ButtonP2
            // 
            this.ButtonP2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonP2.Location = new System.Drawing.Point(588, 175);
            this.ButtonP2.Name = "ButtonP2";
            this.ButtonP2.Size = new System.Drawing.Size(90, 70);
            this.ButtonP2.TabIndex = 33;
            this.ButtonP2.Text = ")";
            this.ButtonP2.UseVisualStyleBackColor = true;
            this.ButtonP2.Click += new System.EventHandler(this.ButtonP2_Click);
            // 
            // ButtonExp
            // 
            this.ButtonExp.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonExp.Location = new System.Drawing.Point(684, 175);
            this.ButtonExp.Name = "ButtonExp";
            this.ButtonExp.Size = new System.Drawing.Size(90, 70);
            this.ButtonExp.TabIndex = 34;
            this.ButtonExp.Text = "Exp";
            this.ButtonExp.UseVisualStyleBackColor = true;
            this.ButtonExp.Click += new System.EventHandler(this.ButtonExp_Click);
            // 
            // ButtonSin
            // 
            this.ButtonSin.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonSin.Location = new System.Drawing.Point(396, 251);
            this.ButtonSin.Name = "ButtonSin";
            this.ButtonSin.Size = new System.Drawing.Size(90, 70);
            this.ButtonSin.TabIndex = 35;
            this.ButtonSin.Text = "Sin";
            this.ButtonSin.UseVisualStyleBackColor = true;
            this.ButtonSin.Click += new System.EventHandler(this.ButtonSin_Click);
            // 
            // ButtonSinh
            // 
            this.ButtonSinh.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonSinh.Location = new System.Drawing.Point(492, 251);
            this.ButtonSinh.Name = "ButtonSinh";
            this.ButtonSinh.Size = new System.Drawing.Size(90, 70);
            this.ButtonSinh.TabIndex = 36;
            this.ButtonSinh.Text = "Sinh";
            this.ButtonSinh.UseVisualStyleBackColor = true;
            this.ButtonSinh.Click += new System.EventHandler(this.ButtonSinh_Click);
            // 
            // ButtonCos
            // 
            this.ButtonCos.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonCos.Location = new System.Drawing.Point(588, 251);
            this.ButtonCos.Name = "ButtonCos";
            this.ButtonCos.Size = new System.Drawing.Size(90, 70);
            this.ButtonCos.TabIndex = 37;
            this.ButtonCos.Text = "Cos";
            this.ButtonCos.UseVisualStyleBackColor = true;
            this.ButtonCos.Click += new System.EventHandler(this.ButtonCos_Click);
            // 
            // ButtonCosh
            // 
            this.ButtonCosh.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonCosh.Location = new System.Drawing.Point(684, 251);
            this.ButtonCosh.Name = "ButtonCosh";
            this.ButtonCosh.Size = new System.Drawing.Size(90, 70);
            this.ButtonCosh.TabIndex = 38;
            this.ButtonCosh.Text = "Cosh";
            this.ButtonCosh.UseVisualStyleBackColor = true;
            this.ButtonCosh.Click += new System.EventHandler(this.ButtonCosh_Click);
            // 
            // ButtonCot
            // 
            this.ButtonCot.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonCot.Location = new System.Drawing.Point(684, 327);
            this.ButtonCot.Name = "ButtonCot";
            this.ButtonCot.Size = new System.Drawing.Size(90, 70);
            this.ButtonCot.TabIndex = 42;
            this.ButtonCot.Text = "Cot";
            this.ButtonCot.UseVisualStyleBackColor = true;
            this.ButtonCot.Click += new System.EventHandler(this.ButtonCot_Click);
            // 
            // ButtonTan
            // 
            this.ButtonTan.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonTan.Location = new System.Drawing.Point(588, 327);
            this.ButtonTan.Name = "ButtonTan";
            this.ButtonTan.Size = new System.Drawing.Size(90, 70);
            this.ButtonTan.TabIndex = 41;
            this.ButtonTan.Text = "Tan";
            this.ButtonTan.UseVisualStyleBackColor = true;
            this.ButtonTan.Click += new System.EventHandler(this.ButtonTan_Click);
            // 
            // ButtonAcos
            // 
            this.ButtonAcos.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonAcos.Location = new System.Drawing.Point(492, 327);
            this.ButtonAcos.Name = "ButtonAcos";
            this.ButtonAcos.Size = new System.Drawing.Size(90, 70);
            this.ButtonAcos.TabIndex = 40;
            this.ButtonAcos.Text = "Cos⁻¹";
            this.ButtonAcos.UseVisualStyleBackColor = true;
            this.ButtonAcos.Click += new System.EventHandler(this.ButtonAcos_Click);
            // 
            // ButtonAsin
            // 
            this.ButtonAsin.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonAsin.Location = new System.Drawing.Point(396, 327);
            this.ButtonAsin.Name = "ButtonAsin";
            this.ButtonAsin.Size = new System.Drawing.Size(90, 70);
            this.ButtonAsin.TabIndex = 39;
            this.ButtonAsin.Text = "Sin⁻¹";
            this.ButtonAsin.UseVisualStyleBackColor = true;
            this.ButtonAsin.Click += new System.EventHandler(this.ButtonAsin_Click);
            // 
            // Button2Powx
            // 
            this.Button2Powx.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button2Powx.Location = new System.Drawing.Point(684, 403);
            this.Button2Powx.Name = "Button2Powx";
            this.Button2Powx.Size = new System.Drawing.Size(90, 70);
            this.Button2Powx.TabIndex = 46;
            this.Button2Powx.Text = "2ˣ";
            this.Button2Powx.UseVisualStyleBackColor = true;
            this.Button2Powx.Click += new System.EventHandler(this.Button2Powx_Click);
            // 
            // ButtonAtan
            // 
            this.ButtonAtan.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonAtan.Location = new System.Drawing.Point(588, 403);
            this.ButtonAtan.Name = "ButtonAtan";
            this.ButtonAtan.Size = new System.Drawing.Size(90, 70);
            this.ButtonAtan.TabIndex = 45;
            this.ButtonAtan.Text = "Tan⁻¹";
            this.ButtonAtan.UseVisualStyleBackColor = true;
            this.ButtonAtan.Click += new System.EventHandler(this.ButtonAtan_Click);
            // 
            // ButtonxYroot
            // 
            this.ButtonxYroot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonxYroot.Location = new System.Drawing.Point(492, 403);
            this.ButtonxYroot.Name = "ButtonxYroot";
            this.ButtonxYroot.Size = new System.Drawing.Size(90, 70);
            this.ButtonxYroot.TabIndex = 44;
            this.ButtonxYroot.Text = "x^(1/y)";
            this.ButtonxYroot.UseVisualStyleBackColor = true;
            this.ButtonxYroot.Click += new System.EventHandler(this.Operators_Click);
            // 
            // ButtonxPowy
            // 
            this.ButtonxPowy.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonxPowy.Location = new System.Drawing.Point(396, 403);
            this.ButtonxPowy.Name = "ButtonxPowy";
            this.ButtonxPowy.Size = new System.Drawing.Size(90, 70);
            this.ButtonxPowy.TabIndex = 43;
            this.ButtonxPowy.Text = "x^y";
            this.ButtonxPowy.UseVisualStyleBackColor = true;
            this.ButtonxPowy.Click += new System.EventHandler(this.Operators_Click);
            // 
            // ButtonePowx
            // 
            this.ButtonePowx.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonePowx.Location = new System.Drawing.Point(684, 479);
            this.ButtonePowx.Name = "ButtonePowx";
            this.ButtonePowx.Size = new System.Drawing.Size(90, 70);
            this.ButtonePowx.TabIndex = 50;
            this.ButtonePowx.Text = "eˣ";
            this.ButtonePowx.UseVisualStyleBackColor = true;
            this.ButtonePowx.Click += new System.EventHandler(this.ButtonePowx_Click);
            // 
            // ButtonLogxy
            // 
            this.ButtonLogxy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonLogxy.Location = new System.Drawing.Point(588, 479);
            this.ButtonLogxy.Name = "ButtonLogxy";
            this.ButtonLogxy.Size = new System.Drawing.Size(90, 70);
            this.ButtonLogxy.TabIndex = 49;
            this.ButtonLogxy.Text = "logx(y)";
            this.ButtonLogxy.UseVisualStyleBackColor = true;
            this.ButtonLogxy.Click += new System.EventHandler(this.Operators_Click);
            // 
            // ButtonLn
            // 
            this.ButtonLn.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonLn.Location = new System.Drawing.Point(492, 479);
            this.ButtonLn.Name = "ButtonLn";
            this.ButtonLn.Size = new System.Drawing.Size(90, 70);
            this.ButtonLn.TabIndex = 48;
            this.ButtonLn.Text = "ln";
            this.ButtonLn.UseVisualStyleBackColor = true;
            this.ButtonLn.Click += new System.EventHandler(this.ButtonLn_Click);
            // 
            // ButtonLg
            // 
            this.ButtonLg.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonLg.Location = new System.Drawing.Point(396, 479);
            this.ButtonLg.Name = "ButtonLg";
            this.ButtonLg.Size = new System.Drawing.Size(90, 70);
            this.ButtonLg.TabIndex = 47;
            this.ButtonLg.Text = "lg";
            this.ButtonLg.UseVisualStyleBackColor = true;
            this.ButtonLg.Click += new System.EventHandler(this.ButtonLg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 553);
            this.Controls.Add(this.ButtonePowx);
            this.Controls.Add(this.ButtonLogxy);
            this.Controls.Add(this.ButtonLn);
            this.Controls.Add(this.ButtonLg);
            this.Controls.Add(this.Button2Powx);
            this.Controls.Add(this.ButtonAtan);
            this.Controls.Add(this.ButtonxYroot);
            this.Controls.Add(this.ButtonxPowy);
            this.Controls.Add(this.ButtonCot);
            this.Controls.Add(this.ButtonTan);
            this.Controls.Add(this.ButtonAcos);
            this.Controls.Add(this.ButtonAsin);
            this.Controls.Add(this.ButtonCosh);
            this.Controls.Add(this.ButtonCos);
            this.Controls.Add(this.ButtonSinh);
            this.Controls.Add(this.ButtonSin);
            this.Controls.Add(this.ButtonExp);
            this.Controls.Add(this.ButtonP2);
            this.Controls.Add(this.ButtonP1);
            this.Controls.Add(this.ButtonFact);
            this.Controls.Add(this.ButtonMod);
            this.Controls.Add(this.ButtonAbs);
            this.Controls.Add(this.ButtonE);
            this.Controls.Add(this.ButtonPi);
            this.Controls.Add(this.label);
            this.Controls.Add(this.ButtonPM);
            this.Controls.Add(this.Button0);
            this.Controls.Add(this.ButtonComma);
            this.Controls.Add(this.ButtonEquals);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.ButtonPlus);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.ButtonMinus);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.Button8);
            this.Controls.Add(this.Button9);
            this.Controls.Add(this.ButtonMultiply);
            this.Controls.Add(this.ButtonDivide);
            this.Controls.Add(this.ButtonSqrt);
            this.Controls.Add(this.ButtonSquare);
            this.Controls.Add(this.ButtonInverse);
            this.Controls.Add(this.ButtonBS);
            this.Controls.Add(this.ButtonC);
            this.Controls.Add(this.ButtonCE);
            this.Controls.Add(this.ButtonPercent);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(415, 600);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem standardToolStripMenuItem;
        private ToolStripMenuItem scientificToolStripMenuItem;
        private ToolStripMenuItem complexToolStripMenuItem;
        private Button ButtonPercent;
        private Button ButtonCE;
        private Button ButtonC;
        private Button ButtonBS;
        private Button ButtonInverse;
        private Button ButtonSquare;
        private Button ButtonSqrt;
        private Button ButtonDivide;
        private Button Button7;
        private Button Button8;
        private Button Button9;
        private Button ButtonMultiply;
        private Button Button4;
        private Button Button5;
        private Button Button6;
        private Button ButtonMinus;
        private Button Button1;
        private Button Button2;
        private Button Button3;
        private Button ButtonPlus;
        private Button ButtonPM;
        private Button Button0;
        private Button ButtonComma;
        private Button ButtonEquals;
        private Label label;
        private Button ButtonPi;
        private Button ButtonE;
        private Button ButtonAbs;
        private Button ButtonMod;
        private Button ButtonFact;
        private Button ButtonP1;
        private Button ButtonP2;
        private Button ButtonExp;
        private Button ButtonSin;
        private Button ButtonSinh;
        private Button ButtonCos;
        private Button ButtonCosh;
        private Button ButtonCot;
        private Button ButtonTan;
        private Button ButtonAcos;
        private Button ButtonAsin;
        private Button Button2Powx;
        private Button ButtonAtan;
        private Button ButtonxYroot;
        private Button ButtonxPowy;
        private Button ButtonePowx;
        private Button ButtonLogxy;
        private Button ButtonLn;
        private Button ButtonLg;
        private ToolStripMenuItem radiansToolStripMenuItem;
        private ToolStripMenuItem degreesToolStripMenuItem;
        internal TextBox textBox;
    }
}