namespace MultiClientUDPCommunication
{
    partial class Client2Form
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
            pnlClientHeader = new Panel();
            lblClientTitle = new Label();
            grpClientMessages = new GroupBox();
            cmbRecipient = new ComboBox();
            lblRecipient = new Label();
            lblEnterMessage = new Label();
            lblClientStatus = new Label();
            btnSendMessage = new Button();
            rtbMessageInput = new RichTextBox();
            rtbClientMessages = new RichTextBox();
            btnRegister = new Button();
            pnlClientHeader.SuspendLayout();
            grpClientMessages.SuspendLayout();
            SuspendLayout();
            // 
            // pnlClientHeader
            // 
            pnlClientHeader.BackColor = Color.SeaGreen;
            pnlClientHeader.Controls.Add(lblClientTitle);
            pnlClientHeader.Location = new Point(0, 0);
            pnlClientHeader.Name = "pnlClientHeader";
            pnlClientHeader.Size = new Size(704, 45);
            pnlClientHeader.TabIndex = 0;
            // 
            // lblClientTitle
            // 
            lblClientTitle.BackColor = Color.Transparent;
            lblClientTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClientTitle.ForeColor = Color.White;
            lblClientTitle.Location = new Point(15, 10);
            lblClientTitle.Name = "lblClientTitle";
            lblClientTitle.Size = new Size(250, 25);
            lblClientTitle.TabIndex = 0;
            lblClientTitle.Text = "UDP Client 2";
            lblClientTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // grpClientMessages
            // 
            grpClientMessages.Controls.Add(btnRegister);
            grpClientMessages.Controls.Add(cmbRecipient);
            grpClientMessages.Controls.Add(lblRecipient);
            grpClientMessages.Controls.Add(lblEnterMessage);
            grpClientMessages.Controls.Add(lblClientStatus);
            grpClientMessages.Controls.Add(btnSendMessage);
            grpClientMessages.Controls.Add(rtbMessageInput);
            grpClientMessages.Controls.Add(rtbClientMessages);
            grpClientMessages.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpClientMessages.ForeColor = Color.DarkGreen;
            grpClientMessages.Location = new Point(15, 60);
            grpClientMessages.Name = "grpClientMessages";
            grpClientMessages.Size = new Size(658, 293);
            grpClientMessages.TabIndex = 1;
            grpClientMessages.TabStop = false;
            grpClientMessages.Text = "Client Messages";
            grpClientMessages.Enter += grpClientMessages_Enter;
            // 
            // cmbRecipient
            // 
            cmbRecipient.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRecipient.ForeColor = Color.DarkGreen;
            cmbRecipient.FormattingEnabled = true;
            cmbRecipient.Items.AddRange(new object[] { "Client 1", "Client 3" });
            cmbRecipient.Location = new Point(512, 170);
            cmbRecipient.Name = "cmbRecipient";
            cmbRecipient.Size = new Size(125, 23);
            cmbRecipient.TabIndex = 6;
            cmbRecipient.SelectedIndexChanged += cmbRecipient_SelectedIndexChanged;
            // 
            // lblRecipient
            // 
            lblRecipient.ForeColor = Color.DarkGreen;
            lblRecipient.Location = new Point(459, 173);
            lblRecipient.Name = "lblRecipient";
            lblRecipient.Size = new Size(65, 25);
            lblRecipient.TabIndex = 5;
            lblRecipient.Text = "Send To:";
            lblRecipient.Click += lblRecipient_Click;
            // 
            // lblEnterMessage
            // 
            lblEnterMessage.ForeColor = Color.DarkGreen;
            lblEnterMessage.ImageAlign = ContentAlignment.MiddleLeft;
            lblEnterMessage.Location = new Point(15, 140);
            lblEnterMessage.Name = "lblEnterMessage";
            lblEnterMessage.Size = new Size(180, 25);
            lblEnterMessage.TabIndex = 4;
            lblEnterMessage.Text = "Enter Your Message:";
            lblEnterMessage.Click += lblEnterMessage_Click;
            // 
            // lblClientStatus
            // 
            lblClientStatus.BackColor = Color.Transparent;
            lblClientStatus.ForeColor = Color.Firebrick;
            lblClientStatus.Location = new Point(15, 225);
            lblClientStatus.Name = "lblClientStatus";
            lblClientStatus.Size = new Size(180, 22);
            lblClientStatus.TabIndex = 3;
            lblClientStatus.Text = "● Disconnected";
            lblClientStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSendMessage
            // 
            btnSendMessage.BackColor = Color.DarkGreen;
            btnSendMessage.FlatStyle = FlatStyle.Flat;
            btnSendMessage.ForeColor = Color.White;
            btnSendMessage.Location = new Point(512, 219);
            btnSendMessage.Name = "btnSendMessage";
            btnSendMessage.Size = new Size(100, 35);
            btnSendMessage.TabIndex = 2;
            btnSendMessage.Text = "Send";
            btnSendMessage.UseVisualStyleBackColor = false;
            btnSendMessage.Click += btnSendMessage_Click;
            // 
            // rtbMessageInput
            // 
            rtbMessageInput.BackColor = Color.White;
            rtbMessageInput.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbMessageInput.Location = new Point(15, 165);
            rtbMessageInput.Name = "rtbMessageInput";
            rtbMessageInput.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbMessageInput.Size = new Size(438, 45);
            rtbMessageInput.TabIndex = 1;
            rtbMessageInput.Text = "";
            rtbMessageInput.TextChanged += rtbMessageInput_TextChanged;
            // 
            // rtbClientMessages
            // 
            rtbClientMessages.BackColor = Color.White;
            rtbClientMessages.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbClientMessages.Location = new Point(15, 25);
            rtbClientMessages.Name = "rtbClientMessages";
            rtbClientMessages.ReadOnly = true;
            rtbClientMessages.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbClientMessages.Size = new Size(622, 110);
            rtbClientMessages.TabIndex = 0;
            rtbClientMessages.Text = "";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.DarkGreen;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(397, 219);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(100, 35);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += button1_Click;
            // 
            // Client2Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(704, 381);
            Controls.Add(grpClientMessages);
            Controls.Add(pnlClientHeader);
            Name = "Client2Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UDP Client 2";
            pnlClientHeader.ResumeLayout(false);
            grpClientMessages.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlClientHeader;
        private Label lblClientTitle;
        private GroupBox grpClientMessages;
        private RichTextBox rtbClientMessages;
        private Button btnSendMessage;
        private RichTextBox rtbMessageInput;
        private Label lblClientStatus;
        private Label lblEnterMessage;
        private ComboBox cmbRecipient;
        private Label lblRecipient;
        private Button btnRegister;
    }
}