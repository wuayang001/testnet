
namespace testNetSpeed
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
            this.textBox1_URL = new System.Windows.Forms.TextBox();
            this.button_download1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2_out = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // textBox1_URL
            // 
            this.textBox1_URL.Location = new System.Drawing.Point(297, 92);
            this.textBox1_URL.Name = "textBox1_URL";
            this.textBox1_URL.Size = new System.Drawing.Size(443, 28);
            this.textBox1_URL.TabIndex = 0;
            this.textBox1_URL.Text = "http://dp2003.com/dp2installer/v3/palm_app.zip";
            // 
            // button_download1
            // 
            this.button_download1.Location = new System.Drawing.Point(297, 198);
            this.button_download1.Name = "button_download1";
            this.button_download1.Size = new System.Drawing.Size(155, 49);
            this.button_download1.TabIndex = 1;
            this.button_download1.Text = "下载";
            this.button_download1.UseVisualStyleBackColor = true;
            this.button_download1.Click += new System.EventHandler(this.button_download1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(568, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 49);
            this.button2.TabIndex = 2;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2_out
            // 
            this.textBox2_out.Location = new System.Drawing.Point(297, 146);
            this.textBox2_out.Name = "textBox2_out";
            this.textBox2_out.Size = new System.Drawing.Size(443, 28);
            this.textBox2_out.TabIndex = 3;
            this.textBox2_out.Text = "D:\\temp\\b";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "网址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "保存到：";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(131, 365);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(747, 62);
            this.progressBar1.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 516);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2_out);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_download1);
            this.Controls.Add(this.textBox1_URL);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1_URL;
        private System.Windows.Forms.Button button_download1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2_out;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}