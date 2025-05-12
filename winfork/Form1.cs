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
        }

        private void UpdateLineStatus(object sender, EventArgs e)
        {
            int index = richTextBox1.SelectionStart;
            int line = richTextBox1.GetLineFromCharIndex(index) + 1;
            int col = richTextBox1.GetFirstCharIndexOfCurrentLine() + 1;
            lineStatus.Text = $"Ln {line}, Col {col}"
        }

        private void newToolMenuStrip_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
        }

        private void saveToolMenuStrip_Click(object sender, EventArgs e)
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

        private void openToolMenuStrip_Click(object sender, EventArgs e)
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

        private void aboutToolMenuStrip_Click(object sender, EventArgs e)
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
    }
}