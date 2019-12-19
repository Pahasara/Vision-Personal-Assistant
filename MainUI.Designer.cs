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
            this.copyright = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.build = new System.Windows.Forms.Label();
            this.searchbtn = new System.Windows.Forms.Button();
            this.udtime = new System.Windows.Forms.Label();
            this.CountWk_Time = new System.Windows.Forms.Timer(this.components);
            this.inputTextBox1 = new System.Windows.Forms.TextBox();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new MARK.DatabaseDataSet();
            this.outputTextBox1 = new System.Windows.Forms.TextBox();
            this.tableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserPref_Timing = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Licence_btn = new System.Windows.Forms.Button();
            this.tableTableAdapter = new MARK.DatabaseDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new MARK.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.Close_btn = new System.Windows.Forms.Button();
            this.titleX = new System.Windows.Forms.Button();
            this.titleY = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Minimize_btn = new System.Windows.Forms.Button();
            this.lineX = new System.Windows.Forms.Label();
            this.lineY = new System.Windows.Forms.Label();
            this.lineZ = new System.Windows.Forms.Label();
            this.copyrightInfoPanel = new System.Windows.Forms.Panel();
            this.Dv = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).BeginInit();
            this.tableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.copyrightInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Black;
            this.title.Cursor = System.Windows.Forms.Cursors.Default;
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(144)))), ((int)(((byte)(200)))));
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(525, 30);
            this.title.TabIndex = 1;
            this.title.Text = " ";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_MouseDown);
            this.title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.title_MouseMove);
            this.title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.title_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(19, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = ">";
            // 
            // copyright
            // 
            this.copyright.AutoSize = true;
            this.copyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyright.ForeColor = System.Drawing.Color.RoyalBlue;
            this.copyright.Location = new System.Drawing.Point(81, 9);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(334, 16);
            this.copyright.TabIndex = 6;
            this.copyright.Text = "Copyright © 2018 Dewnith Fernando. All rights reserved.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(-26, -15);
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
            this.build.ForeColor = System.Drawing.Color.RoyalBlue;
            this.build.Location = new System.Drawing.Point(3, 9);
            this.build.Name = "build";
            this.build.Size = new System.Drawing.Size(69, 16);
            this.build.TabIndex = 9;
            this.build.Text = "Build 1024";
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.Transparent;
            this.searchbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(155)))));
            this.searchbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.searchbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(190)))), ((int)(((byte)(220)))));
            this.searchbtn.Location = new System.Drawing.Point(391, 74);
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
            this.udtime.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udtime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(150)))), ((int)(((byte)(212)))));
            this.udtime.Location = new System.Drawing.Point(8, 36);
            this.udtime.Name = "udtime";
            this.udtime.Size = new System.Drawing.Size(71, 13);
            this.udtime.TabIndex = 17;
            this.udtime.Text = "00 : 00 : 00";
            this.udtime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.udtime.Visible = false;
            // 
            // CountWk_Time
            // 
            this.CountWk_Time.Enabled = true;
            this.CountWk_Time.Interval = 1000;
            this.CountWk_Time.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // inputTextBox1
            // 
            this.inputTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(36)))));
            this.inputTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "input", true));
            this.inputTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextBox1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.inputTextBox1.Location = new System.Drawing.Point(58, 79);
            this.inputTextBox1.Name = "inputTextBox1";
            this.inputTextBox1.Size = new System.Drawing.Size(322, 17);
            this.inputTextBox1.TabIndex = 19;
            this.inputTextBox1.Text = "Hi";
            this.inputTextBox1.Click += new System.EventHandler(this.inputTextBox1_Click1);
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
            this.outputTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(32)))));
            this.outputTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.outputTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "output", true));
            this.outputTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTextBox1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.outputTextBox1.Location = new System.Drawing.Point(32, 125);
            this.outputTextBox1.Multiline = true;
            this.outputTextBox1.Name = "outputTextBox1";
            this.outputTextBox1.Size = new System.Drawing.Size(445, 166);
            this.outputTextBox1.TabIndex = 20;
            this.outputTextBox1.Text = "Hi ,your welcome\r\n";
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
            this.tableBindingNavigator.Location = new System.Drawing.Point(85, 36);
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
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // UserPref_Timing
            // 
            this.UserPref_Timing.Interval = 500;
            this.UserPref_Timing.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(449, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "|";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(68, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "|";
            // 
            // Licence_btn
            // 
            this.Licence_btn.BackColor = System.Drawing.Color.Transparent;
            this.Licence_btn.FlatAppearance.BorderSize = 0;
            this.Licence_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(38)))), ((int)(((byte)(88)))));
            this.Licence_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.Licence_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Licence_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Licence_btn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Licence_btn.Location = new System.Drawing.Point(459, 5);
            this.Licence_btn.Name = "Licence_btn";
            this.Licence_btn.Size = new System.Drawing.Size(58, 22);
            this.Licence_btn.TabIndex = 28;
            this.Licence_btn.Text = "About";
            this.Licence_btn.UseVisualStyleBackColor = false;
            this.Licence_btn.Click += new System.EventHandler(this.Button1_Click);
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
            // Close_btn
            // 
            this.Close_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(2)))), ((int)(((byte)(8)))));
            this.Close_btn.FlatAppearance.BorderSize = 0;
            this.Close_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Close_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(30)))));
            this.Close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_btn.ForeColor = System.Drawing.Color.White;
            this.Close_btn.Location = new System.Drawing.Point(494, 1);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(30, 28);
            this.Close_btn.TabIndex = 31;
            this.Close_btn.Text = "Q";
            this.Close_btn.UseVisualStyleBackColor = false;
            this.Close_btn.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // titleX
            // 
            this.titleX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(144)))), ((int)(((byte)(200)))));
            this.titleX.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(184)))), ((int)(((byte)(200)))));
            this.titleX.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(144)))), ((int)(((byte)(200)))));
            this.titleX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(144)))), ((int)(((byte)(200)))));
            this.titleX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titleX.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleX.ForeColor = System.Drawing.Color.AliceBlue;
            this.titleX.Location = new System.Drawing.Point(82, 3);
            this.titleX.Name = "titleX";
            this.titleX.Size = new System.Drawing.Size(58, 22);
            this.titleX.TabIndex = 33;
            this.titleX.Text = "DvNET";
            this.titleX.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.titleX.UseVisualStyleBackColor = false;
            // 
            // titleY
            // 
            this.titleY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(2)))), ((int)(((byte)(10)))));
            this.titleY.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.titleY.FlatAppearance.BorderSize = 0;
            this.titleY.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.titleY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.titleY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titleY.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleY.ForeColor = System.Drawing.Color.AliceBlue;
            this.titleY.Location = new System.Drawing.Point(156, 1);
            this.titleY.Name = "titleY";
            this.titleY.Size = new System.Drawing.Size(125, 29);
            this.titleY.TabIndex = 35;
            this.titleY.Text = "Vision";
            this.titleY.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.titleY.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Close_btn);
            this.panel2.Controls.Add(this.Minimize_btn);
            this.panel2.Controls.Add(this.titleY);
            this.panel2.Controls.Add(this.titleX);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.title);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(525, 30);
            this.panel2.TabIndex = 39;
            // 
            // Minimize_btn
            // 
            this.Minimize_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(2)))), ((int)(((byte)(8)))));
            this.Minimize_btn.FlatAppearance.BorderSize = 0;
            this.Minimize_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(2)))), ((int)(((byte)(14)))));
            this.Minimize_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(18)))));
            this.Minimize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize_btn.ForeColor = System.Drawing.Color.White;
            this.Minimize_btn.Location = new System.Drawing.Point(461, -6);
            this.Minimize_btn.Name = "Minimize_btn";
            this.Minimize_btn.Size = new System.Drawing.Size(32, 41);
            this.Minimize_btn.TabIndex = 49;
            this.Minimize_btn.Text = "_";
            this.Minimize_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Minimize_btn.UseVisualStyleBackColor = false;
            this.Minimize_btn.Click += new System.EventHandler(this.Minimize_btn_Click);
            // 
            // lineX
            // 
            this.lineX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(100)))), ((int)(((byte)(17)))));
            this.lineX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.lineX.Location = new System.Drawing.Point(-3, 359);
            this.lineX.Name = "lineX";
            this.lineX.Size = new System.Drawing.Size(528, 10);
            this.lineX.TabIndex = 40;
            // 
            // lineY
            // 
            this.lineY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(100)))), ((int)(((byte)(17)))));
            this.lineY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(100)))), ((int)(((byte)(17)))));
            this.lineY.Location = new System.Drawing.Point(524, 29);
            this.lineY.Name = "lineY";
            this.lineY.Size = new System.Drawing.Size(5, 520);
            this.lineY.TabIndex = 41;
            // 
            // lineZ
            // 
            this.lineZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(100)))), ((int)(((byte)(17)))));
            this.lineZ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(144)))), ((int)(((byte)(205)))));
            this.lineZ.Location = new System.Drawing.Point(-4, 30);
            this.lineZ.Name = "lineZ";
            this.lineZ.Size = new System.Drawing.Size(5, 520);
            this.lineZ.TabIndex = 42;
            // 
            // copyrightInfoPanel
            // 
            this.copyrightInfoPanel.Controls.Add(this.Licence_btn);
            this.copyrightInfoPanel.Controls.Add(this.build);
            this.copyrightInfoPanel.Controls.Add(this.copyright);
            this.copyrightInfoPanel.Controls.Add(this.label7);
            this.copyrightInfoPanel.Controls.Add(this.label4);
            this.copyrightInfoPanel.Controls.Add(this.label2);
            this.copyrightInfoPanel.Location = new System.Drawing.Point(2, 327);
            this.copyrightInfoPanel.Name = "copyrightInfoPanel";
            this.copyrightInfoPanel.Size = new System.Drawing.Size(525, 31);
            this.copyrightInfoPanel.TabIndex = 43;
            // 
            // Dv
            // 
            this.Dv.BalloonTipText = "DvNET Vision is still running...";
            this.Dv.BalloonTipTitle = "DvNET Vision";
            this.Dv.Icon = ((System.Drawing.Icon)(resources.GetObject("Dv.Icon")));
            this.Dv.Text = "DvNET Vision";
            this.Dv.Visible = true;
            this.Dv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Dv_MouseClick);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(525, 360);
            this.Controls.Add(this.lineY);
            this.Controls.Add(this.lineX);
            this.Controls.Add(this.copyrightInfoPanel);
            this.Controls.Add(this.lineZ);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.inputTextBox1);
            this.Controls.Add(this.tableBindingNavigator);
            this.Controls.Add(this.udtime);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.outputTextBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(124)))), ((int)(((byte)(185)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainUI";
            this.Opacity = 0.75D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DvNET Vision";
            this.Activated += new System.EventHandler(this.MainUI_Activated);
            this.Deactivate += new System.EventHandler(this.MainUI_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainUI_FormClosing);
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.Resize += new System.EventHandler(this.MainUI_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).EndInit();
            this.tableBindingNavigator.ResumeLayout(false);
            this.tableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.copyrightInfoPanel.ResumeLayout(false);
            this.copyrightInfoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label copyright;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label build;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Label udtime;
        private System.Windows.Forms.Timer CountWk_Time;
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
        private System.Windows.Forms.Timer UserPref_Timing;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Licence_btn;
        private System.Windows.Forms.Button Close_btn;
        private System.Windows.Forms.Button titleX;
        private System.Windows.Forms.Button titleY;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lineZ;
        private System.Windows.Forms.Label lineY;
        private System.Windows.Forms.Label lineX;
        private System.Windows.Forms.Panel copyrightInfoPanel;
        private System.Windows.Forms.Button Minimize_btn;
        private System.Windows.Forms.NotifyIcon Dv;
    }
}

