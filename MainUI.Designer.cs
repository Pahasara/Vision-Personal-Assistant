namespace MARK
{
    partial class MainUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.title = new System.Windows.Forms.Label();
            this.clsbtn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.copyright = new System.Windows.Forms.Label();
            this.license = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.build = new System.Windows.Forms.Label();
            this.details = new System.Windows.Forms.Label();
            this.searchbtn = new System.Windows.Forms.Button();
            this.udtime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.inputTextBox1 = new System.Windows.Forms.TextBox();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new MARK.DatabaseDataSet();
            this.outputTextBox1 = new System.Windows.Forms.TextBox();
            this.inputtext = new System.Windows.Forms.Label();
            this.tableTableAdapter = new MARK.DatabaseDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new MARK.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.tableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.NFS_CB = new System.Diagnostics.Process();
            this.NFS_MW = new System.Diagnostics.Process();
            this.Warcraft3 = new System.Diagnostics.Process();
            this.show_mainui = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).BeginInit();
            this.tableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(144)))), ((int)(((byte)(200)))));
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(910, 30);
            this.title.TabIndex = 1;
            this.title.Text = "Private Assistant VISION";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_MouseDown);
            this.title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.title_MouseMove);
            this.title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.title_MouseUp);
            // 
            // clsbtn
            // 
            this.clsbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.clsbtn.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clsbtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.clsbtn.Location = new System.Drawing.Point(875, -5);
            this.clsbtn.Name = "clsbtn";
            this.clsbtn.Size = new System.Drawing.Size(35, 35);
            this.clsbtn.TabIndex = 2;
            this.clsbtn.Text = "x";
            this.clsbtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.clsbtn.Click += new System.EventHandler(this.clsbtn_Click);
            this.clsbtn.MouseLeave += new System.EventHandler(this.clsbtn_MouseLeave);
            this.clsbtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.clsbtn_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(44, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = ">";
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(124)))), ((int)(((byte)(185)))));
            this.version.Location = new System.Drawing.Point(57, 487);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(117, 15);
            this.version.TabIndex = 5;
            this.version.Text = "Preview  Version 0.1";
            // 
            // copyright
            // 
            this.copyright.AutoSize = true;
            this.copyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(124)))), ((int)(((byte)(186)))));
            this.copyright.Location = new System.Drawing.Point(214, 487);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(313, 15);
            this.copyright.TabIndex = 6;
            this.copyright.Text = "Copyright ©  2019 Dewnith Fernando. All rights reserved.";
            // 
            // license
            // 
            this.license.AutoSize = true;
            this.license.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.license.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(124)))), ((int)(((byte)(185)))));
            this.license.Location = new System.Drawing.Point(773, 487);
            this.license.Name = "license";
            this.license.Size = new System.Drawing.Size(84, 15);
            this.license.TabIndex = 7;
            this.license.Text = "License/About";
            this.license.Click += new System.EventHandler(this.license_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(-9, 470);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(945, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "_________________________________________________________________________________" +
    "_____________________________________________________";
            // 
            // build
            // 
            this.build.AutoSize = true;
            this.build.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.build.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(124)))), ((int)(((byte)(185)))));
            this.build.Location = new System.Drawing.Point(627, 487);
            this.build.Name = "build";
            this.build.Size = new System.Drawing.Size(66, 15);
            this.build.TabIndex = 9;
            this.build.Text = "Build 4096";
            // 
            // details
            // 
            this.details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(8)))), ((int)(((byte)(16)))));
            this.details.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.details.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.details.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(160)))), ((int)(((byte)(210)))));
            this.details.Location = new System.Drawing.Point(116, 94);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(666, 142);
            this.details.TabIndex = 10;
            this.details.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.searchbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(110)))), ((int)(((byte)(128)))));
            this.searchbtn.FlatAppearance.BorderSize = 0;
            this.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.searchbtn.Location = new System.Drawing.Point(771, 50);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(76, 24);
            this.searchbtn.TabIndex = 16;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // udtime
            // 
            this.udtime.AutoSize = true;
            this.udtime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.udtime.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udtime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(160)))), ((int)(((byte)(210)))));
            this.udtime.Location = new System.Drawing.Point(750, 242);
            this.udtime.Name = "udtime";
            this.udtime.Size = new System.Drawing.Size(88, 16);
            this.udtime.TabIndex = 17;
            this.udtime.Text = "00 : 00 : 00";
            this.udtime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.udtime.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // inputTextBox1
            // 
            this.inputTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.inputTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "input", true));
            this.inputTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(176)))), ((int)(((byte)(228)))));
            this.inputTextBox1.Location = new System.Drawing.Point(69, 57);
            this.inputTextBox1.Name = "inputTextBox1";
            this.inputTextBox1.Size = new System.Drawing.Size(685, 17);
            this.inputTextBox1.TabIndex = 19;
            this.inputTextBox1.Text = "Hi";
            this.inputTextBox1.Click += new System.EventHandler(this.inputTextBox1_Click1);
            this.inputTextBox1.TextChanged += new System.EventHandler(this.inputTextBox1_TextChanged);
            this.inputTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTextBox1_KeyDown);
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // outputTextBox1
            // 
            this.outputTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(8)))), ((int)(((byte)(16)))));
            this.outputTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "output", true));
            this.outputTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(170)))), ((int)(((byte)(220)))));
            this.outputTextBox1.Location = new System.Drawing.Point(49, 268);
            this.outputTextBox1.Multiline = true;
            this.outputTextBox1.Name = "outputTextBox1";
            this.outputTextBox1.Size = new System.Drawing.Size(811, 195);
            this.outputTextBox1.TabIndex = 20;
            this.outputTextBox1.Text = "Hi ,your welcome";
            // 
            // inputtext
            // 
            this.inputtext.AutoSize = true;
            this.inputtext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.inputtext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inputtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputtext.ForeColor = System.Drawing.Color.Green;
            this.inputtext.Location = new System.Drawing.Point(414, 243);
            this.inputtext.Name = "inputtext";
            this.inputtext.Size = new System.Drawing.Size(0, 16);
            this.inputtext.TabIndex = 21;
            this.inputtext.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = MARK.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableBindingNavigator
            // 
            this.tableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tableBindingNavigator.AutoSize = false;
            this.tableBindingNavigator.BackColor = System.Drawing.Color.Transparent;
            this.tableBindingNavigator.BindingSource = this.tableBindingSource;
            this.tableBindingNavigator.CountItem = null;
            this.tableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tableBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.tableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tableBindingNavigatorSaveItem});
            this.tableBindingNavigator.Location = new System.Drawing.Point(39, 82);
            this.tableBindingNavigator.MoveFirstItem = null;
            this.tableBindingNavigator.MoveLastItem = null;
            this.tableBindingNavigator.MoveNextItem = null;
            this.tableBindingNavigator.MovePreviousItem = null;
            this.tableBindingNavigator.Name = "tableBindingNavigator";
            this.tableBindingNavigator.PositionItem = null;
            this.tableBindingNavigator.Size = new System.Drawing.Size(96, 25);
            this.tableBindingNavigator.TabIndex = 22;
            this.tableBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // tableBindingNavigatorSaveItem
            // 
            this.tableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tableBindingNavigatorSaveItem.Image")));
            this.tableBindingNavigatorSaveItem.Name = "tableBindingNavigatorSaveItem";
            this.tableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tableBindingNavigatorSaveItem.Text = "Save Data";
            this.tableBindingNavigatorSaveItem.Click += new System.EventHandler(this.tableBindingNavigatorSaveItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(395, 320);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 24;
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // NFS_CB
            // 
            this.NFS_CB.StartInfo.Domain = "";
            this.NFS_CB.StartInfo.FileName = "E:\\Need for Speed Carbon\\NFSC.exe";
            this.NFS_CB.StartInfo.LoadUserProfile = false;
            this.NFS_CB.StartInfo.Password = null;
            this.NFS_CB.StartInfo.StandardErrorEncoding = null;
            this.NFS_CB.StartInfo.StandardOutputEncoding = null;
            this.NFS_CB.StartInfo.UserName = "";
            this.NFS_CB.SynchronizingObject = this;
            // 
            // NFS_MW
            // 
            this.NFS_MW.StartInfo.Domain = "";
            this.NFS_MW.StartInfo.FileName = "E:\\Need for Speed Most Wanted\\speed.exe";
            this.NFS_MW.StartInfo.LoadUserProfile = false;
            this.NFS_MW.StartInfo.Password = null;
            this.NFS_MW.StartInfo.StandardErrorEncoding = null;
            this.NFS_MW.StartInfo.StandardOutputEncoding = null;
            this.NFS_MW.StartInfo.UserName = "";
            this.NFS_MW.SynchronizingObject = this;
            // 
            // Warcraft3
            // 
            this.Warcraft3.StartInfo.Domain = "";
            this.Warcraft3.StartInfo.FileName = "D:\\Applications\\Warcraft III\\Warcraft III.exe";
            this.Warcraft3.StartInfo.LoadUserProfile = false;
            this.Warcraft3.StartInfo.Password = null;
            this.Warcraft3.StartInfo.StandardErrorEncoding = null;
            this.Warcraft3.StartInfo.StandardOutputEncoding = null;
            this.Warcraft3.StartInfo.UserName = "";
            this.Warcraft3.SynchronizingObject = this;
            // 
            // show_mainui
            // 
            this.show_mainui.Tick += new System.EventHandler(this.show_mainui_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(180)))));
            this.label1.Location = new System.Drawing.Point(189, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "|";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(124)))), ((int)(((byte)(185)))));
            this.label2.Location = new System.Drawing.Point(726, 485);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "|";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(124)))), ((int)(((byte)(185)))));
            this.label4.Location = new System.Drawing.Point(562, 485);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "|";
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(7)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(910, 509);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.inputTextBox1);
            this.Controls.Add(this.tableBindingNavigator);
            this.Controls.Add(this.inputtext);
            this.Controls.Add(this.udtime);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.build);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.license);
            this.Controls.Add(this.copyright);
            this.Controls.Add(this.version);
            this.Controls.Add(this.clsbtn);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.details);
            this.Controls.Add(this.outputTextBox1);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainUI";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vision";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainUI_FormClosing);
            this.Load += new System.EventHandler(this.MainUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).EndInit();
            this.tableBindingNavigator.ResumeLayout(false);
            this.tableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label clsbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Label copyright;
        private System.Windows.Forms.Label license;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label build;
        private System.Windows.Forms.Label details;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Label udtime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label inputtext;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private DatabaseDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton tableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox inputTextBox1;
        private System.Windows.Forms.TextBox outputTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer2;
        private System.Diagnostics.Process NFS_CB;
        private System.Diagnostics.Process NFS_MW;
        private System.Diagnostics.Process Warcraft3;
        private System.Windows.Forms.Timer show_mainui;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

