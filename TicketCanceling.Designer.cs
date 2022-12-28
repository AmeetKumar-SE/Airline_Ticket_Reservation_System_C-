
namespace Airline_Reservation_System
{
    partial class TicketCanceling
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
            this.ticketComboBox = new System.Windows.Forms.ComboBox();
            this.txtFlightCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.CancelDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCancelID = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CancelDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ticketComboBox
            // 
            this.ticketComboBox.BackColor = System.Drawing.Color.Moccasin;
            this.ticketComboBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketComboBox.FormattingEnabled = true;
            this.ticketComboBox.Location = new System.Drawing.Point(471, 117);
            this.ticketComboBox.Name = "ticketComboBox";
            this.ticketComboBox.Size = new System.Drawing.Size(182, 27);
            this.ticketComboBox.TabIndex = 43;
            this.ticketComboBox.SelectionChangeCommitted += new System.EventHandler(this.ticketComboBox_SelectionChangeCommitted);
            // 
            // txtFlightCode
            // 
            this.txtFlightCode.BackColor = System.Drawing.Color.Moccasin;
            this.txtFlightCode.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlightCode.Location = new System.Drawing.Point(142, 167);
            this.txtFlightCode.Name = "txtFlightCode";
            this.txtFlightCode.Size = new System.Drawing.Size(182, 27);
            this.txtFlightCode.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Moccasin;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 40;
            this.label4.Text = "Flight Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Moccasin;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(362, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 38;
            this.label1.Text = "Ticket ID";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Silver;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(471, 227);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(131, 46);
            this.btnBack.TabIndex = 66;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Silver;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(350, 227);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 46);
            this.btnClear.TabIndex = 65;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(189, 227);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(155, 46);
            this.btnCancel.TabIndex = 64;
            this.btnCancel.Text = "Cancel Ticket";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CancelDataGridView
            // 
            this.CancelDataGridView.BackgroundColor = System.Drawing.Color.Moccasin;
            this.CancelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CancelDataGridView.Location = new System.Drawing.Point(1, 313);
            this.CancelDataGridView.Name = "CancelDataGridView";
            this.CancelDataGridView.RowHeadersWidth = 51;
            this.CancelDataGridView.RowTemplate.Height = 24;
            this.CancelDataGridView.Size = new System.Drawing.Size(798, 293);
            this.CancelDataGridView.TabIndex = 67;
            this.CancelDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CancelDataGridView_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Moccasin;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 68;
            this.label2.Text = "Cancel ID";
            // 
            // txtCancelID
            // 
            this.txtCancelID.BackColor = System.Drawing.Color.Moccasin;
            this.txtCancelID.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCancelID.Location = new System.Drawing.Point(142, 114);
            this.txtCancelID.Name = "txtCancelID";
            this.txtCancelID.Size = new System.Drawing.Size(182, 27);
            this.txtCancelID.TabIndex = 69;
            // 
            // lblLogin
            // 
            this.lblLogin.BackColor = System.Drawing.Color.Silver;
            this.lblLogin.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(267, 25);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(228, 47);
            this.lblLogin.TabIndex = 70;
            this.lblLogin.Text = "Ticket Canceling";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Silver;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(608, 227);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(153, 58);
            this.btnDelete.TabIndex = 71;
            this.btnDelete.Text = "Delete From Records";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // TicketCanceling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 606);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtCancelID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CancelDataGridView);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.ticketComboBox);
            this.Controls.Add(this.txtFlightCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "TicketCanceling";
            this.Text = "TicketCanceling";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TicketCanceling_FormClosing);
            this.Load += new System.EventHandler(this.TicketCanceling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CancelDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ticketComboBox;
        private System.Windows.Forms.TextBox txtFlightCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView CancelDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCancelID;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnDelete;
    }
}