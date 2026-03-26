using System;
using System.Collections.Generic;

namespace WeekTask0313
{
    public class Monster : Character
    {
        public enum MonsterType
        {
            Slime,
            Goblin,
            Orc,
            Dragon
        }

        public MonsterType MonType { get; private set; }
        public Monster(MonsterType monType, int r, int c) : base(monType.ToString(), 0, 0, r, c)
        {
            MonType = monType; // 기본값으로 슬라임 설정.
            MonsterStats();
        }
        
        

        public void MonsterAttack()
        {

            //플레이어와 일정거리에 있을때
            Dungeon.playerHp -= Attack;
        }

        public (int, int) MonsterStats()
        {
            switch (MonType)
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
        {    

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

            int monsterMove = moveList[Map.random.Next(moveList.Count)];

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

        protected override void MakeSound()
        {
            //throw new NotImplementedException();
        }
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
