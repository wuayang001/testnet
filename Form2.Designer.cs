
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
            this.label_percentage = new System.Windows.Forms.Label();
            this.textBox_statistics = new System.Windows.Forms.TextBox();
            this.textBox_cycle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1_URL
            // 
            this.textBox1_URL.Location = new System.Drawing.Point(83, 224);
            this.textBox1_URL.Name = "textBox1_URL";
            this.textBox1_URL.Size = new System.Drawing.Size(489, 28);
            this.textBox1_URL.TabIndex = 0;
            this.textBox1_URL.Text = "http://dp2003.com/dp2installer/v3/palm_app.zip";
            // 
            // button_download1
            // 
            this.button_download1.Location = new System.Drawing.Point(130, 507);
            this.button_download1.Name = "button_download1";
            this.button_download1.Size = new System.Drawing.Size(366, 65);
            this.button_download1.TabIndex = 1;
            this.button_download1.Text = "下载";
            this.button_download1.UseVisualStyleBackColor = true;
            this.button_download1.Click += new System.EventHandler(this.button_download1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(130, 626);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(366, 65);
            this.button2.TabIndex = 2;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2_out
            // 
            this.textBox2_out.Location = new System.Drawing.Point(83, 324);
            this.textBox2_out.Name = "textBox2_out";
            this.textBox2_out.Size = new System.Drawing.Size(489, 28);
            this.textBox2_out.TabIndex = 3;
            this.textBox2_out.Text = "D:\\temp\\i";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "网址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "保存到：";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(71, 90);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(948, 62);
            this.progressBar1.TabIndex = 6;
            // 
            // label_percentage
            // 
            this.label_percentage.AutoSize = true;
            this.label_percentage.Font = new System.Drawing.Font("宋体", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_percentage.Location = new System.Drawing.Point(1025, 90);
            this.label_percentage.Name = "label_percentage";
            this.label_percentage.Size = new System.Drawing.Size(250, 44);
            this.label_percentage.TabIndex = 7;
            this.label_percentage.Text = "percentage";
            // 
            // textBox_statistics
            // 
            this.textBox_statistics.Location = new System.Drawing.Point(611, 209);
            this.textBox_statistics.Multiline = true;
            this.textBox_statistics.Name = "textBox_statistics";
            this.textBox_statistics.Size = new System.Drawing.Size(664, 514);
            this.textBox_statistics.TabIndex = 8;
            // 
            // textBox_cycle
            // 
            this.textBox_cycle.Location = new System.Drawing.Point(83, 434);
            this.textBox_cycle.Name = "textBox_cycle";
            this.textBox_cycle.Size = new System.Drawing.Size(106, 28);
            this.textBox_cycle.TabIndex = 9;
            this.textBox_cycle.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "循环次数：";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 895);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_cycle);
            this.Controls.Add(this.textBox_statistics);
            this.Controls.Add(this.label_percentage);
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
        private System.Windows.Forms.Label label_percentage;
        private System.Windows.Forms.TextBox textBox_statistics;
        private System.Windows.Forms.TextBox textBox_cycle;
        private System.Windows.Forms.Label label3;
    }
}