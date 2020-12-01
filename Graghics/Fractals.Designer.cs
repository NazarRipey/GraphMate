using System.Windows.Forms;

namespace Graghics
{
    partial class Fractals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fractals));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getHelpBtn = new System.Windows.Forms.Button();
            this.FractalBox = new System.Windows.Forms.PictureBox();
            this.startDrawingBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.FunctionComboBox = new System.Windows.Forms.ComboBox();
            this.CReal = new System.Windows.Forms.TextBox();
            this.CImagine = new System.Windows.Forms.TextBox();
            this.ColorComboBox = new System.Windows.Forms.ComboBox();
            this.Scaling = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FractalBox)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1522, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // getHelpBtn
            // 
            this.getHelpBtn.Location = new System.Drawing.Point(1443, 0);
            this.getHelpBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.getHelpBtn.Name = "getHelpBtn";
            this.getHelpBtn.Size = new System.Drawing.Size(33, 31);
            this.getHelpBtn.TabIndex = 1;
            this.getHelpBtn.Text = "?";
            this.getHelpBtn.UseVisualStyleBackColor = true;
            // 
            // FractalBox
            // 
            this.FractalBox.BackColor = System.Drawing.Color.White;
            this.FractalBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FractalBox.Location = new System.Drawing.Point(15, 47);
            this.FractalBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FractalBox.Name = "FractalBox";
            this.FractalBox.Size = new System.Drawing.Size(1259, 678);
            this.FractalBox.TabIndex = 2;
            this.FractalBox.TabStop = false;
            // 
            // startDrawingBtn
            // 
            this.startDrawingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(83)))));
            this.startDrawingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startDrawingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDrawingBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.startDrawingBtn.Location = new System.Drawing.Point(673, 747);
            this.startDrawingBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startDrawingBtn.Name = "startDrawingBtn";
            this.startDrawingBtn.Size = new System.Drawing.Size(185, 58);
            this.startDrawingBtn.TabIndex = 3;
            this.startDrawingBtn.Text = "Draw";
            this.startDrawingBtn.UseVisualStyleBackColor = false;
            this.startDrawingBtn.Click += new System.EventHandler(this.startDrawingBtn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(404, 367);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(449, 23);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Visible = false;
            // 
            // FunctionComboBox
            // 
            this.FunctionComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(120)))));
            this.FunctionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FunctionComboBox.ForeColor = System.Drawing.Color.White;
            this.FunctionComboBox.FormattingEnabled = true;
            this.FunctionComboBox.Location = new System.Drawing.Point(1297, 144);
            this.FunctionComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FunctionComboBox.Name = "FunctionComboBox";
            this.FunctionComboBox.Size = new System.Drawing.Size(193, 33);
            this.FunctionComboBox.TabIndex = 5;
            this.FunctionComboBox.SelectedIndexChanged += new System.EventHandler(this.FunctionComboBox_SelectedIndexChanged);
            // 
            // CReal
            // 
            this.CReal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(120)))));
            this.CReal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CReal.ForeColor = System.Drawing.SystemColors.Window;
            this.CReal.Location = new System.Drawing.Point(1297, 382);
            this.CReal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CReal.Name = "CReal";
            this.CReal.Size = new System.Drawing.Size(66, 32);
            this.CReal.TabIndex = 6;
            this.CReal.Text = "1.0";
            // 
            // CImagine
            // 
            this.CImagine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(120)))));
            this.CImagine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CImagine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CImagine.ForeColor = System.Drawing.SystemColors.Window;
            this.CImagine.Location = new System.Drawing.Point(1409, 382);
            this.CImagine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CImagine.Name = "CImagine";
            this.CImagine.Size = new System.Drawing.Size(66, 32);
            this.CImagine.TabIndex = 7;
            this.CImagine.Text = "1.0";
            // 
            // ColorComboBox
            // 
            this.ColorComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(120)))));
            this.ColorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorComboBox.ForeColor = System.Drawing.SystemColors.Window;
            this.ColorComboBox.FormattingEnabled = true;
            this.ColorComboBox.ItemHeight = 25;
            this.ColorComboBox.Location = new System.Drawing.Point(1297, 252);
            this.ColorComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ColorComboBox.Name = "ColorComboBox";
            this.ColorComboBox.Size = new System.Drawing.Size(193, 33);
            this.ColorComboBox.TabIndex = 8;
            // 
            // Scaling
            // 
            this.Scaling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(120)))));
            this.Scaling.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Scaling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scaling.ForeColor = System.Drawing.SystemColors.Window;
            this.Scaling.Location = new System.Drawing.Point(1397, 470);
            this.Scaling.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Scaling.Name = "Scaling";
            this.Scaling.Size = new System.Drawing.Size(63, 32);
            this.Scaling.TabIndex = 9;
            this.Scaling.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(1291, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Function";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(1289, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Color sheme";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(1368, 318);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Z";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(1296, 359);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Real part";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(1393, 356);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Imagine part";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(1469, 475);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(1293, 469);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 29);
            this.label6.TabIndex = 18;
            this.label6.Text = "Scale";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(1484, 382);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "i";
            // 
            // Fractals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(1522, 818);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Scaling);
            this.Controls.Add(this.ColorComboBox);
            this.Controls.Add(this.CImagine);
            this.Controls.Add(this.CReal);
            this.Controls.Add(this.FunctionComboBox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.FractalBox);
            this.Controls.Add(this.startDrawingBtn);
            this.Controls.Add(this.getHelpBtn);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Fractals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fractals";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Fractals_Closed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FractalBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Button getHelpBtn;
        private System.Windows.Forms.PictureBox FractalBox;
        private System.Windows.Forms.Button startDrawingBtn;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ProgressBar progressBar1;
        private ComboBox FunctionComboBox;
        private TextBox CReal;
        private TextBox CImagine;
        private ComboBox ColorComboBox;
        private TextBox Scaling;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label6;
        private Label label8;
        private ToolStripMenuItem backToolStripMenuItem;
    }
}