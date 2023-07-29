using System;
using System.Collections.Generic;

namespace decisionPicker
{
    public class DecisionManager
    {
        private Random rand;
        private List<string> choices;
        private List<string> history;

        public DecisionManager()
        {
            rand = new Random();
            choices = new List<string>();
            history = new List<string>();
        }

        public List<string> Choices
        {
            get { return choices; }
        }

        public void AddChoices(List<string> newChoices)
        {
            choices.Clear();
            choices.AddRange(newChoices);
        }

        public string MakeDecision()
        {
            string finalChoice = "";

            if (choices.Count > 0)
            {
                int randomIndex = rand.Next(choices.Count);
                finalChoice = choices[randomIndex].ToUpper();
                history.Add($"{DateTime.Now}: {finalChoice}");
            }

            return finalChoice;
        }

        public List<string> GetDecisionHistory()
        {
            return history;
        }
    }
}
