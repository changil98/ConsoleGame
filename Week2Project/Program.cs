using System.Security.Cryptography.X509Certificates;

namespace Week2Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            State state = new State();
            state.Lv = 01;
            state.Name = "CHANGIL";
            state.Job = "전사";
            state.Ap = 10;
            state.Dp = 5;
            state.Hp = 100;
            state.Gold1 = 1500;

            Inven inven = new Inven();
            inven.item1 = "무쇠갑옷";
            inven.item2 = "스파르타의 창";
            inven.item3 = "낡은 검";
            inven.item4 = "수련자 갑옷";
            inven.item5 = "스파르타의 갑옷";
            inven.item6 = "청동 도끼";
            inven.buy = "구매완료";
            inven.g1 = "G";
            inven.g2 = "G";
            inven.g3 = "G";
            inven.Gold2 = 1000;
            inven.Gold3 = 3500;
            inven.Gold4 = 1500;

            while (true)
            {
                Console.Clear();

                Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
                Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
                Console.WriteLine("\n1. 상태 보기\n2. 인벤토리\n3. 상점");
                Console.Write("\n원하시는 행동을 입력해주세요.\n>> ");

                string userInput = Console.ReadLine();
                int num;


                if (int.TryParse(userInput, out num))
                {
                    if (num == 1)
                    {
                        while (true)
                        {
                            Console.Clear();

                            Console.WriteLine("상태 보기\n캐릭터의 정보가 표시됩니다.\n");
                            state.Print();
                            Console.WriteLine("\n0. 나가기\n");
                            Console.Write("원하시는 행동을 입력해주세요.\n>> ");

                            string userInput1 = Console.ReadLine();
                            int num1;

                            if (int.TryParse(userInput1, out num1))
                            {
                                if (num1 == 0)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.Clear();

                                    Console.Write("\n\n\n\n잘못된 입력입니다.");

                                    Thread.Sleep(1000);
                                }
                            }
                            else
                            {
                                Console.Clear();

                                Console.Write("\n\n\n\n잘못된 입력입니다.");

                                Thread.Sleep(1000);
                            }
                        }
                    }
                    else if (num == 2)
                    {
                        while (true)
                        {
                            Console.Clear();

                            Console.WriteLine("인벤토리\n보유 중인 아이템을 관리할 수 있습니다\n");
                            Console.WriteLine("[아이템 목록]\n");
                            Console.WriteLine("1. 장착관리\n0. 나가기\n");
                            Console.Write("원하시는 행동을 입력해주세요.\n>> ");

                            string userInput2 = Console.ReadLine();
                            int num2;

                            if (int.TryParse(userInput2, out num2))
                            {
                                if (num2 == 1)
                                {
                                    while (true)
                                    {
                                        Console.Clear();                                        

                                        Console.WriteLine("인벤토리\n보유 중인 아이템을 관리할 수 있습니다\n");
                                        Console.WriteLine("[아이템 목록]\n");
                                        inven.PrintItem();
                                        Console.WriteLine("\n0나가기\n");
                                        Console.Write("원하시는 행동을 입력해주세요.\n>> ");

                                        string userInput3 = Console.ReadLine();
                                        int num3;
                                        if (int.TryParse(userInput3, out num3))
                                        {
                                            if (num3 == 0)
                                            {
                                                break;
                                            }
                                            else if (num3 == 1)
                                            {
                                                if (inven.item1.Contains("[E]"))
                                                {
                                                    inven.item1 = "무쇠갑옷";
                                                    state.Dp -= 9;
                                                }
                                                else
                                                {
                                                    inven.item1 = "[E]무쇠갑옷";
                                                    state.Dp += 9;
                                                }
                                            }
                                            else if (num3 == 2)
                                            {
                                                if (inven.item2.Contains("[E]"))
                                                {
                                                    inven.item2 = "스파르타의 창";
                                                    state.Ap -= 7;
                                                }
                                                else
                                                {
                                                    inven.item2 = "[E]스파르타의 창";
                                                    state.Ap += 7;
                                                }
                                            }
                                            else if (num3 == 3)
                                            {
                                                if (inven.item3.Contains("[E]"))
                                                {
                                                    inven.item3 = "낡은 검";
                                                    state.Ap -= 2;
                                                }
                                                else
                                                {
                                                    inven.item3 = "[E]낡은 검";
                                                    state.Ap += 2;
                                                }
                                            }
                                            else if (num3 == 4 && inven.g1 == "구매완료")
                                            {
                                                if (inven.item4.Contains("[E]"))
                                                {
                                                    inven.item4 = "수련자 갑옷";
                                                    state.Dp -= 5;
                                                }
                                                else
                                                {
                                                    inven.item4 = "[E]수련자 갑옷";
                                                    state.Dp += 5;
                                                }
                                            }
                                            else if (num3 == 5 && inven.g2 == "구매완료")
                                            {
                                                if (inven.item5.Contains("[E]"))
                                                {
                                                    inven.item5 = "스파르타의 갑옷";
                                                    state.Dp -= 15;
                                                }
                                                else
                                                {
                                                    inven.item5 = "[E]스파르타의 갑옷";
                                                    state.Dp += 15;
                                                }
                                            }
                                            else if (num3 == 6 && inven.g3 == "구매완료")
                                            {
                                                if (inven.item6.Contains("[E]"))
                                                {
                                                    inven.item6 = "청동 도끼";
                                                    state.Ap -= 5;
                                                }
                                                else
                                                {
                                                    inven.item6 = "[E]청동 도끼";
                                                    state.Ap += 5;
                                                }
                                            }
                                            else
                                            {
                                                Console.Clear();

                                                Console.Write("\n\n\n\n잘못된 입력입니다.");

                                                Thread.Sleep(1000);
                                            }
                                        }
                                        else
                                        {
                                            Console.Clear();

                                            Console.Write("\n\n\n\n잘못된 입력입니다.");

                                            Thread.Sleep(1000);
                                        }
                                    }
                                }
                                else if (num2 == 0)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.Clear();

                                    Console.Write("\n\n\n\n잘못된 입력입니다.");

                                    Thread.Sleep(1000);
                                }
                            }
                            else
                            {
                                Console.Clear();

                                Console.Write("\n\n\n\n잘못된 입력입니다.");

                                Thread.Sleep(1000);
                            }
                        }                        
                    }
                    else if (num == 3)
                    {
                        while (true)
                        {
                            Console.Clear();

                            Console.WriteLine("상점\n필요한 아이템을 얻을 수 있는 상점입니다.");
                            Console.WriteLine("\n[보유 골드]\n" + state.Gold1 + "G\n");
                            Console.WriteLine("[아이템 목록]");
                            inven.PrintShop();
                            Console.WriteLine("\n1. 아이템 구매\n0. 나가기");
                            Console.Write("\n원하시는 행동을 입력해주세요\n>> ");

                            string userInput4 = Console.ReadLine();
                            int num4;
                            if(int.TryParse(userInput4, out num4))
                            {
                                if (num4 == 0)
                                {
                                    break;
                                }
                                else if (num4 == 1)
                                {
                                    while (true)
                                    {
                                        Console.Clear();

                                        Console.WriteLine("상점 - 아이템 구매\n필요한 아이템을 얻을 수 있는 상점입니다.");
                                        Console.WriteLine("\n[보유 골드]\n" + state.Gold1 + "G\n");
                                        Console.WriteLine("[아이템 목록]");
                                        inven.BuyItem();
                                        Console.WriteLine("\n0. 나가기");
                                        Console.Write("\n원하시는 행동을 입력해주세요\n>> ");

                                        string userInput5 = Console.ReadLine();
                                        int num5;
                                        if (int.TryParse(userInput5, out num5))
                                        {
                                            if (num5 == 0)
                                            {
                                                break;
                                            }
                                            else if (num5 == 1)
                                            {
                                                if (inven.g1 == "구매완료")
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("\n\n\n\n이미 구매한 아이템입니다.");
                                                    Thread.Sleep(1000);
                                                }
                                                else if (state.Gold1 >= inven.Gold2)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("\n\n\n\n구매를 완료했습니다.");
                                                    Thread.Sleep(1000);

                                                    state.Gold1 -= inven.Gold2;
                                                    
                                                    inven.g1 = "구매완료";                                                    
                                                }                                                
                                                else if (state.Gold1 < inven.Gold2)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("\n\n\n\nGold 가 부족합니다.");
                                                    Thread.Sleep(1000);
                                                }                                                
                                            }
                                            else if (num5 == 2)
                                            {
                                                if(inven.buy == "구매완료")
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("\n\n\n\n이미 구매한 아이템입니다.");
                                                    Thread.Sleep(1000);
                                                }
                                            }
                                            else if (num5 == 3)
                                            {
                                                if (inven.g2 == "구매완료")
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("\n\n\n\n이미 구매한 아이템입니다.");
                                                    Thread.Sleep(1000);
                                                }
                                                else if (state.Gold1 >= inven.Gold3)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("\n\n\n\n구매를 완료했습니다.");
                                                    Thread.Sleep(1000);

                                                    state.Gold1 -= inven.Gold3;

                                                    inven.g2 = "구매완료";                                                    
                                                }                                                
                                                else if (state.Gold1 < inven.Gold3)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("\n\n\n\nGold 가 부족합니다.");
                                                    Thread.Sleep(1000);
                                                }
                                            }
                                            else if (num5 == 4)
                                            {
                                                if (inven.buy == "구매완료")
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("\n\n\n\n이미 구매한 아이템입니다.");
                                                    Thread.Sleep(1000);
                                                }
                                            }
                                            else if (num5 == 5)
                                            {
                                                if (inven.g3 == "구매완료")
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("\n\n\n\n이미 구매한 아이템입니다.");
                                                    Thread.Sleep(1000);
                                                }
                                                else if (state.Gold1 >= inven.Gold4)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("\n\n\n\n구매를 완료했습니다.");
                                                    Thread.Sleep(1000);

                                                    state.Gold1 -= inven.Gold4;

                                                    inven.g3 = "구매완료";                                                    
                                                }
                                                else if (state.Gold1 < inven.Gold4)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("\n\n\n\nGold 가 부족합니다.");
                                                    Thread.Sleep(1000);
                                                }
                                            }
                                            else if (num5 == 6)
                                            {
                                                if (inven.buy == "구매완료")
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("\n\n\n\n이미 구매한 아이템입니다.");
                                                    Thread.Sleep(1000);
                                                }
                                            }
                                            else
                                            {
                                                Console.Clear();

                                                Console.Write("\n\n\n\n잘못된 입력입니다.");

                                                Thread.Sleep(1000);
                                            }
                                        }
                                        else
                                        {
                                            Console.Clear();

                                            Console.Write("\n\n\n\n잘못된 입력입니다.");

                                            Thread.Sleep(1000);
                                        }
                                    }
                                }
                                else
                                {
                                    Console.Clear();

                                    Console.Write("\n\n\n\n잘못된 입력입니다.");

                                    Thread.Sleep(1000);
                                }
                            }
                            else
                            {
                                Console.Clear();

                                Console.Write("\n\n\n\n잘못된 입력입니다.");

                                Thread.Sleep(1000);
                            }
                        }
                    }
                    else
                    {
                        Console.Clear();

                        Console.Write("\n\n\n\n잘못된 입력입니다.");

                        Thread.Sleep(1000);
                    }
                }
                else
                {
                    Console.Clear();

                    Console.Write("\n\n\n\n잘못된 입력입니다.");

                    Thread.Sleep(1000);
                }
            }
        }
    }
}
