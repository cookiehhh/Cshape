using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text15
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskNPC npc1 = new TaskNPC("去野外挖两根萝卜", "小白兔", NPCType.Task);
            npc1.Speak();

            Console.ReadKey();

        }
    }
}
