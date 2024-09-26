namespace rabota2
{
    partial class Form_futura
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
            menuStrip1 = new MenuStrip();
            AddToolStripMenuItem = new ToolStripMenuItem();
            futuraToolStripMenuItem = new ToolStripMenuItem();
            futurainfoToolStripMenuItem = new ToolStripMenuItem();
            DeleteToolStripMenuItem = new ToolStripMenuItem();
            futuraDeleteButton = new ToolStripMenuItem();
            futuraInfoDelete = new ToolStripMenuItem();
            ExitToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { AddToolStripMenuItem, DeleteToolStripMenuItem, ExitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1513, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked_1;
            // 
            // AddToolStripMenuItem
            // 
            AddToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { futuraToolStripMenuItem, futurainfoToolStripMenuItem });
            AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            AddToolStripMenuItem.Size = new Size(71, 20);
            AddToolStripMenuItem.Text = "Добавить";
            // 
            // futuraToolStripMenuItem
            // 
            futuraToolStripMenuItem.Name = "futuraToolStripMenuItem";
            futuraToolStripMenuItem.Size = new Size(180, 22);
            futuraToolStripMenuItem.Text = "Futura";
            futuraToolStripMenuItem.Click += futuraToolStripMenuItem_Click;
            // 
            // futurainfoToolStripMenuItem
            // 
            futurainfoToolStripMenuItem.Name = "futurainfoToolStripMenuItem";
            futurainfoToolStripMenuItem.Size = new Size(180, 22);
            futurainfoToolStripMenuItem.Text = "Futurainfo";
            futurainfoToolStripMenuItem.Click += futurainfoToolStripMenuItem_Click;
            // 
            // DeleteToolStripMenuItem
            // 
            DeleteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { futuraDeleteButton, futuraInfoDelete });
            DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            DeleteToolStripMenuItem.Size = new Size(58, 20);
            DeleteToolStripMenuItem.Text = "Удалиь";
            // 
            // futuraDeleteButton
            // 
            futuraDeleteButton.Name = "futuraDeleteButton";
            futuraDeleteButton.Size = new Size(127, 22);
            futuraDeleteButton.Text = "futura";
            futuraDeleteButton.Click += futuraDeleteButton_Click;
            // 
            // futuraInfoDelete
            // 
            futuraInfoDelete.Name = "futuraInfoDelete";
            futuraInfoDelete.Size = new Size(127, 22);
            futuraInfoDelete.Text = "futuraInfo";
            futuraInfoDelete.Click += futuraInfoDelete_Click;
            // 
            // ExitToolStripMenuItem
            // 
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.Size = new Size(54, 20);
            ExitToolStripMenuItem.Text = "Выход";
            ExitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(600, 504);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            dataGridView1.RowHeaderMouseClick += dataGridView1_ColumnHeaderMouseClick;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(809, 27);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(702, 414);
            dataGridView2.TabIndex = 2;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(618, 167);
            button1.Name = "button1";
            button1.Size = new Size(162, 76);
            button1.TabIndex = 3;
            button1.Text = "обновить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form_futura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1513, 532);
            Controls.Add(button1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form_futura";
            Text = "Заказы";
            Load += Form_futura_Load;
            Click += Form_futura_Click;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem AddToolStripMenuItem;
        private ToolStripMenuItem DeleteToolStripMenuItem;
        private ToolStripMenuItem ExitToolStripMenuItem;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private ToolStripMenuItem futuraToolStripMenuItem;
        private ToolStripMenuItem futurainfoToolStripMenuItem;
        private ToolStripMenuItem futuraDeleteButton;
        private ToolStripMenuItem futuraInfoDelete;
        private Button button1;
    }
}