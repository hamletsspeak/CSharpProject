namespace rabota2
{
    partial class FormClientAdd
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
            this.add_button = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxAdres = new System.Windows.Forms.TextBox();
            this.labelAdres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(9, 55);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 10;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(9, 26);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 23);
            this.textBoxName.TabIndex = 9;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "ФИО";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.close_button_Click);
            // 
            // textBoxAdres
            // 
            this.textBoxAdres.Location = new System.Drawing.Point(124, 26);
            this.textBoxAdres.Name = "textBoxAdres";
            this.textBoxAdres.Size = new System.Drawing.Size(100, 23);
            this.textBoxAdres.TabIndex = 13;
            this.textBoxAdres.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelAdres
            // 
            this.labelAdres.AutoSize = true;
            this.labelAdres.Location = new System.Drawing.Point(184, 8);
            this.labelAdres.Name = "labelAdres";
            this.labelAdres.Size = new System.Drawing.Size(40, 15);
            this.labelAdres.TabIndex = 12;
            this.labelAdres.Text = "Адрес";
            this.labelAdres.Click += new System.EventHandler(this.label3_Click);
            // 
            // FormClientAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(244, 102);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxAdres);
            this.Controls.Add(this.labelAdres);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.Name = "FormClientAdd";
            this.Text = "FormClientAdd";
            this.Load += new System.EventHandler(this.FormClientAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button add_button;
        private TextBox textBoxName;
        private Label label2;
        private Button button1;
        private TextBox textBoxAdres;
        private Label labelAdres;
    }
}