using MembersAndFinalizersDestructors;
using MembersC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembersAndFinalizersDestructors
{
    class Program
    {

        static void Main(string[] args)
        {
            Members member1 = new Members();
            member1.Introducing(true);
            Console.ReadKey();
        }


    }
}
