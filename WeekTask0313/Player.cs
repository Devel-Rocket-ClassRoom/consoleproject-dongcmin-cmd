using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekTask0313
{
    public class Player : character
    {
        public Player()
        {

        }
        public Player(string name, string clas)
        {
            playerName = name;
            playerClass = clas;
        }
        protected override void MakeSound()
        {
            //throw new NotImplementedException();
        }


        string playerName;
        string playerClass;
        public int playerHp = 100;//나중에 프라이빗으로 바꾸고싶으면 바꾸기
        public int playerDamage = 20;//클래스에 따라 다름

        public void PlayerControl(Map map) //플레이어 이동 메소드
        {
            
            var PlayerPos = map.FindPlayer();
            int playerY = PlayerPos.Item1;
            int playerX = PlayerPos.Item2;

            bool loop = true;

            while (loop == true)
            {


                Console.WriteLine("이동방향을 입력하세요. Right : d, Left : a, Up: w, Down : s, stop : x (, Esc : 종료)");
                string Order = Console.ReadLine();

                //특정 키 이외의 입력일때
                if (Order != "d" && Order != "a" && Order != "w" && Order != "s" && Order != "x")
                {
                    Console.WriteLine("잘못된입력입니다!");
                }
                //Right입력일때
                else if (Order == "d")
                {
                    if (map.CurrentMap[playerY, playerX + 1] == '#')
                    {
                        Console.WriteLine("이동할수없습니다!");
                    }

                    else
                    {
                        map.CurrentMap[playerY, playerX + 1] = 'P';
                        map.CurrentMap[playerY, playerX] = ' ';
                        loop = false;
                    }
                }
                //Left입력일때
                else if (Order == "a")
                {
                    if (map.CurrentMap[playerY, playerX - 1] == '#')
                    {
                        Console.WriteLine("이동할수없습니다!");
                    }

                    else
                    {
                        map.CurrentMap[playerY, playerX - 1] = 'P';
                        map.CurrentMap[playerY, playerX] = ' ';
                        loop = false;

                    }
                }
                //Up입력일때
                else if (Order == "w")
                {
                    if (map.CurrentMap[playerY - 1, playerX] == '#')
                    {
                        Console.WriteLine("이동할수없습니다!");
                    }

                    else
                    {
                        map.CurrentMap[playerY - 1, playerX] = 'P';
                        map.CurrentMap[playerY, playerX] = ' ';
                        loop = false;

                    }
                    //Down입력일때
                }
                else if (Order == "s")
                {
                    if (map.CurrentMap[playerY + 1, playerX] == '#')
                    {
                        Console.WriteLine("이동할수없습니다!");
                    }

                    else
                    {
                        map.CurrentMap[playerY + 1, playerX] = 'P';
                        map.CurrentMap[playerY, playerX] = ' ';
                        loop = false;

                    }
                }
                else if (Order == "x")
                {
                    loop = false;
                }
            }
            //loop = true;
            //while (loop == true)
            //{
            //    Console.WriteLine("행동을 선택하세요. 공격 : q, 방어 : e");
            //    string batOrder = Console.ReadLine();

            //    if (batOrder != "q" && batOrder != "e" && batOrder != "r" && batOrder != "f" && batOrder != "M")
            //    {
            //        Console.WriteLine("잘못된행동입니다!");
            //    }
            //    else if (batOrder == "q")
            //    {
            //        Player player = new Player();
            //        player.PlayerAttack();

            //        Console.WriteLine("공격");

            //        loop = false;


            //    }
            //    else if (batOrder == "e")
            //    {
            //        Console.WriteLine("방어");
            //        loop = false;

            //    }
            //    else if (batOrder == "r")
            //    {
            //        loop = false;

            //    }
            //    else if (batOrder == "f")
            //    {
            //        loop = false;

            //    }
            //    else if (batOrder == "M")
            //    {
            //        //치트모드
            //        loop = false;

            //    }
            //}


        }
        public void PlayerAttack()
        {
            Dungeon.monsterHp -= Dungeon.playerDamage;
        }


    }
    
}
