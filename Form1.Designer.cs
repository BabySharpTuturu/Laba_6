
namespace PKG_6
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbAngleOx = new System.Windows.Forms.TrackBar();
            this.tbAngleOy = new System.Windows.Forms.TrackBar();
            this.tbAngleOz = new System.Windows.Forms.TrackBar();
            this.tbGlobalCoordsOz = new System.Windows.Forms.TrackBar();
            this.tbGlobalCoordsOy = new System.Windows.Forms.TrackBar();
            this.tbGlobalCoordsOx = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numUDTranslateOz = new System.Windows.Forms.NumericUpDown();
            this.numUDTranslateOy = new System.Windows.Forms.NumericUpDown();
            this.numUDTranslateOx = new System.Windows.Forms.NumericUpDown();
            this.bTranslate = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label17 = new System.Windows.Forms.Label();
            this.rbProfile = new System.Windows.Forms.RadioButton();
            this.rbHorizontal = new System.Windows.Forms.RadioButton();
            this.rbFrontal = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.numUDScale = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.bScale = new System.Windows.Forms.Button();
            this.tb00 = new System.Windows.Forms.TextBox();
            this.tb10 = new System.Windows.Forms.TextBox();
            this.tb20 = new System.Windows.Forms.TextBox();
            this.tb30 = new System.Windows.Forms.TextBox();
            this.tb01 = new System.Windows.Forms.TextBox();
            this.tb11 = new System.Windows.Forms.TextBox();
            this.tb21 = new System.Windows.Forms.TextBox();
            this.tb31 = new System.Windows.Forms.TextBox();
            this.tb02 = new System.Windows.Forms.TextBox();
            this.tb12 = new System.Windows.Forms.TextBox();
            this.tb22 = new System.Windows.Forms.TextBox();
            this.tb32 = new System.Windows.Forms.TextBox();
            this.tb03 = new System.Windows.Forms.TextBox();
            this.tb13 = new System.Windows.Forms.TextBox();
            this.tb23 = new System.Windows.Forms.TextBox();
            this.tb33 = new System.Windows.Forms.TextBox();
            this.tbAngleOzOCS = new System.Windows.Forms.TextBox();
            this.tbAngleOyOCS = new System.Windows.Forms.TextBox();
            this.tbAngleOxOCS = new System.Windows.Forms.TextBox();
            this.tbAngleOzGCS = new System.Windows.Forms.TextBox();
            this.tbAngleOyGCS = new System.Windows.Forms.TextBox();
            this.tbAngleOxGCS = new System.Windows.Forms.TextBox();
            this.bDist = new System.Windows.Forms.Button();
            this.lbDist = new System.Windows.Forms.Label();
            this.numUDDist = new System.Windows.Forms.NumericUpDown();
            this.bResetAffine = new System.Windows.Forms.Button();
            this.bResetPicture = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbYes = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAngleOx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAngleOy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAngleOz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGlobalCoordsOz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGlobalCoordsOy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGlobalCoordsOx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDTranslateOz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDTranslateOy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDTranslateOx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDDist)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(10, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1230, 461);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // tbAngleOx
            // 
            this.tbAngleOx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAngleOx.Location = new System.Drawing.Point(105, 568);
            this.tbAngleOx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAngleOx.Maximum = 180;
            this.tbAngleOx.Minimum = -180;
            this.tbAngleOx.Name = "tbAngleOx";
            this.tbAngleOx.Size = new System.Drawing.Size(214, 56);
            this.tbAngleOx.TabIndex = 1;
            this.tbAngleOx.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbAngleOx.ValueChanged += new System.EventHandler(this.tbObjectAngles_ValueChanged);
            // 
            // tbAngleOy
            // 
            this.tbAngleOy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAngleOy.Location = new System.Drawing.Point(105, 594);
            this.tbAngleOy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAngleOy.Maximum = 180;
            this.tbAngleOy.Minimum = -180;
            this.tbAngleOy.Name = "tbAngleOy";
            this.tbAngleOy.Size = new System.Drawing.Size(214, 56);
            this.tbAngleOy.TabIndex = 2;
            this.tbAngleOy.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbAngleOy.ValueChanged += new System.EventHandler(this.tbObjectAngles_ValueChanged);
            // 
            // tbAngleOz
            // 
            this.tbAngleOz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAngleOz.Location = new System.Drawing.Point(105, 621);
            this.tbAngleOz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAngleOz.Maximum = 180;
            this.tbAngleOz.Minimum = -180;
            this.tbAngleOz.Name = "tbAngleOz";
            this.tbAngleOz.Size = new System.Drawing.Size(214, 56);
            this.tbAngleOz.TabIndex = 3;
            this.tbAngleOz.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbAngleOz.ValueChanged += new System.EventHandler(this.tbObjectAngles_ValueChanged);
            // 
            // tbGlobalCoordsOz
            // 
            this.tbGlobalCoordsOz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGlobalCoordsOz.Location = new System.Drawing.Point(474, 618);
            this.tbGlobalCoordsOz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbGlobalCoordsOz.Maximum = 180;
            this.tbGlobalCoordsOz.Minimum = -180;
            this.tbGlobalCoordsOz.Name = "tbGlobalCoordsOz";
            this.tbGlobalCoordsOz.Size = new System.Drawing.Size(210, 56);
            this.tbGlobalCoordsOz.TabIndex = 6;
            this.tbGlobalCoordsOz.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbGlobalCoordsOz.ValueChanged += new System.EventHandler(this.tbGlobalAngles_ValueChanged);
            // 
            // tbGlobalCoordsOy
            // 
            this.tbGlobalCoordsOy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGlobalCoordsOy.Location = new System.Drawing.Point(474, 594);
            this.tbGlobalCoordsOy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbGlobalCoordsOy.Maximum = 180;
            this.tbGlobalCoordsOy.Minimum = -180;
            this.tbGlobalCoordsOy.Name = "tbGlobalCoordsOy";
            this.tbGlobalCoordsOy.Size = new System.Drawing.Size(210, 56);
            this.tbGlobalCoordsOy.TabIndex = 5;
            this.tbGlobalCoordsOy.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbGlobalCoordsOy.ValueChanged += new System.EventHandler(this.tbGlobalAngles_ValueChanged);
            // 
            // tbGlobalCoordsOx
            // 
            this.tbGlobalCoordsOx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGlobalCoordsOx.Location = new System.Drawing.Point(475, 568);
            this.tbGlobalCoordsOx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbGlobalCoordsOx.Maximum = 180;
            this.tbGlobalCoordsOx.Minimum = -180;
            this.tbGlobalCoordsOx.Name = "tbGlobalCoordsOx";
            this.tbGlobalCoordsOx.Size = new System.Drawing.Size(210, 56);
            this.tbGlobalCoordsOx.TabIndex = 4;
            this.tbGlobalCoordsOx.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbGlobalCoordsOx.ValueChanged += new System.EventHandler(this.tbGlobalAngles_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 539);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Rotation in object coodinate system";
            this.toolTip1.SetToolTip(this.label1, "Rotate the object in object\'s coodinate system around axis (counterclockwise dire" +
        "ction)");
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 542);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Rotation of observer\'s perspective";
            this.toolTip1.SetToolTip(this.label2, "Rotate the observer\'s position in global coordinate system around axis (countercl" +
        "ockwise)");
            // 
            // numUDTranslateOz
            // 
            this.numUDTranslateOz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numUDTranslateOz.Location = new System.Drawing.Point(253, 516);
            this.numUDTranslateOz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numUDTranslateOz.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numUDTranslateOz.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.numUDTranslateOz.Name = "numUDTranslateOz";
            this.numUDTranslateOz.Size = new System.Drawing.Size(66, 22);
            this.numUDTranslateOz.TabIndex = 17;
            // 
            // numUDTranslateOy
            // 
            this.numUDTranslateOy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numUDTranslateOy.Location = new System.Drawing.Point(145, 514);
            this.numUDTranslateOy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numUDTranslateOy.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numUDTranslateOy.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.numUDTranslateOy.Name = "numUDTranslateOy";
            this.numUDTranslateOy.Size = new System.Drawing.Size(66, 22);
            this.numUDTranslateOy.TabIndex = 16;
            // 
            // numUDTranslateOx
            // 
            this.numUDTranslateOx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numUDTranslateOx.Location = new System.Drawing.Point(33, 516);
            this.numUDTranslateOx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numUDTranslateOx.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numUDTranslateOx.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.numUDTranslateOx.Name = "numUDTranslateOx";
            this.numUDTranslateOx.Size = new System.Drawing.Size(66, 22);
            this.numUDTranslateOx.TabIndex = 15;
            // 
            // bTranslate
            // 
            this.bTranslate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bTranslate.Location = new System.Drawing.Point(14, 487);
            this.bTranslate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bTranslate.Name = "bTranslate";
            this.bTranslate.Size = new System.Drawing.Size(305, 23);
            this.bTranslate.TabIndex = 18;
            this.bTranslate.Text = "Translate";
            this.bTranslate.UseVisualStyleBackColor = true;
            this.bTranslate.Click += new System.EventHandler(this.bTranslate_Click);
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(800, 528);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(165, 16);
            this.label17.TabIndex = 35;
            this.label17.Text = "Affine transformation matrix";
            this.toolTip1.SetToolTip(this.label17, "Current affine transformation matrix");
            // 
            // rbProfile
            // 
            this.rbProfile.AutoSize = true;
            this.rbProfile.Location = new System.Drawing.Point(113, 21);
            this.rbProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbProfile.Name = "rbProfile";
            this.rbProfile.Size = new System.Drawing.Size(65, 20);
            this.rbProfile.TabIndex = 2;
            this.rbProfile.Text = "profile";
            this.toolTip1.SetToolTip(this.rbProfile, "Oyz");
            this.rbProfile.UseVisualStyleBackColor = true;
            this.rbProfile.CheckedChanged += new System.EventHandler(this.rbProfile_CheckedChanged);
            // 
            // rbHorizontal
            // 
            this.rbHorizontal.AutoSize = true;
            this.rbHorizontal.Location = new System.Drawing.Point(6, 45);
            this.rbHorizontal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbHorizontal.Name = "rbHorizontal";
            this.rbHorizontal.Size = new System.Drawing.Size(85, 20);
            this.rbHorizontal.TabIndex = 1;
            this.rbHorizontal.Text = "horizontal";
            this.toolTip1.SetToolTip(this.rbHorizontal, "Oxy");
            this.rbHorizontal.UseVisualStyleBackColor = true;
            this.rbHorizontal.CheckedChanged += new System.EventHandler(this.rbProfile_CheckedChanged);
            // 
            // rbFrontal
            // 
            this.rbFrontal.AutoSize = true;
            this.rbFrontal.Location = new System.Drawing.Point(6, 21);
            this.rbFrontal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbFrontal.Name = "rbFrontal";
            this.rbFrontal.Size = new System.Drawing.Size(64, 20);
            this.rbFrontal.TabIndex = 0;
            this.rbFrontal.Text = "frontal";
            this.toolTip1.SetToolTip(this.rbFrontal, "Oxz");
            this.rbFrontal.UseVisualStyleBackColor = true;
            this.rbFrontal.CheckedChanged += new System.EventHandler(this.rbProfile_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 574);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ox (α)";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 600);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Oy (β)";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 627);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Oz (γ)";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(374, 627);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Oz (γ)";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(374, 600);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Oy (β)";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(375, 574);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Ox (α)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 16);
            this.label10.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(231, 516);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 16);
            this.label12.TabIndex = 30;
            this.label12.Text = "z";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(123, 515);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 16);
            this.label13.TabIndex = 29;
            this.label13.Text = "y";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 516);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 16);
            this.label14.TabIndex = 28;
            this.label14.Text = "x";
            // 
            // numUDScale
            // 
            this.numUDScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numUDScale.DecimalPlaces = 2;
            this.numUDScale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numUDScale.Location = new System.Drawing.Point(607, 518);
            this.numUDScale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numUDScale.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUDScale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numUDScale.Name = "numUDScale";
            this.numUDScale.Size = new System.Drawing.Size(77, 22);
            this.numUDScale.TabIndex = 32;
            this.numUDScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(557, 520);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 16);
            this.label16.TabIndex = 33;
            this.label16.Text = "Scale";
            // 
            // bScale
            // 
            this.bScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bScale.Location = new System.Drawing.Point(560, 487);
            this.bScale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bScale.Name = "bScale";
            this.bScale.Size = new System.Drawing.Size(124, 23);
            this.bScale.TabIndex = 34;
            this.bScale.Text = "Change scale";
            this.bScale.UseVisualStyleBackColor = true;
            this.bScale.Click += new System.EventHandler(this.bScale_Click);
            // 
            // tb00
            // 
            this.tb00.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb00.Location = new System.Drawing.Point(727, 546);
            this.tb00.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb00.MaxLength = 7;
            this.tb00.Name = "tb00";
            this.tb00.ReadOnly = true;
            this.tb00.Size = new System.Drawing.Size(70, 22);
            this.tb00.TabIndex = 36;
            // 
            // tb10
            // 
            this.tb10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb10.Location = new System.Drawing.Point(727, 572);
            this.tb10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb10.MaxLength = 7;
            this.tb10.Name = "tb10";
            this.tb10.ReadOnly = true;
            this.tb10.Size = new System.Drawing.Size(70, 22);
            this.tb10.TabIndex = 37;
            // 
            // tb20
            // 
            this.tb20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb20.Location = new System.Drawing.Point(727, 598);
            this.tb20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb20.MaxLength = 7;
            this.tb20.Name = "tb20";
            this.tb20.ReadOnly = true;
            this.tb20.Size = new System.Drawing.Size(70, 22);
            this.tb20.TabIndex = 38;
            // 
            // tb30
            // 
            this.tb30.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb30.Location = new System.Drawing.Point(727, 624);
            this.tb30.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb30.MaxLength = 7;
            this.tb30.Name = "tb30";
            this.tb30.ReadOnly = true;
            this.tb30.Size = new System.Drawing.Size(70, 22);
            this.tb30.TabIndex = 39;
            // 
            // tb01
            // 
            this.tb01.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb01.Location = new System.Drawing.Point(803, 546);
            this.tb01.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb01.MaxLength = 7;
            this.tb01.Name = "tb01";
            this.tb01.ReadOnly = true;
            this.tb01.Size = new System.Drawing.Size(70, 22);
            this.tb01.TabIndex = 40;
            // 
            // tb11
            // 
            this.tb11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb11.Location = new System.Drawing.Point(803, 572);
            this.tb11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb11.MaxLength = 7;
            this.tb11.Name = "tb11";
            this.tb11.ReadOnly = true;
            this.tb11.Size = new System.Drawing.Size(70, 22);
            this.tb11.TabIndex = 41;
            // 
            // tb21
            // 
            this.tb21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb21.Location = new System.Drawing.Point(803, 598);
            this.tb21.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb21.MaxLength = 7;
            this.tb21.Name = "tb21";
            this.tb21.ReadOnly = true;
            this.tb21.Size = new System.Drawing.Size(70, 22);
            this.tb21.TabIndex = 42;
            // 
            // tb31
            // 
            this.tb31.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb31.Location = new System.Drawing.Point(803, 624);
            this.tb31.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb31.MaxLength = 7;
            this.tb31.Name = "tb31";
            this.tb31.ReadOnly = true;
            this.tb31.Size = new System.Drawing.Size(70, 22);
            this.tb31.TabIndex = 43;
            // 
            // tb02
            // 
            this.tb02.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb02.Location = new System.Drawing.Point(879, 546);
            this.tb02.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb02.MaxLength = 7;
            this.tb02.Name = "tb02";
            this.tb02.ReadOnly = true;
            this.tb02.Size = new System.Drawing.Size(70, 22);
            this.tb02.TabIndex = 44;
            // 
            // tb12
            // 
            this.tb12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb12.Location = new System.Drawing.Point(879, 572);
            this.tb12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb12.MaxLength = 7;
            this.tb12.Name = "tb12";
            this.tb12.ReadOnly = true;
            this.tb12.Size = new System.Drawing.Size(70, 22);
            this.tb12.TabIndex = 45;
            // 
            // tb22
            // 
            this.tb22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb22.Location = new System.Drawing.Point(879, 598);
            this.tb22.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb22.MaxLength = 7;
            this.tb22.Name = "tb22";
            this.tb22.ReadOnly = true;
            this.tb22.Size = new System.Drawing.Size(70, 22);
            this.tb22.TabIndex = 46;
            // 
            // tb32
            // 
            this.tb32.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb32.Location = new System.Drawing.Point(879, 624);
            this.tb32.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb32.MaxLength = 7;
            this.tb32.Name = "tb32";
            this.tb32.ReadOnly = true;
            this.tb32.Size = new System.Drawing.Size(70, 22);
            this.tb32.TabIndex = 47;
            // 
            // tb03
            // 
            this.tb03.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb03.Location = new System.Drawing.Point(955, 546);
            this.tb03.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb03.MaxLength = 7;
            this.tb03.Name = "tb03";
            this.tb03.ReadOnly = true;
            this.tb03.Size = new System.Drawing.Size(70, 22);
            this.tb03.TabIndex = 48;
            // 
            // tb13
            // 
            this.tb13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb13.Location = new System.Drawing.Point(955, 572);
            this.tb13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb13.MaxLength = 7;
            this.tb13.Name = "tb13";
            this.tb13.ReadOnly = true;
            this.tb13.Size = new System.Drawing.Size(70, 22);
            this.tb13.TabIndex = 49;
            // 
            // tb23
            // 
            this.tb23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb23.Location = new System.Drawing.Point(955, 598);
            this.tb23.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb23.MaxLength = 7;
            this.tb23.Name = "tb23";
            this.tb23.ReadOnly = true;
            this.tb23.Size = new System.Drawing.Size(70, 22);
            this.tb23.TabIndex = 50;
            // 
            // tb33
            // 
            this.tb33.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb33.Location = new System.Drawing.Point(955, 624);
            this.tb33.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb33.MaxLength = 7;
            this.tb33.Name = "tb33";
            this.tb33.ReadOnly = true;
            this.tb33.Size = new System.Drawing.Size(70, 22);
            this.tb33.TabIndex = 51;
            // 
            // tbAngleOzOCS
            // 
            this.tbAngleOzOCS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAngleOzOCS.Location = new System.Drawing.Point(52, 621);
            this.tbAngleOzOCS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAngleOzOCS.MaxLength = 7;
            this.tbAngleOzOCS.Name = "tbAngleOzOCS";
            this.tbAngleOzOCS.ReadOnly = true;
            this.tbAngleOzOCS.Size = new System.Drawing.Size(47, 22);
            this.tbAngleOzOCS.TabIndex = 54;
            this.tbAngleOzOCS.Text = "0°";
            // 
            // tbAngleOyOCS
            // 
            this.tbAngleOyOCS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAngleOyOCS.Location = new System.Drawing.Point(52, 594);
            this.tbAngleOyOCS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAngleOyOCS.MaxLength = 7;
            this.tbAngleOyOCS.Name = "tbAngleOyOCS";
            this.tbAngleOyOCS.ReadOnly = true;
            this.tbAngleOyOCS.Size = new System.Drawing.Size(47, 22);
            this.tbAngleOyOCS.TabIndex = 53;
            this.tbAngleOyOCS.Text = "0°";
            // 
            // tbAngleOxOCS
            // 
            this.tbAngleOxOCS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAngleOxOCS.Location = new System.Drawing.Point(52, 568);
            this.tbAngleOxOCS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAngleOxOCS.MaxLength = 7;
            this.tbAngleOxOCS.Name = "tbAngleOxOCS";
            this.tbAngleOxOCS.ReadOnly = true;
            this.tbAngleOxOCS.Size = new System.Drawing.Size(47, 22);
            this.tbAngleOxOCS.TabIndex = 52;
            this.tbAngleOxOCS.Text = "0°";
            // 
            // tbAngleOzGCS
            // 
            this.tbAngleOzGCS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAngleOzGCS.Location = new System.Drawing.Point(421, 624);
            this.tbAngleOzGCS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAngleOzGCS.MaxLength = 7;
            this.tbAngleOzGCS.Name = "tbAngleOzGCS";
            this.tbAngleOzGCS.ReadOnly = true;
            this.tbAngleOzGCS.Size = new System.Drawing.Size(47, 22);
            this.tbAngleOzGCS.TabIndex = 57;
            this.tbAngleOzGCS.Text = "0°";
            // 
            // tbAngleOyGCS
            // 
            this.tbAngleOyGCS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAngleOyGCS.Location = new System.Drawing.Point(422, 600);
            this.tbAngleOyGCS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAngleOyGCS.MaxLength = 7;
            this.tbAngleOyGCS.Name = "tbAngleOyGCS";
            this.tbAngleOyGCS.ReadOnly = true;
            this.tbAngleOyGCS.Size = new System.Drawing.Size(47, 22);
            this.tbAngleOyGCS.TabIndex = 56;
            this.tbAngleOyGCS.Text = "0°";
            // 
            // tbAngleOxGCS
            // 
            this.tbAngleOxGCS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAngleOxGCS.Location = new System.Drawing.Point(422, 571);
            this.tbAngleOxGCS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAngleOxGCS.MaxLength = 7;
            this.tbAngleOxGCS.Name = "tbAngleOxGCS";
            this.tbAngleOxGCS.ReadOnly = true;
            this.tbAngleOxGCS.Size = new System.Drawing.Size(47, 22);
            this.tbAngleOxGCS.TabIndex = 55;
            this.tbAngleOxGCS.Text = "0°";
            // 
            // bDist
            // 
            this.bDist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bDist.Location = new System.Drawing.Point(377, 487);
            this.bDist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bDist.Name = "bDist";
            this.bDist.Size = new System.Drawing.Size(146, 23);
            this.bDist.TabIndex = 61;
            this.bDist.Text = "Change distance";
            this.bDist.UseVisualStyleBackColor = true;
            this.bDist.Click += new System.EventHandler(this.bDist_Click);
            // 
            // lbDist
            // 
            this.lbDist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDist.AutoSize = true;
            this.lbDist.Location = new System.Drawing.Point(374, 518);
            this.lbDist.Name = "lbDist";
            this.lbDist.Size = new System.Drawing.Size(60, 16);
            this.lbDist.TabIndex = 60;
            this.lbDist.Text = "Distance";
            // 
            // numUDDist
            // 
            this.numUDDist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numUDDist.DecimalPlaces = 2;
            this.numUDDist.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numUDDist.Location = new System.Drawing.Point(446, 516);
            this.numUDDist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numUDDist.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUDDist.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numUDDist.Name = "numUDDist";
            this.numUDDist.Size = new System.Drawing.Size(77, 22);
            this.numUDDist.TabIndex = 59;
            this.numUDDist.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bResetAffine
            // 
            this.bResetAffine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bResetAffine.Location = new System.Drawing.Point(727, 487);
            this.bResetAffine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bResetAffine.Name = "bResetAffine";
            this.bResetAffine.Size = new System.Drawing.Size(298, 23);
            this.bResetAffine.TabIndex = 62;
            this.bResetAffine.Text = "Reset affine transformation";
            this.bResetAffine.UseVisualStyleBackColor = true;
            this.bResetAffine.Click += new System.EventHandler(this.bResetAffine_Click);
            // 
            // bResetPicture
            // 
            this.bResetPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bResetPicture.Location = new System.Drawing.Point(1048, 487);
            this.bResetPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bResetPicture.Name = "bResetPicture";
            this.bResetPicture.Size = new System.Drawing.Size(192, 23);
            this.bResetPicture.TabIndex = 63;
            this.bResetPicture.Text = "Reset observer\'s position";
            this.bResetPicture.UseVisualStyleBackColor = true;
            this.bResetPicture.Click += new System.EventHandler(this.bResetPicture_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rbNone);
            this.groupBox1.Controls.Add(this.rbProfile);
            this.groupBox1.Controls.Add(this.rbHorizontal);
            this.groupBox1.Controls.Add(this.rbFrontal);
            this.groupBox1.Location = new System.Drawing.Point(1048, 530);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(192, 70);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Projections";
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Checked = true;
            this.rbNone.Location = new System.Drawing.Point(113, 45);
            this.rbNone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(58, 20);
            this.rbNone.TabIndex = 3;
            this.rbNone.TabStop = true;
            this.rbNone.Text = "none";
            this.rbNone.UseVisualStyleBackColor = true;
            this.rbNone.CheckedChanged += new System.EventHandler(this.rbProfile_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.rbNo);
            this.groupBox2.Controls.Add(this.rbYes);
            this.groupBox2.Location = new System.Drawing.Point(1048, 604);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(192, 46);
            this.groupBox2.TabIndex = 66;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Show GCS";
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(77, 21);
            this.rbNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(43, 20);
            this.rbNo.TabIndex = 4;
            this.rbNo.Text = "no";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Checked = true;
            this.rbYes.Location = new System.Drawing.Point(21, 21);
            this.rbYes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(50, 20);
            this.rbYes.TabIndex = 3;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "yes";
            this.rbYes.UseVisualStyleBackColor = true;
            this.rbYes.CheckedChanged += new System.EventHandler(this.rbYes_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 706);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bResetPicture);
            this.Controls.Add(this.bResetAffine);
            this.Controls.Add(this.bDist);
            this.Controls.Add(this.lbDist);
            this.Controls.Add(this.numUDDist);
            this.Controls.Add(this.tbAngleOzGCS);
            this.Controls.Add(this.tbAngleOyGCS);
            this.Controls.Add(this.tbAngleOxGCS);
            this.Controls.Add(this.tbAngleOzOCS);
            this.Controls.Add(this.tbAngleOyOCS);
            this.Controls.Add(this.tbAngleOxOCS);
            this.Controls.Add(this.tb33);
            this.Controls.Add(this.tb23);
            this.Controls.Add(this.tb13);
            this.Controls.Add(this.tb03);
            this.Controls.Add(this.tb32);
            this.Controls.Add(this.tb22);
            this.Controls.Add(this.tb12);
            this.Controls.Add(this.tb02);
            this.Controls.Add(this.tb31);
            this.Controls.Add(this.tb21);
            this.Controls.Add(this.tb11);
            this.Controls.Add(this.tb01);
            this.Controls.Add(this.tb30);
            this.Controls.Add(this.tb20);
            this.Controls.Add(this.tb10);
            this.Controls.Add(this.tb00);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.bScale);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.numUDScale);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bTranslate);
            this.Controls.Add(this.numUDTranslateOz);
            this.Controls.Add(this.numUDTranslateOy);
            this.Controls.Add(this.numUDTranslateOx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbGlobalCoordsOz);
            this.Controls.Add(this.tbGlobalCoordsOy);
            this.Controls.Add(this.tbGlobalCoordsOx);
            this.Controls.Add(this.tbAngleOz);
            this.Controls.Add(this.tbAngleOy);
            this.Controls.Add(this.tbAngleOx);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(400, 753);
            this.Name = "Form1";
            this.Text = "Affine Transformation Application";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAngleOx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAngleOy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAngleOz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGlobalCoordsOz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGlobalCoordsOy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGlobalCoordsOx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDTranslateOz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDTranslateOy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDTranslateOx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDDist)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar tbAngleOx;
        private System.Windows.Forms.TrackBar tbAngleOy;
        private System.Windows.Forms.TrackBar tbAngleOz;
        private System.Windows.Forms.TrackBar tbGlobalCoordsOz;
        private System.Windows.Forms.TrackBar tbGlobalCoordsOy;
        private System.Windows.Forms.TrackBar tbGlobalCoordsOx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numUDTranslateOz;
        private System.Windows.Forms.NumericUpDown numUDTranslateOy;
        private System.Windows.Forms.NumericUpDown numUDTranslateOx;
        private System.Windows.Forms.Button bTranslate;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numUDScale;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button bScale;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tb00;
        private System.Windows.Forms.TextBox tb10;
        private System.Windows.Forms.TextBox tb20;
        private System.Windows.Forms.TextBox tb30;
        private System.Windows.Forms.TextBox tb01;
        private System.Windows.Forms.TextBox tb11;
        private System.Windows.Forms.TextBox tb21;
        private System.Windows.Forms.TextBox tb31;
        private System.Windows.Forms.TextBox tb02;
        private System.Windows.Forms.TextBox tb12;
        private System.Windows.Forms.TextBox tb22;
        private System.Windows.Forms.TextBox tb32;
        private System.Windows.Forms.TextBox tb03;
        private System.Windows.Forms.TextBox tb13;
        private System.Windows.Forms.TextBox tb23;
        private System.Windows.Forms.TextBox tb33;
        private System.Windows.Forms.TextBox tbAngleOzOCS;
        private System.Windows.Forms.TextBox tbAngleOyOCS;
        private System.Windows.Forms.TextBox tbAngleOxOCS;
        private System.Windows.Forms.TextBox tbAngleOzGCS;
        private System.Windows.Forms.TextBox tbAngleOyGCS;
        private System.Windows.Forms.TextBox tbAngleOxGCS;
        private System.Windows.Forms.Button bDist;
        private System.Windows.Forms.Label lbDist;
        private System.Windows.Forms.NumericUpDown numUDDist;
        private System.Windows.Forms.Button bResetAffine;
        private System.Windows.Forms.Button bResetPicture;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNone;
        private System.Windows.Forms.RadioButton rbProfile;
        private System.Windows.Forms.RadioButton rbHorizontal;
        private System.Windows.Forms.RadioButton rbFrontal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbYes;
    }
}

