namespace MathQuiz
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimer = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelLeftPlus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelRightPlus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.labelLeftMinus = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelRightMinus = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.difference = new System.Windows.Forms.NumericUpDown();
            this.labelLeftTimes = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelRightTimes = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.product = new System.Windows.Forms.NumericUpDown();
            this.labelLeftDivided = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.labelRightDivided = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.quotient = new System.Windows.Forms.NumericUpDown();
            this.buttonStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 318);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 42);
            this.panel1.TabIndex = 4;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 10);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(591, 20);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://docs.microsoft.com/pt-br/visualstudio/ide/tutorial-2-create-a-timed-math-" +
    "quiz";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time Left";
            // 
            // txtTimer
            // 
            this.txtTimer.Location = new System.Drawing.Point(273, 12);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.ReadOnly = true;
            this.txtTimer.Size = new System.Drawing.Size(150, 26);
            this.txtTimer.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.labelLeftPlus, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelRightPlus, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.sum, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelLeftMinus, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelRightMinus, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.difference, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelLeftTimes, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label11, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelRightTimes, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label13, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.product, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelLeftDivided, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label15, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelRightDivided, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label17, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.quotient, 4, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(107, 80);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 150);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // labelLeftPlus
            // 
            this.labelLeftPlus.AutoSize = true;
            this.labelLeftPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLeftPlus.Location = new System.Drawing.Point(3, 0);
            this.labelLeftPlus.Name = "labelLeftPlus";
            this.labelLeftPlus.Size = new System.Drawing.Size(94, 37);
            this.labelLeftPlus.TabIndex = 0;
            this.labelLeftPlus.Text = "?";
            this.labelLeftPlus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(103, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "+";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRightPlus
            // 
            this.labelRightPlus.AutoSize = true;
            this.labelRightPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRightPlus.Location = new System.Drawing.Point(143, 0);
            this.labelRightPlus.Name = "labelRightPlus";
            this.labelRightPlus.Size = new System.Drawing.Size(94, 37);
            this.labelRightPlus.TabIndex = 2;
            this.labelRightPlus.Text = "?";
            this.labelRightPlus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(243, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 37);
            this.label5.TabIndex = 3;
            this.label5.Text = "=";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(283, 3);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(114, 26);
            this.sum.TabIndex = 4;
            this.sum.Enter += new System.EventHandler(this.Answer_Enter);
            // 
            // labelLeftMinus
            // 
            this.labelLeftMinus.AutoSize = true;
            this.labelLeftMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLeftMinus.Location = new System.Drawing.Point(3, 37);
            this.labelLeftMinus.Name = "labelLeftMinus";
            this.labelLeftMinus.Size = new System.Drawing.Size(94, 37);
            this.labelLeftMinus.TabIndex = 5;
            this.labelLeftMinus.Text = "?";
            this.labelLeftMinus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(103, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 37);
            this.label7.TabIndex = 6;
            this.label7.Text = "-";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRightMinus
            // 
            this.labelRightMinus.AutoSize = true;
            this.labelRightMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRightMinus.Location = new System.Drawing.Point(143, 37);
            this.labelRightMinus.Name = "labelRightMinus";
            this.labelRightMinus.Size = new System.Drawing.Size(94, 37);
            this.labelRightMinus.TabIndex = 7;
            this.labelRightMinus.Text = "?";
            this.labelRightMinus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(243, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 37);
            this.label9.TabIndex = 8;
            this.label9.Text = "=";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // difference
            // 
            this.difference.Location = new System.Drawing.Point(283, 40);
            this.difference.Name = "difference";
            this.difference.Size = new System.Drawing.Size(114, 26);
            this.difference.TabIndex = 9;
            this.difference.Enter += new System.EventHandler(this.Answer_Enter);
            // 
            // labelLeftTimes
            // 
            this.labelLeftTimes.AutoSize = true;
            this.labelLeftTimes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLeftTimes.Location = new System.Drawing.Point(3, 74);
            this.labelLeftTimes.Name = "labelLeftTimes";
            this.labelLeftTimes.Size = new System.Drawing.Size(94, 37);
            this.labelLeftTimes.TabIndex = 10;
            this.labelLeftTimes.Text = "?";
            this.labelLeftTimes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(103, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 37);
            this.label11.TabIndex = 11;
            this.label11.Text = "x";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRightTimes
            // 
            this.labelRightTimes.AutoSize = true;
            this.labelRightTimes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRightTimes.Location = new System.Drawing.Point(143, 74);
            this.labelRightTimes.Name = "labelRightTimes";
            this.labelRightTimes.Size = new System.Drawing.Size(94, 37);
            this.labelRightTimes.TabIndex = 12;
            this.labelRightTimes.Text = "?";
            this.labelRightTimes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(243, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 37);
            this.label13.TabIndex = 13;
            this.label13.Text = "=";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // product
            // 
            this.product.Location = new System.Drawing.Point(283, 77);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(114, 26);
            this.product.TabIndex = 14;
            this.product.Enter += new System.EventHandler(this.Answer_Enter);
            // 
            // labelLeftDivided
            // 
            this.labelLeftDivided.AutoSize = true;
            this.labelLeftDivided.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLeftDivided.Location = new System.Drawing.Point(3, 111);
            this.labelLeftDivided.Name = "labelLeftDivided";
            this.labelLeftDivided.Size = new System.Drawing.Size(94, 39);
            this.labelLeftDivided.TabIndex = 15;
            this.labelLeftDivided.Text = "?";
            this.labelLeftDivided.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(103, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 39);
            this.label15.TabIndex = 16;
            this.label15.Text = "÷";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRightDivided
            // 
            this.labelRightDivided.AutoSize = true;
            this.labelRightDivided.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRightDivided.Location = new System.Drawing.Point(143, 111);
            this.labelRightDivided.Name = "labelRightDivided";
            this.labelRightDivided.Size = new System.Drawing.Size(94, 39);
            this.labelRightDivided.TabIndex = 17;
            this.labelRightDivided.Text = "?";
            this.labelRightDivided.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Location = new System.Drawing.Point(243, 111);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 39);
            this.label17.TabIndex = 18;
            this.label17.Text = "=";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quotient
            // 
            this.quotient.Location = new System.Drawing.Point(283, 114);
            this.quotient.Name = "quotient";
            this.quotient.Size = new System.Drawing.Size(114, 26);
            this.quotient.TabIndex = 19;
            this.quotient.Enter += new System.EventHandler(this.Answer_Enter);
            // 
            // buttonStart
            // 
            this.buttonStart.AutoSize = true;
            this.buttonStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonStart.Location = new System.Drawing.Point(262, 259);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(90, 30);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start Quiz";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 360);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.txtTimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math Quiz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelLeftPlus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelRightPlus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.Label labelLeftMinus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelRightMinus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown difference;
        private System.Windows.Forms.Label labelLeftTimes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelRightTimes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown product;
        private System.Windows.Forms.Label labelLeftDivided;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelRightDivided;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown quotient;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer timer1;
    }
}

