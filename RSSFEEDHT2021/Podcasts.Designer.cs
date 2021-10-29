
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
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ctgSaveTxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.upDateBox1 = new System.Windows.Forms.TextBox();
            this.episodeDesc = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.____ = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // urlTXT
            // 
            this.urlTXT.Location = new System.Drawing.Point(54, 287);
            this.urlTXT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.urlTXT.Name = "urlTXT";
            this.urlTXT.Size = new System.Drawing.Size(282, 26);
            this.urlTXT.TabIndex = 0;
            // 
            // EpisodeLBL
            // 
            this.EpisodeLBL.AutoSize = true;
            this.EpisodeLBL.Location = new System.Drawing.Point(50, 28);
            this.EpisodeLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EpisodeLBL.Name = "EpisodeLBL";
            this.EpisodeLBL.Size = new System.Drawing.Size(46, 20);
            this.EpisodeLBL.TabIndex = 2;
            this.EpisodeLBL.Text = "Feed";
            this.EpisodeLBL.Click += new System.EventHandler(this.label1_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 889);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // episodeBox
            // 
            this.episodeBox.FormattingEnabled = true;
            this.episodeBox.ItemHeight = 20;
            this.episodeBox.Location = new System.Drawing.Point(54, 558);
            this.episodeBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.episodeBox.Name = "episodeBox";
            this.episodeBox.Size = new System.Drawing.Size(654, 304);
            this.episodeBox.TabIndex = 4;
            // 
            // saveBTN
            // 
            this.saveBTN.Location = new System.Drawing.Point(359, 341);
            this.saveBTN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(153, 125);
            this.saveBTN.TabIndex = 8;
            this.saveBTN.Text = "Skapa";
            this.saveBTN.UseVisualStyleBackColor = true;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // deleteBTN
            // 
            this.deleteBTN.Location = new System.Drawing.Point(556, 341);
            this.deleteBTN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(153, 125);
            this.deleteBTN.TabIndex = 9;
            this.deleteBTN.Text = "Ta bort";
            this.deleteBTN.UseVisualStyleBackColor = true;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(788, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kategorier";
            // 
            // ctgSaveBTN
            // 
            this.ctgSaveBTN.Location = new System.Drawing.Point(1048, 369);
            this.ctgSaveBTN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctgSaveBTN.Name = "ctgSaveBTN";
            this.ctgSaveBTN.Size = new System.Drawing.Size(112, 31);
            this.ctgSaveBTN.TabIndex = 12;
            this.ctgSaveBTN.Text = "Spara";
            this.ctgSaveBTN.UseVisualStyleBackColor = true;
            this.ctgSaveBTN.Click += new System.EventHandler(this.ctgSaveBTN_Click);
            // 
            // ctgNewBTN
            // 
            this.ctgNewBTN.Location = new System.Drawing.Point(976, 306);
            this.ctgNewBTN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctgNewBTN.Name = "ctgNewBTN";
            this.ctgNewBTN.Size = new System.Drawing.Size(184, 31);
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
            this.FreqCombo.Location = new System.Drawing.Point(359, 287);
            this.FreqCombo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FreqCombo.Name = "FreqCombo";
            this.FreqCombo.Size = new System.Drawing.Size(154, 28);
            this.FreqCombo.TabIndex = 14;
            this.FreqCombo.SelectedIndexChanged += new System.EventHandler(this.FreqCombo_SelectedIndexChanged);
            // 
            // CategoryCombo
            // 
            this.CategoryCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryCombo.FormattingEnabled = true;
            this.CategoryCombo.Location = new System.Drawing.Point(555, 287);
            this.CategoryCombo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CategoryCombo.Name = "CategoryCombo";
            this.CategoryCombo.Size = new System.Drawing.Size(154, 28);
            this.CategoryCombo.TabIndex = 15;
            this.CategoryCombo.SelectedIndexChanged += new System.EventHandler(this.CategoryCombo_SelectedIndexChanged);
            // 
            // updFreqLBL
            // 
            this.updFreqLBL.AutoSize = true;
            this.updFreqLBL.Location = new System.Drawing.Point(354, 264);
            this.updFreqLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.updFreqLBL.Name = "updFreqLBL";
            this.updFreqLBL.Size = new System.Drawing.Size(169, 20);
            this.updFreqLBL.TabIndex = 16;
            this.updFreqLBL.Text = "Uppdateringsfrekvens:";
            // 
            // CategoryLBL2
            // 
            this.CategoryLBL2.AutoSize = true;
            this.CategoryLBL2.Location = new System.Drawing.Point(556, 264);
            this.CategoryLBL2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CategoryLBL2.Name = "CategoryLBL2";
            this.CategoryLBL2.Size = new System.Drawing.Size(72, 20);
            this.CategoryLBL2.TabIndex = 17;
            this.CategoryLBL2.Text = "Kategori:";
            // 
            // urlLBL
            // 
            this.urlLBL.AutoSize = true;
            this.urlLBL.Location = new System.Drawing.Point(50, 263);
            this.urlLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.urlLBL.Name = "urlLBL";
            this.urlLBL.Size = new System.Drawing.Size(46, 20);
            this.urlLBL.TabIndex = 18;
            this.urlLBL.Text = "URL:";
            this.urlLBL.Click += new System.EventHandler(this.label8_Click);
            // 
            // categoryBox
            // 
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.ItemHeight = 20;
            this.categoryBox.Location = new System.Drawing.Point(788, 52);
            this.categoryBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(370, 244);
            this.categoryBox.TabIndex = 19;
            this.categoryBox.SelectedIndexChanged += new System.EventHandler(this.categoryBox_SelectedIndexChanged);
            // 
            // epEpisodeLBL
            // 
            this.epEpisodeLBL.AutoSize = true;
            this.epEpisodeLBL.Location = new System.Drawing.Point(50, 535);
            this.epEpisodeLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.epEpisodeLBL.Name = "epEpisodeLBL";
            this.epEpisodeLBL.Size = new System.Drawing.Size(57, 20);
            this.epEpisodeLBL.TabIndex = 20;
            this.epEpisodeLBL.Text = "Avsnitt";
            // 
            // episodeInfoLBL
            // 
            this.episodeInfoLBL.AutoSize = true;
            this.episodeInfoLBL.Location = new System.Drawing.Point(788, 535);
            this.episodeInfoLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.episodeInfoLBL.Name = "episodeInfoLBL";
            this.episodeInfoLBL.Size = new System.Drawing.Size(57, 20);
            this.episodeInfoLBL.TabIndex = 22;
            this.episodeInfoLBL.Text = "Avsnitt";
            this.episodeInfoLBL.Click += new System.EventHandler(this.label10_Click);
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(0, 411);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.MaximumSize = new System.Drawing.Size(0, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 3);
            this.label12.TabIndex = 24;
            this.label12.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(784, 343);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Lägg till ny kategori:";
            // 
            // ctgSaveTxt
            // 
            this.ctgSaveTxt.Location = new System.Drawing.Point(786, 366);
            this.ctgSaveTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctgSaveTxt.Name = "ctgSaveTxt";
            this.ctgSaveTxt.Size = new System.Drawing.Size(254, 26);
            this.ctgSaveTxt.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(54, 52);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(654, 200);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Avsnitt";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 98;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Namn";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 140;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Frekvens";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Kategori";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 115;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(54, 347);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(282, 26);
            this.nameTxt.TabIndex = 28;
            this.nameTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 324);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Namn:";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(54, 393);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(284, 72);
            this.updateButton.TabIndex = 31;
            this.updateButton.Text = "Uppdatera podcast";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(788, 306);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 31);
            this.button1.TabIndex = 32;
            this.button1.Text = "Sortera";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1048, 434);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 31);
            this.button2.TabIndex = 33;
            this.button2.Text = "Uppdatera";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // upDateBox1
            // 
            this.upDateBox1.Location = new System.Drawing.Point(786, 439);
            this.upDateBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.upDateBox1.Name = "upDateBox1";
            this.upDateBox1.Size = new System.Drawing.Size(254, 26);
            this.upDateBox1.TabIndex = 34;
            // 
            // episodeDesc
            // 
            this.episodeDesc.FormattingEnabled = true;
            this.episodeDesc.ItemHeight = 20;
            this.episodeDesc.Location = new System.Drawing.Point(788, 558);
            this.episodeDesc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.episodeDesc.Name = "episodeDesc";
            this.episodeDesc.Size = new System.Drawing.Size(372, 304);
            this.episodeDesc.TabIndex = 35;
            this.episodeDesc.SelectedIndexChanged += new System.EventHandler(this.episodeDesc_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(784, 414);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Uppdatera kategorinamn:";
            // 
            // ____
            // 
            this.____.AutoSize = true;
            this.____.Location = new System.Drawing.Point(-4, 486);
            this.____.Name = "____";
            this.____.Size = new System.Drawing.Size(1341, 20);
            this.____.TabIndex = 37;
            this.____.Text = "_________________________________________________________________________________" +
    "___________________________________________________________________";
            // 
            // Podcasts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 889);
            this.Controls.Add(this.____);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.episodeDesc);
            this.Controls.Add(this.upDateBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ctgSaveTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
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
            this.Controls.Add(this.episodeBox);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.EpisodeLBL);
            this.Controls.Add(this.urlTXT);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Podcasts";
            this.Text = "RSS";
            this.Load += new System.EventHandler(this.Podcasts_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlTXT;
        private System.Windows.Forms.Label EpisodeLBL;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ListBox episodeBox;
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ctgSaveTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox upDateBox1;
        private System.Windows.Forms.ListBox episodeDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ____;
    }
}

