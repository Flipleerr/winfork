namespace winfork
{
    partial class PrefForm
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
            TreeNode treeNode1 = new TreeNode("Fonts and Colors");
            TreeNode treeNode2 = new TreeNode("Keyboard Shortcuts");
            TreeNode treeNode3 = new TreeNode("Editor", new TreeNode[] { treeNode1, treeNode2 });
            TreeNode treeNode4 = new TreeNode("Appearance");
            treeView1 = new TreeView();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.LabelEdit = true;
            treeView1.Location = new Point(12, 12);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Fonts and Colors";
            treeNode1.Text = "Fonts and Colors";
            treeNode2.Name = "Keyboard Shortcuts";
            treeNode2.Text = "Keyboard Shortcuts";
            treeNode3.Name = "Editor";
            treeNode3.Text = "Editor";
            treeNode4.Name = "Appearance";
            treeNode4.Text = "Appearance";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode3, treeNode4 });
            treeView1.Size = new Size(155, 391);
            treeView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Location = new Point(173, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(390, 391);
            panel1.TabIndex = 1;
            // 
            // PrefForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 415);
            Controls.Add(panel1);
            Controls.Add(treeView1);
            Name = "PrefForm";
            Text = "Preferences";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView1;
        private Panel panel1;
    }
}