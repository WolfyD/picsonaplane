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
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.openFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.generatePDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.generateIMGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.previewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_OpenPics = new System.Windows.Forms.Button();
			this.lv_PicList = new System.Windows.Forms.ListView();
			this.ch_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label1 = new System.Windows.Forms.Label();
			this.num_NumOfPages = new System.Windows.Forms.NumericUpDown();
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
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.num_MarginSize = new System.Windows.Forms.NumericUpDown();
			this.num_PaddingSize = new System.Windows.Forms.NumericUpDown();
			this.ms_Menu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_NumOfPages)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_Scheme)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_MarginSize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_PaddingSize)).BeginInit();
			this.SuspendLayout();
			// 
			// ms_Menu
			// 
			this.ms_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
			this.ms_Menu.Location = new System.Drawing.Point(0, 0);
			this.ms_Menu.Name = "ms_Menu";
			this.ms_Menu.Size = new System.Drawing.Size(651, 24);
			this.ms_Menu.TabIndex = 0;
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFilesToolStripMenuItem,
            this.toolStripSeparator1,
            this.generatePDFToolStripMenuItem,
            this.generateIMGToolStripMenuItem,
            this.toolStripSeparator2,
            this.previewToolStripMenuItem,
            this.generateToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
			this.toolStripMenuItem1.Text = "File";
			// 
			// openFilesToolStripMenuItem
			// 
			this.openFilesToolStripMenuItem.Name = "openFilesToolStripMenuItem";
			this.openFilesToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
			this.openFilesToolStripMenuItem.Text = "Open Picture(s)";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(153, 6);
			// 
			// generatePDFToolStripMenuItem
			// 
			this.generatePDFToolStripMenuItem.Name = "generatePDFToolStripMenuItem";
			this.generatePDFToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
			this.generatePDFToolStripMenuItem.Text = "Generate PDF";
			// 
			// generateIMGToolStripMenuItem
			// 
			this.generateIMGToolStripMenuItem.Name = "generateIMGToolStripMenuItem";
			this.generateIMGToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
			this.generateIMGToolStripMenuItem.Text = "Generate IMG";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(153, 6);
			// 
			// previewToolStripMenuItem
			// 
			this.previewToolStripMenuItem.Name = "previewToolStripMenuItem";
			this.previewToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
			this.previewToolStripMenuItem.Text = "Preview";
			// 
			// generateToolStripMenuItem
			// 
			this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
			this.generateToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
			this.generateToolStripMenuItem.Text = "Generate";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(153, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			// 
			// btn_OpenPics
			// 
			this.btn_OpenPics.Location = new System.Drawing.Point(12, 27);
			this.btn_OpenPics.Name = "btn_OpenPics";
			this.btn_OpenPics.Size = new System.Drawing.Size(244, 23);
			this.btn_OpenPics.TabIndex = 1;
			this.btn_OpenPics.Text = "Open Picture(s)";
			this.btn_OpenPics.UseVisualStyleBackColor = true;
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
			this.lv_PicList.Size = new System.Drawing.Size(377, 250);
			this.lv_PicList.TabIndex = 2;
			this.lv_PicList.UseCompatibleStateImageBehavior = false;
			this.lv_PicList.View = System.Windows.Forms.View.Details;
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "# of pages:";
			// 
			// num_NumOfPages
			// 
			this.num_NumOfPages.Location = new System.Drawing.Point(74, 62);
			this.num_NumOfPages.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.num_NumOfPages.Name = "num_NumOfPages";
			this.num_NumOfPages.Size = new System.Drawing.Size(52, 20);
			this.num_NumOfPages.TabIndex = 4;
			this.num_NumOfPages.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// rb_PDF
			// 
			this.rb_PDF.AutoSize = true;
			this.rb_PDF.Checked = true;
			this.rb_PDF.Location = new System.Drawing.Point(15, 90);
			this.rb_PDF.Name = "rb_PDF";
			this.rb_PDF.Size = new System.Drawing.Size(46, 17);
			this.rb_PDF.TabIndex = 5;
			this.rb_PDF.TabStop = true;
			this.rb_PDF.Text = "PDF";
			this.rb_PDF.UseVisualStyleBackColor = true;
			// 
			// rb_IMG
			// 
			this.rb_IMG.AutoSize = true;
			this.rb_IMG.Location = new System.Drawing.Point(15, 110);
			this.rb_IMG.Name = "rb_IMG";
			this.rb_IMG.Size = new System.Drawing.Size(54, 17);
			this.rb_IMG.TabIndex = 6;
			this.rb_IMG.Text = "Image";
			this.rb_IMG.UseVisualStyleBackColor = true;
			// 
			// btn_Preview
			// 
			this.btn_Preview.Location = new System.Drawing.Point(12, 225);
			this.btn_Preview.Name = "btn_Preview";
			this.btn_Preview.Size = new System.Drawing.Size(114, 23);
			this.btn_Preview.TabIndex = 7;
			this.btn_Preview.Text = "Preview";
			this.btn_Preview.UseVisualStyleBackColor = true;
			// 
			// btn_GenFiles
			// 
			this.btn_GenFiles.Location = new System.Drawing.Point(142, 225);
			this.btn_GenFiles.Name = "btn_GenFiles";
			this.btn_GenFiles.Size = new System.Drawing.Size(114, 23);
			this.btn_GenFiles.TabIndex = 8;
			this.btn_GenFiles.Text = "Generate Files";
			this.btn_GenFiles.UseVisualStyleBackColor = true;
			// 
			// btn_Exit
			// 
			this.btn_Exit.Location = new System.Drawing.Point(12, 254);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.Size = new System.Drawing.Size(244, 23);
			this.btn_Exit.TabIndex = 9;
			this.btn_Exit.Text = "Exit";
			this.btn_Exit.UseVisualStyleBackColor = true;
			// 
			// rb_HTML
			// 
			this.rb_HTML.AutoSize = true;
			this.rb_HTML.Location = new System.Drawing.Point(15, 130);
			this.rb_HTML.Name = "rb_HTML";
			this.rb_HTML.Size = new System.Drawing.Size(55, 17);
			this.rb_HTML.TabIndex = 10;
			this.rb_HTML.Text = "HTML";
			this.rb_HTML.UseVisualStyleBackColor = true;
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
			this.cb_OneCol.Location = new System.Drawing.Point(15, 160);
			this.cb_OneCol.Name = "cb_OneCol";
			this.cb_OneCol.Size = new System.Drawing.Size(84, 17);
			this.cb_OneCol.TabIndex = 12;
			this.cb_OneCol.Text = "One Column";
			this.cb_OneCol.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(142, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 13);
			this.label2.TabIndex = 13;
			this.label2.Text = "Scheme: ";
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
			this.pb_Scheme.Location = new System.Drawing.Point(187, 88);
			this.pb_Scheme.Name = "pb_Scheme";
			this.pb_Scheme.Size = new System.Drawing.Size(69, 89);
			this.pb_Scheme.TabIndex = 15;
			this.pb_Scheme.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 192);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 13);
			this.label3.TabIndex = 16;
			this.label3.Text = "Margin: ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(142, 192);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 13);
			this.label4.TabIndex = 17;
			this.label4.Text = "Padding: ";
			// 
			// num_MarginSize
			// 
			this.num_MarginSize.Location = new System.Drawing.Point(74, 190);
			this.num_MarginSize.Name = "num_MarginSize";
			this.num_MarginSize.Size = new System.Drawing.Size(52, 20);
			this.num_MarginSize.TabIndex = 18;
			// 
			// num_PaddingSize
			// 
			this.num_PaddingSize.Location = new System.Drawing.Point(187, 190);
			this.num_PaddingSize.Name = "num_PaddingSize";
			this.num_PaddingSize.Size = new System.Drawing.Size(69, 20);
			this.num_PaddingSize.TabIndex = 19;
			// 
			// Form1
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(651, 284);
			this.Controls.Add(this.num_PaddingSize);
			this.Controls.Add(this.num_MarginSize);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.pb_Scheme);
			this.Controls.Add(this.cb_Scheme);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.p_Drop);
			this.Controls.Add(this.cb_OneCol);
			this.Controls.Add(this.rb_HTML);
			this.Controls.Add(this.btn_Exit);
			this.Controls.Add(this.btn_GenFiles);
			this.Controls.Add(this.btn_Preview);
			this.Controls.Add(this.rb_IMG);
			this.Controls.Add(this.rb_PDF);
			this.Controls.Add(this.num_NumOfPages);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lv_PicList);
			this.Controls.Add(this.btn_OpenPics);
			this.Controls.Add(this.ms_Menu);
			this.MainMenuStrip = this.ms_Menu;
			this.Name = "Form1";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
			this.DragLeave += new System.EventHandler(this.Form1_DragLeave);
			this.ms_Menu.ResumeLayout(false);
			this.ms_Menu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_NumOfPages)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_Scheme)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_MarginSize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_PaddingSize)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip ms_Menu;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem openFilesToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem generatePDFToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem generateIMGToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem previewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.Button btn_OpenPics;
		private System.Windows.Forms.ListView lv_PicList;
		private System.Windows.Forms.ColumnHeader ch_ID;
		private System.Windows.Forms.ColumnHeader ch_Name;
		private System.Windows.Forms.ColumnHeader ch_Size;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown num_NumOfPages;
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
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown num_MarginSize;
		private System.Windows.Forms.NumericUpDown num_PaddingSize;
	}
}

