namespace _04.RadioMultiSelect
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.username_input = new System.Windows.Forms.TextBox();
            this.password_input = new System.Windows.Forms.TextBox();
            this.StyleSB = new System.Windows.Forms.GroupBox();
            this.Teacher_radio = new System.Windows.Forms.RadioButton();
            this.Student_radio = new System.Windows.Forms.RadioButton();
            this.OKbtn = new System.Windows.Forms.Button();
            this.ReSet = new System.Windows.Forms.Button();
            this.StyleSB.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "密  码：";
            // 
            // username_input
            // 
            this.username_input.Location = new System.Drawing.Point(290, 52);
            this.username_input.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.username_input.Name = "username_input";
            this.username_input.Size = new System.Drawing.Size(209, 23);
            this.username_input.TabIndex = 0;
            // 
            // password_input
            // 
            this.password_input.Location = new System.Drawing.Point(289, 106);
            this.password_input.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password_input.Name = "password_input";
            this.password_input.Size = new System.Drawing.Size(209, 23);
            this.password_input.TabIndex = 1;
            // 
            // StyleSB
            // 
            this.StyleSB.BackColor = System.Drawing.SystemColors.Control;
            this.StyleSB.Controls.Add(this.Teacher_radio);
            this.StyleSB.Controls.Add(this.Student_radio);
            this.StyleSB.ForeColor = System.Drawing.SystemColors.Control;
            this.StyleSB.Location = new System.Drawing.Point(223, 154);
            this.StyleSB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StyleSB.Name = "StyleSB";
            this.StyleSB.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StyleSB.Size = new System.Drawing.Size(276, 75);
            this.StyleSB.TabIndex = 2;
            this.StyleSB.TabStop = false;
            this.StyleSB.Paint += new System.Windows.Forms.PaintEventHandler(this.StyleSB_Paint);
            // 
            // Teacher_radio
            // 
            this.Teacher_radio.AutoSize = true;
            this.Teacher_radio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Teacher_radio.Location = new System.Drawing.Point(184, 30);
            this.Teacher_radio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Teacher_radio.Name = "Teacher_radio";
            this.Teacher_radio.Size = new System.Drawing.Size(50, 21);
            this.Teacher_radio.TabIndex = 0;
            this.Teacher_radio.TabStop = true;
            this.Teacher_radio.Text = "教师";
            this.Teacher_radio.UseVisualStyleBackColor = true;
            // 
            // Student_radio
            // 
            this.Student_radio.AutoSize = true;
            this.Student_radio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Student_radio.Location = new System.Drawing.Point(22, 30);
            this.Student_radio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Student_radio.Name = "Student_radio";
            this.Student_radio.Size = new System.Drawing.Size(50, 21);
            this.Student_radio.TabIndex = 0;
            this.Student_radio.TabStop = true;
            this.Student_radio.Text = "学生";
            this.Student_radio.UseVisualStyleBackColor = true;
            // 
            // OKbtn
            // 
            this.OKbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKbtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OKbtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.OKbtn.Location = new System.Drawing.Point(196, 258);
            this.OKbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OKbtn.Name = "OKbtn";
            this.OKbtn.Size = new System.Drawing.Size(87, 33);
            this.OKbtn.TabIndex = 3;
            this.OKbtn.Text = "登录";
            this.OKbtn.UseVisualStyleBackColor = true;
            this.OKbtn.Click += new System.EventHandler(this.OKbtn_Click);
            this.OKbtn.Paint += new System.Windows.Forms.PaintEventHandler(this.OKbtn_Paint);
            // 
            // ReSet
            // 
            this.ReSet.Location = new System.Drawing.Point(433, 258);
            this.ReSet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ReSet.Name = "ReSet";
            this.ReSet.Size = new System.Drawing.Size(87, 33);
            this.ReSet.TabIndex = 3;
            this.ReSet.Text = "重置";
            this.ReSet.UseVisualStyleBackColor = true;
            this.ReSet.Click += new System.EventHandler(this.ReSet_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 338);
            this.Controls.Add(this.ReSet);
            this.Controls.Add(this.OKbtn);
            this.Controls.Add(this.StyleSB);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.username_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.StyleSB.ResumeLayout(false);
            this.StyleSB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username_input;
        private System.Windows.Forms.TextBox password_input;
        private System.Windows.Forms.GroupBox StyleSB;
        private System.Windows.Forms.RadioButton Teacher_radio;
        private System.Windows.Forms.RadioButton Student_radio;
        private System.Windows.Forms.Button OKbtn;
        private System.Windows.Forms.Button ReSet;
    }
}