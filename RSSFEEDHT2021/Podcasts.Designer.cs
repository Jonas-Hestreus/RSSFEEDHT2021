
namespace PL
{
    partial class Podcasts
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
            this.urlTXT = new System.Windows.Forms.TextBox();
            this.EpisodeLBL = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.episodeBox = new System.Windows.Forms.ListBox();
            this.NameLBL = new System.Windows.Forms.Label();
            this.FreqLBL = new System.Windows.Forms.Label();
            this.CategoryLBL = new System.Windows.Forms.Label();
            this.saveBTN = new System.Windows.Forms.Button();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ctgSaveBTN = new System.Windows.Forms.Button();
            this.ctgNewBTN = new System.Windows.Forms.Button();
            this.FreqCombo = new System.Windows.Forms.ComboBox();
            this.CategoryCombo = new System.Windows.Forms.ComboBox();
            this.updFreqLBL = new System.Windows.Forms.Label();
            this.CategoryLBL2 = new System.Windows.Forms.Label();
            this.urlLBL = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.ListBox();
            this.epEpisodeLBL = new System.Windows.Forms.Label();
            this.episodeInfoLBL = new System.Windows.Forms.Label();
            this.episodeInfoText = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ctgSaveTxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // urlTXT
            // 
            this.urlTXT.Location = new System.Drawing.Point(102, 422);
            this.urlTXT.Margin = new System.Windows.Forms.Padding(6);
            this.urlTXT.Name = "urlTXT";
            this.urlTXT.Size = new System.Drawing.Size(379, 39);
            this.urlTXT.TabIndex = 0;
            // 
            // EpisodeLBL
            // 
            this.EpisodeLBL.AutoSize = true;
            this.EpisodeLBL.Location = new System.Drawing.Point(102, 45);
            this.EpisodeLBL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.EpisodeLBL.Name = "EpisodeLBL";
            this.EpisodeLBL.Size = new System.Drawing.Size(87, 32);
            this.EpisodeLBL.TabIndex = 2;
            this.EpisodeLBL.Text = "Avsnitt";
            this.EpisodeLBL.Click += new System.EventHandler(this.label1_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(6);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(6, 1310);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // episodeBox
            // 
            this.episodeBox.FormattingEnabled = true;
            this.episodeBox.ItemHeight = 32;
            this.episodeBox.Location = new System.Drawing.Point(100, 766);
            this.episodeBox.Margin = new System.Windows.Forms.Padding(6);
            this.episodeBox.Name = "episodeBox";
            this.episodeBox.Size = new System.Drawing.Size(918, 484);
            this.episodeBox.TabIndex = 4;
            // 
            // NameLBL
            // 
            this.NameLBL.AutoSize = true;
            this.NameLBL.Location = new System.Drawing.Point(217, 45);
            this.NameLBL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.NameLBL.Name = "NameLBL";
            this.NameLBL.Size = new System.Drawing.Size(79, 32);
            this.NameLBL.TabIndex = 5;
            this.NameLBL.Text = "Namn";
            this.NameLBL.Click += new System.EventHandler(this.NameLBL_Click);
            // 
            // FreqLBL
            // 
            this.FreqLBL.AutoSize = true;
            this.FreqLBL.Location = new System.Drawing.Point(544, 45);
            this.FreqLBL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.FreqLBL.Name = "FreqLBL";
            this.FreqLBL.Size = new System.Drawing.Size(108, 32);
            this.FreqLBL.TabIndex = 6;
            this.FreqLBL.Text = "Frekvens";
            // 
            // CategoryLBL
            // 
            this.CategoryLBL.AutoSize = true;
            this.CategoryLBL.Location = new System.Drawing.Point(780, 45);
            this.CategoryLBL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CategoryLBL.Name = "CategoryLBL";
            this.CategoryLBL.Size = new System.Drawing.Size(103, 32);
            this.CategoryLBL.TabIndex = 7;
            this.CategoryLBL.Text = "Kategori";
            // 
            // saveBTN
            // 
            this.saveBTN.Location = new System.Drawing.Point(676, 484);
            this.saveBTN.Margin = new System.Windows.Forms.Padding(6);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(160, 49);
            this.saveBTN.TabIndex = 8;
            this.saveBTN.Text = "Skapa";
            this.saveBTN.UseVisualStyleBackColor = true;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // deleteBTN
            // 
            this.deleteBTN.Location = new System.Drawing.Point(847, 484);
            this.deleteBTN.Margin = new System.Windows.Forms.Padding(6);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(176, 49);
            this.deleteBTN.TabIndex = 9;
            this.deleteBTN.Text = "Ta bort";
            this.deleteBTN.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1138, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kategorier";
            // 
            // ctgSaveBTN
            // 
            this.ctgSaveBTN.Location = new System.Drawing.Point(1551, 638);
            this.ctgSaveBTN.Margin = new System.Windows.Forms.Padding(6);
            this.ctgSaveBTN.Name = "ctgSaveBTN";
            this.ctgSaveBTN.Size = new System.Drawing.Size(124, 49);
            this.ctgSaveBTN.TabIndex = 12;
            this.ctgSaveBTN.Text = "Spara";
            this.ctgSaveBTN.UseVisualStyleBackColor = true;
            this.ctgSaveBTN.Click += new System.EventHandler(this.ctgSaveBTN_Click);
            // 
            // ctgNewBTN
            // 
            this.ctgNewBTN.Location = new System.Drawing.Point(1138, 489);
            this.ctgNewBTN.Margin = new System.Windows.Forms.Padding(6);
            this.ctgNewBTN.Name = "ctgNewBTN";
            this.ctgNewBTN.Size = new System.Drawing.Size(537, 49);
            this.ctgNewBTN.TabIndex = 11;
            this.ctgNewBTN.Text = "Ta bort markerad kategori";
            this.ctgNewBTN.UseVisualStyleBackColor = true;
            this.ctgNewBTN.Click += new System.EventHandler(this.ctgNewBTN_Click);
            // 
            // FreqCombo
            // 
            this.FreqCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FreqCombo.FormattingEnabled = true;
            this.FreqCombo.Items.AddRange(new object[] {
            "Varje minut",
            "Var 5:e minut",
            "Var 10:e minut"});
            this.FreqCombo.Location = new System.Drawing.Point(516, 422);
            this.FreqCombo.Margin = new System.Windows.Forms.Padding(6);
            this.FreqCombo.Name = "FreqCombo";
            this.FreqCombo.Size = new System.Drawing.Size(221, 40);
            this.FreqCombo.TabIndex = 14;
            this.FreqCombo.SelectedIndexChanged += new System.EventHandler(this.FreqCombo_SelectedIndexChanged);
            // 
            // CategoryCombo
            // 
            this.CategoryCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryCombo.FormattingEnabled = true;
            this.CategoryCombo.Location = new System.Drawing.Point(799, 422);
            this.CategoryCombo.Margin = new System.Windows.Forms.Padding(6);
            this.CategoryCombo.Name = "CategoryCombo";
            this.CategoryCombo.Size = new System.Drawing.Size(221, 40);
            this.CategoryCombo.TabIndex = 15;
            this.CategoryCombo.SelectedIndexChanged += new System.EventHandler(this.CategoryCombo_SelectedIndexChanged);
            // 
            // updFreqLBL
            // 
            this.updFreqLBL.AutoSize = true;
            this.updFreqLBL.Location = new System.Drawing.Point(509, 384);
            this.updFreqLBL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.updFreqLBL.Name = "updFreqLBL";
            this.updFreqLBL.Size = new System.Drawing.Size(252, 32);
            this.updFreqLBL.TabIndex = 16;
            this.updFreqLBL.Text = "Uppdateringsfrekvens:";
            // 
            // CategoryLBL2
            // 
            this.CategoryLBL2.AutoSize = true;
            this.CategoryLBL2.Location = new System.Drawing.Point(799, 384);
            this.CategoryLBL2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CategoryLBL2.Name = "CategoryLBL2";
            this.CategoryLBL2.Size = new System.Drawing.Size(108, 32);
            this.CategoryLBL2.TabIndex = 17;
            this.CategoryLBL2.Text = "Kategori:";
            // 
            // urlLBL
            // 
            this.urlLBL.AutoSize = true;
            this.urlLBL.Location = new System.Drawing.Point(102, 384);
            this.urlLBL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.urlLBL.Name = "urlLBL";
            this.urlLBL.Size = new System.Drawing.Size(60, 32);
            this.urlLBL.TabIndex = 18;
            this.urlLBL.Text = "URL:";
            this.urlLBL.Click += new System.EventHandler(this.label8_Click);
            // 
            // categoryBox
            // 
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.ItemHeight = 32;
            this.categoryBox.Location = new System.Drawing.Point(1138, 83);
            this.categoryBox.Margin = new System.Windows.Forms.Padding(6);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(533, 388);
            this.categoryBox.TabIndex = 19;
            this.categoryBox.SelectedIndexChanged += new System.EventHandler(this.categoryBox_SelectedIndexChanged);
            // 
            // epEpisodeLBL
            // 
            this.epEpisodeLBL.AutoSize = true;
            this.epEpisodeLBL.Location = new System.Drawing.Point(100, 734);
            this.epEpisodeLBL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.epEpisodeLBL.Name = "epEpisodeLBL";
            this.epEpisodeLBL.Size = new System.Drawing.Size(87, 32);
            this.epEpisodeLBL.TabIndex = 20;
            this.epEpisodeLBL.Text = "Avsnitt";
            // 
            // episodeInfoLBL
            // 
            this.episodeInfoLBL.AutoSize = true;
            this.episodeInfoLBL.Location = new System.Drawing.Point(1142, 734);
            this.episodeInfoLBL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.episodeInfoLBL.Name = "episodeInfoLBL";
            this.episodeInfoLBL.Size = new System.Drawing.Size(87, 32);
            this.episodeInfoLBL.TabIndex = 22;
            this.episodeInfoLBL.Text = "Avsnitt";
            this.episodeInfoLBL.Click += new System.EventHandler(this.label10_Click);
            // 
            // episodeInfoText
            // 
            this.episodeInfoText.AutoSize = true;
            this.episodeInfoText.Location = new System.Drawing.Point(1142, 785);
            this.episodeInfoText.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.episodeInfoText.Name = "episodeInfoText";
            this.episodeInfoText.Size = new System.Drawing.Size(87, 32);
            this.episodeInfoText.TabIndex = 23;
            this.episodeInfoText.Text = "Avsnitt";
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(0, 657);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.MaximumSize = new System.Drawing.Size(0, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 4);
            this.label12.TabIndex = 24;
            this.label12.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1138, 591);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 32);
            this.label1.TabIndex = 25;
            this.label1.Text = "Lägg till ny kategori:";
            // 
            // ctgSaveTxt
            // 
            this.ctgSaveTxt.Location = new System.Drawing.Point(1138, 638);
            this.ctgSaveTxt.Margin = new System.Windows.Forms.Padding(6);
            this.ctgSaveTxt.Name = "ctgSaveTxt";
            this.ctgSaveTxt.Size = new System.Drawing.Size(398, 39);
            this.ctgSaveTxt.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(74, 45);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(949, 320);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Avsnitt";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.Width = 98;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Namn";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.Width = 140;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Frekvens";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            this.Column3.Width = 115;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Kategori";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            this.Column4.Width = 115;
            // 
            // Podcasts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1748, 1310);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ctgSaveTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.episodeInfoText);
            this.Controls.Add(this.episodeInfoLBL);
            this.Controls.Add(this.epEpisodeLBL);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.urlLBL);
            this.Controls.Add(this.CategoryLBL2);
            this.Controls.Add(this.updFreqLBL);
            this.Controls.Add(this.CategoryCombo);
            this.Controls.Add(this.FreqCombo);
            this.Controls.Add(this.ctgSaveBTN);
            this.Controls.Add(this.ctgNewBTN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.saveBTN);
            this.Controls.Add(this.CategoryLBL);
            this.Controls.Add(this.FreqLBL);
            this.Controls.Add(this.NameLBL);
            this.Controls.Add(this.episodeBox);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.EpisodeLBL);
            this.Controls.Add(this.urlTXT);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Podcasts";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlTXT;
        private System.Windows.Forms.Label EpisodeLBL;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ListBox episodeBox;
        private System.Windows.Forms.Label NameLBL;
        private System.Windows.Forms.Label FreqLBL;
        private System.Windows.Forms.Label CategoryLBL;
        private System.Windows.Forms.Button saveBTN;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ctgSaveBTN;
        private System.Windows.Forms.Button ctgNewBTN;
        private System.Windows.Forms.ComboBox FreqCombo;
        private System.Windows.Forms.ComboBox CategoryCombo;
        private System.Windows.Forms.Label updFreqLBL;
        private System.Windows.Forms.Label CategoryLBL2;
        private System.Windows.Forms.Label urlLBL;
        private System.Windows.Forms.ListBox categoryBox;
        private System.Windows.Forms.Label epEpisodeLBL;
        private System.Windows.Forms.Label episodeInfoLBL;
        private System.Windows.Forms.Label episodeInfoText;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ctgSaveTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

