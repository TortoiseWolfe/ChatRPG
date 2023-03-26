using System;

namespace ChatRPG
{
    public partial class Form1 : Form
    {
        private Random _random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Send_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtBox_Chat_Input.Text))
            {
                ListBox_Chat.Items.Add("User: " + TxtBox_Chat_Input.Text);
                string botResponse = GetBotResponse(TxtBox_Chat_Input.Text);
                ListBox_Chat.Items.Add("Bot: " + botResponse);
                TxtBox_Chat_Input.Clear();
            }
        }

        private string GetBotResponse(string input)
        {
            // Process user input and generate a response.
            // You can implement your own logic here, or call an external API like OpenAI's GPT.
            string response = "I am a simple bot, and I don't have much to say.";

            return response;
        }

        private void TxtBox_Chat_Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true; // To prevent the 'beep' sound when pressing Enter
                e.SuppressKeyPress = true; // To prevent a new line being added to the TextBox

                if (!string.IsNullOrWhiteSpace(TxtBox_Chat_Input.Text))
                {
                    ListBox_Chat.Items.Add("User: " + TxtBox_Chat_Input.Text);
                    string botResponse = GetBotResponse(TxtBox_Chat_Input.Text);
                    ListBox_Chat.Items.Add("Bot: " + botResponse);
                    TxtBox_Chat_Input.Clear();
                }
            }
        }

        private void Btn_DEX_Click(object sender, EventArgs e)
        {
            int sum = RollDice(3, "DEX");
            TxtBox_Chat_Input.AppendText($"DEX({sum})" + Environment.NewLine);
        }

        private void Btn_PER_Click(object sender, EventArgs e)
        {
            int sum = RollDice(3, "PER");
            TxtBox_Chat_Input.AppendText($"PER({sum})" + Environment.NewLine);
        }

        private void Btn_KNO_Click(object sender, EventArgs e)
        {
            int sum = RollDice(3, "KNO");
            TxtBox_Chat_Input.AppendText($"KNO({sum})" + Environment.NewLine);
        }

        private void Btn_STR_Click(object sender, EventArgs e)
        {
            int sum = RollDice(3, "STR");
            TxtBox_Chat_Input.AppendText($"STR({sum})" + Environment.NewLine);
        }

        private void Btn_MEC_Click(object sender, EventArgs e)
        {
            int sum = RollDice(3, "MEC");
            TxtBox_Chat_Input.AppendText($"MEC({sum})" + Environment.NewLine);
        }

        private void Btn_TEC_Click(object sender, EventArgs e)
        {
            int sum = RollDice(3, "TEC");
            TxtBox_Chat_Input.AppendText($"TEC({sum})" + Environment.NewLine);
        }

        private int RollDice(int numberOfRolls, string abilityAbbreviation)
        {
            int sum = 0;
            for (int i = 0; i < numberOfRolls; i++)
            {
                sum += _random.Next(1, 7); // Generate a random number between 1 and 6
            }
            return sum;
        }
    }
}