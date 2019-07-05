using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    static class HavingEnum
    {
        public enum Items
        {
            Item1 = 1,
            Item2 = 2,
            Item3 = 3
        };
    }

    class Indexers
    {
        
        private string[] names = new string[10];

        private int[] ints = new int[5];

        Dictionary<string, int> dict = new Dictionary<string, int>();
        public string this[int i]
        {
            get
            {
                return names[i];
            }
            set
            {
                names[i] = value;
            }
        }

        public int this[string s]
        {
            get
            {
                return dict[s];
            }
            set
            {
                dict[s] = value;
            }
        }

        static void Main(string[] args)
        {
            Indexers Team = new Indexers();
            Team[0] = "Rocky";
            Team[1] = "Teena";
            Team[2] = "Ana";
            Team[3] = "Victoria";
            Team[4] = "Yani";
            Team[5] = "Mary";
            Team[6] = "Gomes";
            Team[7] = "Arnold";
            Team[8] = "Mike";
            Team[9] = "Peter";

            Team["Karthick"] = 5;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Team[i]);
            }

            Console.WriteLine(Team["Karthick"]);


            HavingEnum.Items items = HavingEnum.Items.Item1;
            Console.WriteLine(items);
            Console.ReadKey();
        }
    
}
}
