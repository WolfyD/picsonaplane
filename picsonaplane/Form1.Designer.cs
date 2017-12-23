namespace picsonaplane
{
	partial class Form1
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
			this.ms_Menu = new System.Windows.Forms.MenuStrip();
			this.tmi_File = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Menu_OpenPics = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btn_Menu_GenPDF = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Menu_GenIMG = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Menu_GenHTML = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btn_Menu_Preview = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Menu_Generate = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.btn_Menu_Exit = new System.Windows.Forms.ToolStripMenuItem();
			this.tmi_PageSize = new System.Windows.Forms.ToolStripMenuItem();
			this.cb_DPI = new System.Windows.Forms.ToolStripComboBox();
			this.btn_OpenPics = new System.Windows.Forms.Button();
			this.lv_PicList = new System.Windows.Forms.ListView();
			this.ch_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.rb_PDF = new System.Windows.Forms.RadioButton();
			this.rb_IMG = new System.Windows.Forms.RadioButton();
			this.btn_Preview = new System.Windows.Forms.Button();
			this.btn_GenFiles = new System.Windows.Forms.Button();
			this.btn_Exit = new System.Windows.Forms.Button();
			this.rb_HTML = new System.Windows.Forms.RadioButton();
			this.p_Drop = new System.Windows.Forms.Panel();
			this.cb_OneCol = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cb_Scheme = new System.Windows.Forms.ComboBox();
			this.pb_Scheme = new System.Windows.Forms.PictureBox();
			this.cb_BlackBG = new System.Windows.Forms.CheckBox();
			this.p_Preview = new System.Windows.Forms.Panel();
			this.cb_Borders = new System.Windows.Forms.CheckBox();
			this.btn_DELETE = new System.Windows.Forms.Button();
			this.btn_UP = new System.Windows.Forms.Button();
			this.btn_DOWN = new System.Windows.Forms.Button();
			this.btn_Rand = new System.Windows.Forms.Button();
			this.ms_Menu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pb_Scheme)).BeginInit();
			this.SuspendLayout();
			// 
			// ms_Menu
			// 
			this.ms_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmi_File,
            this.tmi_PageSize,
            this.cb_DPI});
			this.ms_Menu.Location = new System.Drawing.Point(0, 0);
			this.ms_Menu.Name = "ms_Menu";
			this.ms_Menu.Size = new System.Drawing.Size(651, 27);
			this.ms_Menu.TabIndex = 0;
			// 
			// tmi_File
			// 
			this.tmi_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Menu_OpenPics,
            this.toolStripSeparator1,
            this.btn_Menu_GenPDF,
            this.btn_Menu_GenIMG,
            this.btn_Menu_GenHTML,
            this.toolStripSeparator2,
            this.btn_Menu_Preview,
            this.btn_Menu_Generate,
            this.toolStripSeparator3,
            this.btn_Menu_Exit});
			this.tmi_File.Name = "tmi_File";
			this.tmi_File.Size = new System.Drawing.Size(37, 23);
			this.tmi_File.Text = "File";
			// 
			// btn_Menu_OpenPics
			// 
			this.btn_Menu_OpenPics.Name = "btn_Menu_OpenPics";
			this.btn_Menu_OpenPics.Size = new System.Drawing.Size(157, 22);
			this.btn_Menu_OpenPics.Text = "Open Picture(s)";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(154, 6);
			// 
			// btn_Menu_GenPDF
			// 
			this.btn_Menu_GenPDF.Name = "btn_Menu_GenPDF";
			this.btn_Menu_GenPDF.Size = new System.Drawing.Size(157, 22);
			this.btn_Menu_GenPDF.Text = "Generate PDF";
			// 
			// btn_Menu_GenIMG
			// 
			this.btn_Menu_GenIMG.Name = "btn_Menu_GenIMG";
			this.btn_Menu_GenIMG.Size = new System.Drawing.Size(157, 22);
			this.btn_Menu_GenIMG.Text = "Generate IMG";
			// 
			// btn_Menu_GenHTML
			// 
			this.btn_Menu_GenHTML.Name = "btn_Menu_GenHTML";
			this.btn_Menu_GenHTML.Size = new System.Drawing.Size(157, 22);
			this.btn_Menu_GenHTML.Text = "Generate HTML";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(154, 6);
			// 
			// btn_Menu_Preview
			// 
			this.btn_Menu_Preview.Name = "btn_Menu_Preview";
			this.btn_Menu_Preview.Size = new System.Drawing.Size(157, 22);
			this.btn_Menu_Preview.Text = "Preview";
			// 
			// btn_Menu_Generate
			// 
			this.btn_Menu_Generate.Name = "btn_Menu_Generate";
			this.btn_Menu_Generate.Size = new System.Drawing.Size(157, 22);
			this.btn_Menu_Generate.Text = "Generate";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(154, 6);
			// 
			// btn_Menu_Exit
			// 
			this.btn_Menu_Exit.Name = "btn_Menu_Exit";
			this.btn_Menu_Exit.Size = new System.Drawing.Size(157, 22);
			this.btn_Menu_Exit.Text = "Exit";
			// 
			// tmi_PageSize
			// 
			this.tmi_PageSize.Enabled = false;
			this.tmi_PageSize.Name = "tmi_PageSize";
			this.tmi_PageSize.Size = new System.Drawing.Size(74, 23);
			this.tmi_PageSize.Text = "Page Size: ";
			// 
			// cb_DPI
			// 
			this.cb_DPI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_DPI.Items.AddRange(new object[] {
            "72 DPI",
            "100 DPI",
            "140 DPI",
            "200 DPI",
            "300 DPI",
            "400 DPI",
            "600 DPI",
            "1200 DPI"});
			this.cb_DPI.Name = "cb_DPI";
			this.cb_DPI.Size = new System.Drawing.Size(121, 23);
			this.cb_DPI.SelectedIndexChanged += new System.EventHandler(this.cb_DPI_SelectedIndexChanged);
			// 
			// btn_OpenPics
			// 
			this.btn_OpenPics.Location = new System.Drawing.Point(12, 27);
			this.btn_OpenPics.Name = "btn_OpenPics";
			this.btn_OpenPics.Size = new System.Drawing.Size(244, 23);
			this.btn_OpenPics.TabIndex = 1;
			this.btn_OpenPics.Text = "Open Picture(s)";
			this.btn_OpenPics.UseVisualStyleBackColor = true;
			this.btn_OpenPics.Click += new System.EventHandler(this.btn_OpenPics_Click);
			// 
			// lv_PicList
			// 
			this.lv_PicList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lv_PicList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_ID,
            this.ch_Name,
            this.ch_Size});
			this.lv_PicList.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lv_PicList.FullRowSelect = true;
			this.lv_PicList.GridLines = true;
			this.lv_PicList.Location = new System.Drawing.Point(262, 27);
			this.lv_PicList.Name = "lv_PicList";
			this.lv_PicList.Size = new System.Drawing.Size(377, 210);
			this.lv_PicList.TabIndex = 2;
			this.lv_PicList.UseCompatibleStateImageBehavior = false;
			this.lv_PicList.View = System.Windows.Forms.View.Details;
			this.lv_PicList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_PicList_ItemSelectionChanged);
			this.lv_PicList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lv_PicList_KeyDown);
			this.lv_PicList.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lv_PicList_KeyUp);
			// 
			// ch_ID
			// 
			this.ch_ID.Text = "#";
			this.ch_ID.Width = 34;
			// 
			// ch_Name
			// 
			this.ch_Name.Text = "Name";
			this.ch_Name.Width = 217;
			// 
			// ch_Size
			// 
			this.ch_Size.Text = "Size";
			this.ch_Size.Width = 108;
			// 
			// rb_PDF
			// 
			this.rb_PDF.AutoSize = true;
			this.rb_PDF.Checked = true;
			this.rb_PDF.Location = new System.Drawing.Point(12, 65);
			this.rb_PDF.Name = "rb_PDF";
			this.rb_PDF.Size = new System.Drawing.Size(46, 17);
			this.rb_PDF.TabIndex = 5;
			this.rb_PDF.TabStop = true;
			this.rb_PDF.Text = "PDF";
			this.rb_PDF.UseVisualStyleBackColor = true;
			this.rb_PDF.CheckedChanged += new System.EventHandler(this.rb_PDF_CheckedChanged);
			// 
			// rb_IMG
			// 
			this.rb_IMG.AutoSize = true;
			this.rb_IMG.Location = new System.Drawing.Point(12, 85);
			this.rb_IMG.Name = "rb_IMG";
			this.rb_IMG.Size = new System.Drawing.Size(54, 17);
			this.rb_IMG.TabIndex = 6;
			this.rb_IMG.Text = "Image";
			this.rb_IMG.UseVisualStyleBackColor = true;
			this.rb_IMG.CheckedChanged += new System.EventHandler(this.rb_PDF_CheckedChanged);
			// 
			// btn_Preview
			// 
			this.btn_Preview.Enabled = false;
			this.btn_Preview.Location = new System.Drawing.Point(12, 214);
			this.btn_Preview.Name = "btn_Preview";
			this.btn_Preview.Size = new System.Drawing.Size(114, 23);
			this.btn_Preview.TabIndex = 7;
			this.btn_Preview.Text = "Preview";
			this.btn_Preview.UseVisualStyleBackColor = true;
			this.btn_Preview.Click += new System.EventHandler(this.btn_Preview_Click);
			// 
			// btn_GenFiles
			// 
			this.btn_GenFiles.Enabled = false;
			this.btn_GenFiles.Location = new System.Drawing.Point(12, 243);
			this.btn_GenFiles.Name = "btn_GenFiles";
			this.btn_GenFiles.Size = new System.Drawing.Size(244, 23);
			this.btn_GenFiles.TabIndex = 8;
			this.btn_GenFiles.Text = "Generate Files";
			this.btn_GenFiles.UseVisualStyleBackColor = true;
			this.btn_GenFiles.Click += new System.EventHandler(this.btn_GenFiles_Click);
			// 
			// btn_Exit
			// 
			this.btn_Exit.Location = new System.Drawing.Point(12, 272);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.Size = new System.Drawing.Size(244, 23);
			this.btn_Exit.TabIndex = 9;
			this.btn_Exit.Text = "Exit";
			this.btn_Exit.UseVisualStyleBackColor = true;
			this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
			// 
			// rb_HTML
			// 
			this.rb_HTML.AutoSize = true;
			this.rb_HTML.Location = new System.Drawing.Point(12, 105);
			this.rb_HTML.Name = "rb_HTML";
			this.rb_HTML.Size = new System.Drawing.Size(55, 17);
			this.rb_HTML.TabIndex = 10;
			this.rb_HTML.Text = "HTML";
			this.rb_HTML.UseVisualStyleBackColor = true;
			this.rb_HTML.CheckedChanged += new System.EventHandler(this.rb_PDF_CheckedChanged);
			// 
			// p_Drop
			// 
			this.p_Drop.AllowDrop = true;
			this.p_Drop.Location = new System.Drawing.Point(0, 27);
			this.p_Drop.Name = "p_Drop";
			this.p_Drop.Size = new System.Drawing.Size(10, 30);
			this.p_Drop.TabIndex = 11;
			this.p_Drop.DragDrop += new System.Windows.Forms.DragEventHandler(this.p_Drop_DragDrop);
			this.p_Drop.DragEnter += new System.Windows.Forms.DragEventHandler(this.p_Drop_DragEnter);
			// 
			// cb_OneCol
			// 
			this.cb_OneCol.AutoSize = true;
			this.cb_OneCol.Enabled = false;
			this.cb_OneCol.Location = new System.Drawing.Point(12, 135);
			this.cb_OneCol.Name = "cb_OneCol";
			this.cb_OneCol.Size = new System.Drawing.Size(84, 17);
			this.cb_OneCol.TabIndex = 12;
			this.cb_OneCol.Text = "One Column";
			this.cb_OneCol.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(129, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 13);
			this.label2.TabIndex = 13;
			this.label2.Text = "Layout: ";
			// 
			// cb_Scheme
			// 
			this.cb_Scheme.FormattingEnabled = true;
			this.cb_Scheme.Items.AddRange(new object[] {
            "3/2/3",
            "2/3/2",
            "3/3/3",
            "4/3/4",
            "2/1/2",
            "3/1/3",
            "1/3/3",
            "1/3/4"});
			this.cb_Scheme.Location = new System.Drawing.Point(187, 61);
			this.cb_Scheme.Name = "cb_Scheme";
			this.cb_Scheme.Size = new System.Drawing.Size(69, 21);
			this.cb_Scheme.TabIndex = 14;
			this.cb_Scheme.SelectedIndexChanged += new System.EventHandler(this.cb_Scheme_SelectedIndexChanged);
			// 
			// pb_Scheme
			// 
			this.pb_Scheme.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.pb_Scheme.Cursor = System.Windows.Forms.Cursors.Help;
			this.pb_Scheme.Location = new System.Drawing.Point(132, 88);
			this.pb_Scheme.Name = "pb_Scheme";
			this.pb_Scheme.Size = new System.Drawing.Size(124, 149);
			this.pb_Scheme.TabIndex = 15;
			this.pb_Scheme.TabStop = false;
			this.pb_Scheme.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_Scheme_MouseDown);
			this.pb_Scheme.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_Scheme_MouseUp);
			// 
			// cb_BlackBG
			// 
			this.cb_BlackBG.AutoSize = true;
			this.cb_BlackBG.Location = new System.Drawing.Point(12, 158);
			this.cb_BlackBG.Name = "cb_BlackBG";
			this.cb_BlackBG.Size = new System.Drawing.Size(114, 17);
			this.cb_BlackBG.TabIndex = 16;
			this.cb_BlackBG.Text = "Black Background";
			this.cb_BlackBG.UseVisualStyleBackColor = true;
			this.cb_BlackBG.CheckedChanged += new System.EventHandler(this.cb_BlackBG_CheckedChanged);
			// 
			// p_Preview
			// 
			this.p_Preview.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.p_Preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.p_Preview.Dock = System.Windows.Forms.DockStyle.Right;
			this.p_Preview.Location = new System.Drawing.Point(624, 27);
			this.p_Preview.Name = "p_Preview";
			this.p_Preview.Size = new System.Drawing.Size(27, 275);
			this.p_Preview.TabIndex = 17;
			this.p_Preview.Visible = false;
			this.p_Preview.SizeChanged += new System.EventHandler(this.p_Preview_SizeChanged);
			// 
			// cb_Borders
			// 
			this.cb_Borders.AutoSize = true;
			this.cb_Borders.Location = new System.Drawing.Point(12, 181);
			this.cb_Borders.Name = "cb_Borders";
			this.cb_Borders.Size = new System.Drawing.Size(90, 17);
			this.cb_Borders.TabIndex = 18;
			this.cb_Borders.Text = "Draw Borders";
			this.cb_Borders.UseVisualStyleBackColor = true;
			this.cb_Borders.CheckedChanged += new System.EventHandler(this.cb_Borders_CheckedChanged);
			// 
			// btn_DELETE
			// 
			this.btn_DELETE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_DELETE.Location = new System.Drawing.Point(262, 243);
			this.btn_DELETE.Name = "btn_DELETE";
			this.btn_DELETE.Size = new System.Drawing.Size(85, 23);
			this.btn_DELETE.TabIndex = 19;
			this.btn_DELETE.Text = "Delete";
			this.btn_DELETE.UseVisualStyleBackColor = true;
			this.btn_DELETE.Click += new System.EventHandler(this.btn_DELETE_Click);
			// 
			// btn_UP
			// 
			this.btn_UP.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btn_UP.Location = new System.Drawing.Point(374, 243);
			this.btn_UP.Name = "btn_UP";
			this.btn_UP.Size = new System.Drawing.Size(75, 23);
			this.btn_UP.TabIndex = 20;
			this.btn_UP.Text = "UP";
			this.btn_UP.UseVisualStyleBackColor = true;
			this.btn_UP.Click += new System.EventHandler(this.btn_UP_Click);
			// 
			// btn_DOWN
			// 
			this.btn_DOWN.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btn_DOWN.Location = new System.Drawing.Point(452, 243);
			this.btn_DOWN.Name = "btn_DOWN";
			this.btn_DOWN.Size = new System.Drawing.Size(75, 23);
			this.btn_DOWN.TabIndex = 21;
			this.btn_DOWN.Text = "DOWN";
			this.btn_DOWN.UseVisualStyleBackColor = true;
			this.btn_DOWN.Click += new System.EventHandler(this.btn_DOWN_Click);
			// 
			// btn_Rand
			// 
			this.btn_Rand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Rand.Location = new System.Drawing.Point(554, 243);
			this.btn_Rand.Name = "btn_Rand";
			this.btn_Rand.Size = new System.Drawing.Size(85, 23);
			this.btn_Rand.TabIndex = 22;
			this.btn_Rand.Text = "Randomize";
			this.btn_Rand.UseVisualStyleBackColor = true;
			this.btn_Rand.Click += new System.EventHandler(this.btn_Rand_Click);
			// 
			// Form1
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(651, 302);
			this.Controls.Add(this.p_Preview);
			this.Controls.Add(this.p_Drop);
			this.Controls.Add(this.btn_Rand);
			this.Controls.Add(this.btn_DOWN);
			this.Controls.Add(this.btn_UP);
			this.Controls.Add(this.btn_DELETE);
			this.Controls.Add(this.cb_Borders);
			this.Controls.Add(this.cb_BlackBG);
			this.Controls.Add(this.pb_Scheme);
			this.Controls.Add(this.cb_Scheme);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cb_OneCol);
			this.Controls.Add(this.rb_HTML);
			this.Controls.Add(this.btn_Exit);
			this.Controls.Add(this.btn_GenFiles);
			this.Controls.Add(this.btn_Preview);
			this.Controls.Add(this.rb_IMG);
			this.Controls.Add(this.rb_PDF);
			this.Controls.Add(this.lv_PicList);
			this.Controls.Add(this.btn_OpenPics);
			this.Controls.Add(this.ms_Menu);
			this.MainMenuStrip = this.ms_Menu;
			this.Name = "Form1";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pics on a Plane";
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
			this.DragLeave += new System.EventHandler(this.Form1_DragLeave);
			this.ms_Menu.ResumeLayout(false);
			this.ms_Menu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pb_Scheme)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip ms_Menu;
		private System.Windows.Forms.ToolStripMenuItem tmi_File;
		private System.Windows.Forms.ToolStripMenuItem btn_Menu_OpenPics;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem btn_Menu_GenPDF;
		private System.Windows.Forms.ToolStripMenuItem btn_Menu_GenIMG;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem btn_Menu_Preview;
		private System.Windows.Forms.ToolStripMenuItem btn_Menu_Generate;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem btn_Menu_Exit;
		private System.Windows.Forms.Button btn_OpenPics;
		private System.Windows.Forms.ListView lv_PicList;
		private System.Windows.Forms.ColumnHeader ch_ID;
		private System.Windows.Forms.ColumnHeader ch_Name;
		private System.Windows.Forms.ColumnHeader ch_Size;
		private System.Windows.Forms.RadioButton rb_PDF;
		private System.Windows.Forms.RadioButton rb_IMG;
		private System.Windows.Forms.Button btn_Preview;
		private System.Windows.Forms.Button btn_GenFiles;
		private System.Windows.Forms.Button btn_Exit;
		private System.Windows.Forms.RadioButton rb_HTML;
		private System.Windows.Forms.Panel p_Drop;
		private System.Windows.Forms.CheckBox cb_OneCol;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cb_Scheme;
		private System.Windows.Forms.PictureBox pb_Scheme;
		private System.Windows.Forms.ToolStripMenuItem tmi_PageSize;
		private System.Windows.Forms.ToolStripComboBox cb_DPI;
		private System.Windows.Forms.ToolStripMenuItem btn_Menu_GenHTML;
		private System.Windows.Forms.CheckBox cb_BlackBG;
		private System.Windows.Forms.Panel p_Preview;
		private System.Windows.Forms.CheckBox cb_Borders;
		private System.Windows.Forms.Button btn_DELETE;
		private System.Windows.Forms.Button btn_UP;
		private System.Windows.Forms.Button btn_DOWN;
		private System.Windows.Forms.Button btn_Rand;
	}
}

