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
            groupBox1 = new GroupBox();
            Btn_TEC = new Button();
            Btn_STR = new Button();
            Btn_PER = new Button();
            Btn_MEC = new Button();
            Btn_KNO = new Button();
            Btn_DEX = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // TxtBox_Chat_Input
            // 
            TxtBox_Chat_Input.BackColor = SystemColors.Menu;
            TxtBox_Chat_Input.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBox_Chat_Input.Location = new Point(550, 12);
            TxtBox_Chat_Input.Multiline = true;
            TxtBox_Chat_Input.Name = "TxtBox_Chat_Input";
            TxtBox_Chat_Input.Size = new Size(238, 169);
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
            Btn_Send.TabIndex = 6;
            Btn_Send.Text = "Send";
            Btn_Send.UseVisualStyleBackColor = true;
            Btn_Send.Click += Btn_Send_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Btn_TEC);
            groupBox1.Controls.Add(Btn_STR);
            groupBox1.Controls.Add(Btn_PER);
            groupBox1.Controls.Add(Btn_MEC);
            groupBox1.Controls.Add(Btn_KNO);
            groupBox1.Controls.Add(Btn_DEX);
            groupBox1.Location = new Point(550, 187);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(238, 188);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // Btn_TEC
            // 
            Btn_TEC.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_TEC.Location = new Point(175, 153);
            Btn_TEC.Name = "Btn_TEC";
            Btn_TEC.Size = new Size(57, 29);
            Btn_TEC.TabIndex = 5;
            Btn_TEC.Text = "TEC";
            Btn_TEC.UseVisualStyleBackColor = true;
            Btn_TEC.Click += Btn_TEC_Click;
            // 
            // Btn_STR
            // 
            Btn_STR.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_STR.Location = new Point(175, 118);
            Btn_STR.Name = "Btn_STR";
            Btn_STR.Size = new Size(57, 29);
            Btn_STR.TabIndex = 3;
            Btn_STR.Text = "STR";
            Btn_STR.UseVisualStyleBackColor = true;
            Btn_STR.Click += Btn_STR_Click;
            // 
            // Btn_PER
            // 
            Btn_PER.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_PER.Location = new Point(175, 83);
            Btn_PER.Name = "Btn_PER";
            Btn_PER.Size = new Size(57, 29);
            Btn_PER.TabIndex = 1;
            Btn_PER.Text = "PER";
            Btn_PER.UseVisualStyleBackColor = true;
            Btn_PER.Click += Btn_PER_Click;
            // 
            // Btn_MEC
            // 
            Btn_MEC.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_MEC.Location = new Point(91, 153);
            Btn_MEC.Name = "Btn_MEC";
            Btn_MEC.Size = new Size(57, 29);
            Btn_MEC.TabIndex = 4;
            Btn_MEC.Text = "MEC";
            Btn_MEC.UseVisualStyleBackColor = true;
            Btn_MEC.Click += Btn_MEC_Click;
            // 
            // Btn_KNO
            // 
            Btn_KNO.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_KNO.Location = new Point(91, 118);
            Btn_KNO.Name = "Btn_KNO";
            Btn_KNO.Size = new Size(57, 29);
            Btn_KNO.TabIndex = 2;
            Btn_KNO.Text = "KNO";
            Btn_KNO.UseVisualStyleBackColor = true;
            Btn_KNO.Click += Btn_KNO_Click;
            // 
            // Btn_DEX
            // 
            Btn_DEX.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_DEX.Location = new Point(91, 83);
            Btn_DEX.Name = "Btn_DEX";
            Btn_DEX.Size = new Size(57, 29);
            Btn_DEX.TabIndex = 0;
            Btn_DEX.Text = "DEX";
            Btn_DEX.UseVisualStyleBackColor = true;
            Btn_DEX.Click += Btn_DEX_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(Btn_Send);
            Controls.Add(ListBox_Chat);
            Controls.Add(TxtBox_Chat_Input);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtBox_Chat_Input;
        private ListBox ListBox_Chat;
        private Button Btn_Send;
        private GroupBox groupBox1;
        private Button Btn_TEC;
        private Button Btn_STR;
        private Button Btn_PER;
        private Button Btn_MEC;
        private Button Btn_KNO;
        private Button Btn_DEX;
    }
}