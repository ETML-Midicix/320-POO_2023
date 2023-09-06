using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaClub
{
    internal class Para
    {
        private string[] withParachute =
        {
             @" ___ ",
             @"/|||\",
             @"\   /",
             @" \o/ ",
             @"  ░  ",
             @" / \ ",
        };

        private string[] withoutParachute =
        {
             @"     ",
             @"     ",
             @"     ",
             @"  o  ",
             @" /░\ ",
             @" / \ ",
        };

        public Para()
        {

        }

        public void dive(string position)
        {
            Console.Write("oui {0} oui",position);
            for (int i = 0; i < this.withParachute.Length; i++)
            {
                //Console.SetCursorPosition(left, Console.CursorTop);
                //Console.WriteLine(this.withParachute[i]);
            }
        }
    }
}
