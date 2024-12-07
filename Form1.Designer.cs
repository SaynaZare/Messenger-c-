namespace messanger_sayna
{
    partial class Form1
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
            this.TBarClient = new System.Windows.Forms.TrackBar();
            this.BTNValue = new System.Windows.Forms.Button();
            this.JSONBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.IPAdressText = new System.Windows.Forms.TextBox();
            this.LblIP = new System.Windows.Forms.TextBox();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.SenderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MessageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsernameText = new System.Windows.Forms.TextBox();
            this.Usernamelbl = new System.Windows.Forms.TextBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.groupBoxMessage = new System.Windows.Forms.GroupBox();
            this.textMessage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TBarClient)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.groupBoxMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBarClient
            // 
            this.TBarClient.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TBarClient.Location = new System.Drawing.Point(114, 558);
            this.TBarClient.Maximum = 100;
            this.TBarClient.Minimum = 50;
            this.TBarClient.Name = "TBarClient";
            this.TBarClient.Size = new System.Drawing.Size(302, 90);
            this.TBarClient.TabIndex = 0;
            this.TBarClient.TickFrequency = 10;
            this.TBarClient.Value = 50;
            this.TBarClient.Scroll += new System.EventHandler(this.TBarClient_Scroll_1);
            // 
            // BTNValue
            // 
            this.BTNValue.Location = new System.Drawing.Point(30, 558);
            this.BTNValue.Name = "BTNValue";
            this.BTNValue.Size = new System.Drawing.Size(75, 72);
            this.BTNValue.TabIndex = 2;
            this.BTNValue.Text = "A";
            this.BTNValue.UseVisualStyleBackColor = true;
            // 
            // JSONBox
            // 
            this.JSONBox.Location = new System.Drawing.Point(456, 543);
            this.JSONBox.Multiline = true;
            this.JSONBox.Name = "JSONBox";
            this.JSONBox.Size = new System.Drawing.Size(668, 138);
            this.JSONBox.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.IPAdressText);
            this.panel1.Controls.Add(this.LblIP);
            this.panel1.Location = new System.Drawing.Point(16, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 75);
            this.panel1.TabIndex = 5;
            // 
            // IPAdressText
            // 
            this.IPAdressText.Location = new System.Drawing.Point(111, 23);
            this.IPAdressText.Name = "IPAdressText";
            this.IPAdressText.Size = new System.Drawing.Size(124, 26);
            this.IPAdressText.TabIndex = 1;
            // 
            // LblIP
            // 
            this.LblIP.BackColor = System.Drawing.SystemColors.Control;
            this.LblIP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LblIP.Location = new System.Drawing.Point(12, 25);
            this.LblIP.Name = "LblIP";
            this.LblIP.Size = new System.Drawing.Size(96, 19);
            this.LblIP.TabIndex = 0;
            this.LblIP.Text = "IP Address:";
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ConnectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ConnectBtn.Location = new System.Drawing.Point(294, 49);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(88, 48);
            this.ConnectBtn.TabIndex = 6;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToOrderColumns = true;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SenderColumn,
            this.MessageColumn,
            this.TimeColumn});
            this.dataGrid.Location = new System.Drawing.Point(456, 20);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 82;
            this.dataGrid.RowTemplate.Height = 33;
            this.dataGrid.Size = new System.Drawing.Size(668, 505);
            this.dataGrid.TabIndex = 7;
            // 
            // SenderColumn
            // 
            this.SenderColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SenderColumn.HeaderText = "Sender";
            this.SenderColumn.MinimumWidth = 10;
            this.SenderColumn.Name = "SenderColumn";
            this.SenderColumn.ReadOnly = true;
            this.SenderColumn.Width = 106;
            // 
            // MessageColumn
            // 
            this.MessageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MessageColumn.HeaderText = "Message";
            this.MessageColumn.MinimumWidth = 10;
            this.MessageColumn.Name = "MessageColumn";
            this.MessageColumn.ReadOnly = true;
            // 
            // TimeColumn
            // 
            this.TimeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TimeColumn.HeaderText = "Time";
            this.TimeColumn.MinimumWidth = 10;
            this.TimeColumn.Name = "TimeColumn";
            this.TimeColumn.ReadOnly = true;
            this.TimeColumn.Width = 88;
            // 
            // UsernameText
            // 
            this.UsernameText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UsernameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameText.Location = new System.Drawing.Point(112, 28);
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.Size = new System.Drawing.Size(260, 19);
            this.UsernameText.TabIndex = 8;
            this.UsernameText.Text = "client";
            this.UsernameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Usernamelbl
            // 
            this.Usernamelbl.BackColor = System.Drawing.SystemColors.Control;
            this.Usernamelbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Usernamelbl.Location = new System.Drawing.Point(8, 28);
            this.Usernamelbl.Name = "Usernamelbl";
            this.Usernamelbl.Size = new System.Drawing.Size(81, 19);
            this.Usernamelbl.TabIndex = 9;
            this.Usernamelbl.Text = "username:";
            // 
            // txtSend
            // 
            this.txtSend.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSend.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSend.Location = new System.Drawing.Point(15, 55);
            this.txtSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(357, 19);
            this.txtSend.TabIndex = 10;
            this.txtSend.Text = "write your message here!";
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sendBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sendBtn.Location = new System.Drawing.Point(8, 85);
            this.sendBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(364, 40);
            this.sendBtn.TabIndex = 11;
            this.sendBtn.Text = "SEND";
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // groupBoxMessage
            // 
            this.groupBoxMessage.Controls.Add(this.textMessage);
            this.groupBoxMessage.Controls.Add(this.Usernamelbl);
            this.groupBoxMessage.Controls.Add(this.UsernameText);
            this.groupBoxMessage.Controls.Add(this.sendBtn);
            this.groupBoxMessage.Controls.Add(this.txtSend);
            this.groupBoxMessage.Location = new System.Drawing.Point(16, 157);
            this.groupBoxMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxMessage.Name = "groupBoxMessage";
            this.groupBoxMessage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxMessage.Size = new System.Drawing.Size(386, 331);
            this.groupBoxMessage.TabIndex = 12;
            this.groupBoxMessage.TabStop = false;
            this.groupBoxMessage.Text = "Client";
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(8, 134);
            this.textMessage.Multiline = true;
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(364, 189);
            this.textMessage.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1136, 738);
            this.Controls.Add(this.groupBoxMessage);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.JSONBox);
            this.Controls.Add(this.BTNValue);
            this.Controls.Add(this.TBarClient);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TBarClient)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.groupBoxMessage.ResumeLayout(false);
            this.groupBoxMessage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar TBarClient;
        private System.Windows.Forms.Button BTNValue;
        private System.Windows.Forms.TextBox JSONBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox LblIP;
        private System.Windows.Forms.TextBox IPAdressText;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.TextBox UsernameText;
        private System.Windows.Forms.TextBox Usernamelbl;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.GroupBox groupBoxMessage;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn SenderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MessageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeColumn;
    }
}

