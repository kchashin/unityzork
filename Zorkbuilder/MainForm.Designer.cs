namespace Zorkbuilder
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.worldInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.launchZorkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zorkViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveJSON = new System.Windows.Forms.SaveFileDialog();
            this.openJSON = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Rooms = new System.Windows.Forms.TabPage();
            this.roomListBox = new System.Windows.Forms.ListBox();
            this.Room_Name = new System.Windows.Forms.TextBox();
            this.namew = new System.Windows.Forms.Label();
            this.WestN = new System.Windows.Forms.TextBox();
            this.EastN = new System.Windows.Forms.TextBox();
            this.SouthN = new System.Windows.Forms.TextBox();
            this.NorthN = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.TextBox();
            this.west = new System.Windows.Forms.Label();
            this.east = new System.Windows.Forms.Label();
            this.south = new System.Windows.Forms.Label();
            this.neighbors = new System.Windows.Forms.Label();
            this.descriptionw = new System.Windows.Forms.Label();
            this.north = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zorkViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            this.tabControl.SuspendLayout();
            this.Rooms.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.worldInfoToolStripMenuItem,
            this.runToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.addNewRoomToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.newToolStripMenuItem.Text = "New ";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(153, 6);
            // 
            // addNewRoomToolStripMenuItem
            // 
            this.addNewRoomToolStripMenuItem.Name = "addNewRoomToolStripMenuItem";
            this.addNewRoomToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.addNewRoomToolStripMenuItem.Text = "Add new Room";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(153, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // worldInfoToolStripMenuItem
            // 
            this.worldInfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem1});
            this.worldInfoToolStripMenuItem.Name = "worldInfoToolStripMenuItem";
            this.worldInfoToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.worldInfoToolStripMenuItem.Text = "&Game";
            this.worldInfoToolStripMenuItem.Click += new System.EventHandler(this.WorldInfoToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem1
            // 
            this.runToolStripMenuItem1.Name = "runToolStripMenuItem1";
            this.runToolStripMenuItem1.Size = new System.Drawing.Size(95, 22);
            this.runToolStripMenuItem1.Text = "Run";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.launchZorkToolStripMenuItem});
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.runToolStripMenuItem.Text = "&Run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.RunToolStripMenuItem_Click);
            // 
            // launchZorkToolStripMenuItem
            // 
            this.launchZorkToolStripMenuItem.Name = "launchZorkToolStripMenuItem";
            this.launchZorkToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.launchZorkToolStripMenuItem.Text = "Launch Zork";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // zorkViewModelBindingSource
            // 
            this.zorkViewModelBindingSource.DataSource = typeof(Zorkbuilder.ZorkViewModel);
            this.zorkViewModelBindingSource.CurrentChanged += new System.EventHandler(this.zorkViewModelBindingSource_CurrentChanged);
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.zorkViewModelBindingSource;
            // 
            // saveJSON
            // 
            this.saveJSON.Filter = "Zork Files (*.json)|*.json";
            this.saveJSON.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openJSON
            // 
            this.openJSON.FileName = "openFileDialog1";
            this.openJSON.Filter = "Zork Files (*.json)|*.json";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "World Files (*json)|*.json";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Rooms);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(12, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(776, 411);
            this.tabControl.TabIndex = 26;
            // 
            // Rooms
            // 
            this.Rooms.Controls.Add(this.roomListBox);
            this.Rooms.Controls.Add(this.Room_Name);
            this.Rooms.Controls.Add(this.namew);
            this.Rooms.Controls.Add(this.WestN);
            this.Rooms.Controls.Add(this.EastN);
            this.Rooms.Controls.Add(this.SouthN);
            this.Rooms.Controls.Add(this.NorthN);
            this.Rooms.Controls.Add(this.Description);
            this.Rooms.Controls.Add(this.west);
            this.Rooms.Controls.Add(this.east);
            this.Rooms.Controls.Add(this.south);
            this.Rooms.Controls.Add(this.neighbors);
            this.Rooms.Controls.Add(this.descriptionw);
            this.Rooms.Controls.Add(this.north);
            this.Rooms.Location = new System.Drawing.Point(4, 22);
            this.Rooms.Name = "Rooms";
            this.Rooms.Padding = new System.Windows.Forms.Padding(3);
            this.Rooms.Size = new System.Drawing.Size(768, 385);
            this.Rooms.TabIndex = 0;
            this.Rooms.Text = "Rooms";
            this.Rooms.UseVisualStyleBackColor = true;
            // 
            // roomListBox
            // 
            this.roomListBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.roomListBox.DataSource = this.roomsBindingSource;
            this.roomListBox.DisplayMember = "Name";
            this.roomListBox.FormattingEnabled = true;
            this.roomListBox.Location = new System.Drawing.Point(6, 11);
            this.roomListBox.Name = "roomListBox";
            this.roomListBox.Size = new System.Drawing.Size(120, 329);
            this.roomListBox.TabIndex = 39;
            this.roomListBox.ValueMember = "Location";
            this.roomListBox.SelectedIndexChanged += new System.EventHandler(this.RoomListBox_SelectedIndexChanged);
            // 
            // Room_Name
            // 
            this.Room_Name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Room_Name.Location = new System.Drawing.Point(355, 13);
            this.Room_Name.Name = "Room_Name";
            this.Room_Name.Size = new System.Drawing.Size(304, 20);
            this.Room_Name.TabIndex = 38;
            this.Room_Name.TextChanged += new System.EventHandler(this.Room_Name_TextChanged);
            // 
            // namew
            // 
            this.namew.AutoSize = true;
            this.namew.Location = new System.Drawing.Point(224, 13);
            this.namew.Name = "namew";
            this.namew.Size = new System.Drawing.Size(35, 13);
            this.namew.TabIndex = 37;
            this.namew.Text = "&Name";
            this.namew.Click += new System.EventHandler(this.Namew_Click);
            // 
            // WestN
            // 
            this.WestN.Location = new System.Drawing.Point(355, 328);
            this.WestN.Name = "WestN";
            this.WestN.Size = new System.Drawing.Size(235, 20);
            this.WestN.TabIndex = 36;
            this.WestN.TextChanged += new System.EventHandler(this.WestN_TextChanged);
            // 
            // EastN
            // 
            this.EastN.Location = new System.Drawing.Point(355, 290);
            this.EastN.Name = "EastN";
            this.EastN.Size = new System.Drawing.Size(235, 20);
            this.EastN.TabIndex = 35;
            this.EastN.TextChanged += new System.EventHandler(this.EastN_TextChanged);
            // 
            // SouthN
            // 
            this.SouthN.Location = new System.Drawing.Point(355, 258);
            this.SouthN.Name = "SouthN";
            this.SouthN.Size = new System.Drawing.Size(235, 20);
            this.SouthN.TabIndex = 34;
            this.SouthN.TextChanged += new System.EventHandler(this.SouthN_TextChanged);
            // 
            // NorthN
            // 
            this.NorthN.Location = new System.Drawing.Point(355, 222);
            this.NorthN.Name = "NorthN";
            this.NorthN.Size = new System.Drawing.Size(235, 20);
            this.NorthN.TabIndex = 33;
            this.NorthN.TextChanged += new System.EventHandler(this.NorthN_TextChanged);
            // 
            // Description
            // 
            this.Description.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Description.Location = new System.Drawing.Point(355, 51);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(364, 68);
            this.Description.TabIndex = 32;
            this.Description.TextChanged += new System.EventHandler(this.Description_TextChanged);
            // 
            // west
            // 
            this.west.AutoSize = true;
            this.west.Location = new System.Drawing.Point(273, 328);
            this.west.Name = "west";
            this.west.Size = new System.Drawing.Size(32, 13);
            this.west.TabIndex = 31;
            this.west.Text = "&West";
            this.west.Click += new System.EventHandler(this.West_Click);
            // 
            // east
            // 
            this.east.AutoSize = true;
            this.east.Location = new System.Drawing.Point(273, 290);
            this.east.Name = "east";
            this.east.Size = new System.Drawing.Size(28, 13);
            this.east.TabIndex = 30;
            this.east.Text = "&East";
            this.east.Click += new System.EventHandler(this.East_Click);
            // 
            // south
            // 
            this.south.AutoSize = true;
            this.south.Location = new System.Drawing.Point(273, 258);
            this.south.Name = "south";
            this.south.Size = new System.Drawing.Size(35, 13);
            this.south.TabIndex = 29;
            this.south.Text = "&South";
            this.south.Click += new System.EventHandler(this.South_Click);
            // 
            // neighbors
            // 
            this.neighbors.AutoSize = true;
            this.neighbors.Location = new System.Drawing.Point(204, 180);
            this.neighbors.Name = "neighbors";
            this.neighbors.Size = new System.Drawing.Size(55, 13);
            this.neighbors.TabIndex = 28;
            this.neighbors.Text = "&Neighbors";
            this.neighbors.Click += new System.EventHandler(this.Neighbors_Click);
            // 
            // descriptionw
            // 
            this.descriptionw.AutoSize = true;
            this.descriptionw.Location = new System.Drawing.Point(204, 42);
            this.descriptionw.Name = "descriptionw";
            this.descriptionw.Size = new System.Drawing.Size(60, 13);
            this.descriptionw.TabIndex = 27;
            this.descriptionw.Text = "&Description";
            this.descriptionw.Click += new System.EventHandler(this.Descriptionw_Click);
            // 
            // north
            // 
            this.north.AutoSize = true;
            this.north.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.north.Location = new System.Drawing.Point(273, 222);
            this.north.Name = "north";
            this.north.Size = new System.Drawing.Size(33, 13);
            this.north.TabIndex = 26;
            this.north.Text = "&North";
            this.north.Click += new System.EventHandler(this.North_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.welcomeLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 385);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Game";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zorkViewModelBindingSource, "WelcomeMessage", true));
            this.textBox1.Location = new System.Drawing.Point(259, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(405, 25);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged_1);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(35, 26);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(129, 16);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome Message:";
            this.welcomeLabel.Click += new System.EventHandler(this.WelcomeLabel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zorkViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.Rooms.ResumeLayout(false);
            this.Rooms.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem worldInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem launchZorkToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveJSON;
        private System.Windows.Forms.OpenFileDialog openJSON;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.BindingSource zorkViewModelBindingSource;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Rooms;
        private System.Windows.Forms.ListBox roomListBox;
        private System.Windows.Forms.TextBox Room_Name;
        private System.Windows.Forms.Label namew;
        private System.Windows.Forms.TextBox WestN;
        private System.Windows.Forms.TextBox EastN;
        private System.Windows.Forms.TextBox SouthN;
        private System.Windows.Forms.TextBox NorthN;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Label west;
        private System.Windows.Forms.Label east;
        private System.Windows.Forms.Label south;
        private System.Windows.Forms.Label neighbors;
        private System.Windows.Forms.Label descriptionw;
        private System.Windows.Forms.Label north;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem1;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.TextBox textBox1;
    }
}

