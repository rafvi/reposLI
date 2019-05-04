using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Label_Image
{
    public partial class LabelImage : Form
    {
        public LabelImage()
        {
            InitializeComponent();
        }

        int valueProgressBar1 = 0;
        string destFolder = @"LB_Wynik";
        int licznik;

        List<string> listFiles; // lista wybranych plików

        Font MyFont = new Font("Arial", 16, FontStyle.Regular); // ustawienia czcionki, domyślna


        /// <summary>
        /// Dodanie plików wejściowych
        /// </summary>
        private void BtnAddFile_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                listFiles = new List<String>(openFileDialog.FileNames);

                // dodanie path&name do listy (fileListBox)
                foreach (string fileName in listFiles)
                {
                    fileListBox.Items.Add(fileName);
                }
            }
        }

        /// <summary>
        /// Usunięcie wybranego pliku z listy
        /// </summary>
        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (fileListBox.SelectedItems.Count != 0)
            {
                while (fileListBox.SelectedIndex != -1)
                {
                    fileListBox.Items.RemoveAt(fileListBox.SelectedIndex);
                }
            }
        }

        /// <summary>
        /// Usunięcie wszystkich plików z listy
        /// </summary>
        private void BtnDelAll_Click(object sender, EventArgs e)
        {
            listFiles.Clear();
            fileListBox.Items.Clear();
        }

        /// <summary>
        /// Folder wyjściowy
        /// </summary>
        private void BtnLblFolder_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    folderTextBox.Text = folderDialog.SelectedPath;
                    destFolder = folderDialog.SelectedPath;
                }

            }
        }

        /// <summary>
        /// Start
        /// </summary>
        private void BtnStart_Click(object sender, EventArgs e)
        {
            // Jeżeli brak folderu Wynik -> utworzyć!
            if (!Directory.Exists(destFolder))
                Directory.CreateDirectory(destFolder);

            if (destFolder == @"LB_Wynik")
                MessageBox.Show("Pliki wynikowe zostaną zapisane w folderze LB_Wynik", "Label Image",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            Bitmap newBitmap;
            PointF lokalizacjaTekstu;

            string newName = "null";
            licznik = Convert.ToInt16(textBoxPocz.Text);

            try
            {
                foreach (string file in listFiles)
                {
                    if (checkBoxZNP.Checked)
                        newName = textBoxNewName.Text.Replace("#", Convert.ToString(licznik));
                    else
                        newName = Path.GetFileName(file);

                    string myText = richTextBox1.Text;

                    // <filename>
                    if (myText.Contains("<filename>"))
                    {
                        if (checkBoxZNP.Checked)
                            myText = myText.Replace("<filename>", newName);
                        else
                            // zmiana ciągu <filename> na ciąg odpowiadający nazwie pliku (bez rozszerzenia).
                            myText = myText.Replace("<filename>", Path.GetFileNameWithoutExtension(file));
                    }

                    using (var bitmap = (Bitmap)Image.FromFile(file))
                    {
                        using (Graphics graphics = Graphics.FromImage(bitmap))
                        {
                            lokalizacjaTekstu = new PointF(10, bitmap.Height - richTextBox1.Lines.Length * MyFont.GetHeight(graphics) - 5);
                            graphics.DrawString(myText, MyFont, Brushes.White, lokalizacjaTekstu);

                        }
                        newBitmap = new Bitmap(bitmap);
                    }
                    newBitmap.Save(destFolder + "\\" + newName + Path.GetExtension(file));
                    newBitmap.Dispose();

                    // Pasek postępu - ProccesBar
                    progressBar1.Visible = true;
                    progressBar1.Minimum = 0;
                    progressBar1.Maximum = listFiles.Count - 1;
                    lblProgress.Text = file;
                    lblProgress.Update();
                    progressBar1.Value = valueProgressBar1++;
                    if (progressBar1.Value == progressBar1.Maximum)
                    {
                        MessageBox.Show("Zakończono", "Label Image", MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
                        valueProgressBar1 = 0;
                    }

                    // zwiększ licznik o wartość "Krok".
                    licznik = licznik + Convert.ToInt16(textBoxKrok.Text);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Brak wybranych plików!", "Label Image", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// fontDialog
        /// </summary>
        private void BtnFont_Click(object sender, EventArgs e)
        {
            DialogResult res = fontDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                Font diagFont = fontDialog1.Font;
                this.richTextBox1.Font = diagFont;
                MyFont = diagFont;
            }
        }

        private void BtnDevelop_Click(object sender, EventArgs e)
        {
            developMenuStrip.Show(MousePosition);
        }

        private void FileName_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "<filename>";
        }


        /// <summary>
        /// MENU - PRAWY PRZYCISK MYSZY richTextBox1
        /// </summary>
        private void RichTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip1.Show(this, new Point(e.X + 22, e.Y));
            }
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e) { richTextBox1.Cut(); }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e) { richTextBox1.Copy(); }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e) { richTextBox1.Paste(); }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e) { richTextBox1.Clear(); }

        private void SelectAllWszystkoToolStripMenuItem_Click(object sender, EventArgs e) { richTextBox1.SelectAll(); }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (richTextBox1.SelectedText != string.Empty)
            {
                wytnijToolStripMenuItem.ForeColor = Color.Black;
                wytnijToolStripMenuItem.Enabled = true;

                kopiujToolStripMenuItem.ForeColor = Color.Black;
                kopiujToolStripMenuItem.Enabled = true;
            }
            else
            {
                wytnijToolStripMenuItem.ForeColor = Color.LightGray;
                wytnijToolStripMenuItem.Enabled = false;

                kopiujToolStripMenuItem.ForeColor = Color.LightGray;
                kopiujToolStripMenuItem.Enabled = false;
            }
        }
    }
}
