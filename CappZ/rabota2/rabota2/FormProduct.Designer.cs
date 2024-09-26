namespace rabota2
{
    partial class FormProduct
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.StripMenu_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenu_Change = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenu_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 27);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(652, 310);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenu_Add,
            this.StripMenu_Change,
            this.StripMenu_Delete,
            this.StripMenu_Exit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(675, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // StripMenu_Add
            // 
            this.StripMenu_Add.Name = "StripMenu_Add";
            this.StripMenu_Add.Size = new System.Drawing.Size(74, 20);
            this.StripMenu_Add.Text = "Добавить ";
            this.StripMenu_Add.Click += new System.EventHandler(this.StripMenu_Add_Click);
            // 
            // StripMenu_Change
            // 
            this.StripMenu_Change.Name = "StripMenu_Change";
            this.StripMenu_Change.Size = new System.Drawing.Size(73, 20);
            this.StripMenu_Change.Text = "Изменить";
            this.StripMenu_Change.Click += new System.EventHandler(this.StripMenu_Change_Click);
            // 
            // StripMenu_Delete
            // 
            this.StripMenu_Delete.Name = "StripMenu_Delete";
            this.StripMenu_Delete.Size = new System.Drawing.Size(63, 20);
            this.StripMenu_Delete.Text = "Удалить";
            this.StripMenu_Delete.Click += new System.EventHandler(this.StripMenu_Delete_Click);
            // 
            // StripMenu_Exit
            // 
            this.StripMenu_Exit.Name = "StripMenu_Exit";
            this.StripMenu_Exit.Size = new System.Drawing.Size(54, 20);
            this.StripMenu_Exit.Text = "Выход";
            this.StripMenu_Exit.Click += new System.EventHandler(this.StripMenu_Exit_Click);
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(675, 346);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormProduct";
            this.Text = "FormProduct";
            this.Load += new System.EventHandler(this.FormProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem StripMenu_Add;
        private ToolStripMenuItem StripMenu_Change;
        private ToolStripMenuItem StripMenu_Delete;
        private ToolStripMenuItem StripMenu_Exit;
    }
}