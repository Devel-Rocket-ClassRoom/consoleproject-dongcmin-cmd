using System;
using System.Collections.Generic;

namespace WeekTask0313
{
    public class Monster
    {
        public int Row;
        public int Col;
        public int Hp;
        public int Attack;
        public bool IsAlive;
        public Monster()
        {

        }
        public Monster(int r, int c)
        {
            Row = r;
            Col = c;
            Hp = 100;
            Attack = 20;
        }

        public Monster(int stage)
        {
            //스테이지에 따라 다른 몬스터 출력
        }


        public enum MonsterType
        {
            Slime,
            Goblin,
            Orc,
            Dragon
        }
        public MonsterType monType;

        public void MonsterAttack()
        {

            //플레이어와 일정거리에 있을때
            Dungeon.playerHp -= Attack;
        }

        public (int, int) MonsterStats()
        {
            switch (monType)
            {
                case MonsterType.Slime:
                    Hp = 10;
                    Attack = 10;
                    break;
                case MonsterType.Goblin:
                    Hp = 20;
                    Attack = 20;
                    break;
                case MonsterType.Orc:
                    Hp = 30;
                    Attack = 30;
                    break;
                case MonsterType.Dragon:
                    Hp = 40;
                    Attack = 40;
                    break;
            }
            return (Hp, Attack);
        }




        public void MonsterMove(Map map)
        {    // TODO : 몬스터가 비슷한 방향으로 움직임

            var monsterPos = map.MonsterPosList();

            for (int i = 0; i < monsterPos.Count; i++)
            {
                int monsterRow = monsterPos[i].Item1;
                int monsterCol = monsterPos[i].Item2;

                MonsterMovement(map, monsterRow, monsterCol);

            }

        }
        public void MonsterMovement(Map map, int monR, int monC) //플레이어 이동 메소드
        {
            if (map.CountMonster() == 0)
            {
                return;
            }
            //var monsterPos = map.FindMonster();


            int monsterRow = monR;
            int monsterCol = monC;
            List<int> moveList = new List<int>();

            //char chars = map.CurrentMap[monsterRow + 1, monsterCol];
            if (map.CurrentMap[monsterRow + 1, monsterCol] != '#' && map.CurrentMap[monsterRow + 1, monsterCol] != 'D' && map.CurrentMap[monsterRow + 1, monsterCol] != 'M')
            {
                moveList.Add(0);
            }
            if (map.CurrentMap[monsterRow, monsterCol + 1] != '#' && map.CurrentMap[monsterRow, monsterCol + 1] != 'D' && map.CurrentMap[monsterRow, monsterCol + 1] != 'M')
            {
                moveList.Add(1);
            }
            if (map.CurrentMap[monsterRow - 1, monsterCol] != '#' && map.CurrentMap[monsterRow - 1, monsterCol] != 'D' && map.CurrentMap[monsterRow - 1, monsterCol] != 'M')
            {
                moveList.Add(2);
            }
            if (map.CurrentMap[monsterRow, monsterCol - 1] != '#' && map.CurrentMap[monsterRow, monsterCol - 1] != 'D' && map.CurrentMap[monsterRow, monsterCol - 1] != 'M')
            {
                moveList.Add(3);
            }

            if ((moveList.Count) == 0)
            {
                return;
            }

            Random random = new Random();
            int monsterMove = moveList[random.Next(moveList.Count)];

            switch (monsterMove)
            {
                case 0:
                    map.CurrentMap[monsterRow, monsterCol] = ' ';

                    map.CurrentMap[monsterRow + 1, monsterCol] = 'M';

                    break;
                case 1:
                    map.CurrentMap[monsterRow, monsterCol] = ' ';

                    map.CurrentMap[monsterRow, monsterCol + 1] = 'M';
                    break;
                case 2:
                    map.CurrentMap[monsterRow, monsterCol] = ' ';

                    map.CurrentMap[monsterRow - 1, monsterCol] = 'M';
                    break;
                case 3:
                    map.CurrentMap[monsterRow, monsterCol] = ' ';

                    map.CurrentMap[monsterRow, monsterCol - 1] = 'M';
                    break;

            }

        }

        //    protected override void MakeSound()
        //    {
        //        //throw new NotImplementedException();
        //    }
        //    private delegate void PrintNameDelegate(); PrintNameDelegate PrintName = PrintRealName;
               //    public void PrintName()
        //    {

        //    }
        //    void PrintRealName()
        //    {

        //    }
        //}
        

    }
}
