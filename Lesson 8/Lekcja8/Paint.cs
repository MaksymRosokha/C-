using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lekcja8
{
    public partial class Paint : Form
    {
        Brush color = Brushes.Black;
        List<Point> points = new List<Point>();
        int grubosc = 4;
        Bitmap bmp;

        public Paint()
        {
            InitializeComponent();
            numericUpDown1.Value = grubosc;
        }

            void fsend(int x, int y)
            {

                byte[] bytCommand = new byte[] { };
                UdpClient udpClient = new UdpClient();
                udpClient.Connect(IPAddress.Parse("10.0.0.255"), 8000);
            int r = 255;
            int g = 0;
            int b = 0;
            bytCommand = Encoding.UTF8.GetBytes($"#({x},{y},{r}, {g}, {b})");
                udpClient.Send(bytCommand, bytCommand.Length);

            

                pictureBox1.CreateGraphics().FillEllipse(Brushes.Black, x - 2, y - 2, 4, 4);


            }

            void frec()
            {
                CheckForIllegalCrossThreadCalls = false;

                //byte[] bytCommand = new byte[] { };
                System.Net.Sockets.UdpClient receivingUdpClient = new System.Net.Sockets.UdpClient(8000);

                Thread th = new Thread(() => {
                    IPEndPoint iep = new System.Net.IPEndPoint(System.Net.IPAddress.Any, 0);
                    while (true)
                    {
                        byte[] receiveBytes = receivingUdpClient.Receive(ref iep);

                        string str = System.Text.Encoding.UTF8.GetString(receiveBytes);
                        int x = 0;
                        int y = 0;

                        try
                        {
                            x = Convert.ToInt32(str.Replace("#", "").Replace("(", "").Replace(")", "").Split(',')[0]);
                            y = Convert.ToInt32(str.Replace("#", "").Replace("(", "").Replace(")", "").Split(',')[1]);
                        }
                        catch
                        {
                            
                        }
                        int r = Convert.ToInt32(str.Replace("#", "").Replace("(", "").Replace(")", "").Split(',')[2]);
                        int g = Convert.ToInt32(str.Replace("#", "").Replace("(", "").Replace(")", "").Split(',')[3]);
                        int b = Convert.ToInt32(str.Replace("#", "").Replace("(", "").Replace(")", "").Split(',')[4]);
                        //int gr = Convert.ToInt32(str.Replace("#", "").Replace("(", "").Replace(")", "").Split(',')[5]);
                        pictureBox1.CreateGraphics().DrawEllipse(new Pen(Color.FromArgb(r, g, b), 4), x - 2, y - 2, 4, 4);

                    }

                });
                th.IsBackground = true;
                th.Start();

            }

            private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
            {

                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {

                    try
                    {
                        fsend(e.X, e.Y);

                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                }

            }

            private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
            {
            fsend(-1, -1);
        }

            private void button1_Click(object sender, EventArgs e)
            {
                frec();
            }

        private void pctPaint_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                Graphics gg = pctColor.CreateGraphics();
                gg.Clear(Color.FromArgb(bmp.GetPixel(e.X, e.Y).R, bmp.GetPixel(e.X, e.Y).G, bmp.GetPixel(e.X, e.Y).B));


                if (e.Button == MouseButtons.Left)
                {

                    //Graphics g = pctPaint.CreateGraphics();
                    //g.FillEllipse(color, e.X - 2, e.Y - 2, 4, 4);
                    Graphics g = Graphics.FromImage(bmp);

                    points.Add(new Point(e.X, e.Y));

                    if (points.Count > 1)
                    {
                        g.DrawLines(new Pen(color, grubosc), points.ToArray());
                    }
                    pictureBox1.Image = bmp;
                }
            } catch(Exception ex)
            {
                
            }

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {

                try
                {
                    fsend(e.X, e.Y);

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                color = new SolidBrush(colorDialog1.Color);
            }
        }

        private void wyczyśćObrazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wyczyścić obraz?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Graphics g = pictureBox1.CreateGraphics();
                g.Clear(Color.White);
                resetBitmap();
            }
        }

        private void pctPaint_MouseUp(object sender, MouseEventArgs e)
        {
            points.Clear();
            fsend(-1, -1);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            grubosc = (int)numericUpDown1.Value;
        }

        private void Paint_Load(object sender, EventArgs e)
        {
            resetBitmap();
            pictureBox1.Image = bmp;
        }

        private void resetBitmap()
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            pictureBox1.Image = bmp;
        }

        private void pobraćObrazekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "plik jpg|*.jpg|plik bmp|*.bmp";
            DialogResult dr = saveFileDialog1.ShowDialog();
            try
            {
                if (dr == DialogResult.OK)
                {
                    bmp.Save(saveFileDialog1.FileName);
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void otworzyćObrazekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "plik jpg|*.jpg|plik bmp|*.bmp";
            DialogResult dr = openFileDialog1.ShowDialog();

            try
            {
                if (dr == DialogResult.OK)
                {
                    bmp = new Bitmap(openFileDialog1.FileName);
                    pictureBox1.Image = bmp;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void szaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < pictureBox1.Width; x++)
            {
                for (int y = 0; y < pictureBox1.Height; y++)
                {
                    int rgb = (bmp.GetPixel(x, y).R + bmp.GetPixel(x, y).G + bmp.GetPixel(x, y).B) / 3;
                    Color color = Color.FromArgb(rgb, rgb, rgb);
                    bmp.SetPixel(x, y, color);
                }
            }
        }

        private void rozmyćToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmp2 = new Bitmap(bmp);
            for (int x = 0; x < pictureBox1.Width; x++)
            {
                for (int y = 0; y < pictureBox1.Height; y++)
                {
                    try
                    {
                        int r = (bmp.GetPixel(x - 1, y - 1).R + bmp.GetPixel(x - 1, y).R + 
                            bmp.GetPixel(x - 1, y + 1).R + bmp.GetPixel(x, y - 1).R +
                            bmp.GetPixel(x, y).R + bmp.GetPixel(x, y + 1).R +
                            bmp.GetPixel(x+1, y-1).R + bmp.GetPixel(x+1, y).R +
                            bmp.GetPixel(x + 1, y+1).R) / 9;
                        int g = (bmp.GetPixel(x - 1, y - 1).G + bmp.GetPixel(x - 1, y).G +
                            bmp.GetPixel(x - 1, y + 1).G + bmp.GetPixel(x, y - 1).G +
                            bmp.GetPixel(x, y).G + bmp.GetPixel(x, y + 1).G +
                            bmp.GetPixel(x + 1, y - 1).G + bmp.GetPixel(x + 1, y).G +
                            bmp.GetPixel(x + 1, y + 1).G) / 9; ;
                        int b = (bmp.GetPixel(x - 1, y - 1).B + bmp.GetPixel(x - 1, y).B +
                            bmp.GetPixel(x - 1, y + 1).B + bmp.GetPixel(x, y - 1).B +
                            bmp.GetPixel(x, y).B + bmp.GetPixel(x, y + 1).B +
                            bmp.GetPixel(x + 1, y - 1).B + bmp.GetPixel(x + 1, y).B +
                            bmp.GetPixel(x + 1, y + 1).B) / 9; ;
                        Color color = Color.FromArgb(r, g, b);
                        bmp2.SetPixel(x, y, color);
                    } catch (Exception ex)
                    {

                    }
                }
            }
            bmp = new Bitmap(bmp2);
        }

    }
}
