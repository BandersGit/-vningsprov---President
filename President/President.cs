using System;

namespace President
{
    public class President
    {
        static Random generator = new Random();

        public string name;

        int environmentPriority;

        int defensePriority;

        int healthcarePriority;

        int corruption;

        int money;


        public President(string n)
        {
            environmentPriority = generator.Next(0,100);
            defensePriority = generator.Next(0,100);
            healthcarePriority = generator.Next(0,100);
        }

        public void Present()
        {
            System.Console.WriteLine(name);

            System.Console.WriteLine(environmentPriority);

            System.Console.WriteLine(defensePriority);

            System.Console.WriteLine(healthcarePriority);

            System.Console.WriteLine(corruption);

            System.Console.WriteLine(money);
        }

        public bool PassLegislation(int e, int d, int h, int bribe)
        {


            return true;
        }

    }
}
