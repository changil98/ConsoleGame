using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Project
{
    internal class Inven
    {
        public string item1;
        public string item2;
        public string item3;
        public string item4;
        public string item5;
        public string item6;
        public string g1;
        public string g2;
        public string g3;
        public string buy;
        public int Gold2;
        public int Gold3;
        public int Gold4;

        public void PrintItem()
        {
            Console.WriteLine("- 1. " + item1 + " | 방어력 + 5 | 무쇠로 만들어져 튼튼한 갑옷입니다.");
            Console.WriteLine("- 2. " + item2 + " | 공격력 + 7 | 스파트라의 전사들이 사용했다는 전설의 창입니다.");
            Console.WriteLine("- 3. " + item3 + " | 공격력 + 2 | 쉽게 볼 수 있는 낡은 검 입니다.");
            if (g1 == "구매완료")
            {
                Console.WriteLine("- 4. " + item4 + " | 방어력 +5 | 수련에 도움을 주는 갑옷입니다.");
            }
            if (g2 == "구매완료")
            {
                Console.WriteLine("- 5. " + item5 + " | 방어력 +15 | 스파르타의 전사들이 사용했다는 전설의 갑옷입니다.");
            }
            if (g3 == "구매완료")
            {
                Console.WriteLine("- 6. " + item6 + " | 공격력 +5 | 어디선가 사용됐던거 같은 도끼입니다.");
            }
        }

        public void PrintShop()
        {
            if(g1 == "구매완료")
            {
                Console.WriteLine("- " + item4 + " | 방어력 +5 | 수련에 도움을 주는 갑옷입니다. | " + g1);
            }
            else
            {
                Console.WriteLine("- " + item4 + " | 방어력 +5 | 수련에 도움을 주는 갑옷입니다. | " + Gold2 + g1);
            }

            Console.WriteLine("- " + item1 + " | 방어력 +9 | 무쇠로 만들어져 튼튼한 갑옷입니다. | 구매완료");

            if(g2 == "구매완료")
            {
                Console.WriteLine("- " + item5 + " | 방어력 +15 | 스파르타의 전사들이 사용했다는 전설의 갑옷입니다. | " + g2);
            }
            else
            {
                Console.WriteLine("- " + item5 + " | 방어력 +15 | 스파르타의 전사들이 사용했다는 전설의 갑옷입니다. | " + Gold3 + g2);
            }

            Console.WriteLine("- " + item3 + " | 공격력 +2 | 쉽게 볼 수 있는 낡은 검 입니다. | 구매완료");

            if(g3 == "구매완료")
            {
                Console.WriteLine("- " + item6 + " | 공격력 +5 | 어디선가 사용됐던거 같은 도끼입니다. | " + g3);
            }
            else
            {
                Console.WriteLine("- " + item6 + " | 공격력 +5 | 어디선가 사용됐던거 같은 도끼입니다. | " + Gold4 + g3);
            }

            Console.WriteLine("- " + item2 + " | 공력력 +7 | 스파르타의 전사들이 사용했다는 전설의 창입니다. | 구매완료");
        }

        public void BuyItem()
        {
            if(g1 == "구매완료")
            {
                Console.WriteLine("- 1 " + item4 + " | 방어력 +5 | 수련에 도움을 주는 갑옷입니다. | " + g1);
            }
            else
            {
                Console.WriteLine("- 1 " + item4 + " | 방어력 +5 | 수련에 도움을 주는 갑옷입니다. | " + Gold2 + g1);
            }

            Console.WriteLine("- 2 " + item1 + " | 방어력 +9 | 무쇠로 만들어져 튼튼한 갑옷입니다. | " + buy);

            if (g2 == "구매완료")
            {
                Console.WriteLine("- 3 " + item5 + " | 방어력 +15 | 스파르타의 전사들이 사용했다는 전설의 갑옷입니다. | " + g2);
            }
            else
            {
                Console.WriteLine("- 3 " + item5 + " | 방어력 +15 | 스파르타의 전사들이 사용했다는 전설의 갑옷입니다. | " + Gold3 + g2);
            }

            Console.WriteLine("- 4 " + item3 + " | 공격력 +2 | 쉽게 볼 수 있는 낡은 검 입니다. | " + buy);
            
            if (g3 == "구매완료")
            {
                Console.WriteLine("- 5 " + item6 + " | 공격력 +5 | 어디선가 사용됐던거 같은 도끼입니다. | " + g3);
            }
            else
            {
                Console.WriteLine("- 5 " + item6 + " | 공격력 +5 | 어디선가 사용됐던거 같은 도끼입니다. | " + Gold4 + g3);
            }

            Console.WriteLine("- 6 " + item2 + " | 공력력 +7 | 스파르타의 전사들이 사용했다는 전설의 창입니다. | " + buy);
        }
    }
}
