using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace testNetSpeed
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private async void button_download1_Click(object sender, EventArgs e)
        {
            if (textBox1_URL.Text==null)
            {
                MessageBox.Show("不能为空！");
                return;
            }

            DateTime start = DateTime.Now;

            //Stopwatch watch = new Stopwatch();
            //watch.Start();

            string url = this.textBox1_URL.Text;
            string output_filename = this.textBox2_out.Text;

            var request = System.Net.HttpWebRequest.Create(url);

            using (var response = request.GetResponse())
            {
                // 比例转换
                var ratio = new ProgressRatio(response.ContentLength);

                //将下载的文件大小转换成MB格式。Mb
                double a = response.ContentLength;
                double b = 1024;
                double Mb = a / b;
                string show = Mb.ToString("0.00");

                //计算进度条 
                this.Invoke(
                    new Action(() =>
                    {
                        progressBar1.Minimum = 0;
                        progressBar1.Maximum = ratio.GetInteger(response.ContentLength);
                    }
                ));

                using (var source = response.GetResponseStream())

                using (var destination = File.Create(output_filename))
                {
                    // await source.CopyToAsync(destination);
                    await DumpStream(source,
                        destination,
                        (offset) =>
                        {
                            this.Invoke(new Action(() =>
                            {
                                progressBar1.Value = ratio.GetInteger(offset);
                            }));
                            return true;
                        });
                }

                this.Invoke(new Action(() =>
                {
                   // MessageBox.Show(this, $"下载完成。总长度 {response.ContentLength}个字节，合计{show}M");
                }));


                DateTime end = DateTime.Now;

                TimeSpan timespan = end - start;
                //MessageBox.Show("所用时间："+timespan.TotalMilliseconds+"ms");
                double second = timespan.TotalMilliseconds / 1000;
                double speed = Mb / second;
                string speeds = speed.ToString("0.00");
                MessageBox.Show("下载速度是：" + speeds+"kb/s");
            //MessageBox.Show(speed.ToString());
            }
        }

        //定义下面函数的progressoutput 的类型
        //
        public delegate bool ProgressOutput(long offset);

        public static async Task<long> DumpStream(Stream streamSource,
    Stream streamTarget,

    ProgressOutput progressOutputMethod)
        {
            DateTime star1 = DateTime.Now;
            int nChunkSize = 8192;
            byte[] bytes = new byte[nChunkSize];
            long lLength = 0;
            while (true)
            {
                if (progressOutputMethod != null)
                {
                    if (progressOutputMethod(lLength) == false)
                        break;
                }

                int n = await streamSource.ReadAsync(bytes, 0, nChunkSize);

                if (n != 0)
                    await streamTarget.WriteAsync(bytes, 0, n);

                if (n <= 0)
                    break;

                lLength += n;
            }

            if (progressOutputMethod != null)
            {
                progressOutputMethod(lLength);
            }
            DateTime end1 = DateTime.Now;
            TimeSpan timespan = end1 - star1;
            //MessageBox.Show(timespan.ToString());
            return lLength;
            
        }




        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

