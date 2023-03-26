namespace ChatRPG
{
    public partial class Form1 : Form
    {
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

    }
}