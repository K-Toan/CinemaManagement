namespace SE1735_Group6_A2.GUI
{
    partial class ShowGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowGUI));
            dataGridView = new DataGridView();
            addNewButton = new Button();
            filmLabel = new Label();
            menuStrip1 = new MenuStrip();
            showToolStripMenuItem = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            dateLabel = new Label();
            roomLabel = new Label();
            filmComboBox = new ComboBox();
            roomComboBox = new ComboBox();
            searchButton = new Button();
            numberOfShowsLabel = new Label();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            dateTimePicker = new DateTimePicker();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 280);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(960, 245);
            dataGridView.TabIndex = 0;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // addNewButton
            // 
            addNewButton.Location = new Point(66, 212);
            addNewButton.Name = "addNewButton";
            addNewButton.Size = new Size(157, 23);
            addNewButton.TabIndex = 1;
            addNewButton.Text = "Add a new...";
            addNewButton.UseVisualStyleBackColor = true;
            addNewButton.Click += addNewButton_Click;
            // 
            // filmLabel
            // 
            filmLabel.AutoSize = true;
            filmLabel.Location = new Point(66, 56);
            filmLabel.Name = "filmLabel";
            filmLabel.Size = new Size(33, 15);
            filmLabel.TabIndex = 2;
            filmLabel.Text = "Film:";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { showToolStripMenuItem, loginToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(984, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // showToolStripMenuItem
            // 
            showToolStripMenuItem.Name = "showToolStripMenuItem";
            showToolStripMenuItem.Size = new Size(48, 20);
            showToolStripMenuItem.Text = "Show";
            showToolStripMenuItem.Click += showToolStripMenuItem_Click;
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(49, 20);
            loginToolStripMenuItem.Text = "Login";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(66, 105);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(34, 15);
            dateLabel.TabIndex = 4;
            dateLabel.Text = "Date:";
            // 
            // roomLabel
            // 
            roomLabel.AutoSize = true;
            roomLabel.Location = new Point(66, 159);
            roomLabel.Name = "roomLabel";
            roomLabel.Size = new Size(42, 15);
            roomLabel.TabIndex = 5;
            roomLabel.Text = "Room:";
            // 
            // filmComboBox
            // 
            filmComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            filmComboBox.FormattingEnabled = true;
            filmComboBox.Location = new Point(154, 53);
            filmComboBox.Name = "filmComboBox";
            filmComboBox.Size = new Size(196, 23);
            filmComboBox.TabIndex = 6;
            // 
            // roomComboBox
            // 
            roomComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            roomComboBox.FormattingEnabled = true;
            roomComboBox.Location = new Point(154, 156);
            roomComboBox.Name = "roomComboBox";
            roomComboBox.Size = new Size(196, 23);
            roomComboBox.TabIndex = 8;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(411, 156);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 9;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // numberOfShowsLabel
            // 
            numberOfShowsLabel.AutoSize = true;
            numberOfShowsLabel.Location = new Point(66, 262);
            numberOfShowsLabel.Name = "numberOfShowsLabel";
            numberOfShowsLabel.Size = new Size(127, 15);
            numberOfShowsLabel.TabIndex = 10;
            numberOfShowsLabel.Text = "The number of shows: ";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 535);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(984, 22);
            statusStrip1.TabIndex = 11;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(49, 17);
            toolStripStatusLabel1.Text = "Group 6";
            // 
            // dateTimePicker
            // 
            dateTimePicker.CustomFormat = "MM/dd/yyyy";
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.Location = new Point(154, 105);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(196, 23);
            dateTimePicker.TabIndex = 12;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2 });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(984, 25);
            toolStrip1.TabIndex = 13;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 22);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // ShowGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 557);
            Controls.Add(toolStrip1);
            Controls.Add(dateTimePicker);
            Controls.Add(statusStrip1);
            Controls.Add(numberOfShowsLabel);
            Controls.Add(searchButton);
            Controls.Add(roomComboBox);
            Controls.Add(filmComboBox);
            Controls.Add(roomLabel);
            Controls.Add(dateLabel);
            Controls.Add(menuStrip1);
            Controls.Add(filmLabel);
            Controls.Add(addNewButton);
            Controls.Add(dataGridView);
            Name = "ShowGUI";
            Text = "ShowGUI";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Button addNewButton;
        private Label filmLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem showToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private Label dateLabel;
        private Label roomLabel;
        private ComboBox filmComboBox;
        private ComboBox roomComboBox;
        private Button searchButton;
        private Label numberOfShowsLabel;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private DateTimePicker dateTimePicker;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
    }
}