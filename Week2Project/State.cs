using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Project
{
    internal class State
    {
        public int Lv;
        public string Name;
        public string Job;
        public int Ap;
        public int Dp;
        public int Hp;
        public int Gold1;

        public void Print()
        {
            Console.WriteLine("Lv. " + Lv);
            Console.WriteLine(Name + " ( " + Job + " ) ");
            Console.WriteLine("공격력 : " + Ap);
            Console.WriteLine("방어력 : " + Dp);
            Console.WriteLine("체력 : " + Hp);
            Console.WriteLine("Gold : " + Gold1 + " G");
        }
    }
}
