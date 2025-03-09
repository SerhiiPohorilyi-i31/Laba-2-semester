namespace Lab4_task21._3
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.buttonSaveSetting = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDefaultSettings = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Доступність:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(44, 94);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(829, 200);
            this.checkedListBox1.TabIndex = 1;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // buttonSaveSetting
            // 
            this.buttonSaveSetting.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSaveSetting.Location = new System.Drawing.Point(44, 605);
            this.buttonSaveSetting.Name = "buttonSaveSetting";
            this.buttonSaveSetting.Size = new System.Drawing.Size(391, 70);
            this.buttonSaveSetting.TabIndex = 2;
            this.buttonSaveSetting.Text = "Зберегти налаштування";
            this.buttonSaveSetting.UseVisualStyleBackColor = false;
            this.buttonSaveSetting.Click += new System.EventHandler(this.buttonSaveSetting_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(589, 483);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 3;
            // 
            // buttonDefaultSettings
            // 
            this.buttonDefaultSettings.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDefaultSettings.Location = new System.Drawing.Point(482, 605);
            this.buttonDefaultSettings.Name = "buttonDefaultSettings";
            this.buttonDefaultSettings.Size = new System.Drawing.Size(391, 70);
            this.buttonDefaultSettings.TabIndex = 4;
            this.buttonDefaultSettings.Text = "Налаштування по замовчуванню";
            this.buttonDefaultSettings.UseVisualStyleBackColor = false;
            this.buttonDefaultSettings.Click += new System.EventHandler(this.buttonDefaultSettings_Click_1);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(44, 376);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.Size = new System.Drawing.Size(829, 200);
            this.textBoxOutput.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Вибрані налаштування:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 828);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.buttonDefaultSettings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSaveSetting);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Налаштування браузера";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button buttonSaveSetting;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDefaultSettings;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Label label3;
    }
}

