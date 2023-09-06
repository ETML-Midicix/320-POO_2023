using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaClub
{
    internal class Plane
    {
        private string[] view =
        {
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____  |  ",
            @"  \_______ --------- __>-} ",
            @"        \_____|_____/   |  "
        };


        public int left = 0;

        public void draw()
        {
            for (int i = 0; i < this.view.Length; i++)
            {
                Console.SetCursorPosition(left, Console.CursorTop);
                Console.WriteLine(this.view[i]);
            }
        }

        public void update()
        {
            left++;
        }

        public string isHere()
        {
            return Convert.ToString(Console.CursorLeft) + " " + Convert.ToString(Console.CursorTop);
        }
    }
}
