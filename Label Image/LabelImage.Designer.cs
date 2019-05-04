namespace Label_Image
{
    partial class LabelImage
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LabelImage));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLblFolder = new System.Windows.Forms.Button();
            this.folderTextBox = new System.Windows.Forms.TextBox();
            this.lblFolder = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelAll = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.fileListBox = new System.Windows.Forms.ListBox();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.checkBoxZNP = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxKrok = new System.Windows.Forms.TextBox();
            this.textBoxPocz = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnFont = new System.Windows.Forms.Button();
            this.tabPageTekst = new System.Windows.Forms.TabPage();
            this.btnDevelop = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblProgress = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.developMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nazwaPlikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.wytnijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopiujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wklejToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyczyśćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaznaczWszystkoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tabControl.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPageTekst.SuspendLayout();
            this.developMenuStrip.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageGeneral);
            this.tabControl.Controls.Add(this.tabPageSettings);
            this.tabControl.Controls.Add(this.tabPageTekst);
            this.tabControl.Location = new System.Drawing.Point(12, 23);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(422, 332);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.groupBox2);
            this.tabPageGeneral.Controls.Add(this.groupBox1);
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneral.Size = new System.Drawing.Size(414, 306);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "Ogólne";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLblFolder);
            this.groupBox2.Controls.Add(this.folderTextBox);
            this.groupBox2.Controls.Add(this.lblFolder);
            this.groupBox2.Location = new System.Drawing.Point(6, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 82);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pliki wyjściowe";
            // 
            // btnLblFolder
            // 
            this.btnLblFolder.Location = new System.Drawing.Point(367, 25);
            this.btnLblFolder.Name = "btnLblFolder";
            this.btnLblFolder.Size = new System.Drawing.Size(29, 20);
            this.btnLblFolder.TabIndex = 2;
            this.btnLblFolder.Text = "...";
            this.btnLblFolder.UseVisualStyleBackColor = true;
            this.btnLblFolder.Click += new System.EventHandler(this.BtnLblFolder_Click);
            // 
            // folderTextBox
            // 
            this.folderTextBox.Location = new System.Drawing.Point(71, 25);
            this.folderTextBox.Name = "folderTextBox";
            this.folderTextBox.Size = new System.Drawing.Size(290, 20);
            this.folderTextBox.TabIndex = 1;
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(29, 28);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(36, 13);
            this.lblFolder.TabIndex = 0;
            this.lblFolder.Text = "Folder";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelAll);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnAddFile);
            this.groupBox1.Controls.Add(this.fileListBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 206);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Plki wejściowe";
            // 
            // btnDelAll
            // 
            this.btnDelAll.Location = new System.Drawing.Point(304, 175);
            this.btnDelAll.Name = "btnDelAll";
            this.btnDelAll.Size = new System.Drawing.Size(92, 23);
            this.btnDelAll.TabIndex = 3;
            this.btnDelAll.Text = "Usuń wszystko";
            this.btnDelAll.UseVisualStyleBackColor = true;
            this.btnDelAll.Click += new System.EventHandler(this.BtnDelAll_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(304, 146);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(92, 23);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Usuń";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(6, 146);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(92, 23);
            this.btnAddFile.TabIndex = 0;
            this.btnAddFile.Text = "Dodaj...";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.BtnAddFile_Click);
            // 
            // fileListBox
            // 
            this.fileListBox.FormattingEnabled = true;
            this.fileListBox.Location = new System.Drawing.Point(6, 19);
            this.fileListBox.Name = "fileListBox";
            this.fileListBox.Size = new System.Drawing.Size(390, 121);
            this.fileListBox.TabIndex = 1;
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Controls.Add(this.checkBoxZNP);
            this.tabPageSettings.Controls.Add(this.groupBox4);
            this.tabPageSettings.Controls.Add(this.groupBox3);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(414, 306);
            this.tabPageSettings.TabIndex = 1;
            this.tabPageSettings.Text = "Ustawienia";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // checkBoxZNP
            // 
            this.checkBoxZNP.AutoSize = true;
            this.checkBoxZNP.Location = new System.Drawing.Point(7, 19);
            this.checkBoxZNP.Name = "checkBoxZNP";
            this.checkBoxZNP.Size = new System.Drawing.Size(127, 17);
            this.checkBoxZNP.TabIndex = 3;
            this.checkBoxZNP.Text = "Zmiana nazwy plików";
            this.checkBoxZNP.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxKrok);
            this.groupBox4.Controls.Add(this.textBoxPocz);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.textBoxNewName);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(6, 42);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(402, 132);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Zmiana nazw plików";
            // 
            // textBoxKrok
            // 
            this.textBoxKrok.Location = new System.Drawing.Point(72, 93);
            this.textBoxKrok.Name = "textBoxKrok";
            this.textBoxKrok.Size = new System.Drawing.Size(35, 20);
            this.textBoxKrok.TabIndex = 5;
            this.textBoxKrok.Text = "1";
            // 
            // textBoxPocz
            // 
            this.textBoxPocz.Location = new System.Drawing.Point(72, 66);
            this.textBoxPocz.Name = "textBoxPocz";
            this.textBoxPocz.Size = new System.Drawing.Size(35, 20);
            this.textBoxPocz.TabIndex = 4;
            this.textBoxPocz.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Krok:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Początek:";
            // 
            // textBoxNewName
            // 
            this.textBoxNewName.Location = new System.Drawing.Point(10, 36);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(386, 20);
            this.textBoxNewName.TabIndex = 1;
            this.textBoxNewName.Text = "#";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Szablon nazwy:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnFont);
            this.groupBox3.Location = new System.Drawing.Point(6, 180);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(117, 67);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ustawienia czcionki";
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(23, 19);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(70, 35);
            this.btnFont.TabIndex = 0;
            this.btnFont.Text = "Czcionka...";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.BtnFont_Click);
            // 
            // tabPageTekst
            // 
            this.tabPageTekst.Controls.Add(this.btnDevelop);
            this.tabPageTekst.Controls.Add(this.richTextBox1);
            this.tabPageTekst.Location = new System.Drawing.Point(4, 22);
            this.tabPageTekst.Name = "tabPageTekst";
            this.tabPageTekst.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTekst.Size = new System.Drawing.Size(414, 306);
            this.tabPageTekst.TabIndex = 2;
            this.tabPageTekst.Text = "Dodaj tekst";
            this.tabPageTekst.UseVisualStyleBackColor = true;
            // 
            // btnDevelop
            // 
            this.btnDevelop.Location = new System.Drawing.Point(374, 7);
            this.btnDevelop.Name = "btnDevelop";
            this.btnDevelop.Size = new System.Drawing.Size(34, 83);
            this.btnDevelop.TabIndex = 1;
            this.btnDevelop.Text = ">>";
            this.btnDevelop.UseVisualStyleBackColor = true;
            this.btnDevelop.Click += new System.EventHandler(this.BtnDevelop_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(361, 183);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RichTextBox1_MouseDown);
            // 
            // lblProgress
            // 
            this.lblProgress.Location = new System.Drawing.Point(12, 387);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(316, 23);
            this.lblProgress.TabIndex = 3;
            this.lblProgress.Text = "...";
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 361);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(316, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(334, 361);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Podpisz obrazy";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Pliki graficzne (PNG, JPG, JPEG, BMP)|*.png;*.jpg;*.jpeg;*.bmp|JPEG|*.jpg;*.jpeg;" +
    "*.jpe;*.jfif|PNG|*.png|BMP|*.bmp|Wszystkie pliki (*.*)|*.*";
            this.openFileDialog.Multiselect = true;
            this.openFileDialog.ReadOnlyChecked = true;
            // 
            // developMenuStrip
            // 
            this.developMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nazwaPlikuToolStripMenuItem});
            this.developMenuStrip.Name = "developMenuStrip";
            this.developMenuStrip.Size = new System.Drawing.Size(139, 26);
            // 
            // nazwaPlikuToolStripMenuItem
            // 
            this.nazwaPlikuToolStripMenuItem.Name = "nazwaPlikuToolStripMenuItem";
            this.nazwaPlikuToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.nazwaPlikuToolStripMenuItem.Text = "Nazwa pliku";
            this.nazwaPlikuToolStripMenuItem.Click += new System.EventHandler(this.FileName_ToolStripMenuItem_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 439);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wytnijToolStripMenuItem,
            this.kopiujToolStripMenuItem,
            this.wklejToolStripMenuItem,
            this.wyczyśćToolStripMenuItem,
            this.zaznaczWszystkoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(167, 114);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip1_Opening);
            // 
            // wytnijToolStripMenuItem
            // 
            this.wytnijToolStripMenuItem.Name = "wytnijToolStripMenuItem";
            this.wytnijToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.wytnijToolStripMenuItem.Text = "Wytnij";
            this.wytnijToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // kopiujToolStripMenuItem
            // 
            this.kopiujToolStripMenuItem.Name = "kopiujToolStripMenuItem";
            this.kopiujToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.kopiujToolStripMenuItem.Text = "Kopiuj";
            this.kopiujToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // wklejToolStripMenuItem
            // 
            this.wklejToolStripMenuItem.Name = "wklejToolStripMenuItem";
            this.wklejToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.wklejToolStripMenuItem.Text = "Wklej";
            this.wklejToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // wyczyśćToolStripMenuItem
            // 
            this.wyczyśćToolStripMenuItem.Name = "wyczyśćToolStripMenuItem";
            this.wyczyśćToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.wyczyśćToolStripMenuItem.Text = "Wyczyść";
            this.wyczyśćToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
            // 
            // zaznaczWszystkoToolStripMenuItem
            // 
            this.zaznaczWszystkoToolStripMenuItem.Name = "zaznaczWszystkoToolStripMenuItem";
            this.zaznaczWszystkoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.zaznaczWszystkoToolStripMenuItem.Text = "Zaznacz wszystko";
            this.zaznaczWszystkoToolStripMenuItem.Click += new System.EventHandler(this.SelectAllWszystkoToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Copyright 2018 Rafał Marzewski";
            // 
            // groupBox5
            // 
            this.groupBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox5.Location = new System.Drawing.Point(-33, 413);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(519, 26);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            // 
            // LabelImage
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(446, 439);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.groupBox5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LabelImage";
            this.Text = "Label Image v1.0";
            this.tabControl.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPageSettings.ResumeLayout(false);
            this.tabPageSettings.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabPageTekst.ResumeLayout(false);
            this.developMenuStrip.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.TabPage tabPageTekst;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ListBox fileListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelAll;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLblFolder;
        private System.Windows.Forms.TextBox folderTextBox;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Button btnDevelop;
        private System.Windows.Forms.ContextMenuStrip developMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem nazwaPlikuToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxKrok;
        private System.Windows.Forms.TextBox textBoxPocz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNewName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxZNP;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem wytnijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopiujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wklejToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyczyśćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaznaczWszystkoToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

