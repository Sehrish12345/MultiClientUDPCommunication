namespace MultiClientUDPCommunication
{
    partial class ServerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlServerHeader = new Panel();
            lblServerTitle = new Label();
            grpServerControl = new GroupBox();
            lvConnectedClients = new ListView();
            colClientName = new ColumnHeader();
            colClientIP = new ColumnHeader();
            lblServerStatus = new Label();
            btnStartServer = new Button();
            lblPortNumber = new Label();
            lblServerPort = new Label();
            grpServerMessages = new GroupBox();
            rtbServerMessages = new RichTextBox();
            pnlServerHeader.SuspendLayout();
            grpServerControl.SuspendLayout();
            grpServerMessages.SuspendLayout();
            SuspendLayout();
            // 
            // pnlServerHeader
            // 
            pnlServerHeader.BackColor = Color.SteelBlue;
            pnlServerHeader.Controls.Add(lblServerTitle);
            pnlServerHeader.ForeColor = Color.White;
            pnlServerHeader.Location = new Point(0, 0);
            pnlServerHeader.Name = "pnlServerHeader";
            pnlServerHeader.Size = new Size(703, 45);
            pnlServerHeader.TabIndex = 0;
            // 
            // lblServerTitle
            // 
            lblServerTitle.BackColor = Color.Transparent;
            lblServerTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblServerTitle.Location = new Point(15, 10);
            lblServerTitle.Name = "lblServerTitle";
            lblServerTitle.Size = new Size(250, 25);
            lblServerTitle.TabIndex = 0;
            lblServerTitle.Text = "UDP Server";
            lblServerTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // grpServerControl
            // 
            grpServerControl.Controls.Add(lvConnectedClients);
            grpServerControl.Controls.Add(lblServerStatus);
            grpServerControl.Controls.Add(btnStartServer);
            grpServerControl.Controls.Add(lblPortNumber);
            grpServerControl.Controls.Add(lblServerPort);
            grpServerControl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpServerControl.ForeColor = Color.SteelBlue;
            grpServerControl.Location = new Point(15, 55);
            grpServerControl.Name = "grpServerControl";
            grpServerControl.Size = new Size(310, 294);
            grpServerControl.TabIndex = 0;
            grpServerControl.TabStop = false;
            grpServerControl.Text = "Server Control";
            grpServerControl.Enter += grpServerControl_Enter;
            // 
            // lvConnectedClients
            // 
            lvConnectedClients.BackColor = Color.White;
            lvConnectedClients.Columns.AddRange(new ColumnHeader[] { colClientName, colClientIP });
            lvConnectedClients.ForeColor = Color.SteelBlue;
            lvConnectedClients.FullRowSelect = true;
            lvConnectedClients.GridLines = true;
            lvConnectedClients.Location = new Point(15, 105);
            lvConnectedClients.Name = "lvConnectedClients";
            lvConnectedClients.Size = new Size(270, 159);
            lvConnectedClients.TabIndex = 4;
            lvConnectedClients.UseCompatibleStateImageBehavior = false;
            lvConnectedClients.View = View.Details;
            // 
            // colClientName
            // 
            colClientName.Text = "Client Name";
            colClientName.Width = 125;
            // 
            // colClientIP
            // 
            colClientIP.Text = "Client IP";
            colClientIP.Width = 125;
            // 
            // lblServerStatus
            // 
            lblServerStatus.BackColor = Color.Transparent;
            lblServerStatus.ForeColor = Color.Firebrick;
            lblServerStatus.Location = new Point(145, 70);
            lblServerStatus.Name = "lblServerStatus";
            lblServerStatus.Size = new Size(130, 25);
            lblServerStatus.TabIndex = 3;
            lblServerStatus.Text = "● Stopped";
            lblServerStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnStartServer
            // 
            btnStartServer.BackColor = Color.RoyalBlue;
            btnStartServer.FlatStyle = FlatStyle.Flat;
            btnStartServer.ForeColor = Color.White;
            btnStartServer.Location = new Point(15, 65);
            btnStartServer.Name = "btnStartServer";
            btnStartServer.Size = new Size(120, 32);
            btnStartServer.TabIndex = 2;
            btnStartServer.Text = "Start Server";
            btnStartServer.UseVisualStyleBackColor = false;
            btnStartServer.Click += btnStartServer_Click;
            // 
            // lblPortNumber
            // 
            lblPortNumber.BackColor = Color.Transparent;
            lblPortNumber.Location = new Point(110, 30);
            lblPortNumber.Name = "lblPortNumber";
            lblPortNumber.Size = new Size(60, 22);
            lblPortNumber.TabIndex = 1;
            lblPortNumber.Text = "5000";
            lblPortNumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblServerPort
            // 
            lblServerPort.BackColor = Color.Transparent;
            lblServerPort.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblServerPort.Location = new Point(15, 30);
            lblServerPort.Name = "lblServerPort";
            lblServerPort.Size = new Size(90, 22);
            lblServerPort.TabIndex = 0;
            lblServerPort.Text = "Server Port:";
            lblServerPort.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // grpServerMessages
            // 
            grpServerMessages.Controls.Add(rtbServerMessages);
            grpServerMessages.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpServerMessages.ForeColor = Color.SteelBlue;
            grpServerMessages.Location = new Point(330, 55);
            grpServerMessages.Name = "grpServerMessages";
            grpServerMessages.Size = new Size(300, 250);
            grpServerMessages.TabIndex = 1;
            grpServerMessages.TabStop = false;
            grpServerMessages.Text = "Server Messages";
            // 
            // rtbServerMessages
            // 
            rtbServerMessages.BackColor = Color.White;
            rtbServerMessages.BorderStyle = BorderStyle.FixedSingle;
            rtbServerMessages.ForeColor = Color.Black;
            rtbServerMessages.Location = new Point(15, 22);
            rtbServerMessages.Name = "rtbServerMessages";
            rtbServerMessages.ReadOnly = true;
            rtbServerMessages.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbServerMessages.Size = new Size(270, 269);
            rtbServerMessages.TabIndex = 0;
            rtbServerMessages.Text = "";
            // 
            // ServerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(704, 381);
            Controls.Add(grpServerMessages);
            Controls.Add(grpServerControl);
            Controls.Add(pnlServerHeader);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(660, 350);
            Name = "ServerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UDP Server";
            Load += ServerForm_Load;
            pnlServerHeader.ResumeLayout(false);
            grpServerControl.ResumeLayout(false);
            grpServerMessages.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlServerHeader;
        private Label lblServerTitle;
        private GroupBox grpServerControl;
        private Label lblServerPort;
        private Label lblPortNumber;
        private Button btnStartServer;
        private Label lblServerStatus;
        private ListView lvConnectedClients;
        private ColumnHeader colClientName;
        private ColumnHeader colClientIP;
        private GroupBox grpServerMessages;
        private RichTextBox rtbServerMessages;
    }
}
