namespace SE1735_Group6_A2.GUI
{
    partial class ShowAddEditGUI
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
            roomLabel = new Label();
            dateLabel = new Label();
            slotLabel = new Label();
            filmLabel = new Label();
            priceLabel = new Label();
            roomComboBox = new ComboBox();
            slotComboBox = new ComboBox();
            filmComboBox = new ComboBox();
            priceTextBox = new TextBox();
            saveButton = new Button();
            cancelButton = new Button();
            dateTimePicker = new DateTimePicker();
            SuspendLayout();
            // 
            // roomLabel
            // 
            roomLabel.AutoSize = true;
            roomLabel.Location = new Point(163, 74);
            roomLabel.Name = "roomLabel";
            roomLabel.Size = new Size(42, 15);
            roomLabel.TabIndex = 0;
            roomLabel.Text = "Room:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(163, 114);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(34, 15);
            dateLabel.TabIndex = 1;
            dateLabel.Text = "Date:";
            // 
            // slotLabel
            // 
            slotLabel.AutoSize = true;
            slotLabel.Location = new Point(163, 154);
            slotLabel.Name = "slotLabel";
            slotLabel.Size = new Size(30, 15);
            slotLabel.TabIndex = 2;
            slotLabel.Text = "Slot:";
            // 
            // filmLabel
            // 
            filmLabel.AutoSize = true;
            filmLabel.Location = new Point(163, 194);
            filmLabel.Name = "filmLabel";
            filmLabel.Size = new Size(33, 15);
            filmLabel.TabIndex = 3;
            filmLabel.Text = "Film:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(163, 234);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(36, 15);
            priceLabel.TabIndex = 4;
            priceLabel.Text = "Price:";
            // 
            // roomComboBox
            // 
            roomComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            roomComboBox.FormattingEnabled = true;
            roomComboBox.Location = new Point(341, 71);
            roomComboBox.Name = "roomComboBox";
            roomComboBox.Size = new Size(121, 23);
            roomComboBox.TabIndex = 1;
            roomComboBox.Leave += cboRoom_Leave;
            // 
            // slotComboBox
            // 
            slotComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            slotComboBox.FormattingEnabled = true;
            slotComboBox.Location = new Point(341, 151);
            slotComboBox.Name = "slotComboBox";
            slotComboBox.Size = new Size(121, 23);
            slotComboBox.TabIndex = 3;
            // 
            // filmComboBox
            // 
            filmComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            filmComboBox.FormattingEnabled = true;
            filmComboBox.Location = new Point(341, 191);
            filmComboBox.Name = "filmComboBox";
            filmComboBox.Size = new Size(121, 23);
            filmComboBox.TabIndex = 4;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(341, 231);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(100, 23);
            priceTextBox.TabIndex = 5;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(186, 294);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 6;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(355, 294);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 7;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.CustomFormat = "dd/MM/yyyy";
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.Location = new Point(341, 108);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(121, 23);
            dateTimePicker.TabIndex = 2;
            dateTimePicker.ValueChanged += date_ValueChanged;
            // 
            // ShowAddEditGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 375);
            Controls.Add(dateTimePicker);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(priceTextBox);
            Controls.Add(filmComboBox);
            Controls.Add(slotComboBox);
            Controls.Add(roomComboBox);
            Controls.Add(priceLabel);
            Controls.Add(filmLabel);
            Controls.Add(slotLabel);
            Controls.Add(dateLabel);
            Controls.Add(roomLabel);
            Name = "ShowAddEditGUI";
            Text = "ShowAddEditGUI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label roomLabel;
        private Label dateLabel;
        private Label slotLabel;
        private Label filmLabel;
        private Label priceLabel;
        private ComboBox roomComboBox;
        private ComboBox slotComboBox;
        private ComboBox filmComboBox;
        private TextBox priceTextBox;
        private Button saveButton;
        private Button cancelButton;
        private DateTimePicker dateTimePicker;
    }
}