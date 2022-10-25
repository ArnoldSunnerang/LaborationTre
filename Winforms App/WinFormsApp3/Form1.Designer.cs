namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchAndRemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSelectedWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.practiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 427);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newListToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 26);
            // 
            // newListToolStripMenuItem
            // 
            this.newListToolStripMenuItem.Name = "newListToolStripMenuItem";
            this.newListToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.newListToolStripMenuItem.Text = "New list";
            this.newListToolStripMenuItem.Click += new System.EventHandler(this.newListToolStripMenuItem_Click);
            // 
            // listBox2
            // 
            this.listBox2.ContextMenuStrip = this.contextMenuStrip2;
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(240, 0);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(560, 427);
            this.listBox2.TabIndex = 1;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeWordToolStripMenuItem,
            this.addWordToolStripMenuItem,
            this.practiceToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(181, 92);
            // 
            // removeWordToolStripMenuItem
            // 
            this.removeWordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchAndRemoveToolStripMenuItem,
            this.removeSelectedWordToolStripMenuItem});
            this.removeWordToolStripMenuItem.Name = "removeWordToolStripMenuItem";
            this.removeWordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeWordToolStripMenuItem.Text = "Remove word";
            this.removeWordToolStripMenuItem.Click += new System.EventHandler(this.removeWordToolStripMenuItem_Click);
            // 
            // searchAndRemoveToolStripMenuItem
            // 
            this.searchAndRemoveToolStripMenuItem.Name = "searchAndRemoveToolStripMenuItem";
            this.searchAndRemoveToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.searchAndRemoveToolStripMenuItem.Text = "Search and remove";
            this.searchAndRemoveToolStripMenuItem.Click += new System.EventHandler(this.searchAndRemoveToolStripMenuItem_Click);
            // 
            // removeSelectedWordToolStripMenuItem
            // 
            this.removeSelectedWordToolStripMenuItem.Name = "removeSelectedWordToolStripMenuItem";
            this.removeSelectedWordToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.removeSelectedWordToolStripMenuItem.Text = "Remove selected word";
            this.removeSelectedWordToolStripMenuItem.Click += new System.EventHandler(this.removeSelectedWordToolStripMenuItem_Click);
            // 
            // addWordToolStripMenuItem
            // 
            this.addWordToolStripMenuItem.Name = "addWordToolStripMenuItem";
            this.addWordToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.addWordToolStripMenuItem.Text = "Add word";
            this.addWordToolStripMenuItem.Click += new System.EventHandler(this.addWordToolStripMenuItem_Click);
            // 
            // practiceToolStripMenuItem
            // 
            this.practiceToolStripMenuItem.Name = "practiceToolStripMenuItem";
            this.practiceToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.practiceToolStripMenuItem.Text = "Practice";
            this.practiceToolStripMenuItem.Click += new System.EventHandler(this.practiceToolStripMenuItem_Click);
            // 
            // listBox3
            // 
            this.listBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 15;
            this.listBox3.Location = new System.Drawing.Point(120, 0);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 427);
            this.listBox3.TabIndex = 2;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(0, 427);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(800, 23);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.MinimumSize = new System.Drawing.Size(380, 300);
            this.Name = "Form1";
            this.Text = "GlosKos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public ListBox listBox1;
        private ListBox listBox2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem newListToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem removeWordToolStripMenuItem;
        private ToolStripMenuItem addWordToolStripMenuItem;
        private ToolStripMenuItem searchAndRemoveToolStripMenuItem;
        public ListBox listBox3;
        private ToolStripMenuItem removeSelectedWordToolStripMenuItem;
        private TextBox textBox1;
        private ToolStripMenuItem practiceToolStripMenuItem;
    }
}