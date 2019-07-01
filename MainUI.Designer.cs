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
            this.label3 = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.copyright = new System.Windows.Forms.Label();
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
            this.Licence_btn = new System.Windows.Forms.Button();
            this.MrJK = new System.Diagnostics.Process();
            this.Vision_Portal = new System.Diagnostics.Process();
            this.Wait = new System.Windows.Forms.Timer(this.components);
            this.TextLine = new System.Windows.Forms.Label();
            this.tableTableAdapter = new MARK.DatabaseDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new MARK.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.OutLine = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).BeginInit();
            this.tableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.DodgerBlue;
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(910, 30);
            this.title.TabIndex = 1;
            this.title.Text = "Private Assistant Vision DARK";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_MouseDown);
            this.title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.title_MouseMove);
            this.title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.title_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(37, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = ">";
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(124)))), ((int)(((byte)(190)))));
            this.version.Location = new System.Drawing.Point(50, 500);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(74, 16);
            this.version.TabIndex = 5;
            this.version.Text = "Version 0.1";
            // 
            // copyright
            // 
            this.copyright.AutoSize = true;
            this.copyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(124)))), ((int)(((byte)(190)))));
            this.copyright.Location = new System.Drawing.Point(228, 499);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(306, 16);
            this.copyright.TabIndex = 6;
            this.copyright.Text = "Copyright ©  Dewnith Fernando. All rights reserved.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(94)))), ((int)(((byte)(165)))));
            this.label7.Location = new System.Drawing.Point(-9, 481);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(945, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "_________________________________________________________________________________" +
    "_____________________________________________________";
            // 
            // build
            // 
            this.build.AutoSize = true;
            this.build.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.build.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(124)))), ((int)(((byte)(190)))));
            this.build.Location = new System.Drawing.Point(635, 500);
            this.build.Name = "build";
            this.build.Size = new System.Drawing.Size(69, 16);
            this.build.TabIndex = 9;
            this.build.Text = "Build 1024";
            // 
            // details
            // 
            this.details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
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
            this.searchbtn.BackColor = System.Drawing.Color.Transparent;
            this.searchbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(94)))), ((int)(((byte)(165)))));
            this.searchbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.searchbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(160)))), ((int)(((byte)(210)))));
            this.searchbtn.Location = new System.Drawing.Point(706, 52);
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
            this.udtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udtime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(160)))), ((int)(((byte)(210)))));
            this.udtime.Location = new System.Drawing.Point(750, 242);
            this.udtime.Name = "udtime";
            this.udtime.Size = new System.Drawing.Size(68, 16);
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
            this.inputTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.inputTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "input", true));
            this.inputTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(176)))), ((int)(((byte)(19)))));
            this.inputTextBox1.Location = new System.Drawing.Point(69, 55);
            this.inputTextBox1.Name = "inputTextBox1";
            this.inputTextBox1.Size = new System.Drawing.Size(597, 17);
            this.inputTextBox1.TabIndex = 19;
            this.inputTextBox1.Text = "Hi";
            this.inputTextBox1.Click += new System.EventHandler(this.inputTextBox1_Click1);
            this.inputTextBox1.TextChanged += new System.EventHandler(this.inputTextBox1_TextChanged);
            this.inputTextBox1.Enter += new System.EventHandler(this.InputTextBox1_Enter);
            this.inputTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTextBox1_KeyDown);
            this.inputTextBox1.Leave += new System.EventHandler(this.InputTextBox1_Leave);
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
            this.outputTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.outputTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "output", true));
            this.outputTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(170)))), ((int)(((byte)(17)))));
            this.outputTextBox1.Location = new System.Drawing.Point(50, 267);
            this.outputTextBox1.Multiline = true;
            this.outputTextBox1.Name = "outputTextBox1";
            this.outputTextBox1.Size = new System.Drawing.Size(812, 196);
            this.outputTextBox1.TabIndex = 20;
            this.outputTextBox1.Text = "Hi ,your welcome";
            this.outputTextBox1.Enter += new System.EventHandler(this.OutputTextBox1_Enter);
            this.outputTextBox1.Leave += new System.EventHandler(this.OutputTextBox1_Leave);
            // 
            // inputtext
            // 
            this.inputtext.AutoSize = true;
            this.inputtext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(7)))), ((int)(((byte)(12)))));
            this.inputtext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inputtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputtext.ForeColor = System.Drawing.Color.Green;
            this.inputtext.Location = new System.Drawing.Point(414, 243);
            this.inputtext.Name = "inputtext";
            this.inputtext.Size = new System.Drawing.Size(0, 16);
            this.inputtext.TabIndex = 21;
            this.inputtext.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(94)))), ((int)(((byte)(165)))));
            this.label1.Location = new System.Drawing.Point(193, 496);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "|";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(94)))), ((int)(((byte)(165)))));
            this.label2.Location = new System.Drawing.Point(739, 496);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "|";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(94)))), ((int)(((byte)(165)))));
            this.label4.Location = new System.Drawing.Point(588, 496);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "|";
            // 
            // Licence_btn
            // 
            this.Licence_btn.BackColor = System.Drawing.Color.Transparent;
            this.Licence_btn.FlatAppearance.BorderSize = 0;
            this.Licence_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Licence_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Licence_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Licence_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(124)))), ((int)(((byte)(190)))));
            this.Licence_btn.Location = new System.Drawing.Point(785, 495);
            this.Licence_btn.Name = "Licence_btn";
            this.Licence_btn.Size = new System.Drawing.Size(75, 22);
            this.Licence_btn.TabIndex = 28;
            this.Licence_btn.Text = "About us";
            this.Licence_btn.UseVisualStyleBackColor = false;
            this.Licence_btn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // MrJK
            // 
            this.MrJK.StartInfo.Domain = "";
            this.MrJK.StartInfo.FileName = "Application\\Mr.JK.exe";
            this.MrJK.StartInfo.LoadUserProfile = false;
            this.MrJK.StartInfo.Password = null;
            this.MrJK.StartInfo.StandardErrorEncoding = null;
            this.MrJK.StartInfo.StandardOutputEncoding = null;
            this.MrJK.StartInfo.UserName = "";
            this.MrJK.SynchronizingObject = this;
            // 
            // Vision_Portal
            // 
            this.Vision_Portal.StartInfo.Domain = "";
            this.Vision_Portal.StartInfo.FileName = "Vision_Portal.exe";
            this.Vision_Portal.StartInfo.LoadUserProfile = false;
            this.Vision_Portal.StartInfo.Password = null;
            this.Vision_Portal.StartInfo.StandardErrorEncoding = null;
            this.Vision_Portal.StartInfo.StandardOutputEncoding = null;
            this.Vision_Portal.StartInfo.UserName = "";
            this.Vision_Portal.SynchronizingObject = this;
            // 
            // TextLine
            // 
            this.TextLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextLine.Location = new System.Drawing.Point(67, 54);
            this.TextLine.Name = "TextLine";
            this.TextLine.Size = new System.Drawing.Size(600, 19);
            this.TextLine.TabIndex = 29;
            this.TextLine.Text = "label5";
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
            // OutLine
            // 
            this.OutLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OutLine.Location = new System.Drawing.Point(49, 266);
            this.OutLine.Name = "OutLine";
            this.OutLine.Size = new System.Drawing.Size(814, 198);
            this.OutLine.TabIndex = 30;
            this.OutLine.Text = "label5";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(102)))), ((int)(((byte)(209)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(872, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 30);
            this.button1.TabIndex = 31;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(910, 520);
            this.Controls.Add(this.button1);
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
            this.Controls.Add(this.copyright);
            this.Controls.Add(this.version);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.details);
            this.Controls.Add(this.outputTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Licence_btn);
            this.Controls.Add(this.TextLine);
            this.Controls.Add(this.OutLine);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(124)))), ((int)(((byte)(185)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainUI";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DvNET Vision Dark";
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Label copyright;
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
        private System.Windows.Forms.Button Licence_btn;
        private System.Diagnostics.Process MrJK;
        private System.Diagnostics.Process Vision_Portal;
        private System.Windows.Forms.Timer Wait;
        private System.Windows.Forms.Label TextLine;
        private System.Windows.Forms.Label OutLine;
        private System.Windows.Forms.Button button1;
    }
}

