namespace Lab3_task21._2
{
    partial class Form1
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txt_ = new System.Windows.Forms.Label();
            this.radioPlombir = new System.Windows.Forms.RadioButton();
            this.radioVershkove = new System.Windows.Forms.RadioButton();
            this.radioSorbet = new System.Windows.Forms.RadioButton();
            this.radioFructoviyLid = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FructoviyLidPrice = new System.Windows.Forms.TextBox();
            this.SorbetPrice = new System.Windows.Forms.TextBox();
            this.VershkovePrice = new System.Windows.Forms.TextBox();
            this.PlombirPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._ = new System.Windows.Forms.Label();
            this.numericPortions = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPortions)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnOrder);
            this.flowLayoutPanel1.Controls.Add(this.btnReset);
            this.flowLayoutPanel1.Controls.Add(this.btnExit);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(41, 596);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(568, 120);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.ForestGreen;
            this.btnOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOrder.Location = new System.Drawing.Point(3, 3);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(191, 97);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "Сформувати замовлення";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Red;
            this.btnReset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReset.Location = new System.Drawing.Point(200, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(176, 97);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Відмінити";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(382, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(170, 97);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Вихід";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txt_
            // 
            this.txt_.AutoSize = true;
            this.txt_.Location = new System.Drawing.Point(37, 519);
            this.txt_.Name = "txt_";
            this.txt_.Size = new System.Drawing.Size(198, 25);
            this.txt_.TabIndex = 2;
            this.txt_.Text = "Загальна вартість:";
            this.txt_.Click += new System.EventHandler(this.label6_Click);
            // 
            // radioPlombir
            // 
            this.radioPlombir.AutoSize = true;
            this.radioPlombir.Location = new System.Drawing.Point(29, 48);
            this.radioPlombir.Name = "radioPlombir";
            this.radioPlombir.Size = new System.Drawing.Size(126, 29);
            this.radioPlombir.TabIndex = 8;
            this.radioPlombir.TabStop = true;
            this.radioPlombir.Text = "Пломбір";
            this.radioPlombir.UseVisualStyleBackColor = true;
            this.radioPlombir.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioVershkove
            // 
            this.radioVershkove.AutoSize = true;
            this.radioVershkove.Location = new System.Drawing.Point(29, 102);
            this.radioVershkove.Name = "radioVershkove";
            this.radioVershkove.Size = new System.Drawing.Size(144, 29);
            this.radioVershkove.TabIndex = 9;
            this.radioVershkove.TabStop = true;
            this.radioVershkove.Text = "Вершкове";
            this.radioVershkove.UseVisualStyleBackColor = true;
            // 
            // radioSorbet
            // 
            this.radioSorbet.AutoSize = true;
            this.radioSorbet.Location = new System.Drawing.Point(29, 154);
            this.radioSorbet.Name = "radioSorbet";
            this.radioSorbet.Size = new System.Drawing.Size(116, 29);
            this.radioSorbet.TabIndex = 10;
            this.radioSorbet.TabStop = true;
            this.radioSorbet.Text = "Сорбет";
            this.radioSorbet.UseVisualStyleBackColor = true;
            // 
            // radioFructoviyLid
            // 
            this.radioFructoviyLid.AutoSize = true;
            this.radioFructoviyLid.Location = new System.Drawing.Point(29, 207);
            this.radioFructoviyLid.Name = "radioFructoviyLid";
            this.radioFructoviyLid.Size = new System.Drawing.Size(187, 29);
            this.radioFructoviyLid.TabIndex = 11;
            this.radioFructoviyLid.TabStop = true;
            this.radioFructoviyLid.Text = "Фруктовий лід";
            this.radioFructoviyLid.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FructoviyLidPrice);
            this.groupBox1.Controls.Add(this.SorbetPrice);
            this.groupBox1.Controls.Add(this.VershkovePrice);
            this.groupBox1.Controls.Add(this.PlombirPrice);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioPlombir);
            this.groupBox1.Controls.Add(this.radioFructoviyLid);
            this.groupBox1.Controls.Add(this.radioVershkove);
            this.groupBox1.Controls.Add(this.radioSorbet);
            this.groupBox1.Location = new System.Drawing.Point(41, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 278);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вибір морозива";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // FructoviyLidPrice
            // 
            this.FructoviyLidPrice.Location = new System.Drawing.Point(376, 207);
            this.FructoviyLidPrice.Name = "FructoviyLidPrice";
            this.FructoviyLidPrice.ReadOnly = true;
            this.FructoviyLidPrice.Size = new System.Drawing.Size(142, 31);
            this.FructoviyLidPrice.TabIndex = 16;
            this.FructoviyLidPrice.Text = "70 грн.";
            // 
            // SorbetPrice
            // 
            this.SorbetPrice.Location = new System.Drawing.Point(376, 152);
            this.SorbetPrice.Name = "SorbetPrice";
            this.SorbetPrice.ReadOnly = true;
            this.SorbetPrice.Size = new System.Drawing.Size(142, 31);
            this.SorbetPrice.TabIndex = 15;
            this.SorbetPrice.Text = "160 грн.";
            // 
            // VershkovePrice
            // 
            this.VershkovePrice.Location = new System.Drawing.Point(376, 100);
            this.VershkovePrice.Name = "VershkovePrice";
            this.VershkovePrice.ReadOnly = true;
            this.VershkovePrice.Size = new System.Drawing.Size(142, 31);
            this.VershkovePrice.TabIndex = 14;
            this.VershkovePrice.Text = "100 грн.";
            // 
            // PlombirPrice
            // 
            this.PlombirPrice.Location = new System.Drawing.Point(376, 46);
            this.PlombirPrice.Name = "PlombirPrice";
            this.PlombirPrice.ReadOnly = true;
            this.PlombirPrice.Size = new System.Drawing.Size(142, 31);
            this.PlombirPrice.TabIndex = 13;
            this.PlombirPrice.Text = "150 грн.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Вартість";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // _
            // 
            this._.AutoSize = true;
            this._.Location = new System.Drawing.Point(36, 377);
            this._.Name = "_";
            this._.Size = new System.Drawing.Size(142, 25);
            this._.TabIndex = 14;
            this._.Text = "К-сть порцій:";
            // 
            // numericPortions
            // 
            this.numericPortions.Location = new System.Drawing.Point(209, 375);
            this.numericPortions.Name = "numericPortions";
            this.numericPortions.Size = new System.Drawing.Size(142, 31);
            this.numericPortions.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 768);
            this.Controls.Add(this.numericPortions);
            this.Controls.Add(this._);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.txt_);
            this.Name = "Form1";
            this.Text = "Замовлення морозива";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPortions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label txt_;
        private System.Windows.Forms.RadioButton radioFructoviyLid;
        private System.Windows.Forms.RadioButton radioSorbet;
        private System.Windows.Forms.RadioButton radioVershkove;
        private System.Windows.Forms.RadioButton radioPlombir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FructoviyLidPrice;
        private System.Windows.Forms.TextBox SorbetPrice;
        private System.Windows.Forms.TextBox VershkovePrice;
        private System.Windows.Forms.TextBox PlombirPrice;
        private System.Windows.Forms.Label _;
        private System.Windows.Forms.NumericUpDown numericPortions;
    }
}

