namespace winfork
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            quitWinforkToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            preferencesToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            pluginsToolStripMenuItem = new ToolStripMenuItem();
            installedPluginsToolStripMenuItem = new ToolStripMenuItem();
            noneToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            getPluginsToolStripMenuItem = new ToolStripMenuItem();
            windowToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lineStatus = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            richTextBox1 = new RichTextBox();
            lineNumberPanel = new Panel();
            vScrollBar1 = new VScrollBar();
            lineEndingStatusLabel = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AllowDrop = true;
            menuStrip1.BackColor = SystemColors.MenuBar;
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, pluginsToolStripMenuItem, windowToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(807, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, toolStripSeparator1, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator4, quitWinforkToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(192, 22);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenu_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(192, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenu_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(189, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(192, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenu_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(192, 22);
            saveAsToolStripMenuItem.Text = "Save As";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(189, 6);
            // 
            // quitWinforkToolStripMenuItem
            // 
            quitWinforkToolStripMenuItem.Name = "quitWinforkToolStripMenuItem";
            quitWinforkToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            quitWinforkToolStripMenuItem.Size = new Size(192, 22);
            quitWinforkToolStripMenuItem.Text = "Quit winfork...";
            quitWinforkToolStripMenuItem.Click += quitWinforkToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, toolStripSeparator2, preferencesToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(144, 22);
            cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(144, 22);
            copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(144, 22);
            pasteToolStripMenuItem.Text = "Paste";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(141, 6);
            // 
            // preferencesToolStripMenuItem
            // 
            preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            preferencesToolStripMenuItem.Size = new Size(144, 22);
            preferencesToolStripMenuItem.Text = "Preferences...";
            preferencesToolStripMenuItem.Click += preferencesToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // pluginsToolStripMenuItem
            // 
            pluginsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { installedPluginsToolStripMenuItem, toolStripSeparator3, getPluginsToolStripMenuItem });
            pluginsToolStripMenuItem.Name = "pluginsToolStripMenuItem";
            pluginsToolStripMenuItem.Size = new Size(58, 20);
            pluginsToolStripMenuItem.Text = "Plugins";
            // 
            // installedPluginsToolStripMenuItem
            // 
            installedPluginsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { noneToolStripMenuItem });
            installedPluginsToolStripMenuItem.Name = "installedPluginsToolStripMenuItem";
            installedPluginsToolStripMenuItem.Size = new Size(169, 22);
            installedPluginsToolStripMenuItem.Text = "Installed Plugins...";
            // 
            // noneToolStripMenuItem
            // 
            noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            noneToolStripMenuItem.Size = new Size(103, 22);
            noneToolStripMenuItem.Text = "None";
            noneToolStripMenuItem.Click += noneToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(166, 6);
            // 
            // getPluginsToolStripMenuItem
            // 
            getPluginsToolStripMenuItem.Name = "getPluginsToolStripMenuItem";
            getPluginsToolStripMenuItem.Size = new Size(169, 22);
            getPluginsToolStripMenuItem.Text = "Get Plugins...";
            getPluginsToolStripMenuItem.Click += getPluginsToolStripMenuItem_Click;
            // 
            // windowToolStripMenuItem
            // 
            windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            windowToolStripMenuItem.Size = new Size(63, 20);
            windowToolStripMenuItem.Text = "Window";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(116, 22);
            aboutToolStripMenuItem.Text = "About...";
            aboutToolStripMenuItem.Click += aboutToolStripMenu_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lineStatus, toolStripStatusLabel3, lineEndingStatusLabel, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 510);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(807, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lineStatus
            // 
            lineStatus.Name = "lineStatus";
            lineStatus.Size = new Size(62, 17);
            lineStatus.Text = "Ln 1, Col 1";
            lineStatus.ToolTipText = "Shows where your cursor is located.";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(641, 17);
            toolStripStatusLabel3.Spring = true;
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripStatusLabel2.ImageAlign = ContentAlignment.MiddleRight;
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(39, 17);
            toolStripStatusLabel2.Text = "Ready";
            // 
            // richTextBox1
            // 
            richTextBox1.AcceptsTab = true;
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(23, 24);
            richTextBox1.Margin = new Padding(0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox1.Size = new Size(784, 10003);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // lineNumberPanel
            // 
            lineNumberPanel.Dock = DockStyle.Left;
            lineNumberPanel.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lineNumberPanel.Location = new Point(0, 24);
            lineNumberPanel.Name = "lineNumberPanel";
            lineNumberPanel.Padding = new Padding(4);
            lineNumberPanel.Size = new Size(20, 486);
            lineNumberPanel.TabIndex = 4;
            lineNumberPanel.Paint += lineNumberPanel_Paint_1;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Dock = DockStyle.Right;
            vScrollBar1.Location = new Point(790, 24);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(17, 486);
            vScrollBar1.TabIndex = 5;
            // 
            // lineEndingStatusLabel
            // 
            lineEndingStatusLabel.Name = "lineEndingStatusLabel";
            lineEndingStatusLabel.Size = new Size(19, 17);
            lineEndingStatusLabel.Text = "LF";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 532);
            Controls.Add(vScrollBar1);
            Controls.Add(lineNumberPanel);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(richTextBox1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "winfork";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lineStatus;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripMenuItem pluginsToolStripMenuItem;
        private ToolStripMenuItem installedPluginsToolStripMenuItem;
        private ToolStripMenuItem noneToolStripMenuItem;
        private ToolStripMenuItem windowToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem getPluginsToolStripMenuItem;
        private RichTextBox richTextBox1;
        private ToolStripMenuItem preferencesToolStripMenuItem;
        private Panel lineNumberPanel;
        private VScrollBar vScrollBar1;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem quitWinforkToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripStatusLabel lineEndingStatusLabel;
    }
}