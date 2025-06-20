using System;
using System.Collections.Generic;
using System.IO;

namespace winfork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Resize += Resize_TextBox;
            richTextBox1.SelectionChanged += RichTextBox_PositionChanged;
            richTextBox1.VScroll += richTextBox1_VScroll;
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            lineNumberPanel.Paint += lineNumberPanel_Paint;
        }

        private void UpdateLineStatus()
        {
            int index = richTextBox1.SelectionStart;
            int line = richTextBox1.GetLineFromCharIndex(index) + 1;
            int col = index - richTextBox1.GetFirstCharIndexOfCurrentLine() + 1;
            lineStatus.Text = $"Ln {line}, Col {col}";
        }

        private void Resize_TextBox(object sender, EventArgs e)
        {
            richTextBox1.Size = new Size(this.ClientSize.Width, this.ClientSize.Height - this.menuStrip1.Height);
            richTextBox1.Location = new Point(this.lineNumberPanel.Right, this.menuStrip1.Height);
        }

        private void RichTextBox_PositionChanged(object sender, EventArgs e)
        {
            UpdateLineStatus();
        }

        private void newToolStripMenu_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
        }

        private void saveToolStripMenu_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "Text (*.txt)|*.txt|All Files (*.*)|*.*",
                DefaultExt = "txt",
                AddExtension = true,
                Title = "Save"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                string contents = richTextBox1.Text;

                System.IO.File.WriteAllText(filePath, contents);

                MessageBox.Show($"saved to {filePath}");
            }
        }

        private void openToolStripMenu_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Text (*.txt)|*.txt|All Files (*.*)|*.*",
                Title = "Open"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                string contents = File.ReadAllText(filePath);

                richTextBox1.Text = contents;
            }
        }

        private void aboutToolStripMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("winfork" + "\n" + "the worst code editor out there for Windows.");
        }

        private void getPluginsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("no Forktools backend found! please install Forktools from https://forktools.net first");
        }

        private void noneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new Exception("oops! winfork crashed! we don't know why, but our telemetry system logged everything so we're probably working on a fix.");
        }

        private void richTextBox1_VScroll(object sender, EventArgs e)
        {
            lineNumberPanel.Invalidate();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            lineNumberPanel.Invalidate();
        }

        private void lineNumberPanel_Paint(object sender, PaintEventArgs e)
        {
            int firstline = richTextBox1.GetLineFromCharIndex(richTextBox1.GetCharIndexFromPosition(new Point(0, 0)));
            int lastline = richTextBox1.GetLineFromCharIndex(richTextBox1.GetCharIndexFromPosition(new Point(0, richTextBox1.ClientSize.Height)));

            int lineheight = richTextBox1.Font.Height;
            int startY = -richTextBox1.GetPositionFromCharIndex(richTextBox1.GetFirstCharIndexFromLine(firstline)).Y;

            for (int i = firstline; i <= lastline; i++)
            {
                int y = startY + (i - firstline) * lineheight;
                e.Graphics.DrawString((i + 1).ToString(), richTextBox1.Font, Brushes.Gray, new PointF(0, y));
            }
        }

        private void quitWinforkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}