using System.Drawing;

namespace calculator
{
    partial class calculatorload
    {
        //必需的设计器变量
        private System.ComponentModel.IContainer components = null;

        //清理所有正在使用的资源
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        //设计器支持所需的方法 - 不要修改
        //使用代码编辑器修改此方法的内容
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calculatorload));
            this.lblShow = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnbur = new System.Windows.Forms.Button();
            this.butradicalsign = new System.Windows.Forms.Button();
            this.butsquare = new System.Windows.Forms.Button();
            this.butquarter = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnPI = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.亮ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.暗ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.进制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.窗口置顶ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.屏幕常量ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listbinary = new System.Windows.Forms.ListBox();
            this.reduce = new System.Windows.Forms.Button();
            this.labelbinary1 = new System.Windows.Forms.Label();
            this.buttonclose = new System.Windows.Forms.Button();
            this.buttonminimize = new System.Windows.Forms.Button();
            this.movewindowpanel = new System.Windows.Forms.Panel();
            this.titlelabel = new System.Windows.Forms.Label();
            this.stateshow = new System.Windows.Forms.Label();
            this.labelbinary2 = new System.Windows.Forms.Label();
            this.labelbinary3 = new System.Windows.Forms.Label();
            this.labelbinary4 = new System.Windows.Forms.Label();
            this.contextMenuStrip.SuspendLayout();
            this.movewindowpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblShow
            // 
            this.lblShow.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblShow.Font = new System.Drawing.Font("方正粗黑宋简体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblShow.ForeColor = System.Drawing.Color.White;
            this.lblShow.Location = new System.Drawing.Point(12, 65);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(318, 40);
            this.lblShow.TabIndex = 0;
            this.lblShow.Text = "0";
            this.lblShow.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblShow.Click += new System.EventHandler(this.lblShow_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("方正粗黑宋简体", 12F);
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(12, 304);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 45);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("方正粗黑宋简体", 12F);
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(92, 304);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 45);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("方正粗黑宋简体", 12F);
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.Location = new System.Drawing.Point(172, 304);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 45);
            this.btn3.TabIndex = 1;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("方正粗黑宋简体", 12F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(252, 304);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 45);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("方正粗黑宋简体", 12F);
            this.btn4.ForeColor = System.Drawing.Color.White;
            this.btn4.Location = new System.Drawing.Point(12, 255);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 45);
            this.btn4.TabIndex = 1;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("方正粗黑宋简体", 12F);
            this.btn5.ForeColor = System.Drawing.Color.White;
            this.btn5.Location = new System.Drawing.Point(92, 255);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 45);
            this.btn5.TabIndex = 1;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("方正粗黑宋简体", 12F);
            this.btn6.ForeColor = System.Drawing.Color.White;
            this.btn6.Location = new System.Drawing.Point(172, 255);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 45);
            this.btn6.TabIndex = 1;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSub.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSub.FlatAppearance.BorderSize = 0;
            this.btnSub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnSub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSub.Font = new System.Drawing.Font("方正粗黑宋简体", 12F);
            this.btnSub.ForeColor = System.Drawing.Color.White;
            this.btnSub.Location = new System.Drawing.Point(252, 255);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(75, 45);
            this.btnSub.TabIndex = 1;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("方正粗黑宋简体", 12F);
            this.btn7.ForeColor = System.Drawing.Color.White;
            this.btn7.Location = new System.Drawing.Point(12, 206);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 45);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("方正粗黑宋简体", 12F);
            this.btn8.ForeColor = System.Drawing.Color.White;
            this.btn8.Location = new System.Drawing.Point(92, 206);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 45);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("方正粗黑宋简体", 12F);
            this.btn9.ForeColor = System.Drawing.Color.White;
            this.btn9.Location = new System.Drawing.Point(172, 206);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 45);
            this.btn9.TabIndex = 1;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnMul
            // 
            this.btnMul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMul.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMul.FlatAppearance.BorderSize = 0;
            this.btnMul.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnMul.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnMul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMul.Font = new System.Drawing.Font("方正粗黑宋简体", 12F);
            this.btnMul.ForeColor = System.Drawing.Color.White;
            this.btnMul.Location = new System.Drawing.Point(252, 206);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(75, 45);
            this.btnMul.TabIndex = 1;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = false;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btnDot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDot.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDot.FlatAppearance.BorderSize = 0;
            this.btnDot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnDot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDot.Font = new System.Drawing.Font("方正粗黑宋简体", 12F);
            this.btnDot.ForeColor = System.Drawing.Color.White;
            this.btnDot.Location = new System.Drawing.Point(172, 353);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(75, 45);
            this.btnDot.TabIndex = 1;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn0.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("方正粗黑宋简体", 12F);
            this.btn0.ForeColor = System.Drawing.Color.White;
            this.btn0.Location = new System.Drawing.Point(92, 353);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 45);
            this.btn0.TabIndex = 1;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDiv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDiv.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDiv.FlatAppearance.BorderSize = 0;
            this.btnDiv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnDiv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiv.Font = new System.Drawing.Font("方正粗黑宋简体", 12F);
            this.btnDiv.ForeColor = System.Drawing.Color.White;
            this.btnDiv.Location = new System.Drawing.Point(252, 157);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(75, 45);
            this.btnDiv.TabIndex = 1;
            this.btnDiv.Text = "÷";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnEqual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEqual.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEqual.FlatAppearance.BorderSize = 0;
            this.btnEqual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnEqual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqual.Font = new System.Drawing.Font("方正粗黑宋简体", 12F);
            this.btnEqual.ForeColor = System.Drawing.Color.White;
            this.btnEqual.Location = new System.Drawing.Point(252, 353);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(75, 45);
            this.btnEqual.TabIndex = 1;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnbur
            // 
            this.btnbur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btnbur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbur.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnbur.FlatAppearance.BorderSize = 0;
            this.btnbur.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnbur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnbur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbur.Font = new System.Drawing.Font("方正粗黑宋简体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnbur.ForeColor = System.Drawing.Color.White;
            this.btnbur.Location = new System.Drawing.Point(12, 353);
            this.btnbur.Name = "btnbur";
            this.btnbur.Size = new System.Drawing.Size(75, 45);
            this.btnbur.TabIndex = 2;
            this.btnbur.Text = "+/-";
            this.btnbur.UseVisualStyleBackColor = false;
            this.btnbur.Click += new System.EventHandler(this.btnbur_Click);
            // 
            // butradicalsign
            // 
            this.butradicalsign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.butradicalsign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butradicalsign.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.butradicalsign.FlatAppearance.BorderSize = 0;
            this.butradicalsign.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.butradicalsign.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.butradicalsign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butradicalsign.Font = new System.Drawing.Font("方正粗黑宋简体", 12F);
            this.butradicalsign.ForeColor = System.Drawing.Color.White;
            this.butradicalsign.Location = new System.Drawing.Point(172, 157);
            this.butradicalsign.Name = "butradicalsign";
            this.butradicalsign.Size = new System.Drawing.Size(75, 45);
            this.butradicalsign.TabIndex = 6;
            this.butradicalsign.Text = "²√x";
            this.butradicalsign.UseVisualStyleBackColor = false;
            this.butradicalsign.Click += new System.EventHandler(this.butradicalsign_Click);
            // 
            // butsquare
            // 
            this.butsquare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.butsquare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butsquare.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.butsquare.FlatAppearance.BorderSize = 0;
            this.butsquare.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.butsquare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.butsquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butsquare.Font = new System.Drawing.Font("方正粗黑宋简体", 12F);
            this.butsquare.ForeColor = System.Drawing.Color.White;
            this.butsquare.Location = new System.Drawing.Point(92, 157);
            this.butsquare.Name = "butsquare";
            this.butsquare.Size = new System.Drawing.Size(75, 45);
            this.butsquare.TabIndex = 7;
            this.butsquare.Text = "x²";
            this.butsquare.UseVisualStyleBackColor = false;
            this.butsquare.Click += new System.EventHandler(this.butsquare_Click);
            // 
            // butquarter
            // 
            this.butquarter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.butquarter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butquarter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.butquarter.FlatAppearance.BorderSize = 0;
            this.butquarter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.butquarter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.butquarter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butquarter.Font = new System.Drawing.Font("方正粗黑宋简体", 12F);
            this.butquarter.ForeColor = System.Drawing.Color.White;
            this.butquarter.Location = new System.Drawing.Point(12, 157);
            this.butquarter.Name = "butquarter";
            this.butquarter.Size = new System.Drawing.Size(75, 45);
            this.butquarter.TabIndex = 8;
            this.butquarter.Text = "⅟x";
            this.butquarter.UseVisualStyleBackColor = false;
            this.butquarter.Click += new System.EventHandler(this.butquarter_Click);
            // 
            // btnremove
            // 
            this.btnremove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnremove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnremove.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnremove.FlatAppearance.BorderSize = 0;
            this.btnremove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnremove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnremove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnremove.Font = new System.Drawing.Font("方正粗黑宋简体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnremove.ForeColor = System.Drawing.Color.White;
            this.btnremove.Location = new System.Drawing.Point(252, 108);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(75, 45);
            this.btnremove.TabIndex = 9;
            this.btnremove.Text = "⩤";
            this.btnremove.UseVisualStyleBackColor = false;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnC.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnC.FlatAppearance.BorderSize = 0;
            this.btnC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Font = new System.Drawing.Font("方正粗黑宋简体", 12F);
            this.btnC.ForeColor = System.Drawing.Color.White;
            this.btnC.Location = new System.Drawing.Point(172, 108);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(75, 45);
            this.btnC.TabIndex = 10;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCE.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCE.FlatAppearance.BorderSize = 0;
            this.btnCE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnCE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCE.Font = new System.Drawing.Font("方正粗黑宋简体", 12F);
            this.btnCE.ForeColor = System.Drawing.Color.White;
            this.btnCE.Location = new System.Drawing.Point(92, 108);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(75, 45);
            this.btnCE.TabIndex = 11;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnPI
            // 
            this.btnPI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPI.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPI.FlatAppearance.BorderSize = 0;
            this.btnPI.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnPI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnPI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPI.Font = new System.Drawing.Font("方正粗黑宋简体", 12F);
            this.btnPI.ForeColor = System.Drawing.Color.White;
            this.btnPI.Location = new System.Drawing.Point(12, 108);
            this.btnPI.Name = "btnPI";
            this.btnPI.Size = new System.Drawing.Size(75, 45);
            this.btnPI.TabIndex = 12;
            this.btnPI.Text = "π";
            this.btnPI.UseVisualStyleBackColor = false;
            this.btnPI.Click += new System.EventHandler(this.btnPI_Click);
            // 
            // label
            // 
            this.label.Cursor = System.Windows.Forms.Cursors.Default;
            this.label.Font = new System.Drawing.Font("方正粗黑宋简体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(12, 39);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(318, 26);
            this.label.TabIndex = 13;
            this.label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.contextMenuStrip.ForeColor = System.Drawing.Color.White;
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置ToolStripMenuItem,
            this.进制ToolStripMenuItem,
            this.窗口置顶ToolStripMenuItem,
            this.屏幕常量ToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip.ShowImageMargin = false;
            this.contextMenuStrip.Size = new System.Drawing.Size(114, 100);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.亮ToolStripMenuItem,
            this.暗ToolStripMenuItem});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 亮ToolStripMenuItem
            // 
            this.亮ToolStripMenuItem.Name = "亮ToolStripMenuItem";
            this.亮ToolStripMenuItem.Size = new System.Drawing.Size(107, 26);
            this.亮ToolStripMenuItem.Text = "浅";
            this.亮ToolStripMenuItem.Click += new System.EventHandler(this.浅ToolStripMenuItem_Click);
            // 
            // 暗ToolStripMenuItem
            // 
            this.暗ToolStripMenuItem.Name = "暗ToolStripMenuItem";
            this.暗ToolStripMenuItem.Size = new System.Drawing.Size(107, 26);
            this.暗ToolStripMenuItem.Text = "深";
            this.暗ToolStripMenuItem.Click += new System.EventHandler(this.深ToolStripMenuItem_Click);
            // 
            // 进制ToolStripMenuItem
            // 
            this.进制ToolStripMenuItem.Name = "进制ToolStripMenuItem";
            this.进制ToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.进制ToolStripMenuItem.Text = "显示进制";
            this.进制ToolStripMenuItem.Click += new System.EventHandler(this.显示进制ToolStripMenuItem_Click);
            // 
            // 窗口置顶ToolStripMenuItem
            // 
            this.窗口置顶ToolStripMenuItem.Name = "窗口置顶ToolStripMenuItem";
            this.窗口置顶ToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.窗口置顶ToolStripMenuItem.Text = "窗口置顶";
            this.窗口置顶ToolStripMenuItem.Click += new System.EventHandler(this.窗口置顶ToolStripMenuItem_Click);
            // 
            // 屏幕常量ToolStripMenuItem
            // 
            this.屏幕常量ToolStripMenuItem.Name = "屏幕常量ToolStripMenuItem";
            this.屏幕常量ToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.屏幕常量ToolStripMenuItem.Text = "屏幕常量";
            this.屏幕常量ToolStripMenuItem.Click += new System.EventHandler(this.屏幕常量ToolStripMenuItem_Click);
            // 
            // listbinary
            // 
            this.listbinary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.listbinary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listbinary.Font = new System.Drawing.Font("方正粗黑宋简体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listbinary.ForeColor = System.Drawing.Color.White;
            this.listbinary.FormattingEnabled = true;
            this.listbinary.ItemHeight = 18;
            this.listbinary.Items.AddRange(new object[] {
            "HEX",
            "DEC",
            "OTC",
            "BIN"});
            this.listbinary.Location = new System.Drawing.Point(347, 55);
            this.listbinary.Name = "listbinary";
            this.listbinary.Size = new System.Drawing.Size(40, 90);
            this.listbinary.TabIndex = 17;
            // 
            // reduce
            // 
            this.reduce.ContextMenuStrip = this.contextMenuStrip;
            this.reduce.FlatAppearance.BorderSize = 0;
            this.reduce.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.reduce.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.reduce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reduce.Font = new System.Drawing.Font("方正粗黑宋简体", 10.8F, System.Drawing.FontStyle.Bold);
            this.reduce.ForeColor = System.Drawing.Color.White;
            this.reduce.Location = new System.Drawing.Point(347, 20);
            this.reduce.Name = "reduce";
            this.reduce.Size = new System.Drawing.Size(28, 33);
            this.reduce.TabIndex = 18;
            this.reduce.Text = "-";
            this.reduce.UseVisualStyleBackColor = true;
            this.reduce.Click += new System.EventHandler(this.reduce_Click);
            // 
            // labelbinary1
            // 
            this.labelbinary1.AutoSize = true;
            this.labelbinary1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelbinary1.Font = new System.Drawing.Font("方正粗黑宋简体", 9F);
            this.labelbinary1.ForeColor = System.Drawing.Color.White;
            this.labelbinary1.Location = new System.Drawing.Point(392, 53);
            this.labelbinary1.Name = "labelbinary1";
            this.labelbinary1.Size = new System.Drawing.Size(17, 18);
            this.labelbinary1.TabIndex = 19;
            this.labelbinary1.Text = "0";
            this.labelbinary1.Click += new System.EventHandler(this.labelbinary1_Click);
            // 
            // buttonclose
            // 
            this.buttonclose.ContextMenuStrip = this.contextMenuStrip;
            this.buttonclose.FlatAppearance.BorderSize = 0;
            this.buttonclose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.buttonclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.buttonclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonclose.Font = new System.Drawing.Font("方正粗黑宋简体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonclose.ForeColor = System.Drawing.Color.White;
            this.buttonclose.Location = new System.Drawing.Point(320, -1);
            this.buttonclose.Name = "buttonclose";
            this.buttonclose.Size = new System.Drawing.Size(28, 33);
            this.buttonclose.TabIndex = 20;
            this.buttonclose.Text = "✕";
            this.buttonclose.UseVisualStyleBackColor = true;
            this.buttonclose.Click += new System.EventHandler(this.buttonclose_Click);
            // 
            // buttonminimize
            // 
            this.buttonminimize.ContextMenuStrip = this.contextMenuStrip;
            this.buttonminimize.FlatAppearance.BorderSize = 0;
            this.buttonminimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.buttonminimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.buttonminimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonminimize.Font = new System.Drawing.Font("方正粗黑宋简体", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonminimize.ForeColor = System.Drawing.Color.White;
            this.buttonminimize.Location = new System.Drawing.Point(290, -2);
            this.buttonminimize.Name = "buttonminimize";
            this.buttonminimize.Size = new System.Drawing.Size(28, 33);
            this.buttonminimize.TabIndex = 21;
            this.buttonminimize.Text = "-";
            this.buttonminimize.UseVisualStyleBackColor = true;
            this.buttonminimize.Click += new System.EventHandler(this.buttonminimize_Click);
            // 
            // movewindowpanel
            // 
            this.movewindowpanel.Controls.Add(this.titlelabel);
            this.movewindowpanel.Controls.Add(this.buttonclose);
            this.movewindowpanel.Controls.Add(this.buttonminimize);
            this.movewindowpanel.Location = new System.Drawing.Point(-10, 0);
            this.movewindowpanel.Name = "movewindowpanel";
            this.movewindowpanel.Size = new System.Drawing.Size(553, 33);
            this.movewindowpanel.TabIndex = 22;
            this.movewindowpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.downmouse);
            this.movewindowpanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.movemouse);
            this.movewindowpanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.upmouse);
            // 
            // titlelabel
            // 
            this.titlelabel.AutoSize = true;
            this.titlelabel.Font = new System.Drawing.Font("方正粗黑宋简体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.titlelabel.ForeColor = System.Drawing.Color.White;
            this.titlelabel.Location = new System.Drawing.Point(16, 3);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(98, 22);
            this.titlelabel.TabIndex = 22;
            this.titlelabel.Text = "calculator";
            this.titlelabel.Click += new System.EventHandler(this.titlelabel_Click);
            // 
            // stateshow
            // 
            this.stateshow.AutoSize = true;
            this.stateshow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.stateshow.Location = new System.Drawing.Point(3, 25);
            this.stateshow.Name = "stateshow";
            this.stateshow.Size = new System.Drawing.Size(55, 15);
            this.stateshow.TabIndex = 23;
            this.stateshow.Text = "label1";
            this.stateshow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelbinary2
            // 
            this.labelbinary2.AutoSize = true;
            this.labelbinary2.Font = new System.Drawing.Font("方正粗黑宋简体", 9F);
            this.labelbinary2.ForeColor = System.Drawing.Color.White;
            this.labelbinary2.Location = new System.Drawing.Point(393, 73);
            this.labelbinary2.Name = "labelbinary2";
            this.labelbinary2.Size = new System.Drawing.Size(17, 18);
            this.labelbinary2.TabIndex = 25;
            this.labelbinary2.Text = "0";
            this.labelbinary2.Click += new System.EventHandler(this.labelbinary2_Click);
            // 
            // labelbinary3
            // 
            this.labelbinary3.AutoSize = true;
            this.labelbinary3.Font = new System.Drawing.Font("方正粗黑宋简体", 9F);
            this.labelbinary3.ForeColor = System.Drawing.Color.White;
            this.labelbinary3.Location = new System.Drawing.Point(393, 91);
            this.labelbinary3.Name = "labelbinary3";
            this.labelbinary3.Size = new System.Drawing.Size(17, 18);
            this.labelbinary3.TabIndex = 26;
            this.labelbinary3.Text = "0";
            this.labelbinary3.Click += new System.EventHandler(this.labelbinary3_Click);
            // 
            // labelbinary4
            // 
            this.labelbinary4.AutoSize = true;
            this.labelbinary4.Font = new System.Drawing.Font("方正粗黑宋简体", 9F);
            this.labelbinary4.ForeColor = System.Drawing.Color.White;
            this.labelbinary4.Location = new System.Drawing.Point(393, 108);
            this.labelbinary4.Name = "labelbinary4";
            this.labelbinary4.Size = new System.Drawing.Size(17, 18);
            this.labelbinary4.TabIndex = 27;
            this.labelbinary4.Text = "0";
            this.labelbinary4.Click += new System.EventHandler(this.labelbinary4_Click);
            // 
            // calculatorload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(340, 410);
            this.Controls.Add(this.labelbinary4);
            this.Controls.Add(this.labelbinary3);
            this.Controls.Add(this.labelbinary2);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.stateshow);
            this.Controls.Add(this.movewindowpanel);
            this.Controls.Add(this.labelbinary1);
            this.Controls.Add(this.reduce);
            this.Controls.Add(this.listbinary);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnPI);
            this.Controls.Add(this.butradicalsign);
            this.Controls.Add(this.butsquare);
            this.Controls.Add(this.butquarter);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.btnbur);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "calculatorload";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Down);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Press);
            this.contextMenuStrip.ResumeLayout(false);
            this.movewindowpanel.ResumeLayout(false);
            this.movewindowpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnbur;
        private System.Windows.Forms.Button butradicalsign;
        private System.Windows.Forms.Button butsquare;
        private System.Windows.Forms.Button butquarter;
        private System.Windows.Forms.Button btnPI;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 亮ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 暗ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 进制ToolStripMenuItem;
        private System.Windows.Forms.ListBox listbinary;
        private System.Windows.Forms.Button reduce;
        private System.Windows.Forms.Button buttonclose;
        private System.Windows.Forms.Button buttonminimize;
        private System.Windows.Forms.Panel movewindowpanel;
        private System.Windows.Forms.Label titlelabel;
        private System.Windows.Forms.ToolStripMenuItem 窗口置顶ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 屏幕常量ToolStripMenuItem;
        private System.Windows.Forms.Label stateshow;
        private System.Windows.Forms.Label labelbinary1;
        private System.Windows.Forms.Label labelbinary2;
        private System.Windows.Forms.Label labelbinary3;
        private System.Windows.Forms.Label labelbinary4;
    }
}

