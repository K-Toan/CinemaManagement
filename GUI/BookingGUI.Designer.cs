namespace SE1735_Group4_A2.GUI
{
    partial class BookingGUI
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
            dataGridView = new DataGridView();
            btnAddBooking = new Button();
            btnBack = new Button();
            label1 = new Label();
            label2 = new Label();
            lblBookingNumber = new Label();
            tlpSeat = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(10, 204);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(679, 161);
            dataGridView.TabIndex = 1;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // btnAddBooking
            // 
            btnAddBooking.Location = new Point(12, 140);
            btnAddBooking.Margin = new Padding(3, 2, 3, 2);
            btnAddBooking.Name = "btnAddBooking";
            btnAddBooking.Size = new Size(158, 22);
            btnAddBooking.TabIndex = 2;
            btnAddBooking.Text = "Create a new booking...";
            btnAddBooking.UseVisualStyleBackColor = true;
            btnAddBooking.Click += btnAddBooking_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(607, 171);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(82, 22);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 178);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 4;
            label1.Text = "Number of bookings:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 178);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 121;
            // 
            // lblBookingNumber
            // 
            lblBookingNumber.AutoSize = true;
            lblBookingNumber.Location = new Point(138, 178);
            lblBookingNumber.Name = "lblBookingNumber";
            lblBookingNumber.Size = new Size(0, 15);
            lblBookingNumber.TabIndex = 122;
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
            tlpSeat.Location = new Point(241, 9);
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
            tlpSeat.TabIndex = 224;
            // 
            // BookingGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 374);
            Controls.Add(tlpSeat);
            Controls.Add(lblBookingNumber);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnAddBooking);
            Controls.Add(dataGridView);
            Margin = new Padding(3, 2, 3, 2);
            Name = "BookingGUI";
            Text = "BookingGUI";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Button btnAddBooking;
        private Button btnBack;
        private Label label1;
        private Label label2;
        private Label lblBookingNumber;
        private TableLayoutPanel tlpSeat;
    }
}