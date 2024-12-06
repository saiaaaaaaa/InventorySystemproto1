
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
            this.backpanel = new System.Windows.Forms.Panel();
            this.panelMiddle = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelMarkComplete = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonMarkAsComplete = new System.Windows.Forms.Button();
            this.toppanel = new System.Windows.Forms.Panel();
            this.panelDatetime = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblfromDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbltoDate = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btn_delivered = new System.Windows.Forms.Button();
            this.btn_allOrders = new System.Windows.Forms.Button();
            this.btn_incoming = new System.Windows.Forms.Button();
            this.btn_cancelled = new System.Windows.Forms.Button();
            this.backpanel.SuspendLayout();
            this.panelMiddle.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.panelMarkComplete.SuspendLayout();
            this.toppanel.SuspendLayout();
            this.panelDatetime.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // backpanel
            // 
            this.backpanel.Controls.Add(this.panelMiddle);
            this.backpanel.Controls.Add(this.toppanel);
            this.backpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backpanel.Location = new System.Drawing.Point(0, 0);
            this.backpanel.Name = "backpanel";
            this.backpanel.Size = new System.Drawing.Size(800, 450);
            this.backpanel.TabIndex = 16;
            // 
            // panelMiddle
            // 
            this.panelMiddle.BackColor = System.Drawing.Color.RosyBrown;
            this.panelMiddle.Controls.Add(this.panel1);
            this.panelMiddle.Controls.Add(this.panelBottom);
            this.panelMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMiddle.Location = new System.Drawing.Point(0, 98);
            this.panelMiddle.Name = "panelMiddle";
            this.panelMiddle.Size = new System.Drawing.Size(800, 352);
            this.panelMiddle.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 296);
            this.panel1.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 296);
            this.dataGridView1.TabIndex = 1;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.panelMarkComplete);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 296);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(800, 56);
            this.panelBottom.TabIndex = 19;
            // 
            // panelMarkComplete
            // 
            this.panelMarkComplete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.panelMarkComplete.Controls.Add(this.checkBox1);
            this.panelMarkComplete.Controls.Add(this.buttonMarkAsComplete);
            this.panelMarkComplete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMarkComplete.Location = new System.Drawing.Point(0, 0);
            this.panelMarkComplete.Name = "panelMarkComplete";
            this.panelMarkComplete.Size = new System.Drawing.Size(800, 56);
            this.panelMarkComplete.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(760, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(40, 56);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "All";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // buttonMarkAsComplete
            // 
            this.buttonMarkAsComplete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMarkAsComplete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(144)))), ((int)(((byte)(128)))));
            this.buttonMarkAsComplete.FlatAppearance.BorderSize = 0;
            this.buttonMarkAsComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMarkAsComplete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMarkAsComplete.ForeColor = System.Drawing.Color.White;
            this.buttonMarkAsComplete.Location = new System.Drawing.Point(651, 10);
            this.buttonMarkAsComplete.Name = "buttonMarkAsComplete";
            this.buttonMarkAsComplete.Size = new System.Drawing.Size(100, 34);
            this.buttonMarkAsComplete.TabIndex = 0;
            this.buttonMarkAsComplete.Text = "Complete";
            this.buttonMarkAsComplete.UseVisualStyleBackColor = false;
            // 
            // toppanel
            // 
            this.toppanel.AutoSize = true;
            this.toppanel.BackColor = System.Drawing.SystemColors.Control;
            this.toppanel.Controls.Add(this.panelDatetime);
            this.toppanel.Controls.Add(this.panelButtons);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(800, 98);
            this.toppanel.TabIndex = 17;
            // 
            // panelDatetime
            // 
            this.panelDatetime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.panelDatetime.Controls.Add(this.dateTimePicker2);
            this.panelDatetime.Controls.Add(this.lblfromDate);
            this.panelDatetime.Controls.Add(this.dateTimePicker1);
            this.panelDatetime.Controls.Add(this.lbltoDate);
            this.panelDatetime.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDatetime.Location = new System.Drawing.Point(0, 0);
            this.panelDatetime.Name = "panelDatetime";
            this.panelDatetime.Size = new System.Drawing.Size(800, 55);
            this.panelDatetime.TabIndex = 16;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(677, 18);
            this.dateTimePicker2.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker2.Size = new System.Drawing.Size(104, 23);
            this.dateTimePicker2.TabIndex = 13;
            this.dateTimePicker2.Value = new System.DateTime(2024, 11, 19, 0, 0, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged_1);
            // 
            // lblfromDate
            // 
            this.lblfromDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblfromDate.AutoSize = true;
            this.lblfromDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfromDate.Location = new System.Drawing.Point(499, 24);
            this.lblfromDate.Name = "lblfromDate";
            this.lblfromDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblfromDate.Size = new System.Drawing.Size(38, 15);
            this.lblfromDate.TabIndex = 11;
            this.lblfromDate.Text = "From:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(538, 18);
            this.dateTimePicker1.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(104, 23);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.Value = new System.DateTime(2024, 11, 19, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // lbltoDate
            // 
            this.lbltoDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltoDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltoDate.Location = new System.Drawing.Point(651, 24);
            this.lbltoDate.Name = "lbltoDate";
            this.lbltoDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbltoDate.Size = new System.Drawing.Size(32, 17);
            this.lbltoDate.TabIndex = 12;
            this.lbltoDate.Text = "To:";
            // 
            // panelButtons
            // 
            this.panelButtons.AutoSize = true;
            this.panelButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelButtons.Controls.Add(this.btn_delivered);
            this.panelButtons.Controls.Add(this.btn_allOrders);
            this.panelButtons.Controls.Add(this.btn_incoming);
            this.panelButtons.Controls.Add(this.btn_cancelled);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 55);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(800, 43);
            this.panelButtons.TabIndex = 15;
            // 
            // btn_delivered
            // 
            this.btn_delivered.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_delivered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(144)))), ((int)(((byte)(128)))));
            this.btn_delivered.FlatAppearance.BorderSize = 0;
            this.btn_delivered.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delivered.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delivered.ForeColor = System.Drawing.Color.White;
            this.btn_delivered.Location = new System.Drawing.Point(201, 3);
            this.btn_delivered.Name = "btn_delivered";
            this.btn_delivered.Size = new System.Drawing.Size(100, 34);
            this.btn_delivered.TabIndex = 7;
            this.btn_delivered.Text = "Delivered";
            this.btn_delivered.UseVisualStyleBackColor = false;
            this.btn_delivered.Click += new System.EventHandler(this.btn_delivered_Click);
            // 
            // btn_allOrders
            // 
            this.btn_allOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_allOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(144)))), ((int)(((byte)(128)))));
            this.btn_allOrders.FlatAppearance.BorderSize = 0;
            this.btn_allOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_allOrders.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_allOrders.ForeColor = System.Drawing.Color.White;
            this.btn_allOrders.Location = new System.Drawing.Point(6, 5);
            this.btn_allOrders.Name = "btn_allOrders";
            this.btn_allOrders.Size = new System.Drawing.Size(83, 31);
            this.btn_allOrders.TabIndex = 5;
            this.btn_allOrders.TabStop = false;
            this.btn_allOrders.Text = "All orders";
            this.btn_allOrders.UseVisualStyleBackColor = false;
            this.btn_allOrders.Click += new System.EventHandler(this.btn_allOrders_Click);
            // 
            // btn_incoming
            // 
            this.btn_incoming.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_incoming.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(144)))), ((int)(((byte)(128)))));
            this.btn_incoming.FlatAppearance.BorderSize = 0;
            this.btn_incoming.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_incoming.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_incoming.ForeColor = System.Drawing.Color.White;
            this.btn_incoming.Location = new System.Drawing.Point(95, 3);
            this.btn_incoming.Name = "btn_incoming";
            this.btn_incoming.Size = new System.Drawing.Size(100, 34);
            this.btn_incoming.TabIndex = 6;
            this.btn_incoming.Text = "Incoming";
            this.btn_incoming.UseVisualStyleBackColor = false;
            this.btn_incoming.Click += new System.EventHandler(this.btn_incoming_Click);
            // 
            // btn_cancelled
            // 
            this.btn_cancelled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(144)))), ((int)(((byte)(128)))));
            this.btn_cancelled.FlatAppearance.BorderSize = 0;
            this.btn_cancelled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelled.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelled.ForeColor = System.Drawing.Color.White;
            this.btn_cancelled.Location = new System.Drawing.Point(307, 4);
            this.btn_cancelled.Name = "btn_cancelled";
            this.btn_cancelled.Size = new System.Drawing.Size(100, 34);
            this.btn_cancelled.TabIndex = 8;
            this.btn_cancelled.Text = "Cancelled";
            this.btn_cancelled.UseVisualStyleBackColor = false;
            this.btn_cancelled.Click += new System.EventHandler(this.btn_cancelled_Click);
            // 
            // OrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderHistory";
            this.Text = "OrderHistory";
            this.backpanel.ResumeLayout(false);
            this.backpanel.PerformLayout();
            this.panelMiddle.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelMarkComplete.ResumeLayout(false);
            this.panelMarkComplete.PerformLayout();
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            this.panelDatetime.ResumeLayout(false);
            this.panelDatetime.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel backpanel;
        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btn_delivered;
        private System.Windows.Forms.Button btn_allOrders;
        private System.Windows.Forms.Button btn_incoming;
        private System.Windows.Forms.Button btn_cancelled;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbltoDate;
        private System.Windows.Forms.Label lblfromDate;
        private System.Windows.Forms.Panel panelDatetime;
        private System.Windows.Forms.Panel panelMiddle;
        private System.Windows.Forms.Panel panelMarkComplete;
        private System.Windows.Forms.Button buttonMarkAsComplete;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
    }
}