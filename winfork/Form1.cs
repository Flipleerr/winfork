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

        private void newToolMenuStrip_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
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

                string contents = textBox1.Text;

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

                textBox1.Text = contents;
            }
        }

        private void aboutToolMenuStrip_Click(object sender, EventArgs e)
        {
            MessageBox.Show("winfork" + "\n" + "the worst code editor out there for Windows.");
        }
    }
}