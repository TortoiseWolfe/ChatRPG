using System;

namespace ChatRPG.Helpers
{
    public static class DiceHelper
    {
        private static Random _random = new Random();

        public static int RollDice(string diceNotation)
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
