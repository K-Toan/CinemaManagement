namespace SE1735_Group4_A2.GUI
{
    partial class BookingAddGUI
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
            tlpSeat = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tbName = new TextBox();
            tbAmount = new TextBox();
            lblAmount = new Label();
            lblName = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tlpSeat
            // 
            tlpSeat.ColumnCount = 10;
            tlpSeat.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlpSeat.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlpSeat.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlpSeat.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlpSeat.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlpSeat.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlpSeat.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlpSeat.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlpSeat.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlpSeat.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlpSeat.Location = new Point(199, 9);
            tlpSeat.Margin = new Padding(3, 2, 3, 2);
            tlpSeat.Name = "tlpSeat";
            tlpSeat.RowCount = 10;
            tlpSeat.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpSeat.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpSeat.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpSeat.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpSeat.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpSeat.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpSeat.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpSeat.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpSeat.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpSeat.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpSeat.Size = new Size(219, 184);
            tlpSeat.TabIndex = 225;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.15923F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.840765F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 191F));
            tableLayoutPanel1.Controls.Add(tbName, 2, 0);
            tableLayoutPanel1.Controls.Add(tbAmount, 2, 1);
            tableLayoutPanel1.Controls.Add(lblAmount, 0, 1);
            tableLayoutPanel1.Controls.Add(lblName, 0, 0);
            tableLayoutPanel1.Location = new Point(61, 220);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(328, 71);
            tableLayoutPanel1.TabIndex = 226;
            // 
            // tbName
            // 
            tbName.Location = new Point(139, 2);
            tbName.Margin = new Padding(3, 2, 3, 2);
            tbName.Name = "tbName";
            tbName.Size = new Size(110, 23);
            tbName.TabIndex = 2;
            // 
            // tbAmount
            // 
            tbAmount.Location = new Point(139, 37);
            tbAmount.Margin = new Padding(3, 2, 3, 2);
            tbAmount.Name = "tbAmount";
            tbAmount.Size = new Size(110, 23);
            tbAmount.TabIndex = 3;
            // 
            // lblAmount
            // 
            lblAmount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(48, 39);
            lblAmount.Margin = new Padding(3, 4, 3, 0);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(51, 15);
            lblAmount.TabIndex = 1;
            lblAmount.Text = "Amount";
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblName.AutoSize = true;
            lblName.Location = new Point(60, 4);
            lblName.Margin = new Padding(3, 4, 3, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(190, 336);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(92, 32);
            btnSave.TabIndex = 227;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(336, 336);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(97, 32);
            btnCancel.TabIndex = 228;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // BookingAddGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 409);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tlpSeat);
            Margin = new Padding(3, 2, 3, 2);
            Name = "BookingAddGUI";
            Text = "BookingAddGUI";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpSeat;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblAmount;
        private Label lblName;
        private TextBox tbName;
        private TextBox tbAmount;
        private Button btnSave;
        private Button btnCancel;
    }
}