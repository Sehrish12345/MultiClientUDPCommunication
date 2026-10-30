namespace MultiClientUDPCommunication
{
    partial class Client3Form
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
            btnRegister = new Button();
            cmbRecipient = new ComboBox();
            lblRecipient = new Label();
            lblEnterMessage = new Label();
            lblClientStatus = new Label();
            btnSendMessage = new Button();
            rtbMessageInput = new RichTextBox();
            rtbClientMessages = new RichTextBox();
            pnlClientHeader.SuspendLayout();
            grpClientMessages.SuspendLayout();
            SuspendLayout();
            // 
            // pnlClientHeader
            // 
            pnlClientHeader.BackColor = Color.DarkOrchid;
            pnlClientHeader.Controls.Add(lblClientTitle);
            pnlClientHeader.Location = new Point(0, 0);
            pnlClientHeader.Name = "pnlClientHeader";
            pnlClientHeader.Size = new Size(708, 45);
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
            lblClientTitle.Text = "UDP Client 3";
            lblClientTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // grpClientMessages
            // 
            grpClientMessages.Anchor = AnchorStyles.Top;
            grpClientMessages.Controls.Add(btnRegister);
            grpClientMessages.Controls.Add(cmbRecipient);
            grpClientMessages.Controls.Add(lblRecipient);
            grpClientMessages.Controls.Add(lblEnterMessage);
            grpClientMessages.Controls.Add(lblClientStatus);
            grpClientMessages.Controls.Add(btnSendMessage);
            grpClientMessages.Controls.Add(rtbMessageInput);
            grpClientMessages.Controls.Add(rtbClientMessages);
            grpClientMessages.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpClientMessages.Location = new Point(15, 60);
            grpClientMessages.Name = "grpClientMessages";
            grpClientMessages.Size = new Size(656, 282);
            grpClientMessages.TabIndex = 1;
            grpClientMessages.TabStop = false;
            grpClientMessages.Text = "Client Messages";
            grpClientMessages.Enter += grpClientMessages_Enter;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.DarkMagenta;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(393, 226);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(100, 35);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // cmbRecipient
            // 
            cmbRecipient.BackColor = Color.White;
            cmbRecipient.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRecipient.ForeColor = Color.DarkMagenta;
            cmbRecipient.FormattingEnabled = true;
            cmbRecipient.Items.AddRange(new object[] { "Client 1", "Client 2" });
            cmbRecipient.Location = new Point(510, 177);
            cmbRecipient.Name = "cmbRecipient";
            cmbRecipient.Size = new Size(127, 23);
            cmbRecipient.TabIndex = 6;
            // 
            // lblRecipient
            // 
            lblRecipient.AutoSize = true;
            lblRecipient.BackColor = Color.Transparent;
            lblRecipient.ForeColor = Color.DarkMagenta;
            lblRecipient.Location = new Point(459, 180);
            lblRecipient.Name = "lblRecipient";
            lblRecipient.Size = new Size(54, 15);
            lblRecipient.TabIndex = 5;
            lblRecipient.Text = "Send To:";
            lblRecipient.TextAlign = ContentAlignment.MiddleLeft;
            lblRecipient.Click += lblRecipient_Click;
            // 
            // lblEnterMessage
            // 
            lblEnterMessage.ForeColor = Color.DarkMagenta;
            lblEnterMessage.Location = new Point(15, 140);
            lblEnterMessage.Name = "lblEnterMessage";
            lblEnterMessage.Size = new Size(180, 25);
            lblEnterMessage.TabIndex = 4;
            lblEnterMessage.Text = "Enter Your Message:";
            lblEnterMessage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblClientStatus
            // 
            lblClientStatus.BackColor = Color.Transparent;
            lblClientStatus.ForeColor = Color.Firebrick;
            lblClientStatus.Location = new Point(15, 232);
            lblClientStatus.Name = "lblClientStatus";
            lblClientStatus.Size = new Size(200, 22);
            lblClientStatus.TabIndex = 3;
            lblClientStatus.Text = "● Disconnected";
            lblClientStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSendMessage
            // 
            btnSendMessage.BackColor = Color.DarkMagenta;
            btnSendMessage.FlatStyle = FlatStyle.Flat;
            btnSendMessage.ForeColor = Color.White;
            btnSendMessage.Location = new Point(510, 226);
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
            rtbMessageInput.Location = new Point(15, 168);
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
            // Client3Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(704, 381);
            Controls.Add(grpClientMessages);
            Controls.Add(pnlClientHeader);
            Name = "Client3Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UDP Client 3";
            Load += Client3Form_Load;
            pnlClientHeader.ResumeLayout(false);
            grpClientMessages.ResumeLayout(false);
            grpClientMessages.PerformLayout();
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
        private Label lblRecipient;
        private ComboBox cmbRecipient;
        private Button btnRegister;
    }
}