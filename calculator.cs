using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using System.Net.Configuration;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace calculator
{
    public partial class calculatorload : Form
    {
        Thread thread;
        public calculatorload()
        {
            InitializeComponent();

            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;//跨线程访问

            buttonclose.Location = new Point(241, -2);
            buttonminimize.Location = new Point(218, -2);
            reduce.Visible = false;
            listbinary.Visible = false;
            labelbinary1.Visible = false;
            labelbinary2.Visible = false;
            labelbinary3.Visible = false;
            labelbinary4.Visible = false;
            Type();
        }

        //数
        double op1 = 0;
        double op2 = 0;
        double result = 0;
        //等值
        bool n = false;
        bool Eq = false;
        //功能
        bool topMost = true;
        bool PreventSystemSleep = false;
        int lbl = 0;

        //运算符符号
        string symbol = null;

        //数字输入
        void num (int num, object sender, EventArgs e)
        {
            if (lblShow.Text == "0" || n == true)
            {
                lblShow.Text = "";
                n = false;
            }
            if (Eq == true)
            {
                btnC_Click(sender, e);
                lblShow.Text = "";
            }
            lblShow.Text += num;
            labelbinaryshow();
        }
        //遥遥领先！！！

        //数字
        private void btn1_Click(object sender, EventArgs e)
        {
            num(1,sender, e);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            num(2, sender, e);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            num(3, sender, e);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            num(4, sender, e);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            num(5, sender, e);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            num(6, sender, e);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            num(7, sender, e);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            num(8, sender, e);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            num(9, sender, e);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            num(0, sender, e);
        }


        //c 清除全部
        private void btnC_Click(object sender, EventArgs e)
        {
            op1 = 0;
            op2 = 0;
            result = 0;
            Eq = false;
            symbol = null;
            label.Text = "";
            lblShow.Text = "0";
            labelbinaryshow();
        }
        //ce 清除输入
        private void btnCE_Click(object sender, EventArgs e)
        {
            if (Eq == true)
            {
                btnC_Click(sender, e);
                Eq = false;
            }
            lblShow.Text = "0";
            labelbinaryshow();
        }

        //=
        private void Equal()
        {
            switch (symbol)
            {
                case "+":
                    result = op1 + op2;
                    break;
                case "-":
                    result = op1 - op2;
                    break;
                case "*":
                    result = op1 * op2;
                    break;
                case "/":
                    if (op2 == 0)
                    {
                        lblShow.Text = " 除数不能为0!";
                        return;
                    }
                    result = op1 / op2;
                    break;
                default:
                    result = double.Parse(lblShow.Text);
                    break;
            }
        }

        //运算符号
        void mode (string mode)
        {
            if (Eq == true)
            {
                op1 = result;
                lblShow.Text = "" + op1;
            }
            else if (symbol != null)
            {
                op2 = double.Parse(lblShow.Text);
                Equal();
                op1 = result;
                lblShow.Text = Convert.ToString(op1);
            }
            else
            {
                op1 = double.Parse(lblShow.Text);
            }
            label.Text = op1 + mode;
            n = true;
            Eq = false;
            symbol = mode;
            labelbinaryshow();
        }
        //+
        private void btnAdd_Click(object sender, EventArgs e)
        {
            mode("+");
        }
        //-
        private void btnSub_Click(object sender, EventArgs e)
        {
            mode("-");
        }
        //*
        private void btnMul_Click(object sender, EventArgs e)
        {
            mode("*");
        }
        // /
        private void btnDiv_Click(object sender, EventArgs e)
        {
            mode("/");
        }
        //负
        private void btnbur_Click(object sender, EventArgs e)
        {
            if (Eq == true)
                btnC_Click(sender, e);
            if (lblShow.Text != "0" && lblShow.Text[0] != '-')
                lblShow.Text = "-" + lblShow.Text;
            else if (lblShow.Text != "0" && lblShow.Text[0] == '-')
                lblShow.Text = lblShow.Text.Replace("-", "");
            labelbinaryshow();
        }
        //点
        private void btnDot_Click(object sender, EventArgs e)
        {
            if (lblShow.Text.Contains(".") == false)
                lblShow.Text += ".";
            labelbinaryshow();
        }
        // =
        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (Eq == true)
                op1 = result;
            else
            {
                op2 = double.Parse(lblShow.Text);
                Eq = true;
            }
            if (symbol == null)
                label.Text = op2 + "=";
            else
                label.Text = op1 + symbol + op2 + "=";
            Equal();
            lblShow.Text = result.ToString();
            labelbinaryshow();
        }

        //主输入框复制
        private void lblShow_Click(object sender, EventArgs e)
        {
            showing = "已复制至剪贴板";
            Clipboard.SetDataObject(lblShow.Text);
            thread = new Thread(this.showsetmode);//多线程
            thread.IsBackground = true;
            thread.Start();
        }

        //退格键
        private void btnremove_Click(object sender, EventArgs e)
        {
            if (Eq == true)
            {
                btnC_Click(sender, e);
                Eq = false;
            }
            if (lblShow.Text.Length > 1)
                lblShow.Text = lblShow.Text.Substring(0, lblShow.Text.Length - 1);
            else if (lblShow.Text.Length == 1)
                lblShow.Text = "0";
            labelbinaryshow();
        }

        //圆角参数    改变窗口时执行
        public void Type()
        {
            int p_1 = 24;
            double p_2 = 0.06;
            GraphicsPath oPath = new GraphicsPath();
            oPath.AddClosedCurve(new Point[] { new Point(0, this.Height / p_1), new Point(this.Width / p_1, 0), new Point(this.Width - this.Width / p_1, 0), new Point(this.Width, this.Height / p_1), new Point(this.Width, this.Height - this.Height / p_1), new Point(this.Width - this.Width / p_1, this.Height), new Point(this.Width / p_1, this.Height), new Point(0, this.Height - this.Height / p_1) }, (float)p_2);
            this.Region = new Region(oPath);
        }

        //小输入框复制
        private void label_Click(object sender, EventArgs e)
        {
            showing = "已复制至剪贴板";
            Clipboard.SetDataObject(label.Text);
            thread = new Thread(this.showsetmode);//多线程
            thread.IsBackground = true;
            thread.Start();
        }

        //x分之1运算
        private void butquarter_Click(object sender, EventArgs e)
        {
            if (Eq == true)
                label.Text = "1/(" + result + ")";
            else
                label.Text = "1/(" + lblShow.Text + ")";

            lblShow.Text = "" + 1 / double.Parse(lblShow.Text);
            labelbinaryshow();
        }

        //次方运算
        private void butsquare_Click(object sender, EventArgs e)
        {
            if (Eq == true)
                label.Text = "sqr(" + result + ")";
            else
                label.Text = "sqr(" + lblShow.Text + ")";

            lblShow.Text = "" + Math.Pow(double.Parse(lblShow.Text), 2);
            labelbinaryshow();
        }

        //平方根运算
        private void butradicalsign_Click(object sender, EventArgs e)
        {
            if (Eq == true)
                label.Text = "√(" + result + ")";
            else
                label.Text = "√(" + lblShow.Text + ")";

            lblShow.Text = "" + Math.Sqrt(double.Parse(lblShow.Text));
            labelbinaryshow();
        }

        //派运算
        private void btnPI_Click(object sender, EventArgs e)
        {
            lblShow.Text = "" + Math.PI;
            labelbinaryshow();
        }



        #region 设置
        //这个灭，这个亮，这个。。。不干了！！
        private void 浅ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //背景
            this.BackColor = Color.FromArgb(243, 243, 243);
            listbinary.BackColor = Color.FromArgb(243, 243, 243);
            reduce.BackColor = Color.FromArgb(243, 243, 243);
            stateshow.ForeColor = Color.FromArgb(243, 243, 243);
            contextMenuStrip.BackColor = Color.FromArgb(243, 243, 243);
            contextMenuStrip.ForeColor = Color.Black;

            //背景
            btnbur.BackColor = Color.White;
            btnDot.BackColor = Color.White;
            btn1.BackColor = Color.White;
            btn2.BackColor = Color.White;
            btn3.BackColor = Color.White;
            btn4.BackColor = Color.White;
            btn5.BackColor = Color.White;
            btn6.BackColor = Color.White;
            btn7.BackColor = Color.White;
            btn8.BackColor = Color.White;
            btn9.BackColor = Color.White;
            btn0.BackColor = Color.White;


            Color Whites = Color.FromArgb(249, 249, 249);
            btnC.BackColor = Whites;
            btnCE.BackColor = Whites;
            btnAdd.BackColor = Whites;
            btnSub.BackColor = Whites;
            btnMul.BackColor = Whites;
            btnDiv.BackColor = Whites;
            btnEqual.BackColor = Whites;
            butquarter.BackColor = Whites;
            butsquare.BackColor = Whites;
            butradicalsign.BackColor = Whites;
            btnPI.BackColor = Whites;
            btnremove.BackColor = Whites;

            //字体
            btnbur.ForeColor = Color.Black;
            btnDot.ForeColor = Color.Black;
            btn1.ForeColor = Color.Black;
            btn2.ForeColor = Color.Black;
            btn3.ForeColor = Color.Black;
            btn4.ForeColor = Color.Black;
            btn5.ForeColor = Color.Black;
            btn6.ForeColor = Color.Black;
            btn7.ForeColor = Color.Black;
            btn8.ForeColor = Color.Black;
            btn9.ForeColor = Color.Black;
            btn0.ForeColor = Color.Black;
            btnC.ForeColor = Color.Black;
            btnCE.ForeColor = Color.Black;
            btnAdd.ForeColor = Color.Black;
            btnSub.ForeColor = Color.Black;
            btnMul.ForeColor = Color.Black;
            btnDiv.ForeColor = Color.Black;
            btnEqual.ForeColor = Color.Black;
            butquarter.ForeColor = Color.Black;
            butsquare.ForeColor = Color.Black;
            butradicalsign.ForeColor = Color.Black;
            btnPI.ForeColor = Color.Black;
            btnremove.ForeColor = Color.Black;
            lblShow.ForeColor = Color.Black;
            label.ForeColor = Color.Black;
            listbinary.ForeColor = Color.Black;
            reduce.ForeColor = Color.Black;
            labelbinary1.ForeColor = Color.Black;
            labelbinary2.ForeColor = Color.Black;
            labelbinary3.ForeColor = Color.Black;
            labelbinary4.ForeColor = Color.Black;

            buttonclose.ForeColor = Color.Black;
            buttonminimize.ForeColor = Color.Black;
            titlelabel.ForeColor = Color.Black;
        }

        private void 深ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //背景
            this.BackColor = Color.FromArgb(32, 32, 32);
            listbinary.BackColor = Color.FromArgb(32, 32, 32);
            reduce.BackColor = Color.FromArgb(32, 32, 32);
            stateshow.ForeColor = Color.FromArgb(32, 32, 32);
            contextMenuStrip.BackColor = Color.FromArgb(32, 32, 32);
            contextMenuStrip.ForeColor = Color.White;


            //背景
            Color black = Color.FromArgb(59, 59, 59);
            btnbur.BackColor = black;
            btnDot.BackColor = black;
            btn1.BackColor = black;
            btn2.BackColor = black;
            btn3.BackColor = black;
            btn4.BackColor = black;
            btn5.BackColor = black;
            btn6.BackColor = black;
            btn7.BackColor = black;
            btn8.BackColor = black;
            btn9.BackColor = black;
            btn0.BackColor = black;


            Color blacks = Color.FromArgb(50, 50, 50);
            btnC.BackColor = blacks;
            btnCE.BackColor = blacks;
            btnAdd.BackColor = blacks;
            btnSub.BackColor = blacks;
            btnMul.BackColor = blacks;
            btnDiv.BackColor = blacks;
            btnEqual.BackColor = blacks;
            butquarter.BackColor = blacks;
            butsquare.BackColor = blacks;
            butradicalsign.BackColor = blacks;
            btnPI.BackColor = blacks;
            btnremove.BackColor = blacks;

            //字体
            btnbur.ForeColor = Color.White;
            btnDot.ForeColor = Color.White;
            btn1.ForeColor = Color.White;
            btn2.ForeColor = Color.White;
            btn3.ForeColor = Color.White;
            btn4.ForeColor = Color.White;
            btn5.ForeColor = Color.White;
            btn6.ForeColor = Color.White;
            btn7.ForeColor = Color.White;
            btn8.ForeColor = Color.White;
            btn9.ForeColor = Color.White;
            btn0.ForeColor = Color.White;
            btnC.ForeColor = Color.White;
            btnCE.ForeColor = Color.White;
            btnAdd.ForeColor = Color.White;
            btnSub.ForeColor = Color.White;
            btnMul.ForeColor = Color.White;
            btnDiv.ForeColor = Color.White;
            btnEqual.ForeColor = Color.White;
            butquarter.ForeColor = Color.White;
            butsquare.ForeColor = Color.White;
            butradicalsign.ForeColor = Color.White;
            btnPI.ForeColor = Color.White;
            btnremove.ForeColor = Color.White;
            lblShow.ForeColor = Color.White;
            label.ForeColor = Color.White;
            listbinary.ForeColor = Color.White;
            reduce.ForeColor = Color.White;
            labelbinary1.ForeColor = Color.White;
            labelbinary2.ForeColor = Color.White;
            labelbinary3.ForeColor = Color.White;
            labelbinary4.ForeColor = Color.White;

            buttonclose.ForeColor = Color.White;
            buttonminimize.ForeColor = Color.White;
            titlelabel.ForeColor = Color.White;

        }

        //窗口置顶设置
        private void 窗口置顶ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (topMost == false)
            {
                topMost = true;
                this.TopMost = true;
            }
            else
            {
                topMost = false;
                this.TopMost = false;
            }

            showing = "窗口置顶" + topMost;

            thread = new Thread(this.showsetmode);//多线程
            thread.IsBackground = true;
            thread.Start();
        }
        //屏幕常量设置
        private void 屏幕常量ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PreventSystemSleep == false)
            {
                PreventSystemSleep = true;
                SystemSleep.PreventForCurrentThread();
            }
            else
            {
                PreventSystemSleep = false;
                SystemSleep.RestoreForCurrentThread();
            }

            showing = "屏幕常量" + PreventSystemSleep;

            thread = new Thread(this.showsetmode);//多线程
            thread.IsBackground = true;
            thread.Start();
        }
        //屏幕常量class
        public static class SystemSleep
        {
            [DllImport("kernel32")]
            private static extern ExecutionState SetThreadExecutionState(ExecutionState esFlags);
            [Flags]
            private enum ExecutionState : uint
            {
                SystemRequired = 0x01,

                DisplayRequired = 0x02,

                [Obsolete("This value is not supported.")]
                UserPresent = 0x04,
                AwaymodeRequired = 0x40,
                Continuous = 0x80000000,
            }

            public static void PreventForCurrentThread(bool keepDisplayOn = true)
            {
                SetThreadExecutionState(keepDisplayOn
                    ? ExecutionState.Continuous | ExecutionState.SystemRequired | ExecutionState.DisplayRequired
                    : ExecutionState.Continuous | ExecutionState.SystemRequired);
            }
            public static void RestoreForCurrentThread()
            {
                SetThreadExecutionState(ExecutionState.Continuous);
            }
            public static void ResetIdle(bool keepDisplayOn = true)
            {
                SetThreadExecutionState(keepDisplayOn
                    ? ExecutionState.SystemRequired | ExecutionState.DisplayRequired
                    : ExecutionState.SystemRequired);
            }
        }

        //显示设置
        string showing;
        //突然出现，突然消失
        private void showsetmode()
        {
            int color = stateshow.ForeColor.B;

            stateshow.Text = showing;
            if (this.BackColor.B < 100)
            {
                stateshow.ForeColor = Color.FromArgb(32, 32, 32);
                for (int i = color; i < 255; i += 5)
                {
                    stateshow.ForeColor = Color.FromArgb(i, i, i);
                    Thread.Sleep(1);
                }
                Thread.Sleep(800);
                for (int i = 255; i > color; i -= 5)
                {
                    stateshow.ForeColor = Color.FromArgb(i, i, i);
                    Thread.Sleep(1);
                }
                stateshow.ForeColor = Color.FromArgb(32, 32, 32);
            }
            else
            {
                stateshow.ForeColor = Color.FromArgb(243, 243, 243);
                for (int i = color; i > 0; i -= 5)
                {
                    stateshow.ForeColor = Color.FromArgb(i, i, i);
                    Thread.Sleep(1);
                }
                Thread.Sleep(800);
                for (int i = 0; i < color; i += 5)
                {
                    stateshow.ForeColor = Color.FromArgb(i, i, i);
                    Thread.Sleep(1);
                }
                stateshow.ForeColor = Color.FromArgb(243, 243, 243);
            }
        }
        #endregion

        #region 显示进制   

        private void 显示进制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonclose.Location = new Point(382, -2);
            buttonminimize.Location = new Point(359, -2);
            Width = 398;
            reduce.Visible = true;
            listbinary.Visible = true;

            labelbinary1.Visible = true;
            labelbinary2.Visible = true;
            labelbinary3.Visible = true;
            labelbinary4.Visible = true;
            Type();
        }

        //隐藏进制
        private void reduce_Click(object sender, EventArgs e)
        {
            buttonclose.Location = new Point(241, -2);
            buttonminimize.Location = new Point(218, -2);
            this.Width = 255;
            reduce.Visible = false;
            listbinary.Visible = false;
            labelbinary1.Visible = false;
            Type();
        }

        
        void binary(System.Windows.Forms.Label a)
        {
            showing = "已复制至剪贴板";
            Clipboard.SetDataObject(a.Text);
            thread = new Thread(this.showsetmode);//多线程
            thread.IsBackground = true;
            thread.Start();

            labelbinary1.BorderStyle = BorderStyle.None;
            labelbinary2.BorderStyle = BorderStyle.None;
            labelbinary3.BorderStyle = BorderStyle.None;
            labelbinary4.BorderStyle = BorderStyle.None;

            a.BorderStyle = BorderStyle.FixedSingle;
        }

        //各回各家各找各妈
        private void labelbinary1_Click(object sender, EventArgs e)
        {
            binary(labelbinary1);
        }
        private void labelbinary2_Click(object sender, EventArgs e)
        {
            binary(labelbinary2);
        }
        private void labelbinary3_Click(object sender, EventArgs e)
        {
            binary(labelbinary3);
        }
        private void labelbinary4_Click(object sender, EventArgs e)
        {
            binary(labelbinary4);
        }

        
        public void labelbinaryshow()
        {
            labelbinary1.Text = Convert.ToString((int)double.Parse(lblShow.Text), 16);//10 转 16 进制
            labelbinary2.Text = "" + (int)double.Parse(lblShow.Text);
            labelbinary3.Text = Convert.ToString((int)double.Parse(lblShow.Text), 8);//10 转 8 进制
            labelbinary4.Text = Convert.ToString((int)double.Parse(lblShow.Text), 2);//10 转 2 进制
        }

        #endregion
        #region 键盘
        //我徒弟呢！？              我不到啊？！
        private void Press(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '+':
                    btnAdd_Click(sender, e);
                    break;
                case '-':
                    btnSub_Click(sender, e);
                    break;
                case '*':
                    btnMul_Click(sender, e);
                    break;
                case '\\':
                    btnDiv_Click(sender, e);
                    break;
                case '/':
                    btnDiv_Click(sender, e);
                    break;
                case '=':
                    btnEqual_Click(sender, e);
                    break;
                case '1':
                    btn1_Click(sender, e);
                    break;
                case '2':
                    btn2_Click(sender, e);
                    break;
                case '3':
                    btn3_Click(sender, e);
                    break;
                case '4':
                    btn4_Click(sender, e);
                    break;
                case '5':
                    btn5_Click(sender, e);
                    break;
                case '6':
                    btn6_Click(sender, e);
                    break;
                case '7':
                    btn7_Click(sender, e);
                    break;
                case '8':
                    btn8_Click(sender, e);
                    break;
                case '9':
                    btn9_Click(sender, e);
                    break;
                case '0':
                    btn0_Click(sender, e);
                    break;
                case 'r':
                    butquarter_Click(sender, e);
                    break;
                case 'q':
                    butsquare_Click(sender, e);
                    break;
                case 'c':
                    btnC_Click(sender, e);
                    break;
                case 'e':
                    btnCE_Click(sender, e);
                    break;
                case '.':
                    btnDot_Click(sender, e);
                    break;
                case '\b':
                    btnremove_Click(sender, e);
                    break;
                case 'p':
                    btnPI_Click(sender, e);
                    break;
                default:
                    break;
            }
            labelbinaryshow();
        }
        #endregion

        #region 标题栏
        //关闭
        private void buttonclose_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
            System.Environment.Exit(0);
        }
        //最小化
        private void buttonminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }




        private Point mouseLocation;//表示鼠标对于窗口左上角的坐标的负数
        private bool moveing;//标识鼠标是否按下
        private void downmouse(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseLocation = new Point(-e.X, -e.Y);
                //表示鼠标当前位置相对于窗口左上角的坐标，
                //并取负数,这里的e是参数，
                //可以获取鼠标位置
                moveing = true;//标识鼠标已经按下
            }
        }
        private void movemouse(object sender, MouseEventArgs e)
        {
            if (moveing)
            {
                Point newMouseLocation = MousePosition;
                //获取鼠标当前位置
                newMouseLocation.Offset(mouseLocation.X, mouseLocation.Y);
                //用鼠标当前位置加上鼠标相较于窗体左上角的
                //坐标的负数，也就获取到了新的窗体左上角位置
                Location = newMouseLocation;//设置新的窗体左上角位置
            }
        }
        private void upmouse(object sender, MouseEventArgs e)
        {
            if (moveing)
            {
                moveing = false;//鼠标已抬起，标识为false
            }
        }


        private void titlelabel_Click(object sender, EventArgs e)
        {
            contextMenuStrip.Show(MousePosition.X, MousePosition.Y);
        }


        private void Down(object sender, KeyEventArgs e)
        {
            string label = lblShow.Text;
            if ((Control.ModifierKeys & Keys.Control) == Keys.Control && e.KeyCode == Keys.V)//ctrl v
            {
                try
                {
                    lblShow.Text = (String)Clipboard.GetDataObject().GetData(DataFormats.Text);//赋值剪贴板
                    labelbinaryshow();
                }
                catch
                {
                    //这么玩是吧
                    lblShow.Text = label;
                    labelbinaryshow();

                    showing = "无效输入";
                    thread = new Thread(this.showsetmode);//多线程
                    thread.IsBackground = true;
                    thread.Start();
                }
            }
        }
        #endregion
    }
}
