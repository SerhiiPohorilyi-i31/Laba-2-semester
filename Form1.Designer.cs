using System;

namespace Lab5_task21._1
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
            this._ = new System.Windows.Forms.Label();
            this.numericPortions = new System.Windows.Forms.NumericUpDown();
            this.chkPlombir = new System.Windows.Forms.CheckBox();
            this.chkVershkove = new System.Windows.Forms.CheckBox();
            this.chkSorbet = new System.Windows.Forms.CheckBox();
            this.chkFructoviyLid = new System.Windows.Forms.CheckBox();
            this.PlombirPrice_ = new System.Windows.Forms.Label();
            this.VershkovePrice_ = new System.Windows.Forms.Label();
            this.SorbetPrice_ = new System.Windows.Forms.Label();
            this.FructoviyLidPrice_ = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPortions)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // chkPlombir
            // 
            this.chkPlombir.AutoSize = true;
            this.chkPlombir.Location = new System.Drawing.Point(14, 51);
            this.chkPlombir.Name = "chkPlombir";
            this.chkPlombir.Size = new System.Drawing.Size(127, 29);
            this.chkPlombir.TabIndex = 16;
            this.chkPlombir.Text = "Пломбір";
            this.chkPlombir.UseVisualStyleBackColor = true;
            // 
            // chkVershkove
            // 
            this.chkVershkove.AutoSize = true;
            this.chkVershkove.Location = new System.Drawing.Point(14, 103);
            this.chkVershkove.Name = "chkVershkove";
            this.chkVershkove.Size = new System.Drawing.Size(145, 29);
            this.chkVershkove.TabIndex = 17;
            this.chkVershkove.Text = "Вершкове";
            this.chkVershkove.UseVisualStyleBackColor = true;
            // 
            // chkSorbet
            // 
            this.chkSorbet.AutoSize = true;
            this.chkSorbet.Location = new System.Drawing.Point(14, 158);
            this.chkSorbet.Name = "chkSorbet";
            this.chkSorbet.Size = new System.Drawing.Size(117, 29);
            this.chkSorbet.TabIndex = 18;
            this.chkSorbet.Text = "Сорбет";
            this.chkSorbet.UseVisualStyleBackColor = true;
            // 
            // chkFructoviyLid
            // 
            this.chkFructoviyLid.AutoSize = true;
            this.chkFructoviyLid.Location = new System.Drawing.Point(14, 207);
            this.chkFructoviyLid.Name = "chkFructoviyLid";
            this.chkFructoviyLid.Size = new System.Drawing.Size(188, 29);
            this.chkFructoviyLid.TabIndex = 19;
            this.chkFructoviyLid.Text = "Фруктовий лід";
            this.chkFructoviyLid.UseVisualStyleBackColor = true;
            // 
            // PlombirPrice_
            // 
            this.PlombirPrice_.AutoSize = true;
            this.PlombirPrice_.Location = new System.Drawing.Point(279, 55);
            this.PlombirPrice_.Name = "PlombirPrice_";
            this.PlombirPrice_.Size = new System.Drawing.Size(92, 25);
            this.PlombirPrice_.TabIndex = 20;
            this.PlombirPrice_.Text = "150 грн.";
            // 
            // VershkovePrice_
            // 
            this.VershkovePrice_.AutoSize = true;
            this.VershkovePrice_.Location = new System.Drawing.Point(279, 104);
            this.VershkovePrice_.Name = "VershkovePrice_";
            this.VershkovePrice_.Size = new System.Drawing.Size(92, 25);
            this.VershkovePrice_.TabIndex = 21;
            this.VershkovePrice_.Text = "100 грн.";
            // 
            // SorbetPrice_
            // 
            this.SorbetPrice_.AutoSize = true;
            this.SorbetPrice_.Location = new System.Drawing.Point(279, 159);
            this.SorbetPrice_.Name = "SorbetPrice_";
            this.SorbetPrice_.Size = new System.Drawing.Size(92, 25);
            this.SorbetPrice_.TabIndex = 22;
            this.SorbetPrice_.Text = "160 грн.";
            // 
            // FructoviyLidPrice_
            // 
            this.FructoviyLidPrice_.AutoSize = true;
            this.FructoviyLidPrice_.Location = new System.Drawing.Point(279, 208);
            this.FructoviyLidPrice_.Name = "FructoviyLidPrice_";
            this.FructoviyLidPrice_.Size = new System.Drawing.Size(80, 25);
            this.FructoviyLidPrice_.TabIndex = 23;
            this.FructoviyLidPrice_.Text = "70 грн.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.chkPlombir);
            this.groupBox1.Controls.Add(this.FructoviyLidPrice_);
            this.groupBox1.Controls.Add(this.chkVershkove);
            this.groupBox1.Controls.Add(this.SorbetPrice_);
            this.groupBox1.Controls.Add(this.chkSorbet);
            this.groupBox1.Controls.Add(this.VershkovePrice_);
            this.groupBox1.Controls.Add(this.chkFructoviyLid);
            this.groupBox1.Controls.Add(this.PlombirPrice_);
            this.groupBox1.Location = new System.Drawing.Point(27, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 275);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вибір морозива";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Вартість";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab2_task21._1.Properties.Resources.OIP;
            this.pictureBox1.Location = new System.Drawing.Point(573, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(446, 347);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 768);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numericPortions);
            this.Controls.Add(this._);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.txt_);
            this.Name = "Form1";
            this.Text = "Замовлення морозива";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericPortions)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label txt_;
        private System.Windows.Forms.Label _;
        private System.Windows.Forms.NumericUpDown numericPortions;
        private System.Windows.Forms.CheckBox chkPlombir;
        private System.Windows.Forms.CheckBox chkVershkove;
        private System.Windows.Forms.CheckBox chkSorbet;
        private System.Windows.Forms.CheckBox chkFructoviyLid;
        private System.Windows.Forms.Label PlombirPrice_;
        private System.Windows.Forms.Label VershkovePrice_;
        private System.Windows.Forms.Label SorbetPrice_;
        private System.Windows.Forms.Label FructoviyLidPrice_;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

