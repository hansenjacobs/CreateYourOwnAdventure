using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourOwnAdventure
{
    class Element
    {
        string story;
        string choice;
        int optionAElement;
        int optionBElement;

        public Element(string story, string choice, int optionAElement, int optionBElement)
        {
            this.story = story;
            this.choice = choice;
            this.optionAElement = optionAElement;
            this.optionBElement = optionBElement;
        }

        public void DisplayElement()
        {
            Console.WriteLine(story);
            if(choice != "")
            {
                Console.WriteLine(choice);
            }
        }

        public int GetNextElement()
        {
            string input = Console.ReadKey().KeyChar.ToString().ToLower();

            switch (input)
            {
                case "a":
                    return optionAElement;

                case "b":
                    return optionBElement;

                default:
                    Console.WriteLine("Invalid input! '" + input + "' is not a valid option.  Please try again.\n");
                    DisplayElement();
                    return 0;
            }
        }
    }
}
