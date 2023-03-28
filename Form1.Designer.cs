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
            GrpBx_Character = new GroupBox();
            Label_TEC = new Label();
            Label_PER = new Label();
            Label_KNO = new Label();
            Label_STR = new Label();
            Label_MEC = new Label();
            Label_DEX = new Label();
            Label_CharacterName = new Label();
            Btn_Next = new Button();
            Btn_Previous = new Button();
            ComboBox_Equipment = new ComboBox();
            ComboBox_DEX = new ComboBox();
            ComboBox_STR = new ComboBox();
            ComboBox_PER = new ComboBox();
            ComboBox_MEC = new ComboBox();
            ComboBox_KNO = new ComboBox();
            ComboBox_TEC = new ComboBox();
            button6 = new Button();
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
            GrpBx_Character.SuspendLayout();
            SuspendLayout();
            // 
            // TxtBox_Chat_Input
            // 
            TxtBox_Chat_Input.BackColor = SystemColors.GradientActiveCaption;
            TxtBox_Chat_Input.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBox_Chat_Input.Location = new Point(410, 12);
            TxtBox_Chat_Input.Multiline = true;
            TxtBox_Chat_Input.Name = "TxtBox_Chat_Input";
            TxtBox_Chat_Input.Size = new Size(378, 165);
            TxtBox_Chat_Input.TabIndex = 0;
            TxtBox_Chat_Input.KeyDown += TxtBox_Chat_Input_KeyDown;
            // 
            // ListBox_Chat
            // 
            ListBox_Chat.BackColor = Color.DarkSlateGray;
            ListBox_Chat.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            ListBox_Chat.ForeColor = Color.YellowGreen;
            ListBox_Chat.FormattingEnabled = true;
            ListBox_Chat.ItemHeight = 23;
            ListBox_Chat.Location = new Point(1, 12);
            ListBox_Chat.Name = "ListBox_Chat";
            ListBox_Chat.Size = new Size(403, 395);
            ListBox_Chat.TabIndex = 1;
            // 
            // Btn_Send
            // 
            Btn_Send.FlatStyle = FlatStyle.Popup;
            Btn_Send.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Send.Location = new Point(255, 214);
            Btn_Send.Name = "Btn_Send";
            Btn_Send.Size = new Size(59, 41);
            Btn_Send.TabIndex = 6;
            Btn_Send.Text = "Send";
            Btn_Send.UseVisualStyleBackColor = true;
            Btn_Send.Click += Btn_Send_Click;
            // 
            // GrpBx_Character
            // 
            GrpBx_Character.Controls.Add(Label_TEC);
            GrpBx_Character.Controls.Add(Label_PER);
            GrpBx_Character.Controls.Add(Label_KNO);
            GrpBx_Character.Controls.Add(Label_STR);
            GrpBx_Character.Controls.Add(Label_MEC);
            GrpBx_Character.Controls.Add(Label_DEX);
            GrpBx_Character.Controls.Add(Label_CharacterName);
            GrpBx_Character.Controls.Add(Btn_Next);
            GrpBx_Character.Controls.Add(Btn_Previous);
            GrpBx_Character.Controls.Add(ComboBox_Equipment);
            GrpBx_Character.Controls.Add(Btn_Send);
            GrpBx_Character.Controls.Add(ComboBox_DEX);
            GrpBx_Character.Controls.Add(ComboBox_STR);
            GrpBx_Character.Controls.Add(ComboBox_PER);
            GrpBx_Character.Controls.Add(ComboBox_MEC);
            GrpBx_Character.Controls.Add(ComboBox_KNO);
            GrpBx_Character.Controls.Add(ComboBox_TEC);
            GrpBx_Character.Controls.Add(button6);
            GrpBx_Character.Controls.Add(button5);
            GrpBx_Character.Controls.Add(button4);
            GrpBx_Character.Controls.Add(button3);
            GrpBx_Character.Controls.Add(button2);
            GrpBx_Character.Controls.Add(button1);
            GrpBx_Character.Controls.Add(Btn_TEC);
            GrpBx_Character.Controls.Add(Btn_STR);
            GrpBx_Character.Controls.Add(Btn_PER);
            GrpBx_Character.Controls.Add(Btn_MEC);
            GrpBx_Character.Controls.Add(Btn_KNO);
            GrpBx_Character.Controls.Add(Btn_DEX);
            GrpBx_Character.Location = new Point(404, 155);
            GrpBx_Character.Name = "GrpBx_Character";
            GrpBx_Character.Size = new Size(384, 261);
            GrpBx_Character.TabIndex = 3;
            GrpBx_Character.TabStop = false;
            GrpBx_Character.Text = "groupBox1";
            // 
            // Label_TEC
            // 
            Label_TEC.AutoSize = true;
            Label_TEC.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Label_TEC.Location = new Point(246, 159);
            Label_TEC.Name = "Label_TEC";
            Label_TEC.Size = new Size(38, 15);
            Label_TEC.TabIndex = 26;
            Label_TEC.Text = "label4";
            // 
            // Label_PER
            // 
            Label_PER.AutoSize = true;
            Label_PER.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Label_PER.Location = new Point(60, 161);
            Label_PER.Name = "Label_PER";
            Label_PER.Size = new Size(38, 15);
            Label_PER.TabIndex = 23;
            Label_PER.Text = "label3";
            // 
            // Label_KNO
            // 
            Label_KNO.AutoSize = true;
            Label_KNO.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Label_KNO.Location = new Point(246, 93);
            Label_KNO.Name = "Label_KNO";
            Label_KNO.Size = new Size(38, 15);
            Label_KNO.TabIndex = 25;
            Label_KNO.Text = "label5";
            // 
            // Label_STR
            // 
            Label_STR.AutoSize = true;
            Label_STR.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Label_STR.Location = new Point(60, 95);
            Label_STR.Name = "Label_STR";
            Label_STR.Size = new Size(38, 15);
            Label_STR.TabIndex = 22;
            Label_STR.Text = "label2";
            // 
            // Label_MEC
            // 
            Label_MEC.AutoSize = true;
            Label_MEC.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Label_MEC.Location = new Point(246, 29);
            Label_MEC.Name = "Label_MEC";
            Label_MEC.Size = new Size(38, 15);
            Label_MEC.TabIndex = 24;
            Label_MEC.Text = "label6";
            // 
            // Label_DEX
            // 
            Label_DEX.AutoSize = true;
            Label_DEX.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Label_DEX.Location = new Point(60, 31);
            Label_DEX.Name = "Label_DEX";
            Label_DEX.Size = new Size(38, 15);
            Label_DEX.TabIndex = 21;
            Label_DEX.Text = "label1";
            // 
            // Label_CharacterName
            // 
            Label_CharacterName.AutoSize = true;
            Label_CharacterName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Label_CharacterName.Location = new Point(69, 6);
            Label_CharacterName.Name = "Label_CharacterName";
            Label_CharacterName.Size = new Size(40, 15);
            Label_CharacterName.TabIndex = 20;
            Label_CharacterName.Text = "label1";
            // 
            // Btn_Next
            // 
            Btn_Next.FlatStyle = FlatStyle.Popup;
            Btn_Next.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Next.Location = new Point(320, 214);
            Btn_Next.Name = "Btn_Next";
            Btn_Next.Size = new Size(54, 41);
            Btn_Next.TabIndex = 19;
            Btn_Next.Text = ">";
            Btn_Next.UseVisualStyleBackColor = true;
            Btn_Next.Click += Btn_Next_Click;
            // 
            // Btn_Previous
            // 
            Btn_Previous.FlatStyle = FlatStyle.Popup;
            Btn_Previous.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Previous.Location = new Point(194, 214);
            Btn_Previous.Name = "Btn_Previous";
            Btn_Previous.Size = new Size(55, 41);
            Btn_Previous.TabIndex = 18;
            Btn_Previous.Text = "<";
            Btn_Previous.UseVisualStyleBackColor = true;
            Btn_Previous.Click += Btn_Previous_Click;
            // 
            // ComboBox_Equipment
            // 
            ComboBox_Equipment.BackColor = Color.Salmon;
            ComboBox_Equipment.FormattingEnabled = true;
            ComboBox_Equipment.Items.AddRange(new object[] { "", "Bare Hand", "Blaster", "Club" });
            ComboBox_Equipment.Location = new Point(6, 220);
            ComboBox_Equipment.Name = "ComboBox_Equipment";
            ComboBox_Equipment.Size = new Size(182, 23);
            ComboBox_Equipment.TabIndex = 17;
            ComboBox_Equipment.SelectedIndexChanged += ComboBox_Equipment_SelectedIndexChanged;
            // 
            // ComboBox_DEX
            // 
            ComboBox_DEX.BackColor = Color.PaleGoldenrod;
            ComboBox_DEX.FormattingEnabled = true;
            ComboBox_DEX.Items.AddRange(new object[] { "", "Blaster", "Brawling", "Dodge", "Melee Combat", "Pick Pocket", "Sneak", "Thrown Weapons", "Vehicle Blasters", "Repulsorlift Operations" });
            ComboBox_DEX.Location = new Point(6, 57);
            ComboBox_DEX.Name = "ComboBox_DEX";
            ComboBox_DEX.Size = new Size(182, 23);
            ComboBox_DEX.TabIndex = 16;
            ComboBox_DEX.SelectedIndexChanged += ComboBox_DEX_SelectedIndexChanged;
            // 
            // ComboBox_STR
            // 
            ComboBox_STR.BackColor = Color.PaleGoldenrod;
            ComboBox_STR.FormattingEnabled = true;
            ComboBox_STR.Items.AddRange(new object[] { "", "Brawling Parry", "Climbing/Jumping", "Lifting", "Melee Combat", "Stamina", "Swimming" });
            ComboBox_STR.Location = new Point(6, 121);
            ComboBox_STR.Name = "ComboBox_STR";
            ComboBox_STR.Size = new Size(182, 23);
            ComboBox_STR.TabIndex = 15;
            // 
            // ComboBox_PER
            // 
            ComboBox_PER.BackColor = Color.PaleGoldenrod;
            ComboBox_PER.FormattingEnabled = true;
            ComboBox_PER.Items.AddRange(new object[] { "", "Blaster Repair", "Capital Ship Repair", "Computer Programming/Repair", "Droid Programming/Repair", "Ground Vehicle Repair", "Security", "Space Transports Repair", "Starship Repair", "Armor Repair", "Demolitions" });
            ComboBox_PER.Location = new Point(6, 185);
            ComboBox_PER.Name = "ComboBox_PER";
            ComboBox_PER.Size = new Size(182, 23);
            ComboBox_PER.TabIndex = 14;
            // 
            // ComboBox_MEC
            // 
            ComboBox_MEC.BackColor = Color.PaleGoldenrod;
            ComboBox_MEC.FormattingEnabled = true;
            ComboBox_MEC.Items.AddRange(new object[] { "", "Astrogation", "Capital Ship Gunnery", "Capital Ship Piloting", "Communications", "Ground Vehicle Operation", "Sensors", "Space Transports", "Starship Gunnery", "Starship Piloting", "Starship Shields" });
            ComboBox_MEC.Location = new Point(192, 57);
            ComboBox_MEC.Name = "ComboBox_MEC";
            ComboBox_MEC.Size = new Size(182, 23);
            ComboBox_MEC.TabIndex = 13;
            // 
            // ComboBox_KNO
            // 
            ComboBox_KNO.BackColor = Color.PaleGoldenrod;
            ComboBox_KNO.FormattingEnabled = true;
            ComboBox_KNO.Items.AddRange(new object[] { "", "Alien Species", "Bureaucracy", "Cultures", "Intimidation", "Languages", "Planetary Systems", "Scholastic Aptitude", "Streetwise", "Survival", "Tactics", "Technology" });
            ComboBox_KNO.Location = new Point(192, 121);
            ComboBox_KNO.Name = "ComboBox_KNO";
            ComboBox_KNO.Size = new Size(182, 23);
            ComboBox_KNO.TabIndex = 12;
            // 
            // ComboBox_TEC
            // 
            ComboBox_TEC.BackColor = Color.PaleGoldenrod;
            ComboBox_TEC.FormattingEnabled = true;
            ComboBox_TEC.Items.AddRange(new object[] { "", "Blaster Repair", "Capital Ship Repair", "Computer Programming/Repair", "Droid Programming/Repair", "Ground Vehicle Repair", "Security", "Space Transports Repair", "Starship Repair", "Armor Repair", "Demolitions" });
            ComboBox_TEC.Location = new Point(192, 185);
            ComboBox_TEC.Name = "ComboBox_TEC";
            ComboBox_TEC.Size = new Size(182, 23);
            ComboBox_TEC.TabIndex = 4;
            // 
            // button6
            // 
            button6.BackColor = Color.PaleGoldenrod;
            button6.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(129, 150);
            button6.Name = "button6";
            button6.Size = new Size(57, 29);
            button6.TabIndex = 11;
            button6.Text = "Parry";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.PaleGoldenrod;
            button5.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(129, 22);
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
            button4.Location = new Point(129, 86);
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
            button3.Location = new Point(317, 86);
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
            button2.Location = new Point(317, 152);
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
            button1.Location = new Point(317, 22);
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
            Btn_TEC.Location = new Point(192, 152);
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
            Btn_STR.Location = new Point(6, 86);
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
            Btn_PER.Location = new Point(6, 152);
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
            Btn_MEC.Location = new Point(192, 22);
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
            Btn_KNO.Location = new Point(192, 86);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GrpBx_Character);
            Controls.Add(ListBox_Chat);
            Controls.Add(TxtBox_Chat_Input);
            Name = "Form1";
            Text = "Form1";
            GrpBx_Character.ResumeLayout(false);
            GrpBx_Character.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtBox_Chat_Input;
        private ListBox ListBox_Chat;
        private Button Btn_Send;
        private GroupBox GrpBx_Character;
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
        private ComboBox ComboBox_TEC;
        private ComboBox ComboBox_KNO;
        private ComboBox ComboBox_MEC;
        private ComboBox ComboBox_DEX;
        private ComboBox ComboBox_STR;
        private ComboBox ComboBox_PER;
        private ComboBox ComboBox_Equipment;
        private Button Btn_Previous;
        private Button Btn_Next;
        private Label Label_CharacterName;
        private Label Label_DEX;
        private Label Label_PER;
        private Label Label_STR;
        private Label Label_TEC;
        private Label Label_KNO;
        private Label Label_MEC;
    }
}