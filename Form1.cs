using ChatRPG.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Linq;
using ChatRPG.Helpers;

namespace ChatRPG
{
    public partial class Form1 : Form
    {
        private Random _random = new Random();
        private List<CharacterModel.Character> _characters;
        private int _currentIndex;
        public Form1()
        {
            InitializeComponent();
            string json = System.IO.File.ReadAllText(@"C:\Users\JonPo\source\repos\ChatRPG\characters.json");
            CharacterModel.RootObject? root = JsonConvert.DeserializeObject<CharacterModel.RootObject>(json);
            _characters = root?.Characters ?? new List<CharacterModel.Character>();
            _currentIndex = 0;
            UpdateCharacterUI();
        }
        private void UpdateCharacterUI()
        {
            CharacterModel.Character currentCharacter = _characters[_currentIndex];

            // Update the label with the current character's name
            //Label_CharacterName.Text = currentCharacter.Name;
            GrpBx_Character.Text = currentCharacter.Name;
            // Update the labels with the current character's attribute values
            Label_DEX.Text = $"DEX: {currentCharacter.Attributes?.GetValueOrDefault("DEX") ?? "N/A"}";
            Label_PER.Text = $"PER: {currentCharacter.Attributes?.GetValueOrDefault("PER") ?? "N/A"}";
            Label_KNO.Text = $"KNO: {currentCharacter.Attributes?.GetValueOrDefault("KNO") ?? "N/A"}";
            Label_STR.Text = $"STR: {currentCharacter.Attributes?.GetValueOrDefault("STR") ?? "N/A"}";
            Label_MEC.Text = $"MEC: {currentCharacter.Attributes?.GetValueOrDefault("MEC") ?? "N/A"}";
            Label_TEC.Text = $"TEC: {currentCharacter.Attributes?.GetValueOrDefault("TEC") ?? "N/A"}";


            // ... (previous code)

            // Update ComboBox_Equipment
            List<string> equipmentNames = currentCharacter.Equipment?.ConvertAll(equip => equip.Name) ?? new List<string>();
            UpdateComboBoxWithList(ComboBox_Equipment, equipmentNames);

            foreach (var skillCategory in currentCharacter.Skills)
            {
                ComboBox targetComboBox;

                switch (skillCategory.Key)
                {
                    case "DEX":
                        targetComboBox = ComboBox_DEX;
                        break;
                    case "STR":
                        targetComboBox = ComboBox_STR;
                        break;
                    case "TEC":
                        targetComboBox = ComboBox_TEC;
                        break;
                    case "PER":
                        targetComboBox = ComboBox_PER;
                        break;
                    case "KNO":
                        targetComboBox = ComboBox_KNO;
                        break;
                    case "MEC":
                        targetComboBox = ComboBox_MEC;
                        break;
                    default:
                        throw new InvalidOperationException($"Unknown skill category '{skillCategory.Key}'");
                }
            }
            //

        }

        //// UI event handlers
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
            string dexValue = _characters[_currentIndex].Attributes?.GetValueOrDefault("DEX") ?? "1D";
            int sum = DiceHelper.RollDice(dexValue);
            TxtBox_Chat_Input.AppendText($"DEX({sum})" + Environment.NewLine);
        }
        private void Btn_PER_Click(object sender, EventArgs e)
        {
            string perValue = _characters[_currentIndex].Attributes?.GetValueOrDefault("PER") ?? "1D";
            int sum = DiceHelper.RollDice(perValue);
            TxtBox_Chat_Input.AppendText($"PER({sum})" + Environment.NewLine);
        }
        private void Btn_KNO_Click(object sender, EventArgs e)
        {
            string knoValue = _characters[_currentIndex].Attributes?.GetValueOrDefault("KNO") ?? "1D";
            int sum = DiceHelper.RollDice(knoValue);
            TxtBox_Chat_Input.AppendText($"KNO({sum})" + Environment.NewLine);
        }
        private void Btn_STR_Click(object sender, EventArgs e)
        {
            string strValue = _characters[_currentIndex].Attributes?.GetValueOrDefault("STR") ?? "1D";
            int sum = DiceHelper.RollDice(strValue);
            TxtBox_Chat_Input.AppendText($"STR({sum})" + Environment.NewLine);
        }
        private void Btn_MEC_Click(object sender, EventArgs e)
        {
            string mecValue = _characters[_currentIndex].Attributes?.GetValueOrDefault("MEC") ?? "1D";
            int sum = DiceHelper.RollDice(mecValue);
            TxtBox_Chat_Input.AppendText($"MEC({sum})" + Environment.NewLine);
        }
        private void Btn_TEC_Click(object sender, EventArgs e)
        {
            string tecValue = _characters[_currentIndex].Attributes?.GetValueOrDefault("TEC") ?? "1D";
            int sum = DiceHelper.RollDice(tecValue);
            TxtBox_Chat_Input.AppendText($"TEC({sum})" + Environment.NewLine);
        }
        private void Btn_Next_Click(object sender, EventArgs e)
        {
            _currentIndex++;
            if (_currentIndex >= _characters.Count)
            {
                _currentIndex = 0;
            }
            UpdateCharacterUI();
        }
        private void Btn_Previous_Click(object sender, EventArgs e)
        {
            _currentIndex--;
            if (_currentIndex < 0)
            {
                _currentIndex = _characters.Count - 1;
            }
            UpdateCharacterUI();
        }
        private void ComboBox_DEX_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ComboBox_Equipment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //// Character attribute and equipment handling
        private List<string> DictionaryToList(Dictionary<string, string>? dictionary)
        {
            var list = new List<string>();

            if (dictionary != null)
            {
                foreach (var keyValuePair in dictionary)
                {
                    if (keyValuePair.Key != null && keyValuePair.Value != null)
                    {
                        list.Add($"{keyValuePair.Key}: {keyValuePair.Value}");
                    }
                }
            }

            return list;
        }
        private List<string> EquipmentToList(List<CharacterModel.Equipment>? equipmentList)
        {
            var list = new List<string>();

            if (equipmentList != null)
            {
                foreach (var equipment in equipmentList)
                {
                    list.Add($"{equipment.Name} ({equipment.Type}) - Damage: {equipment.Damage}");
                }
            }

            return list;
        }
        private void UpdateComboBoxWithList(ComboBox comboBox, List<string> items)

        {
            comboBox.Items.Clear();

            if (items != null)
            {
                foreach (var item in items)
                {
                    if (item != null)
                    {
                        comboBox.Items.Add(item);
                    }
                }
            }
        }

        //// Chat functionality
        private string GetBotResponse(string input)
        {
            return ChatHelper.GetBotResponse(input);
        }

        //// Dice rolling
        private int RollDice(string diceNotation)
        {
            var parts = diceNotation.Split('D', '+');
            int numberOfRolls = int.Parse(parts[0]);
            int modifier = parts.Length == 3 ? int.Parse(parts[2]) : 0;

            int sum = 0;
            for (int i = 0; i < numberOfRolls; i++)
            {
                sum += _random.Next(1, 7); // Generate a random number between 1 and 6
            }
            return sum + modifier;
        }
    }
}