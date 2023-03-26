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
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            Btn_TEC = new Button();
            Btn_STR = new Button();
            Btn_PER = new Button();
            Btn_MEC = new Button();
            Btn_KNO = new Button();
            Btn_DEX = new Button();
            button6 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // TxtBox_Chat_Input
            // 
            TxtBox_Chat_Input.BackColor = SystemColors.Info;
            TxtBox_Chat_Input.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBox_Chat_Input.Location = new Point(535, 12);
            TxtBox_Chat_Input.Multiline = true;
            TxtBox_Chat_Input.Name = "TxtBox_Chat_Input";
            TxtBox_Chat_Input.Size = new Size(253, 210);
            TxtBox_Chat_Input.TabIndex = 0;
            TxtBox_Chat_Input.KeyDown += TxtBox_Chat_Input_KeyDown;
            // 
            // ListBox_Chat
            // 
            ListBox_Chat.BackColor = SystemColors.InactiveCaption;
            ListBox_Chat.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            ListBox_Chat.FormattingEnabled = true;
            ListBox_Chat.ItemHeight = 25;
            ListBox_Chat.Location = new Point(1, 12);
            ListBox_Chat.Name = "ListBox_Chat";
            ListBox_Chat.Size = new Size(522, 404);
            ListBox_Chat.TabIndex = 1;
            // 
            // Btn_Send
            // 
            Btn_Send.FlatStyle = FlatStyle.Popup;
            Btn_Send.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Send.Location = new Point(0, 127);
            Btn_Send.Name = "Btn_Send";
            Btn_Send.Size = new Size(126, 55);
            Btn_Send.TabIndex = 6;
            Btn_Send.Text = "Send";
            Btn_Send.UseVisualStyleBackColor = true;
            Btn_Send.Click += Btn_Send_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(Btn_TEC);
            groupBox1.Controls.Add(Btn_Send);
            groupBox1.Controls.Add(Btn_STR);
            groupBox1.Controls.Add(Btn_PER);
            groupBox1.Controls.Add(Btn_MEC);
            groupBox1.Controls.Add(Btn_KNO);
            groupBox1.Controls.Add(Btn_DEX);
            groupBox1.Location = new Point(529, 228);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(259, 188);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // button5
            // 
            button5.BackColor = Color.PaleGoldenrod;
            button5.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(132, 60);
            button5.Name = "button5";
            button5.Size = new Size(57, 29);
            button5.TabIndex = 10;
            button5.Text = "Dodge";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.PaleGoldenrod;
            button4.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(132, 25);
            button4.Name = "button4";
            button4.Size = new Size(57, 29);
            button4.TabIndex = 9;
            button4.Text = "Attack";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.YellowGreen;
            button3.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(195, 60);
            button3.Name = "button3";
            button3.Size = new Size(57, 29);
            button3.TabIndex = 7;
            button3.Text = "1000";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.YellowGreen;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(195, 94);
            button2.Name = "button2";
            button2.Size = new Size(57, 29);
            button2.TabIndex = 8;
            button2.Text = "1";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.YellowGreen;
            button1.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(195, 25);
            button1.Name = "button1";
            button1.Size = new Size(57, 29);
            button1.TabIndex = 6;
            button1.Text = "Healthy";
            button1.UseVisualStyleBackColor = false;
            // 
            // Btn_TEC
            // 
            Btn_TEC.BackColor = SystemColors.ActiveCaption;
            Btn_TEC.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_TEC.Location = new Point(69, 92);
            Btn_TEC.Name = "Btn_TEC";
            Btn_TEC.Size = new Size(57, 29);
            Btn_TEC.TabIndex = 5;
            Btn_TEC.Text = "TEC";
            Btn_TEC.UseVisualStyleBackColor = false;
            Btn_TEC.Click += Btn_TEC_Click;
            // 
            // Btn_STR
            // 
            Btn_STR.BackColor = SystemColors.ActiveCaption;
            Btn_STR.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_STR.Location = new Point(69, 57);
            Btn_STR.Name = "Btn_STR";
            Btn_STR.Size = new Size(57, 29);
            Btn_STR.TabIndex = 3;
            Btn_STR.Text = "STR";
            Btn_STR.UseVisualStyleBackColor = false;
            Btn_STR.Click += Btn_STR_Click;
            // 
            // Btn_PER
            // 
            Btn_PER.BackColor = SystemColors.ActiveCaption;
            Btn_PER.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_PER.Location = new Point(69, 23);
            Btn_PER.Name = "Btn_PER";
            Btn_PER.Size = new Size(57, 29);
            Btn_PER.TabIndex = 1;
            Btn_PER.Text = "PER";
            Btn_PER.UseVisualStyleBackColor = false;
            Btn_PER.Click += Btn_PER_Click;
            // 
            // Btn_MEC
            // 
            Btn_MEC.BackColor = SystemColors.ActiveCaption;
            Btn_MEC.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_MEC.Location = new Point(6, 92);
            Btn_MEC.Name = "Btn_MEC";
            Btn_MEC.Size = new Size(57, 29);
            Btn_MEC.TabIndex = 4;
            Btn_MEC.Text = "MEC";
            Btn_MEC.UseVisualStyleBackColor = false;
            Btn_MEC.Click += Btn_MEC_Click;
            // 
            // Btn_KNO
            // 
            Btn_KNO.BackColor = SystemColors.ActiveCaption;
            Btn_KNO.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_KNO.Location = new Point(6, 57);
            Btn_KNO.Name = "Btn_KNO";
            Btn_KNO.Size = new Size(57, 29);
            Btn_KNO.TabIndex = 2;
            Btn_KNO.Text = "KNO";
            Btn_KNO.UseVisualStyleBackColor = false;
            Btn_KNO.Click += Btn_KNO_Click;
            // 
            // Btn_DEX
            // 
            Btn_DEX.BackColor = SystemColors.ActiveCaption;
            Btn_DEX.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_DEX.Location = new Point(6, 22);
            Btn_DEX.Name = "Btn_DEX";
            Btn_DEX.Size = new Size(57, 29);
            Btn_DEX.TabIndex = 0;
            Btn_DEX.Text = "DEX";
            Btn_DEX.UseVisualStyleBackColor = false;
            Btn_DEX.Click += Btn_DEX_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.PaleGoldenrod;
            button6.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(132, 92);
            button6.Name = "button6";
            button6.Size = new Size(57, 29);
            button6.TabIndex = 11;
            button6.Text = "Parry";
            button6.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
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
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}