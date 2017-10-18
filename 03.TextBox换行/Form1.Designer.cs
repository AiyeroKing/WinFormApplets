namespace _03.TextBox换行
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
            this.textscanf = new System.Windows.Forms.TextBox();
            this.textprintf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textscanf
            // 
            this.textscanf.Location = new System.Drawing.Point(51, 46);
            this.textscanf.Multiline = true;
            this.textscanf.Name = "textscanf";
            this.textscanf.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textscanf.Size = new System.Drawing.Size(550, 128);
            this.textscanf.TabIndex = 0;
            this.textscanf.TextChanged += new System.EventHandler(this.textscanf_TextChanged);
            // 
            // textprintf
            // 
            this.textprintf.AutoSize = true;
            this.textprintf.Location = new System.Drawing.Point(51, 195);
            this.textprintf.MaximumSize = new System.Drawing.Size(530, 131);
            this.textprintf.Name = "textprintf";
            this.textprintf.Size = new System.Drawing.Size(41, 12);
            this.textprintf.TabIndex = 1;
            this.textprintf.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 373);
            this.Controls.Add(this.textprintf);
            this.Controls.Add(this.textscanf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textscanf;
        private System.Windows.Forms.Label textprintf;
    }
}

