using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "I like learning about C#. " + "Just like Python there is a lot you can do with it. " +
                "Each programming language has there own special set up.";
            Console.WriteLine(sentence + "\n");

            string christmas = "I can't believe that it is almost Christmas!";
            christmas = christmas.ToUpper();
            Console.WriteLine(christmas + "\n");

            StringBuilder sb = new StringBuilder("   My kiddos are the most ", 100);

            sb.Append("important thing in my life.");
            sb.AppendLine(" It was fun before we had kids, but because of them ");
            sb.AppendLine("life has meaning and purpose with new memories to embrace. Even though they are little precious bundles ");
            sb.AppendLine("of joy, bringing light and warmth to the soul, they are a handful. Each one comes as different package as a  ");
            sb.AppendLine("new experience. Once you think you have it all figured out with the first one, the second comes along and ");
            sb.AppendLine("rocks the boat with new angles and strategies you wouldn't expect. Each child is a new adventure in this ");
            sb.AppendLine("journey of life and within the Family unit. Even though there are times I think I am going to lose my mind, ");
            sb.AppendLine("but even with all the chaos, there is nothing I would change. With these challenges has allowed me to become ");
            sb.AppendLine("a better father, husband and person in general.");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
