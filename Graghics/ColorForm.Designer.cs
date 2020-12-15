namespace Graghics
{
    partial class ColorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorForm));
            this.AfterPicture = new System.Windows.Forms.PictureBox();
            this.ConvertBtn = new System.Windows.Forms.Button();
            this.valueBar = new System.Windows.Forms.TrackBar();
            this.R = new System.Windows.Forms.TextBox();
            this.H = new System.Windows.Forms.TextBox();
            this.G = new System.Windows.Forms.TextBox();
            this.S = new System.Windows.Forms.TextBox();
            this.B = new System.Windows.Forms.TextBox();
            this.V = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ValueBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SaturationBox = new System.Windows.Forms.TextBox();
            this.saturationBar = new System.Windows.Forms.TrackBar();
            this.BeforePicture = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.currentColor = new System.Windows.Forms.Panel();
            this.getHelpBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AfterPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueBar)).BeginInit();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saturationBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeforePicture)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AfterPicture
            // 
            this.AfterPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.AfterPicture.Location = new System.Drawing.Point(0, 0);
            this.AfterPicture.Name = "AfterPicture";
            this.AfterPicture.Size = new System.Drawing.Size(597, 482);
            this.AfterPicture.TabIndex = 1;
            this.AfterPicture.TabStop = false;
            this.AfterPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AfterPicture_MouseMove);
            // 
            // ConvertBtn
            // 
            this.ConvertBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(83)))));
            this.ConvertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ConvertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ConvertBtn.Location = new System.Drawing.Point(579, 665);
            this.ConvertBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ConvertBtn.Name = "ConvertBtn";
            this.ConvertBtn.Size = new System.Drawing.Size(129, 52);
            this.ConvertBtn.TabIndex = 4;
            this.ConvertBtn.Text = "Convert";
            this.ConvertBtn.UseVisualStyleBackColor = false;
            this.ConvertBtn.Click += new System.EventHandler(this.ConvertBtn_Click);
            // 
            // valueBar
            // 
            this.valueBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.valueBar.Location = new System.Drawing.Point(887, 642);
            this.valueBar.Maximum = 100;
            this.valueBar.Name = "valueBar";
            this.valueBar.Size = new System.Drawing.Size(226, 56);
            this.valueBar.TabIndex = 6;
            this.valueBar.Scroll += new System.EventHandler(this.ValueBar_Scroll);
            // 
            // R
            // 
            this.R.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.R.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.R.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R.ForeColor = System.Drawing.Color.Black;
            this.R.Location = new System.Drawing.Point(38, 18);
            this.R.Name = "R";
            this.R.ReadOnly = true;
            this.R.Size = new System.Drawing.Size(48, 32);
            this.R.TabIndex = 10;
            this.R.Text = "0";
            this.R.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // H
            // 
            this.H.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.H.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.H.ForeColor = System.Drawing.SystemColors.MenuText;
            this.H.Location = new System.Drawing.Point(38, 71);
            this.H.Name = "H";
            this.H.ReadOnly = true;
            this.H.Size = new System.Drawing.Size(48, 32);
            this.H.TabIndex = 11;
            this.H.Text = "0";
            this.H.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // G
            // 
            this.G.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.G.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.G.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G.ForeColor = System.Drawing.Color.Black;
            this.G.Location = new System.Drawing.Point(140, 18);
            this.G.Name = "G";
            this.G.ReadOnly = true;
            this.G.Size = new System.Drawing.Size(48, 32);
            this.G.TabIndex = 12;
            this.G.Text = "0";
            this.G.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // S
            // 
            this.S.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.S.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.S.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S.ForeColor = System.Drawing.Color.Black;
            this.S.Location = new System.Drawing.Point(140, 71);
            this.S.Name = "S";
            this.S.ReadOnly = true;
            this.S.Size = new System.Drawing.Size(48, 32);
            this.S.TabIndex = 13;
            this.S.Text = "0";
            this.S.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // B
            // 
            this.B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.B.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B.ForeColor = System.Drawing.Color.Black;
            this.B.Location = new System.Drawing.Point(243, 18);
            this.B.Name = "B";
            this.B.ReadOnly = true;
            this.B.Size = new System.Drawing.Size(48, 32);
            this.B.TabIndex = 14;
            this.B.Text = "0";
            this.B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // V
            // 
            this.V.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.V.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.V.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V.ForeColor = System.Drawing.Color.Black;
            this.V.Location = new System.Drawing.Point(243, 71);
            this.V.Name = "V";
            this.V.ReadOnly = true;
            this.V.Size = new System.Drawing.Size(48, 32);
            this.V.TabIndex = 15;
            this.V.Text = "0";
            this.V.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "R:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(204, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "V:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(102, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "S:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(0, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "H:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(205, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "B:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(102, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "G:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(32, 230);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(539, 15);
            this.progressBar1.TabIndex = 23;
            this.progressBar1.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.R);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.G);
            this.panel3.Controls.Add(this.B);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.V);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.S);
            this.panel3.Controls.Add(this.H);
            this.panel3.Location = new System.Drawing.Point(170, 573);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(309, 113);
            this.panel3.TabIndex = 26;
            // 
            // ValueBox
            // 
            this.ValueBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.ValueBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ValueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.ValueBox.Location = new System.Drawing.Point(1119, 642);
            this.ValueBox.Name = "ValueBox";
            this.ValueBox.ReadOnly = true;
            this.ValueBox.Size = new System.Drawing.Size(48, 32);
            this.ValueBox.TabIndex = 27;
            this.ValueBox.Text = "0";
            this.ValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(780, 642);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 29);
            this.label7.TabIndex = 28;
            this.label7.Text = "Red value:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(122)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1289, 28);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.backToolStripMenuItem.Text = "< Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click_1);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(944, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 31);
            this.label8.TabIndex = 30;
            this.label8.Text = "After";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(280, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 31);
            this.label9.TabIndex = 31;
            this.label9.Text = "Before";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(736, 591);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 29);
            this.label10.TabIndex = 34;
            this.label10.Text = "Red saturation:";
            // 
            // SaturationBox
            // 
            this.SaturationBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.SaturationBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SaturationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaturationBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.SaturationBox.Location = new System.Drawing.Point(1119, 591);
            this.SaturationBox.Name = "SaturationBox";
            this.SaturationBox.ReadOnly = true;
            this.SaturationBox.Size = new System.Drawing.Size(48, 32);
            this.SaturationBox.TabIndex = 33;
            this.SaturationBox.Text = "0";
            this.SaturationBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // saturationBar
            // 
            this.saturationBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saturationBar.Location = new System.Drawing.Point(887, 591);
            this.saturationBar.Maximum = 100;
            this.saturationBar.Name = "saturationBar";
            this.saturationBar.Size = new System.Drawing.Size(226, 56);
            this.saturationBar.TabIndex = 32;
            this.saturationBar.Scroll += new System.EventHandler(this.saturationBar_Scroll);
            // 
            // BeforePicture
            // 
            this.BeforePicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.BeforePicture.Location = new System.Drawing.Point(0, 0);
            this.BeforePicture.Name = "BeforePicture";
            this.BeforePicture.Size = new System.Drawing.Size(597, 482);
            this.BeforePicture.TabIndex = 0;
            this.BeforePicture.TabStop = false;
            this.BeforePicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BeforePicture_MouseMove);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.AfterPicture);
            this.panel2.Location = new System.Drawing.Point(659, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 482);
            this.panel2.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.BeforePicture);
            this.panel1.Location = new System.Drawing.Point(29, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 482);
            this.panel1.TabIndex = 24;
            // 
            // currentColor
            // 
            this.currentColor.Location = new System.Drawing.Point(114, 609);
            this.currentColor.Name = "currentColor";
            this.currentColor.Size = new System.Drawing.Size(40, 40);
            this.currentColor.TabIndex = 35;
            // 
            // getHelpBtn
            // 
            this.getHelpBtn.Location = new System.Drawing.Point(1256, 0);
            this.getHelpBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.getHelpBtn.Name = "getHelpBtn";
            this.getHelpBtn.Size = new System.Drawing.Size(33, 28);
            this.getHelpBtn.TabIndex = 36;
            this.getHelpBtn.Text = "?";
            this.getHelpBtn.UseVisualStyleBackColor = true;
            this.getHelpBtn.Click += new System.EventHandler(this.getHelpBtn_Click);
            // 
            // ColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(1289, 728);
            this.Controls.Add(this.getHelpBtn);
            this.Controls.Add(this.currentColor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.SaturationBox);
            this.Controls.Add(this.saturationBar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ValueBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.valueBar);
            this.Controls.Add(this.ConvertBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ColorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colors";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ColorForm_Closed);
            ((System.ComponentModel.ISupportInitialize)(this.AfterPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueBar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saturationBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeforePicture)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox AfterPicture;
        private System.Windows.Forms.Button ConvertBtn;
        private System.Windows.Forms.TrackBar valueBar;
        private System.Windows.Forms.TextBox R;
        private System.Windows.Forms.TextBox H;
        private System.Windows.Forms.TextBox G;
        private System.Windows.Forms.TextBox S;
        private System.Windows.Forms.TextBox B;
        private System.Windows.Forms.TextBox V;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox ValueBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox SaturationBox;
        private System.Windows.Forms.TrackBar saturationBar;
        private System.Windows.Forms.PictureBox BeforePicture;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel currentColor;
        private System.Windows.Forms.Button getHelpBtn;
    }
}