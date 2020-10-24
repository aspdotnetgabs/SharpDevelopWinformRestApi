/*
 * Created by SharpDevelop.
 * User: Gabs
 * Date: 10/19/2020
 * Time: 11:43 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SDWinformRestAPI
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.BindingSource bindingSource1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn artistDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button btnGetSongs;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox txtGenre;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtArtist;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.BindingNavigator bindingNavigator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.Button btnLoginDemo;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.btnGetSongs = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.artistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.btnSave = new System.Windows.Forms.Button();
			this.txtGenre = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtArtist = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.btnLoginDemo = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
			this.bindingNavigator1.SuspendLayout();
			this.SuspendLayout();
			// 
			// bindingSource1
			// 
			this.bindingSource1.DataSource = typeof(Song);
			// 
			// btnGetSongs
			// 
			this.btnGetSongs.Location = new System.Drawing.Point(12, 34);
			this.btnGetSongs.Name = "btnGetSongs";
			this.btnGetSongs.Size = new System.Drawing.Size(115, 37);
			this.btnGetSongs.TabIndex = 1;
			this.btnGetSongs.Text = "Get All Songs";
			this.btnGetSongs.UseVisualStyleBackColor = true;
			this.btnGetSongs.Click += new System.EventHandler(this.BtnGetSongsClick);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Enabled = false;
			this.tabControl1.Location = new System.Drawing.Point(12, 77);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(640, 297);
			this.tabControl1.TabIndex = 2;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.dataGridView1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(632, 271);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Datasheet View";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.idDataGridViewTextBoxColumn,
			this.titleDataGridViewTextBoxColumn,
			this.artistDataGridViewTextBoxColumn,
			this.genreDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.bindingSource1;
			this.dataGridView1.Location = new System.Drawing.Point(6, 6);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(620, 247);
			this.dataGridView1.TabIndex = 0;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			// 
			// titleDataGridViewTextBoxColumn
			// 
			this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
			this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
			this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
			// 
			// artistDataGridViewTextBoxColumn
			// 
			this.artistDataGridViewTextBoxColumn.DataPropertyName = "Artist";
			this.artistDataGridViewTextBoxColumn.HeaderText = "Artist";
			this.artistDataGridViewTextBoxColumn.Name = "artistDataGridViewTextBoxColumn";
			// 
			// genreDataGridViewTextBoxColumn
			// 
			this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
			this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
			this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.btnSave);
			this.tabPage2.Controls.Add(this.txtGenre);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.txtArtist);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Controls.Add(this.txtTitle);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Controls.Add(this.txtId);
			this.tabPage2.Controls.Add(this.label1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(632, 271);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Detail View";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(182, 172);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(100, 33);
			this.btnSave.TabIndex = 8;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
			// 
			// txtGenre
			// 
			this.txtGenre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Genre", true));
			this.txtGenre.Location = new System.Drawing.Point(182, 134);
			this.txtGenre.Name = "txtGenre";
			this.txtGenre.Size = new System.Drawing.Size(255, 20);
			this.txtGenre.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(100, 137);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Genre";
			// 
			// txtArtist
			// 
			this.txtArtist.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Artist", true));
			this.txtArtist.Location = new System.Drawing.Point(182, 108);
			this.txtArtist.Name = "txtArtist";
			this.txtArtist.Size = new System.Drawing.Size(255, 20);
			this.txtArtist.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(100, 111);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Artist";
			// 
			// txtTitle
			// 
			this.txtTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Title", true));
			this.txtTitle.Location = new System.Drawing.Point(182, 82);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(255, 20);
			this.txtTitle.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(100, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Title";
			// 
			// txtId
			// 
			this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Id", true));
			this.txtId.Location = new System.Drawing.Point(182, 56);
			this.txtId.Name = "txtId";
			this.txtId.ReadOnly = true;
			this.txtId.Size = new System.Drawing.Size(255, 20);
			this.txtId.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(100, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Id";
			// 
			// bindingNavigator1
			// 
			this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
			this.bindingNavigator1.BindingSource = this.bindingSource1;
			this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
			this.bindingNavigator1.DeleteItem = null;
			this.bindingNavigator1.Enabled = false;
			this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.bindingNavigatorMoveFirstItem,
			this.bindingNavigatorMovePreviousItem,
			this.bindingNavigatorSeparator,
			this.bindingNavigatorPositionItem,
			this.bindingNavigatorCountItem,
			this.bindingNavigatorSeparator1,
			this.bindingNavigatorMoveNextItem,
			this.bindingNavigatorMoveLastItem,
			this.bindingNavigatorSeparator2,
			this.bindingNavigatorAddNewItem,
			this.bindingNavigatorDeleteItem});
			this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
			this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.bindingNavigator1.Name = "bindingNavigator1";
			this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
			this.bindingNavigator1.Size = new System.Drawing.Size(660, 25);
			this.bindingNavigator1.TabIndex = 3;
			this.bindingNavigator1.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Add new";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Move previous";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Position";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Current position";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem.Text = "Move last";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Delete";
			this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.BindingNavigatorDeleteItemClick);
			// 
			// btnLoginDemo
			// 
			this.btnLoginDemo.Location = new System.Drawing.Point(533, 34);
			this.btnLoginDemo.Name = "btnLoginDemo";
			this.btnLoginDemo.Size = new System.Drawing.Size(109, 23);
			this.btnLoginDemo.TabIndex = 4;
			this.btnLoginDemo.Text = "Login Demo...";
			this.btnLoginDemo.UseVisualStyleBackColor = true;
			this.btnLoginDemo.Click += new System.EventHandler(this.BtnLoginDemoClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(660, 385);
			this.Controls.Add(this.btnLoginDemo);
			this.Controls.Add(this.bindingNavigator1);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.btnGetSongs);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Songs from Web API";
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
			this.bindingNavigator1.ResumeLayout(false);
			this.bindingNavigator1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
