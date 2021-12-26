namespace GifOptimizer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCompressLevel = new System.Windows.Forms.ComboBox();
            this.numericUpDownLossy = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownColor = new System.Windows.Forms.NumericUpDown();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonOptimize = new System.Windows.Forms.Button();
            this.pictureBoxTarget = new System.Windows.Forms.PictureBox();
            this.pictureBoxSource = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLossy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColor)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTarget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source Gif";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(665, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Optmized Gif";
            // 
            // comboBoxCompressLevel
            // 
            this.comboBoxCompressLevel.FormattingEnabled = true;
            this.comboBoxCompressLevel.Items.AddRange(new object[] {
            "O1",
            "O2",
            "O3"});
            this.comboBoxCompressLevel.Location = new System.Drawing.Point(219, 30);
            this.comboBoxCompressLevel.Name = "comboBoxCompressLevel";
            this.comboBoxCompressLevel.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCompressLevel.TabIndex = 4;
            // 
            // numericUpDownLossy
            // 
            this.numericUpDownLossy.Location = new System.Drawing.Point(219, 61);
            this.numericUpDownLossy.Name = "numericUpDownLossy";
            this.numericUpDownLossy.Size = new System.Drawing.Size(120, 24);
            this.numericUpDownLossy.TabIndex = 5;
            // 
            // numericUpDownColor
            // 
            this.numericUpDownColor.Location = new System.Drawing.Point(548, 30);
            this.numericUpDownColor.Name = "numericUpDownColor";
            this.numericUpDownColor.Size = new System.Drawing.Size(120, 24);
            this.numericUpDownColor.TabIndex = 6;
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(868, 30);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(100, 24);
            this.textBoxWidth.TabIndex = 7;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(868, 63);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(100, 24);
            this.textBoxHeight.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxHeight);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxWidth);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxCompressLevel);
            this.groupBox1.Controls.Add(this.numericUpDownColor);
            this.groupBox1.Controls.Add(this.numericUpDownLossy);
            this.groupBox1.Location = new System.Drawing.Point(50, 552);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1072, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(800, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Height:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(800, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Width:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(431, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Color Reduction:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Lossy :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Compress Level:";
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(47, 468);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(431, 24);
            this.textBoxPath.TabIndex = 12;
            // 
            // buttonSave
            // 
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Image = global::GifOptimizer.Properties.Resources.SaveTo_16x16;
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSave.Location = new System.Drawing.Point(1001, 468);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(121, 43);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowse.Image = global::GifOptimizer.Properties.Resources.Folder;
            this.buttonBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBrowse.Location = new System.Drawing.Point(370, 14);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(108, 30);
            this.buttonBrowse.TabIndex = 11;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonOptimize
            // 
            this.buttonOptimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOptimize.Image = global::GifOptimizer.Properties.Resources.Wizard_16x16;
            this.buttonOptimize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOptimize.Location = new System.Drawing.Point(170, 503);
            this.buttonOptimize.Name = "buttonOptimize";
            this.buttonOptimize.Size = new System.Drawing.Size(199, 43);
            this.buttonOptimize.TabIndex = 10;
            this.buttonOptimize.Text = "Optimize";
            this.buttonOptimize.UseVisualStyleBackColor = true;
            this.buttonOptimize.Click += new System.EventHandler(this.buttonOptimize_Click);
            // 
            // pictureBoxTarget
            // 
            this.pictureBoxTarget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxTarget.Location = new System.Drawing.Point(668, 50);
            this.pictureBoxTarget.Name = "pictureBoxTarget";
            this.pictureBoxTarget.Size = new System.Drawing.Size(454, 412);
            this.pictureBoxTarget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTarget.TabIndex = 1;
            this.pictureBoxTarget.TabStop = false;
            // 
            // pictureBoxSource
            // 
            this.pictureBoxSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSource.Location = new System.Drawing.Point(47, 50);
            this.pictureBoxSource.Name = "pictureBoxSource";
            this.pictureBoxSource.Size = new System.Drawing.Size(431, 412);
            this.pictureBoxSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSource.TabIndex = 0;
            this.pictureBoxSource.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1151, 664);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.buttonOptimize);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxTarget);
            this.Controls.Add(this.pictureBoxSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GIF OPTIMIZER";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLossy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTarget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSource;
        private System.Windows.Forms.PictureBox pictureBoxTarget;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCompressLevel;
        private System.Windows.Forms.NumericUpDown numericUpDownLossy;
        private System.Windows.Forms.NumericUpDown numericUpDownColor;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonOptimize;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonSave;
    }
}

