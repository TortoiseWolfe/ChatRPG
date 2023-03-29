using System.Collections.Generic;
using System.Windows.Forms;
using ChatRPG.Models;

namespace ChatRPG.Helpers
{
    public static class UIHelper
    {
        public static List<string> DictionaryToList(Dictionary<string, string>? dictionary)
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

        internal static List<string> EquipmentToList(List<CharacterModel.Equipment>? equipmentList)
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

        public static void UpdateComboBoxWithList(ComboBox comboBox, List<string> items)
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
    }
}

