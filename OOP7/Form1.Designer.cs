﻿namespace OOP7
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_clr = new System.Windows.Forms.Button();
            this.btn_crcle = new System.Windows.Forms.Button();
            this.btn_sqr = new System.Windows.Forms.Button();
            this.btn_tri = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_red = new System.Windows.Forms.Button();
            this.btn_green = new System.Windows.Forms.Button();
            this.btn_blu = new System.Windows.Forms.Button();
            this.btn_yellow = new System.Windows.Forms.Button();
            this.btn_black = new System.Windows.Forms.Button();
            this.btn_darkblu = new System.Windows.Forms.Button();
            this.btn_manycolor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.picturbx = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturbx)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox1.Location = new System.Drawing.Point(1, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1873, 202);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_clr
            // 
            this.btn_clr.Location = new System.Drawing.Point(257, 4);
            this.btn_clr.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clr.Name = "btn_clr";
            this.btn_clr.Size = new System.Drawing.Size(208, 66);
            this.btn_clr.TabIndex = 2;
            this.btn_clr.Text = "Clear All";
            this.btn_clr.UseVisualStyleBackColor = true;
            this.btn_clr.Click += new System.EventHandler(this.btn_clr_Click);
            // 
            // btn_crcle
            // 
            this.btn_crcle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_crcle.Location = new System.Drawing.Point(4, 4);
            this.btn_crcle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_crcle.Name = "btn_crcle";
            this.btn_crcle.Size = new System.Drawing.Size(76, 66);
            this.btn_crcle.TabIndex = 3;
            this.btn_crcle.Text = "Circle";
            this.btn_crcle.UseVisualStyleBackColor = true;
            this.btn_crcle.Click += new System.EventHandler(this.btn_crcle_Click);
            // 
            // btn_sqr
            // 
            this.btn_sqr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_sqr.Location = new System.Drawing.Point(88, 4);
            this.btn_sqr.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sqr.Name = "btn_sqr";
            this.btn_sqr.Size = new System.Drawing.Size(71, 66);
            this.btn_sqr.TabIndex = 4;
            this.btn_sqr.Text = "Square";
            this.btn_sqr.UseVisualStyleBackColor = true;
            this.btn_sqr.Click += new System.EventHandler(this.btn_sqr_Click);
            // 
            // btn_tri
            // 
            this.btn_tri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_tri.Location = new System.Drawing.Point(167, 4);
            this.btn_tri.Margin = new System.Windows.Forms.Padding(4);
            this.btn_tri.Name = "btn_tri";
            this.btn_tri.Size = new System.Drawing.Size(82, 66);
            this.btn_tri.TabIndex = 5;
            this.btn_tri.Text = "Triangle";
            this.btn_tri.UseVisualStyleBackColor = true;
            this.btn_tri.Click += new System.EventHandler(this.btn_tri_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.flowLayoutPanel1.Controls.Add(this.btn_crcle);
            this.flowLayoutPanel1.Controls.Add(this.btn_sqr);
            this.flowLayoutPanel1.Controls.Add(this.btn_tri);
            this.flowLayoutPanel1.Controls.Add(this.btn_clr);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(33, 28);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(669, 78);
            this.flowLayoutPanel1.TabIndex = 6;
            this.flowLayoutPanel1.TabStop = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.btn_red);
            this.flowLayoutPanel2.Controls.Add(this.btn_green);
            this.flowLayoutPanel2.Controls.Add(this.btn_blu);
            this.flowLayoutPanel2.Controls.Add(this.btn_yellow);
            this.flowLayoutPanel2.Controls.Add(this.btn_black);
            this.flowLayoutPanel2.Controls.Add(this.btn_darkblu);
            this.flowLayoutPanel2.Controls.Add(this.btn_manycolor);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(719, 28);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(639, 74);
            this.flowLayoutPanel2.TabIndex = 7;
            this.flowLayoutPanel2.TabStop = true;
            // 
            // btn_red
            // 
            this.btn_red.BackColor = System.Drawing.Color.Red;
            this.btn_red.Location = new System.Drawing.Point(4, 4);
            this.btn_red.Margin = new System.Windows.Forms.Padding(4);
            this.btn_red.Name = "btn_red";
            this.btn_red.Size = new System.Drawing.Size(100, 28);
            this.btn_red.TabIndex = 0;
            this.btn_red.UseVisualStyleBackColor = false;
            this.btn_red.Click += new System.EventHandler(this.btn_red_Click);
            // 
            // btn_green
            // 
            this.btn_green.BackColor = System.Drawing.Color.Lime;
            this.btn_green.Location = new System.Drawing.Point(112, 4);
            this.btn_green.Margin = new System.Windows.Forms.Padding(4);
            this.btn_green.Name = "btn_green";
            this.btn_green.Size = new System.Drawing.Size(100, 28);
            this.btn_green.TabIndex = 2;
            this.btn_green.UseVisualStyleBackColor = false;
            this.btn_green.Click += new System.EventHandler(this.btn_red_Click);
            // 
            // btn_blu
            // 
            this.btn_blu.BackColor = System.Drawing.Color.Cyan;
            this.btn_blu.Location = new System.Drawing.Point(220, 4);
            this.btn_blu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_blu.Name = "btn_blu";
            this.btn_blu.Size = new System.Drawing.Size(100, 28);
            this.btn_blu.TabIndex = 1;
            this.btn_blu.UseVisualStyleBackColor = false;
            this.btn_blu.Click += new System.EventHandler(this.btn_red_Click);
            // 
            // btn_yellow
            // 
            this.btn_yellow.BackColor = System.Drawing.Color.Yellow;
            this.btn_yellow.Location = new System.Drawing.Point(328, 4);
            this.btn_yellow.Margin = new System.Windows.Forms.Padding(4);
            this.btn_yellow.Name = "btn_yellow";
            this.btn_yellow.Size = new System.Drawing.Size(100, 28);
            this.btn_yellow.TabIndex = 3;
            this.btn_yellow.UseVisualStyleBackColor = false;
            this.btn_yellow.Click += new System.EventHandler(this.btn_red_Click);
            // 
            // btn_black
            // 
            this.btn_black.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_black.Location = new System.Drawing.Point(436, 4);
            this.btn_black.Margin = new System.Windows.Forms.Padding(4);
            this.btn_black.Name = "btn_black";
            this.btn_black.Size = new System.Drawing.Size(100, 28);
            this.btn_black.TabIndex = 5;
            this.btn_black.UseVisualStyleBackColor = false;
            this.btn_black.Click += new System.EventHandler(this.btn_red_Click);
            // 
            // btn_darkblu
            // 
            this.btn_darkblu.BackColor = System.Drawing.Color.Blue;
            this.btn_darkblu.Location = new System.Drawing.Point(4, 40);
            this.btn_darkblu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_darkblu.Name = "btn_darkblu";
            this.btn_darkblu.Size = new System.Drawing.Size(100, 28);
            this.btn_darkblu.TabIndex = 6;
            this.btn_darkblu.UseVisualStyleBackColor = false;
            this.btn_darkblu.Click += new System.EventHandler(this.btn_red_Click);
            // 
            // btn_manycolor
            // 
            this.btn_manycolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btn_manycolor.Location = new System.Drawing.Point(112, 40);
            this.btn_manycolor.Margin = new System.Windows.Forms.Padding(4);
            this.btn_manycolor.Name = "btn_manycolor";
            this.btn_manycolor.Size = new System.Drawing.Size(208, 28);
            this.btn_manycolor.TabIndex = 4;
            this.btn_manycolor.Text = "***";
            this.btn_manycolor.UseVisualStyleBackColor = true;
            this.btn_manycolor.Click += new System.EventHandler(this.btn_manycolor_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // picturbx
            // 
            this.picturbx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picturbx.Location = new System.Drawing.Point(1, 238);
            this.picturbx.Margin = new System.Windows.Forms.Padding(4);
            this.picturbx.Name = "picturbx";
            this.picturbx.Size = new System.Drawing.Size(2136, 805);
            this.picturbx.TabIndex = 8;
            this.picturbx.TabStop = false;
            this.picturbx.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.picturbx.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.picturbx.Resize += new System.EventHandler(this.picturbx_Resize);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(711, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 31);
            this.label1.TabIndex = 9;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(4, 4);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(100, 28);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(4, 40);
            this.btn_load.Margin = new System.Windows.Forms.Padding(4);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(100, 28);
            this.btn_load.TabIndex = 11;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btn_save);
            this.flowLayoutPanel3.Controls.Add(this.btn_load);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(1366, 28);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(109, 74);
            this.flowLayoutPanel3.TabIndex = 12;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1040);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picturbx);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form";
            this.Text = "Moi_Paint";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturbx)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_clr;
        private System.Windows.Forms.Button btn_crcle;
        private System.Windows.Forms.Button btn_sqr;
        private System.Windows.Forms.Button btn_tri;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btn_red;
        private System.Windows.Forms.Button btn_green;
        private System.Windows.Forms.Button btn_blu;
        private System.Windows.Forms.Button btn_yellow;
        private System.Windows.Forms.Button btn_manycolor;
        private System.Windows.Forms.Button btn_black;
        private System.Windows.Forms.Button btn_darkblu;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox picturbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
    }
}

