
namespace InventorySystemproto1
{
    partial class OrderHistory
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_cancelled = new System.Windows.Forms.Button();
            this.btn_delivered = new System.Windows.Forms.Button();
            this.btn_incoming = new System.Windows.Forms.Button();
            this.btn_allOrders = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblfromDate = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lbltoDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 332);
            this.dataGridView1.TabIndex = 1;
            // 
            // btn_cancelled
            // 
            this.btn_cancelled.Location = new System.Drawing.Point(300, 3);
            this.btn_cancelled.Name = "btn_cancelled";
            this.btn_cancelled.Size = new System.Drawing.Size(100, 34);
            this.btn_cancelled.TabIndex = 8;
            this.btn_cancelled.Text = "Cancelled";
            this.btn_cancelled.UseVisualStyleBackColor = true;
            this.btn_cancelled.Click += new System.EventHandler(this.btn_cancelled_Click);
            // 
            // btn_delivered
            // 
            this.btn_delivered.Location = new System.Drawing.Point(200, 3);
            this.btn_delivered.Name = "btn_delivered";
            this.btn_delivered.Size = new System.Drawing.Size(100, 34);
            this.btn_delivered.TabIndex = 7;
            this.btn_delivered.Text = "Delivered";
            this.btn_delivered.UseVisualStyleBackColor = true;
            this.btn_delivered.Click += new System.EventHandler(this.btn_delivered_Click);
            // 
            // btn_incoming
            // 
            this.btn_incoming.Location = new System.Drawing.Point(100, 3);
            this.btn_incoming.Name = "btn_incoming";
            this.btn_incoming.Size = new System.Drawing.Size(100, 34);
            this.btn_incoming.TabIndex = 6;
            this.btn_incoming.Text = "Incoming";
            this.btn_incoming.UseVisualStyleBackColor = true;
            this.btn_incoming.Click += new System.EventHandler(this.btn_incoming_Click);
            // 
            // btn_allOrders
            // 
            this.btn_allOrders.Location = new System.Drawing.Point(0, 3);
            this.btn_allOrders.Name = "btn_allOrders";
            this.btn_allOrders.Size = new System.Drawing.Size(100, 34);
            this.btn_allOrders.TabIndex = 5;
            this.btn_allOrders.TabStop = false;
            this.btn_allOrders.Text = "All orders";
            this.btn_allOrders.UseVisualStyleBackColor = true;
            this.btn_allOrders.Click += new System.EventHandler(this.btn_allOrders_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.btn_delivered);
            this.panel1.Controls.Add(this.btn_allOrders);
            this.panel1.Controls.Add(this.btn_incoming);
            this.panel1.Controls.Add(this.btn_cancelled);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 40);
            this.panel1.TabIndex = 15;
            // 
            // lblfromDate
            // 
            this.lblfromDate.AutoSize = true;
            this.lblfromDate.Location = new System.Drawing.Point(190, 29);
            this.lblfromDate.Name = "lblfromDate";
            this.lblfromDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblfromDate.Size = new System.Drawing.Size(33, 13);
            this.lblfromDate.TabIndex = 11;
            this.lblfromDate.Text = "From:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(368, 22);
            this.dateTimePicker2.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker2.Size = new System.Drawing.Size(104, 20);
            this.dateTimePicker2.TabIndex = 13;
            this.dateTimePicker2.Value = new System.DateTime(2024, 11, 19, 0, 0, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged_1);
            // 
            // lbltoDate
            // 
            this.lbltoDate.AutoSize = true;
            this.lbltoDate.Location = new System.Drawing.Point(339, 28);
            this.lbltoDate.Name = "lbltoDate";
            this.lbltoDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbltoDate.Size = new System.Drawing.Size(23, 13);
            this.lbltoDate.TabIndex = 12;
            this.lbltoDate.Text = "To:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(229, 22);
            this.dateTimePicker1.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(104, 20);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.Value = new System.DateTime(2024, 11, 19, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.lblfromDate);
            this.panel2.Controls.Add(this.lbltoDate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 49);
            this.panel2.TabIndex = 16;
            // 
            // OrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderHistory";
            this.Text = "OrderHistory";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_cancelled;
        private System.Windows.Forms.Button btn_delivered;
        private System.Windows.Forms.Button btn_incoming;
        private System.Windows.Forms.Button btn_allOrders;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblfromDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lbltoDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel2;
    }
}