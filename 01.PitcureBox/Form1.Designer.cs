namespace _01.PitcureBox
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.up_Next_picture_btn = new System.Windows.Forms.Button();
            this.down_Next_picture_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(496, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // up_Next_picture_btn
            // 
            this.up_Next_picture_btn.Location = new System.Drawing.Point(121, 349);
            this.up_Next_picture_btn.Name = "up_Next_picture_btn";
            this.up_Next_picture_btn.Size = new System.Drawing.Size(75, 23);
            this.up_Next_picture_btn.TabIndex = 1;
            this.up_Next_picture_btn.Text = "上一张";
            this.up_Next_picture_btn.UseVisualStyleBackColor = true;
            this.up_Next_picture_btn.Click += new System.EventHandler(this.up_Next_picture_btn_Click);
            // 
            // down_Next_picture_btn
            // 
            this.down_Next_picture_btn.Location = new System.Drawing.Point(371, 349);
            this.down_Next_picture_btn.Name = "down_Next_picture_btn";
            this.down_Next_picture_btn.Size = new System.Drawing.Size(75, 23);
            this.down_Next_picture_btn.TabIndex = 1;
            this.down_Next_picture_btn.Text = "下一张";
            this.down_Next_picture_btn.UseVisualStyleBackColor = true;
            this.down_Next_picture_btn.Click += new System.EventHandler(this.down_Next_picture_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 446);
            this.Controls.Add(this.down_Next_picture_btn);
            this.Controls.Add(this.up_Next_picture_btn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button up_Next_picture_btn;
        private System.Windows.Forms.Button down_Next_picture_btn;
    }
}

