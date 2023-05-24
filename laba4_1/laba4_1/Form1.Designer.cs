
namespace laba4_1
{
    partial class Form1
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
            this.checkBoxCtrl = new System.Windows.Forms.CheckBox();
            this.checkBoxCrcl = new System.Windows.Forms.CheckBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxCtrl
            // 
            this.checkBoxCtrl.AutoSize = true;
            this.checkBoxCtrl.Location = new System.Drawing.Point(12, 12);
            this.checkBoxCtrl.Name = "checkBoxCtrl";
            this.checkBoxCtrl.Size = new System.Drawing.Size(91, 21);
            this.checkBoxCtrl.TabIndex = 0;
            this.checkBoxCtrl.Text = "Press Ctrl";
            this.checkBoxCtrl.UseVisualStyleBackColor = true;
            // 
            // checkBoxCrcl
            // 
            this.checkBoxCrcl.AutoSize = true;
            this.checkBoxCrcl.Location = new System.Drawing.Point(12, 39);
            this.checkBoxCrcl.Name = "checkBoxCrcl";
            this.checkBoxCrcl.Size = new System.Drawing.Size(110, 21);
            this.checkBoxCrcl.TabIndex = 1;
            this.checkBoxCrcl.Text = "Many Circles";
            this.checkBoxCrcl.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(12, 66);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(50, 32);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Del";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 509);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.checkBoxCrcl);
            this.Controls.Add(this.checkBoxCtrl);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxCtrl;
        private System.Windows.Forms.CheckBox checkBoxCrcl;
        private System.Windows.Forms.Button btnDel;
    }
}

