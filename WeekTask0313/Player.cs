using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekTask0313
{
    public class Player     : Character
    {
        string playerName;
        public string PlayerClass { get; private set; }

        public Player(string name, string clas, int row, int col) : base(name, 0, 0, row, col)
        {
            PlayerClass = clas;
            playerName = name;
            SetPlayerStats();
        }   
        
        private void SetPlayerStats()
        {
            // ToLower() 함수는 모든 문자열을 소문자로 변환하여 새 문자열을 반환합니다.
            // Program 클래스에서 입력을 받을 때, Warrior, warrior, WaRrior 등으로 입력해도 자동으로 warrior로 만들고 타입을 인식합니다.
            switch (PlayerClass.ToLower())
            {
                case "warrior":
                    Hp = 140;
                    Attack = 20;
                    break;

                case "archer":
                    Hp = 100;
                    Attack = 25;
                    break;

                case "mage":
                    Hp = 80;
                    Attack = 30;
                    break;

                default:
                    PlayerClass = "Warrior";
                    Hp = 140;
                    Attack = 20;
                    break;
            }
        }


        public void PlayerControl(Map map) //플레이어 이동 메소드
        {
            
            //var PlayerPos = map.FindPlayer();
            //int playerY = PlayerPos.Item1;
            //int playerX = PlayerPos.Item2;

            bool loop = true;

            while (loop == true)
            {
                Console.WriteLine("이동방향을 입력하세요. Right : d, Left : a, Up: w, Down : s, stop : x , Esc : 종료");
                ConsoleKeyInfo key = Console.ReadKey();
                int nextRow = Row;
                int nextCol = Col;
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        {
                            nextRow--;
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            nextRow++;
                            break;
                        }
                    case ConsoleKey.LeftArrow:
                        {
                            nextCol--;
                            break;
                        }
                    case ConsoleKey.RightArrow:
                        {
                            nextCol++;
                            break;
                        }
                    case ConsoleKey.X:
                        {
                            loop = false;
                            continue;
                        }
                    case ConsoleKey.Escape:
                        {
                            loop = false;
                            continue;
                            //TODO : 전체게임 종료
                        }
                    default:
                        {
                            Console.WriteLine("잘못된입력입니다!");
                            continue;
                        }

                       
                }
                if (!map.CanMove(nextRow, nextCol))
                {
                    Console.WriteLine("이동할수없습니다!");
                }
                else
                {
                    SetPosition(nextRow, nextCol);
                    loop = false;
                }



            }

        }
        public void PlayerSkill()
        {

            bool loop = true;
            while (loop == true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                Console.WriteLine("행동을 선택하세요. 공격 : q, 방어 : w, ......");
                switch (key.Key)
                {
                    case ConsoleKey.Q:
                        {
                            break;
                        }
                    case ConsoleKey.W:
                        {
                            break;
                        }
                    case ConsoleKey.E:
                        {
                            break;
                        }
                    case ConsoleKey.R:
                        {

                            break;
                        }
                    case ConsoleKey.Spacebar:
                        {
                            //치트
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("잘못된입력입니다!");
                            continue;
                        }
                }
            }
        }







        protected override void MakeSound()
        {
            //throw new NotImplementedException();
        }

        //public void PlayerAttack()
        //{
        //    Dungeon.monsterHp -= Dungeon.playerDamage;
        //}


    }
    
}
