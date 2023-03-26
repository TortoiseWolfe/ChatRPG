namespace ChatRPG
{
    partial class Form1
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
            TxtBox_Chat_Input = new TextBox();
            ListBox_Chat = new ListBox();
            Btn_Send = new Button();
            SuspendLayout();
            // 
            // TxtBox_Chat_Input
            // 
            TxtBox_Chat_Input.BackColor = SystemColors.Menu;
            TxtBox_Chat_Input.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBox_Chat_Input.Location = new Point(550, 12);
            TxtBox_Chat_Input.Multiline = true;
            TxtBox_Chat_Input.Name = "TxtBox_Chat_Input";
            TxtBox_Chat_Input.Size = new Size(238, 363);
            TxtBox_Chat_Input.TabIndex = 0;
            TxtBox_Chat_Input.KeyDown += TxtBox_Chat_Input_KeyDown;
            // 
            // ListBox_Chat
            // 
            ListBox_Chat.BackColor = SystemColors.InactiveCaption;
            ListBox_Chat.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            ListBox_Chat.FormattingEnabled = true;
            ListBox_Chat.ItemHeight = 30;
            ListBox_Chat.Location = new Point(1, 12);
            ListBox_Chat.Name = "ListBox_Chat";
            ListBox_Chat.Size = new Size(543, 424);
            ListBox_Chat.TabIndex = 1;
            // 
            // Btn_Send
            // 
            Btn_Send.FlatStyle = FlatStyle.Popup;
            Btn_Send.Font = new Font("Segoe UI", 29F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Send.Location = new Point(550, 381);
            Btn_Send.Name = "Btn_Send";
            Btn_Send.Size = new Size(238, 70);
            Btn_Send.TabIndex = 2;
            Btn_Send.Text = "Send";
            Btn_Send.UseVisualStyleBackColor = true;
            Btn_Send.Click += Btn_Send_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Btn_Send);
            Controls.Add(ListBox_Chat);
            Controls.Add(TxtBox_Chat_Input);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtBox_Chat_Input;
        private ListBox ListBox_Chat;
        private Button Btn_Send;
    }
}