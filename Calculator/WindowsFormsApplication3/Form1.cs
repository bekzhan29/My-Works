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
    public partial class calc : Form
    {
        class bigint
        {
            public int[] a = new int[1111];
            public int size;
            public static bigint f(string s)
            {
                bigint a = new bigint();
                a.size = s.Length;
                for (int i = 1; i <= a.size; i++)
                {
                    a.a[a.size - i + 1] = s[i - 1] - 48;
                }
                return a;
            }
            public static bigint operator +(bigint a, bigint b)
            {
                bigint c = new bigint();
                c.size = Math.Max(a.size, b.size);
                for (int i = 1; i <= c.size; i++)
                    c.a[i] = a.a[i] + b.a[i];
                for (int i = 1; i <= c.size; i++)
                    if (c.a[i] > 9)
                    {
                        c.a[i] -= 10;
                        c.a[i + 1]++;
                        if (i == c.size)
                            c.size++;
                    }
                return c;
            }
            public static bigint operator -(bigint a, bigint b)
            {
                bigint c = new bigint();
                c.size = Math.Max(a.size, b.size);
                for (int i = 1; i <= c.size; i++)
                    c.a[i] = a.a[i] - b.a[i];
                for (int i = 1; i <= c.size; i++)
                    if (c.a[i] < 0)
                    {
                        c.a[i] += 10;
                        c.a[i + 1]--;
                    }
                while (c.a[c.size] == 0 && c.size > 1)
                    c.size--;
                return c;
            }
            public static bigint operator *(bigint a, bigint b)
            {
                bigint c = new bigint();
                c.size = a.size + b.size;
                for (int i = 1; i <= a.size; i++)
                    for (int j = 1; j <= b.size; j++)
                        c.a[i + j - 1] += a.a[i] * b.a[j];
                for (int i = 1; i <= c.size; i++)
                    if (c.a[i] > 9)
                    {
                        c.a[i + 1] += c.a[i] / 10;
                        c.a[i] %= 10;
                        if (i == c.size)
                            c.size++;
                    }
                while (c.a[c.size] == 0 && c.size > 1)
                    c.size--;
                return c;
            }
            public override string ToString()
            {
                string s = "";
                for (int i = size; i >= 1; i--)
                    s = s + a[i];
                return s;
            }
        }

        bigint last = new bigint();
        bigint latest = new bigint();
        int oper, loper;

        public calc()
        {
            InitializeComponent();
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (calctxt.Text == "0")
                calctxt.Text = "";
            calctxt.Text += 0;
        }

        private void one_Click(object sender, EventArgs e)
        {
            if (calctxt.Text == "0")
                calctxt.Text = "";
            calctxt.Text += 1;
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (calctxt.Text == "0")
                calctxt.Text = "";
            calctxt.Text += 2;
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (calctxt.Text == "0")
                calctxt.Text = "";
            calctxt.Text += 3;
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (calctxt.Text == "0")
                calctxt.Text = "";
            calctxt.Text += 4;
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (calctxt.Text == "0")
                calctxt.Text = "";
            calctxt.Text += 5;
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (calctxt.Text == "0")
                calctxt.Text = "";
            calctxt.Text += 6;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (calctxt.Text == "0")
                calctxt.Text = "";
            calctxt.Text += 7;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (calctxt.Text == "0")
                calctxt.Text = "";
            calctxt.Text += 8;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (calctxt.Text == "0")
                calctxt.Text = "";
            calctxt.Text += 9;
        }

        private void calc_Load(object sender, EventArgs e)
        {
            calctxt.Text = "0";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            last = bigint.f("0");
            calctxt.Text = "0";
        }

        private void add_Click(object sender, EventArgs e)
        {
            last = bigint.f(calctxt.Text);
            oper = 1;
            calctxt.Text = "0";
        }
        
        private void sub_Click(object sender, EventArgs e)
        {
            last = bigint.f(calctxt.Text);
            oper = 2;
            calctxt.Text = "0";
        }

        private void mul_Click(object sender, EventArgs e)
        {
            last = bigint.f(calctxt.Text);
            oper = 3;
            calctxt.Text = "0";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            bigint b = bigint.f(calctxt.Text);
            if (oper == 1)
            {
                last += b;
                calctxt.Text = last.ToString();
                latest = b;
                loper = oper;
            }
            if (oper == 2)
            {
                last -= b;
                calctxt.Text = last.ToString();
                latest = b;
                loper = oper;
            }
            if (oper == 3)
            {
                last *= b;
                calctxt.Text = last.ToString();
                latest = b;
                loper = oper;
            }
            if (oper == 4)
            {
                if (loper == 1)
                {
                    last += latest;
                    calctxt.Text = last.ToString();
                }
                if (loper == 2)
                {
                    last -= latest;
                    calctxt.Text = last.ToString();
                }
                if(loper==3)
                {
                    last *= latest;
                    calctxt.Text = last.ToString();
                }
            }
            oper = 4;
        }

        private void foreachkeydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Multiply)
                mul_Click(sender, e);
            if (e.KeyCode == Keys.Add)
                add_Click(sender, e);
            if (e.KeyCode == Keys.Subtract)
                sub_Click(sender, e);
            if (e.KeyCode == Keys.NumPad0)
                zero_Click(sender, e);
            if (e.KeyCode == Keys.NumPad1)
                one_Click(sender, e);
            if (e.KeyCode == Keys.NumPad2)
                two_Click(sender, e);
            if (e.KeyCode == Keys.NumPad3)
                three_Click(sender, e);
            if (e.KeyCode == Keys.NumPad4)
                four_Click(sender, e);
            if (e.KeyCode == Keys.NumPad5)
                five_Click(sender, e);
            if (e.KeyCode == Keys.NumPad6)
                six_Click(sender, e);
            if (e.KeyCode == Keys.NumPad7)
                seven_Click(sender, e);
            if (e.KeyCode == Keys.NumPad8)
                eight_Click(sender, e);
            if (e.KeyCode == Keys.NumPad9)
                nine_Click(sender, e);
            if (e.KeyCode == Keys.D0)
                zero_Click(sender, e);
            if (e.KeyCode == Keys.D1)
                one_Click(sender, e);
            if (e.KeyCode == Keys.D2)
                two_Click(sender, e);
            if (e.KeyCode == Keys.D3)
                three_Click(sender, e);
            if (e.KeyCode == Keys.D4)
                four_Click(sender, e);
            if (e.KeyCode == Keys.D5)
                five_Click(sender, e);
            if (e.KeyCode == Keys.D6)
                six_Click(sender, e);
            if (e.KeyCode == Keys.D7)
                seven_Click(sender, e);
            if (e.KeyCode == Keys.D8)
                eight_Click(sender, e);
            if (e.KeyCode == Keys.D9)
                nine_Click(sender, e);
        }

        private void calc_KeyDown(object sender, KeyEventArgs e)
        {
            foreachkeydown(sender, e);
        }

        private void calctxt_KeyDown(object sender, KeyEventArgs e)
        {
            foreachkeydown(sender, e);
        }

        private void clear_KeyDown(object sender, KeyEventArgs e)
        {
            foreachkeydown(sender, e);
        }

        private void mul_KeyDown(object sender, KeyEventArgs e)
        {
            foreachkeydown(sender, e);
        }

        private void sub_KeyDown(object sender, KeyEventArgs e)
        {
            foreachkeydown(sender, e);
        }

        private void seven_KeyDown(object sender, KeyEventArgs e)
        {
            foreachkeydown(sender, e);
        }

        private void eight_KeyDown(object sender, KeyEventArgs e)
        {
            foreachkeydown(sender, e);
        }

        private void add_KeyDown_1(object sender, KeyEventArgs e)
        {
            foreachkeydown(sender, e);
        }

        private void equal_KeyDown_1(object sender, KeyEventArgs e)
        {
            foreachkeydown(sender, e);
        }

        private void nine_KeyDown_1(object sender, KeyEventArgs e)
        {
            foreachkeydown(sender, e);
        }

        private void six_KeyDown_1(object sender, KeyEventArgs e)
        {
            foreachkeydown(sender, e);
        }

        private void five_KeyDown_1(object sender, KeyEventArgs e)
        {
            foreachkeydown(sender, e);
        }

        private void four_KeyDown_1(object sender, KeyEventArgs e)
        {
            foreachkeydown(sender, e);
        }

        private void three_KeyDown_1(object sender, KeyEventArgs e)
        {
            foreachkeydown(sender, e);
        }

        private void two_KeyDown_1(object sender, KeyEventArgs e)
        {
            foreachkeydown(sender, e);
        }

        private void one_KeyDown_1(object sender, KeyEventArgs e)
        {
            foreachkeydown(sender, e);
        }

        private void zero_KeyDown_1(object sender, KeyEventArgs e)
        {
            foreachkeydown(sender, e);
        }
    }
}
