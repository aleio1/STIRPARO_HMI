
namespace STIRPARO
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.aspoPanel = new System.Windows.Forms.Panel();
            this.aspoVelUpDown = new System.Windows.Forms.NumericUpDown();
            this.aspoLabel = new System.Windows.Forms.Label();
            this.aspoCloseButton = new System.Windows.Forms.Button();
            this.aspoOpenButton = new System.Windows.Forms.Button();
            this.aspoBackwardButton = new System.Windows.Forms.Button();
            this.aspoForwardButton = new System.Windows.Forms.Button();
            this.aspoUpButton = new System.Windows.Forms.Button();
            this.aspoLeftButton = new System.Windows.Forms.Button();
            this.aspoRightButton = new System.Windows.Forms.Button();
            this.aspoDownButton = new System.Windows.Forms.Button();
            this.straightenerPanel = new System.Windows.Forms.Panel();
            this.straightenerVelUpDown = new System.Windows.Forms.NumericUpDown();
            this.straightenerLabel = new System.Windows.Forms.Label();
            this.straightenerBackwardButton = new System.Windows.Forms.Button();
            this.straightenerForwardButton = new System.Windows.Forms.Button();
            this.profilingPanel = new System.Windows.Forms.Panel();
            this.profilingVelUpDown = new System.Windows.Forms.NumericUpDown();
            this.profilingLabel = new System.Windows.Forms.Label();
            this.profilingBackwardButton = new System.Windows.Forms.Button();
            this.profilingForwardButton = new System.Windows.Forms.Button();
            this.shearPanel = new System.Windows.Forms.Panel();
            this.shearLabel = new System.Windows.Forms.Label();
            this.shearDownButton = new System.Windows.Forms.Button();
            this.shearUpButton = new System.Windows.Forms.Button();
            this.aspoEnableButton = new System.Windows.Forms.Button();
            this.straightenerEnableButton = new System.Windows.Forms.Button();
            this.profilingEnableButton = new System.Windows.Forms.Button();
            this.shearEnableButton = new System.Windows.Forms.Button();
            this.bottomPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.connectButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.aspoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aspoVelUpDown)).BeginInit();
            this.straightenerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.straightenerVelUpDown)).BeginInit();
            this.profilingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilingVelUpDown)).BeginInit();
            this.shearPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.aspoPanel);
            this.flowLayoutPanel1.Controls.Add(this.straightenerPanel);
            this.flowLayoutPanel1.Controls.Add(this.profilingPanel);
            this.flowLayoutPanel1.Controls.Add(this.shearPanel);
            this.flowLayoutPanel1.Controls.Add(this.aspoEnableButton);
            this.flowLayoutPanel1.Controls.Add(this.straightenerEnableButton);
            this.flowLayoutPanel1.Controls.Add(this.profilingEnableButton);
            this.flowLayoutPanel1.Controls.Add(this.shearEnableButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(70, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(2208, 657);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // aspoPanel
            // 
            this.aspoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aspoPanel.Controls.Add(this.aspoVelUpDown);
            this.aspoPanel.Controls.Add(this.aspoLabel);
            this.aspoPanel.Controls.Add(this.aspoCloseButton);
            this.aspoPanel.Controls.Add(this.aspoOpenButton);
            this.aspoPanel.Controls.Add(this.aspoBackwardButton);
            this.aspoPanel.Controls.Add(this.aspoForwardButton);
            this.aspoPanel.Controls.Add(this.aspoUpButton);
            this.aspoPanel.Controls.Add(this.aspoLeftButton);
            this.aspoPanel.Controls.Add(this.aspoRightButton);
            this.aspoPanel.Controls.Add(this.aspoDownButton);
            this.aspoPanel.Enabled = false;
            this.aspoPanel.Location = new System.Drawing.Point(3, 3);
            this.aspoPanel.Name = "aspoPanel";
            this.aspoPanel.Size = new System.Drawing.Size(600, 600);
            this.aspoPanel.TabIndex = 0;
            // 
            // aspoVelUpDown
            // 
            this.aspoVelUpDown.Location = new System.Drawing.Point(225, 531);
            this.aspoVelUpDown.Name = "aspoVelUpDown";
            this.aspoVelUpDown.Size = new System.Drawing.Size(120, 22);
            this.aspoVelUpDown.TabIndex = 12;
            // 
            // aspoLabel
            // 
            this.aspoLabel.AutoSize = true;
            this.aspoLabel.Location = new System.Drawing.Point(4, 4);
            this.aspoLabel.Name = "aspoLabel";
            this.aspoLabel.Size = new System.Drawing.Size(46, 17);
            this.aspoLabel.TabIndex = 11;
            this.aspoLabel.Text = "ASPO";
            // 
            // aspoCloseButton
            // 
            this.aspoCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aspoCloseButton.Location = new System.Drawing.Point(465, 35);
            this.aspoCloseButton.Name = "aspoCloseButton";
            this.aspoCloseButton.Size = new System.Drawing.Size(100, 100);
            this.aspoCloseButton.TabIndex = 10;
            this.aspoCloseButton.Text = "CLOSE";
            this.aspoCloseButton.UseVisualStyleBackColor = true;
            this.aspoCloseButton.Click += new System.EventHandler(this.aspoCloseButton_Click);
            this.aspoCloseButton.MouseDown += this.aspoCloseButton_MouseDown;
            this.aspoCloseButton.MouseUp += this.aspoCloseButton_MouseUp;
            // 
            // aspoOpenButton
            // 
            this.aspoOpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aspoOpenButton.Location = new System.Drawing.Point(17, 35);
            this.aspoOpenButton.Name = "aspoOpenButton";
            this.aspoOpenButton.Size = new System.Drawing.Size(100, 100);
            this.aspoOpenButton.TabIndex = 9;
            this.aspoOpenButton.Text = "OPEN";
            this.aspoOpenButton.UseVisualStyleBackColor = true;
            this.aspoOpenButton.Click += new System.EventHandler(this.aspoOpenButton_Click);
            this.aspoOpenButton.MouseDown += this.aspoOpenButton_MouseDown;
            this.aspoOpenButton.MouseUp += this.aspoOpenButton_MouseUp;
            // 
            // aspoBackwardButton
            // 
            this.aspoBackwardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aspoBackwardButton.Image = ((System.Drawing.Image)(resources.GetObject("aspoBackwardButton.Image")));
            this.aspoBackwardButton.Location = new System.Drawing.Point(17, 453);
            this.aspoBackwardButton.Name = "aspoBackwardButton";
            this.aspoBackwardButton.Size = new System.Drawing.Size(100, 100);
            this.aspoBackwardButton.TabIndex = 8;
            this.aspoBackwardButton.Text = "INDIETRO";
            this.aspoBackwardButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.aspoBackwardButton.UseVisualStyleBackColor = true;
            this.aspoBackwardButton.Click += new System.EventHandler(this.aspoBackwardButton_Click);
            this.aspoBackwardButton.MouseDown += this.aspoBackwardButton_MouseDown;
            this.aspoBackwardButton.MouseUp += this.aspoBackwardButton_MouseUp;
            // 
            // aspoForwardButton
            // 
            this.aspoForwardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aspoForwardButton.Image = ((System.Drawing.Image)(resources.GetObject("aspoForwardButton.Image")));
            this.aspoForwardButton.Location = new System.Drawing.Point(474, 453);
            this.aspoForwardButton.Name = "aspoForwardButton";
            this.aspoForwardButton.Size = new System.Drawing.Size(100, 100);
            this.aspoForwardButton.TabIndex = 7;
            this.aspoForwardButton.Text = "AVANTI";
            this.aspoForwardButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.aspoForwardButton.UseVisualStyleBackColor = true;
            this.aspoForwardButton.Click += new System.EventHandler(this.aspoForwardButton_Click);
            this.aspoForwardButton.MouseDown += this.aspoForwardButton_MouseDown;
            this.aspoForwardButton.MouseUp += this.aspoForwardButton_MouseUp;
            // 
            // aspoUpButton
            // 
            this.aspoUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aspoUpButton.Image = ((System.Drawing.Image)(resources.GetObject("aspoUpButton.Image")));
            this.aspoUpButton.Location = new System.Drawing.Point(245, 125);
            this.aspoUpButton.Name = "aspoUpButton";
            this.aspoUpButton.Size = new System.Drawing.Size(100, 100);
            this.aspoUpButton.TabIndex = 6;
            this.aspoUpButton.Text = "UP";
            this.aspoUpButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.aspoUpButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.aspoUpButton.UseVisualStyleBackColor = true;
            this.aspoUpButton.Click += new System.EventHandler(this.aspoUpButton_Click);
            this.aspoUpButton.MouseDown += this.aspoUpButton_MouseDown;
            this.aspoUpButton.MouseUp += this.aspoUpButton_MouseUp;
            // 
            // aspoLeftButton
            // 
            this.aspoLeftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aspoLeftButton.Image = ((System.Drawing.Image)(resources.GetObject("aspoLeftButton.Image")));
            this.aspoLeftButton.Location = new System.Drawing.Point(139, 231);
            this.aspoLeftButton.Name = "aspoLeftButton";
            this.aspoLeftButton.Size = new System.Drawing.Size(100, 100);
            this.aspoLeftButton.TabIndex = 5;
            this.aspoLeftButton.Text = "LEFT";
            this.aspoLeftButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.aspoLeftButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.aspoLeftButton.UseVisualStyleBackColor = true;
            this.aspoLeftButton.Click += new System.EventHandler(this.aspoLeftButton_Click);
            this.aspoLeftButton.MouseDown += this.aspoLeftButton_MouseDown;
            this.aspoLeftButton.MouseUp += this.aspoLeftButton_MouseUp;
            // 
            // aspoRightButton
            // 
            this.aspoRightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aspoRightButton.Image = ((System.Drawing.Image)(resources.GetObject("aspoRightButton.Image")));
            this.aspoRightButton.Location = new System.Drawing.Point(345, 231);
            this.aspoRightButton.Name = "aspoRightButton";
            this.aspoRightButton.Size = new System.Drawing.Size(100, 100);
            this.aspoRightButton.TabIndex = 4;
            this.aspoRightButton.Text = "RIGHT";
            this.aspoRightButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.aspoRightButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.aspoRightButton.UseVisualStyleBackColor = true;
            this.aspoRightButton.Click += new System.EventHandler(this.aspoRightButton_Click);
            this.aspoRightButton.MouseDown += this.aspoRightButton_MouseDown;
            this.aspoRightButton.MouseUp += this.aspoRightButton_MouseUp;
            // 
            // aspoDownButton
            // 
            this.aspoDownButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aspoDownButton.Image = ((System.Drawing.Image)(resources.GetObject("aspoDownButton.Image")));
            this.aspoDownButton.Location = new System.Drawing.Point(245, 335);
            this.aspoDownButton.Name = "aspoDownButton";
            this.aspoDownButton.Size = new System.Drawing.Size(100, 100);
            this.aspoDownButton.TabIndex = 3;
            this.aspoDownButton.Text = "DOWN";
            this.aspoDownButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.aspoDownButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.aspoDownButton.UseVisualStyleBackColor = true;
            this.aspoDownButton.Click += new System.EventHandler(this.aspoDownButton_Click);
            this.aspoDownButton.MouseDown += this.aspoDownButton_MouseDown;
            this.aspoDownButton.MouseUp += this.aspoDownButton_MouseUp;
            // 
            // straightenerPanel
            // 
            this.straightenerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.straightenerPanel.Controls.Add(this.straightenerVelUpDown);
            this.straightenerPanel.Controls.Add(this.straightenerLabel);
            this.straightenerPanel.Controls.Add(this.straightenerBackwardButton);
            this.straightenerPanel.Controls.Add(this.straightenerForwardButton);
            this.straightenerPanel.Enabled = false;
            this.straightenerPanel.Location = new System.Drawing.Point(609, 3);
            this.straightenerPanel.Name = "straightenerPanel";
            this.straightenerPanel.Size = new System.Drawing.Size(420, 600);
            this.straightenerPanel.TabIndex = 1;
            this.straightenerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.straightenerPanel_Paint);
            // 
            // straightenerVelUpDown
            // 
            this.straightenerVelUpDown.Location = new System.Drawing.Point(150, 531);
            this.straightenerVelUpDown.Name = "straightenerVelUpDown";
            this.straightenerVelUpDown.Size = new System.Drawing.Size(120, 22);
            this.straightenerVelUpDown.TabIndex = 15;
            // 
            // straightenerLabel
            // 
            this.straightenerLabel.AutoSize = true;
            this.straightenerLabel.Location = new System.Drawing.Point(4, 4);
            this.straightenerLabel.Name = "straightenerLabel";
            this.straightenerLabel.Size = new System.Drawing.Size(127, 17);
            this.straightenerLabel.TabIndex = 12;
            this.straightenerLabel.Text = "RADDRIZZATRICE";
            // 
            // straightenerBackwardButton
            // 
            this.straightenerBackwardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.straightenerBackwardButton.Image = ((System.Drawing.Image)(resources.GetObject("straightenerBackwardButton.Image")));
            this.straightenerBackwardButton.Location = new System.Drawing.Point(9, 453);
            this.straightenerBackwardButton.Name = "straightenerBackwardButton";
            this.straightenerBackwardButton.Size = new System.Drawing.Size(100, 100);
            this.straightenerBackwardButton.TabIndex = 14;
            this.straightenerBackwardButton.Text = "INDIETRO";
            this.straightenerBackwardButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.straightenerBackwardButton.UseVisualStyleBackColor = true;
            this.straightenerBackwardButton.Click += new System.EventHandler(this.straightenerBackwardButton_Click);
            this.straightenerBackwardButton.MouseDown += this.straightenerBackwardButton_MouseDown;
            this.straightenerBackwardButton.MouseUp += this.straightenerBackwardButton_MouseUp;
            // 
            // straightenerForwardButton
            // 
            this.straightenerForwardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.straightenerForwardButton.Image = ((System.Drawing.Image)(resources.GetObject("straightenerForwardButton.Image")));
            this.straightenerForwardButton.Location = new System.Drawing.Point(310, 453);
            this.straightenerForwardButton.Name = "straightenerForwardButton";
            this.straightenerForwardButton.Size = new System.Drawing.Size(100, 100);
            this.straightenerForwardButton.TabIndex = 13;
            this.straightenerForwardButton.Text = "AVANTI";
            this.straightenerForwardButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.straightenerForwardButton.UseVisualStyleBackColor = true;
            this.straightenerForwardButton.Click += new System.EventHandler(this.straightenerForwardButton_Click);
            this.straightenerForwardButton.MouseDown += this.straightenerForwardButton_MouseDown;
            this.straightenerForwardButton.MouseUp += this.straightenerForwardButton_MouseUp;
            // 
            // profilingPanel
            // 
            this.profilingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profilingPanel.Controls.Add(this.profilingVelUpDown);
            this.profilingPanel.Controls.Add(this.profilingLabel);
            this.profilingPanel.Controls.Add(this.profilingBackwardButton);
            this.profilingPanel.Controls.Add(this.profilingForwardButton);
            this.profilingPanel.Enabled = false;
            this.profilingPanel.Location = new System.Drawing.Point(1035, 3);
            this.profilingPanel.Name = "profilingPanel";
            this.profilingPanel.Size = new System.Drawing.Size(420, 600);
            this.profilingPanel.TabIndex = 2;
            this.profilingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.profilingPanel_Paint);
            // 
            // profilingVelUpDown
            // 
            this.profilingVelUpDown.Location = new System.Drawing.Point(150, 531);
            this.profilingVelUpDown.Name = "profilingVelUpDown";
            this.profilingVelUpDown.Size = new System.Drawing.Size(120, 22);
            this.profilingVelUpDown.TabIndex = 18;
            // 
            // profilingLabel
            // 
            this.profilingLabel.AutoSize = true;
            this.profilingLabel.Location = new System.Drawing.Point(4, 4);
            this.profilingLabel.Name = "profilingLabel";
            this.profilingLabel.Size = new System.Drawing.Size(106, 17);
            this.profilingLabel.TabIndex = 13;
            this.profilingLabel.Text = "PROFILATRICE";
            // 
            // profilingBackwardButton
            // 
            this.profilingBackwardButton.Image = ((System.Drawing.Image)(resources.GetObject("profilingBackwardButton.Image")));
            this.profilingBackwardButton.Location = new System.Drawing.Point(9, 453);
            this.profilingBackwardButton.Name = "profilingBackwardButton";
            this.profilingBackwardButton.Size = new System.Drawing.Size(100, 100);
            this.profilingBackwardButton.TabIndex = 17;
            this.profilingBackwardButton.UseVisualStyleBackColor = true;
            this.profilingBackwardButton.Click += new System.EventHandler(this.profilingBackwardButton_Click);
            this.profilingBackwardButton.MouseDown += this.profilingBackwardButton_MouseDown;
            this.profilingBackwardButton.MouseUp += this.profilingBackwardButton_MouseUp;
            // 
            // profilingForwardButton
            // 
            this.profilingForwardButton.Image = ((System.Drawing.Image)(resources.GetObject("profilingForwardButton.Image")));
            this.profilingForwardButton.Location = new System.Drawing.Point(310, 453);
            this.profilingForwardButton.Name = "profilingForwardButton";
            this.profilingForwardButton.Size = new System.Drawing.Size(100, 100);
            this.profilingForwardButton.TabIndex = 16;
            this.profilingForwardButton.UseVisualStyleBackColor = true;
            this.profilingForwardButton.Click += new System.EventHandler(this.profilingForwardButton_Click);
            this.profilingForwardButton.MouseDown += this.profilingForwardButton_MouseDown;
            this.profilingForwardButton.MouseUp += this.profilingForwardButton_MouseUp;
            // 
            // shearPanel
            // 
            this.shearPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shearPanel.Controls.Add(this.shearLabel);
            this.shearPanel.Controls.Add(this.shearDownButton);
            this.shearPanel.Controls.Add(this.shearUpButton);
            this.shearPanel.Enabled = false;
            this.shearPanel.Location = new System.Drawing.Point(1461, 3);
            this.shearPanel.Name = "shearPanel";
            this.shearPanel.Size = new System.Drawing.Size(420, 600);
            this.shearPanel.TabIndex = 3;
            // 
            // shearLabel
            // 
            this.shearLabel.AutoSize = true;
            this.shearLabel.Location = new System.Drawing.Point(4, 4);
            this.shearLabel.Name = "shearLabel";
            this.shearLabel.Size = new System.Drawing.Size(58, 17);
            this.shearLabel.TabIndex = 14;
            this.shearLabel.Text = "CESOIA";
            // 
            // shearDownButton
            // 
            this.shearDownButton.Image = ((System.Drawing.Image)(resources.GetObject("shearDownButton.Image")));
            this.shearDownButton.Location = new System.Drawing.Point(310, 453);
            this.shearDownButton.Name = "shearDownButton";
            this.shearDownButton.Size = new System.Drawing.Size(100, 100);
            this.shearDownButton.TabIndex = 11;
            this.shearDownButton.UseVisualStyleBackColor = true;
            this.shearDownButton.Click += new System.EventHandler(this.shearDownButton_Click);
            this.shearDownButton.MouseDown += this.shearDownButton_MouseDown;
            this.shearDownButton.MouseUp += this.shearDownButton_MouseUp;
            // 
            // shearUpButton
            // 
            this.shearUpButton.Image = ((System.Drawing.Image)(resources.GetObject("shearUpButton.Image")));
            this.shearUpButton.Location = new System.Drawing.Point(9, 453);
            this.shearUpButton.Name = "shearUpButton";
            this.shearUpButton.Size = new System.Drawing.Size(100, 100);
            this.shearUpButton.TabIndex = 10;
            this.shearUpButton.UseVisualStyleBackColor = true;
            this.shearUpButton.Click += new System.EventHandler(this.shearUpButton_Click);
            this.shearUpButton.MouseDown += this.shearUpButton_MouseDown;
            this.shearUpButton.MouseUp += this.shearUpButton_MouseUp;
            // 
            // aspoEnableButton
            // 
            this.aspoEnableButton.Location = new System.Drawing.Point(3, 609);
            this.aspoEnableButton.Name = "aspoEnableButton";
            this.aspoEnableButton.Size = new System.Drawing.Size(600, 37);
            this.aspoEnableButton.TabIndex = 4;
            this.aspoEnableButton.Text = "ENABLE";
            this.aspoEnableButton.UseVisualStyleBackColor = true;
            this.aspoEnableButton.Click += new System.EventHandler(this.aspoEnableButton_Click);
            // 
            // straightenerEnableButton
            // 
            this.straightenerEnableButton.Location = new System.Drawing.Point(609, 609);
            this.straightenerEnableButton.Name = "straightenerEnableButton";
            this.straightenerEnableButton.Size = new System.Drawing.Size(420, 37);
            this.straightenerEnableButton.TabIndex = 5;
            this.straightenerEnableButton.Text = "ENABLE";
            this.straightenerEnableButton.UseVisualStyleBackColor = true;
            this.straightenerEnableButton.Click += new System.EventHandler(this.straightenerEnableButton_Click);
            // 
            // profilingEnableButton
            // 
            this.profilingEnableButton.Location = new System.Drawing.Point(1035, 609);
            this.profilingEnableButton.Name = "profilingEnableButton";
            this.profilingEnableButton.Size = new System.Drawing.Size(420, 37);
            this.profilingEnableButton.TabIndex = 6;
            this.profilingEnableButton.Text = "ENABLE";
            this.profilingEnableButton.UseVisualStyleBackColor = true;
            this.profilingEnableButton.Click += new System.EventHandler(this.profilingEnableButton_Click);
            // 
            // shearEnableButton
            // 
            this.shearEnableButton.Location = new System.Drawing.Point(1461, 609);
            this.shearEnableButton.Name = "shearEnableButton";
            this.shearEnableButton.Size = new System.Drawing.Size(420, 37);
            this.shearEnableButton.TabIndex = 7;
            this.shearEnableButton.Text = "ENABLE";
            this.shearEnableButton.UseVisualStyleBackColor = true;
            this.shearEnableButton.Click += new System.EventHandler(this.shearEnableButton_Click);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.connectButton);
            this.bottomPanel.Controls.Add(this.closeButton);
            this.bottomPanel.Location = new System.Drawing.Point(70, 777);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(917, 100);
            this.bottomPanel.TabIndex = 1;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(3, 3);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(110, 88);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "CONNECT";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(119, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(110, 88);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "CLOSE";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.flowLayoutPanel1.ResumeLayout(false);
            this.aspoPanel.ResumeLayout(false);
            this.aspoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aspoVelUpDown)).EndInit();
            this.straightenerPanel.ResumeLayout(false);
            this.straightenerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.straightenerVelUpDown)).EndInit();
            this.profilingPanel.ResumeLayout(false);
            this.profilingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilingVelUpDown)).EndInit();
            this.shearPanel.ResumeLayout(false);
            this.shearPanel.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel aspoPanel;
        private System.Windows.Forms.Panel straightenerPanel;
        private System.Windows.Forms.Panel profilingPanel;
        private System.Windows.Forms.Panel shearPanel;
        private System.Windows.Forms.Button aspoCloseButton;
        private System.Windows.Forms.Button aspoOpenButton;
        private System.Windows.Forms.Button aspoBackwardButton;
        private System.Windows.Forms.Button aspoForwardButton;
        private System.Windows.Forms.Button aspoUpButton;
        private System.Windows.Forms.Button aspoLeftButton;
        private System.Windows.Forms.Button aspoRightButton;
        private System.Windows.Forms.Button aspoDownButton;
        private System.Windows.Forms.Button shearDownButton;
        private System.Windows.Forms.Button shearUpButton;
        private System.Windows.Forms.NumericUpDown aspoVelUpDown;
        private System.Windows.Forms.Label aspoLabel;
        private System.Windows.Forms.NumericUpDown straightenerVelUpDown;
        private System.Windows.Forms.Label straightenerLabel;
        private System.Windows.Forms.Button straightenerBackwardButton;
        private System.Windows.Forms.Button straightenerForwardButton;
        private System.Windows.Forms.NumericUpDown profilingVelUpDown;
        private System.Windows.Forms.Label profilingLabel;
        private System.Windows.Forms.Button profilingBackwardButton;
        private System.Windows.Forms.Button profilingForwardButton;
        private System.Windows.Forms.Label shearLabel;
        private System.Windows.Forms.Button aspoEnableButton;
        private System.Windows.Forms.Button straightenerEnableButton;
        private System.Windows.Forms.Button profilingEnableButton;
        private System.Windows.Forms.Button shearEnableButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel bottomPanel;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button closeButton;
    }
}

