using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        float x, y, wid, hei, xspace, yspace;
        Pen bpen = new Pen(Brushes.Blue, 1);
        int xcnt, ycnt, cnt, pcnt;
        float[] a = new float[22], b = new float[22];
        int[,] cl = new int[22, 22];

        private void columns_ValueChanged(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            panel.Refresh();
            Graphics gr = panel.CreateGraphics();
            wid = panel.Width - 1;
            hei = panel.Height - 1;
            xcnt = Convert.ToInt32(columns.Value);
            ycnt = Convert.ToInt32(rows.Value);
            if (xcnt % 2 == 1 || ycnt % 2 == 1)
            {

            }
            x = y = cnt = pcnt = 0;
            xspace = wid / xcnt;
            yspace = hei / ycnt;
            for (int i = 0; i < xcnt; i++)
            {
                a[i + 1] = x;
                x += xspace;
            }
            a[xcnt + 1] = wid;
            for (int i = 0; i < ycnt; i++)
            {
                b[i + 1] = y;
                y += yspace;
            }
            b[ycnt + 1] = hei;
            Random col = new Random();
            for(int i = 1; i <= xcnt; i++)
                for(int j = 1; j <= ycnt; j++)
                    if (Convert.ToInt32(col.Next(0, 2)) == 0)
                    {
                        gr.FillRectangle(Brushes.Black, a[i], b[j], xspace, yspace);
                        cl[i, j] = 0;
                    }
                    else
                    {
                        cnt++;
                        gr.FillRectangle(Brushes.White, a[i], b[j], xspace, yspace);
                        cl[i, j] = 1;
                    }
            if (cnt == 0)
            {
                gr.FillRectangle(Brushes.White, a[xcnt], b[ycnt], xspace, yspace);
                cl[xcnt, ycnt] = 1;
            }
            if (cnt== xcnt * ycnt)
            {
                gr.FillRectangle(Brushes.Black, a[xcnt], b[ycnt], xspace, yspace);
                cl[xcnt, ycnt] = 0;
            }
            x = y = 0;
            for (int i = 0; i < xcnt; i++)
            {
                gr.DrawLine(bpen, x, 0, x, hei);
                x += xspace;
            }
            gr.DrawLine(bpen, wid, 0, wid, hei);
            for (int i = 0; i < ycnt; i++)
            {
                gr.DrawLine(bpen, 0, y, wid, y);
                y += yspace;
            }
            gr.DrawLine(bpen, 0, hei, wid, hei);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void columns_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                btn_start_Click(sender,e);
        }

        private void rows_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_start_Click(sender, e);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_start_Click(sender, e);
        }

        private void panel_MouseClick(object sender, MouseEventArgs e)
        {
            pcnt++;
            Graphics gr = panel.CreateGraphics();
            for (int i = 1; i <= xcnt; i++)
                for (int j = 1; j <= ycnt; j++)
                {
                    if (a[i] <= e.X && e.X <= a[i + 1] && b[j] <= e.Y && e.Y <= b[j + 1])
                    {
                        for (int ii = 1; ii <= xcnt; ii++)
                        {
                            if (cl[ii, j] == 0)
                            {
                                cl[ii, j] = 1;
                                gr.FillRectangle(Brushes.White, a[ii], b[j], xspace, yspace);
                            }
                            else
                            {
                                cl[ii, j] = 0;
                                gr.FillRectangle(Brushes.Black, a[ii], b[j], xspace, yspace);
                            }
                        }
                        for (int jj = 1; jj <= ycnt; jj++)
                            if (jj != j)
                            {
                                if (cl[i, jj] == 0)
                                {
                                    cl[i, jj] = 1;
                                    gr.FillRectangle(Brushes.White, a[i], b[jj], xspace, yspace);
                                }
                                else
                                {
                                    cl[i, jj] = 0;
                                    gr.FillRectangle(Brushes.Black, a[i], b[jj], xspace, yspace);
                                }
                            }
                        i = xcnt;
                        j = ycnt;
                    }
                }
            x = y = 0;
            for (int i = 0; i < xcnt; i++)
            {
                gr.DrawLine(bpen, x, 0, x, hei);
                x += xspace;
            }
            gr.DrawLine(bpen, wid, 0, wid, hei);
            for (int i = 0; i < ycnt; i++)
            {
                gr.DrawLine(bpen, 0, y, wid, y);
                y += yspace;
            }
            gr.DrawLine(bpen, 0, hei, wid, hei);
            cnt = 0;
            for(int i = 1; i <= xcnt; i++)
                for(int j = 1; j <= ycnt; j++)
                    cnt += cl[i, j];
            if (cnt == 0 || cnt == xcnt * ycnt)
            {
                if (pcnt > 1)
                    MessageBox.Show("You won in " + pcnt.ToString() + " moves");
                else
                    MessageBox.Show("You won in " + pcnt.ToString() + " move");
                panel.Refresh();
            }
        }
    }
}