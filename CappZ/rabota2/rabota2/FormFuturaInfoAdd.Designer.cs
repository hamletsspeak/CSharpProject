namespace rabota2
{
    partial class FormFuturaInfoAdd
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
            prodcomboBox = new ComboBox();
            textBoxQan = new TextBox();
            textBoxPr = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            add_button = new Button();
            close_button = new Button();
            comboBox1 = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // prodcomboBox
            // 
            prodcomboBox.FormattingEnabled = true;
            prodcomboBox.Location = new Point(5, 24);
            prodcomboBox.Name = "prodcomboBox";
            prodcomboBox.Size = new Size(202, 23);
            prodcomboBox.TabIndex = 0;
            prodcomboBox.Click += FormFuturaInfoAdd_Load;
            // 
            // textBoxQan
            // 
            textBoxQan.Location = new Point(213, 67);
            textBoxQan.Name = "textBoxQan";
            textBoxQan.Size = new Size(155, 23);
            textBoxQan.TabIndex = 1;
            // 
            // textBoxPr
            // 
            textBoxPr.Location = new Point(213, 23);
            textBoxPr.Name = "textBoxPr";
            textBoxPr.Size = new Size(155, 23);
            textBoxPr.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 6);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 3;
            label1.Text = "Товары";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 49);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 4;
            label2.Text = "Количество";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(213, 5);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 5;
            label3.Text = "Цена";
            label3.Click += label3_Click;
            // 
            // add_button
            // 
            add_button.Location = new Point(48, 66);
            add_button.Name = "add_button";
            add_button.Size = new Size(75, 23);
            add_button.TabIndex = 6;
            add_button.Text = "Добавить";
            add_button.UseVisualStyleBackColor = true;
            add_button.Click += button1_Click;
            // 
            // close_button
            // 
            close_button.Location = new Point(129, 66);
            close_button.Name = "close_button";
            close_button.Size = new Size(75, 23);
            close_button.TabIndex = 7;
            close_button.Text = "Закрыть";
            close_button.UseVisualStyleBackColor = true;
            close_button.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(5, 67);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(37, 23);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.Click += FormFuturaInfoAdd_Load_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 50);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 9;
            label4.Text = "id договора";
            // 
            // FormFuturaInfoAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(376, 102);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(close_button);
            Controls.Add(add_button);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPr);
            Controls.Add(textBoxQan);
            Controls.Add(prodcomboBox);
            Name = "FormFuturaInfoAdd";
            Text = "FormFuturaInfoAdd";
            Load += FormFuturaInfoAdd_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox prodcomboBox;
        private TextBox textBoxQan;
        private TextBox textBoxPr;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button add_button;
        private Button close_button;
        private ComboBox comboBox1;
        private Label label4;
    }
}