namespace rabota2
{
    partial class FormClient
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
            dataGridView2 = new DataGridView();
            menuStrip2 = new MenuStrip();
            StripMenu_Add = new ToolStripMenuItem();
            StripMenu_Change = new ToolStripMenuItem();
            StripMenu_Delete = new ToolStripMenuItem();
            StripMenu_Exit = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(62, 77);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(154, 306);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick_1;
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = SystemColors.GradientActiveCaption;
            menuStrip2.Items.AddRange(new ToolStripItem[] { StripMenu_Add, StripMenu_Change, StripMenu_Delete, StripMenu_Exit });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(288, 24);
            menuStrip2.TabIndex = 2;
            menuStrip2.Text = "menuStrip1";
            menuStrip2.ItemClicked += menuStrip2_ItemClicked;
            // 
            // StripMenu_Add
            // 
            StripMenu_Add.Name = "StripMenu_Add";
            StripMenu_Add.Size = new Size(74, 20);
            StripMenu_Add.Text = "Добавить ";
            StripMenu_Add.Click += StripMenu_Add_Click;
            // 
            // StripMenu_Change
            // 
            StripMenu_Change.Name = "StripMenu_Change";
            StripMenu_Change.Size = new Size(73, 20);
            StripMenu_Change.Text = "Изменить";
            StripMenu_Change.Click += StripMenu_Change_Click;
            // 
            // StripMenu_Delete
            // 
            StripMenu_Delete.Name = "StripMenu_Delete";
            StripMenu_Delete.Size = new Size(63, 20);
            StripMenu_Delete.Text = "Удалить";
            StripMenu_Delete.Click += StripMenu_Delete_Click;
            // 
            // StripMenu_Exit
            // 
            StripMenu_Exit.Name = "StripMenu_Exit";
            StripMenu_Exit.Size = new Size(54, 20);
            StripMenu_Exit.Text = "Выход";
            StripMenu_Exit.Click += StripMenu_Exit_Click;
            // 
            // FormClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(288, 452);
            Controls.Add(menuStrip2);
            Controls.Add(dataGridView2);
            Name = "FormClient";
            Text = "FormClient";
            Load += FormClient_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView2;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem StripMenu_Add;
        private ToolStripMenuItem StripMenu_Change;
        private ToolStripMenuItem StripMenu_Delete;
        private ToolStripMenuItem StripMenu_Exit;
    }
}