namespace rabota2
{
    partial class FuturaFormAdd
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
            button1 = new Button();
            add_button = new Button();
            label2 = new Label();
            label1 = new Label();
            comboBoxClient = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(243, 73);
            button1.Name = "button1";
            button1.Size = new Size(96, 23);
            button1.TabIndex = 22;
            button1.Text = "Закрыть";
            button1.UseVisualStyleBackColor = true;
            button1.Click += add_button_Click;
            // 
            // add_button
            // 
            add_button.Location = new Point(139, 73);
            add_button.Name = "add_button";
            add_button.Size = new Size(98, 23);
            add_button.TabIndex = 19;
            add_button.Text = "Добавить";
            add_button.UseVisualStyleBackColor = true;
            add_button.Click += add_button_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 7);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 16;
            label2.Text = "Клиент";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 6);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 15;
            label1.Text = "Дата";
            // 
            // comboBoxClient
            // 
            comboBoxClient.FormattingEnabled = true;
            comboBoxClient.Location = new Point(12, 24);
            comboBoxClient.Name = "comboBoxClient";
            comboBoxClient.Size = new Size(121, 23);
            comboBoxClient.TabIndex = 23;
            comboBoxClient.SelectedIndexChanged += comboBoxClient_SelectedIndexChanged;
            comboBoxClient.Click += comboBoxClient_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(139, 24);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 24;
            // 
            // FuturaFormAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(349, 115);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBoxClient);
            Controls.Add(button1);
            Controls.Add(add_button);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FuturaFormAdd";
            Text = "FuturaFormAdd";
            Load += FuturaFormAdd_Load;
            Click += FuturaFormAdd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button add_button;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxClient;
        private DateTimePicker dateTimePicker1;
    }
}