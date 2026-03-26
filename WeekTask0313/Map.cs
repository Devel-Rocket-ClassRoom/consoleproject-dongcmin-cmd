using System;
using System.Collections.Generic;
using static WeekTask0313.Monster;

namespace WeekTask0313
{
    //TODO : 특별 스테이지는 json으로 save load하기. - 보스
    
    public class Map
    {
        public static Random random = new Random();

        int doorRow, doorCol;

        public char[,] map;



        public char[,] CurrentMap
        {
            get { return map; }
        }
        List<Monster> Monsters = new List<Monster>();

        //public List<Monster> Monsters // 몬스터 명단을 외부에서 확인(접근) 가능하게 하는 프로퍼티
        //{
        //    get { return monsters; }
        //}

        public int Stage { get; private set; }
        public Player Player { get; private set; }
        public enum MapType//미리저장할 맵
        {
            startMap,
            eventMap,
            bossMap
        }
        public MapType mapType;
        public Map(MapType type)
        {
            mapType = type;
            switch (type)
            {
                case MapType.startMap:
                    {
                        StartMap();
                        break;
                    }
                case MapType.eventMap:
                    {
                        EventMap();
                        break;
                    }
                  
                case MapType.bossMap:
                    {
                        BossMap();
                        break;
                    }
            }
            
        }
        public Map(int r, int c, int m, int o)
        {
            CreateMap(r, c, m, o);
        }
        public void PrintMap()
        {
            //맵 프린트
            int row = map.GetLength(0);
            int col = map.GetLength(1);

            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    Console.Write(map[r, c]);
                }
                Console.WriteLine();
            }

        }

        private void StartMap()//시작맵
        {
            int row = 20;
            int col = 20;
            map = new char[row, col];

            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    if (c == 0 || c == col - 1 || r == 0 || r == row - 1)
                    {
                        map[r, c] = '#';
                        
                    }
                    else
                        map[r, c] = ' ';
                }
            }
            map[15, 15] = 'M';
            map[5, 5] = 'P';

        }
        private void EventMap()//이벤트맵
        {
            int row = 15;
            int col = 15;
            map = new char[row, col];

            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    if (c == 0 || c == col - 1 || r == 0 || r == row - 1)
                    {
                        map[r, c] = '#';

                    }
                    else
                        map[r, c] = ' ';
                }
            }
            map[5, 5] = 'P';

        }
        private void BossMap()//보스맵
        {
            int row = 50;
            int col = 50;
            map = new char[row, col];

            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    if (c == 0 || c == col - 1 || r == 0 || r == row - 1)
                    {
                        map[r, c] = '#';

                    }
                    else
                        map[r, c] = ' ';
                }
            }
            map[45, 45] = 'M';
            map[5, 5] = 'P';

        }

        public void CreateMap(int row, int col, int mon, int obj)
        {

            map = new char[row, col];
            //var list = new List<List<char>>();
            //맵생성
            for (int r = 0; r < row; r++)
            {
                //var rowList = new List<char>();
                for (int c = 0; c < col; c++)
                {
                    if (c == 0 || c == col - 1 || r == 0 || r == row - 1)
                    {
                        map[r, c] = '#';
                        //rowList.Add(map[r, c]);
                    }

                    else
                        map[r, c] = ' ';
                    //rowList.Add(map[r, c]);

                }

            }

            //DataTime dateTime = new DataTime();
            //var seed = DateTime.Now.Ticks;
            //int seeds = (int)seed;

            int randomRowPlayer;
            int randomColPlayer;
            int randomDoorRow;
            int randomDoorCol;
            int randomColM;
            int randomRowM;
            int randomRowO;
            int randomColO;
            //문이랑 플레이어 다른위치로!!!!!!!!! 문이랑 플레이어가 같을때 뜸
            //do
            //{
            //    randomColPlayer = random.Next(1, col - 1);
            //    randomRowPlayer = random.Next(1, row - 1);
            //    randomDoorCol = random.Next(1, col - 1);
            //    randomDoorRow = random.Next(1, row - 1);
            //}
            //while (randomRowPlayer == randomDoorRow && randomColPlayer == randomDoorCol);


            //장애물생성
            for (int i = 0; i < obj; i++)
            {
                do
                {
                    randomRowO = random.Next(1, row - 1);
                    randomColO = random.Next(1, col - 1);

                }
                while (map[randomRowO, randomColO] != ' ');


                map[randomRowO, randomColO] = '#';

            }

            //TODO : 몬스터 생성 무한 루프 개선
            //몬스터 랜덤 생성
            //스테이지에 따라 다른 
            //빈칸찾기 > 리스트 튜플 > 개수만큼 랜덤
            //int bCount = 0;
            //List<(int, int)> ints = new List<(int, int)>();
            //for(int r = 0; r < row; r++)
            //{
            //    for(int c = 0; c < col; c++)
            //    {
            //        if(map[r, c] == ' ')
            //        {
            //            ints.Add((r, c));
            //        }
            //    }
            //}
            //for (int i = 0; i < mon; i++)
            //{
            //    randomColM = random.Next(ints.Count);

            //}

            for (int i = 0; i < mon; i++)
            {
                Monster monster;


                do
                {
                    randomColM = random.Next(1, col - 1);
                    randomRowM = random.Next(1, row - 1);
                    monster = new Monster(GetStageMonsterType() ,randomRowM, randomColM);

                }
                while (map[randomRowM, randomColM] != ' ');

                //map[randomRowM, randomColM] = 'M'; 업데이트 함수 생성 필요.
                Monsters.Add(monster);

            }
            //문 생성
            do
            {
                randomDoorCol = random.Next(1, col - 1);
                randomDoorRow = random.Next(1, row - 1);

            }
            while (map[randomDoorRow, randomDoorCol] != ' ');
            doorRow = randomDoorRow;
            doorCol = randomDoorCol;
            map[randomDoorRow, randomDoorCol] = 'D';

            //플레이어 생성

            do
            {
                randomColPlayer = random.Next(1, col - 1);
                randomRowPlayer = random.Next(1, row - 1);

            }
            while (map[randomRowPlayer, randomColPlayer] != ' ');






            //직업에따라 다른
            //map[randomRowPlayer, randomColPlayer] = 'P'; 업데이트 함수 생성 필요.
            Console.WriteLine($"P{randomRowPlayer} {randomColPlayer}");

            UpdateMap();
        }

        public void UpdateMap()//플레이어 몬스터 삭제, 생성 업데이트
        {
            for (int r = 0; r < map.GetLength(0); r++)
            {
                for (int c = 0; c < map.GetLength(1); c++)
                {
                    if (map[r, c] == 'P' || map[r, c] == 'M')
                    {
                        map[r, c] = ' ';
                    }
                }
            }

            for (int i = 0; i < Monsters.Count; i++)
            {
                if (Monsters[i].IsAlive)
                {
                    map[Monsters[i].Row, Monsters[i].Col] = 'M';
                }
            }

            if (Player != null && Player.IsAlive)
            {
                map[Player.Row, Player.Col] = 'P';
            }


        }
        public bool CanMove(int row, int col)
        {
            if (!IsInside(row, col))
            {
                return false;
            }
            if (map[row, col] == '#' || map[row, col] == 'M')
            {
                return false;
            }


            return true;
        }

        public int DetectDoor()
        {
            //문 개수
            int DoorNember = 0;

            int row = map.GetLength(0);
            int col = map.GetLength(1);

            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    if (map[r, c] == 'D')
                    {
                        DoorNember += 1;
                    }
                }
            }
            return (DoorNember);
        }
        public (int, int) FindPlayer()
        {
            //플레이어 좌표 찾기, 갱신
            int playerRow = 0;
            int playerCol = 0;
            int row = map.GetLength(0);
            int col = map.GetLength(1);

            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    if (map[r, c] == 'P')
                    {
                        playerRow = r;
                        playerCol = c;
                    }

                }

            }

            return (playerRow, playerCol);

        }
        public bool PlayerDie()
        {
            //몬스터 개수 찾기
            bool playerDie = true;

            int row = map.GetLength(0);
            int col = map.GetLength(1);

            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    if (map[r, c] == 'P')
                    {
                        playerDie = false;

                    }
                }

            }

            return (playerDie);

        }
        public bool IsMonster()
        {
            bool isMoster = false;
            int row = map.GetLength(0);
            int col = map.GetLength(1);

            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    if (map[r, c] == 'M')
                    {
                        isMoster = true;

                    }
                }
            }
            return (isMoster);
        }
        public int CountMonster()
        {
            //몬스터 개수 찾기
            int monsterNumber = 0;

            //int row = map.GetLength(0);
            //int col = map.GetLength(1);

            //for (int r = 0; r < row; r++)
            //{
            //    for (int c = 0; c < col; c++)
            //    {
            //        if (map[r, c] == 'M')
            //        {
            //            monsterNumber += 1;

            //        }
            //    }

            //}
            if (IsMonster() == true)
            {
                monsterNumber++;
            }


            return (monsterNumber);

        }


        public List<(int, int)> MonsterPosList()
        {
            List<(int, int)> monPosList = new List<(int, int)>();

            int row = map.GetLength(0);
            int col = map.GetLength(1);

            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    if (map[r, c] == 'M')
                    {
                        monPosList.Add((r, c));

                    }

                }

            }

            return monPosList;

        }

        public bool MonsterDie()
        {
            //몬스터 개수 찾기
            bool monsterDie = true;

            int row = map.GetLength(0);
            int col = map.GetLength(1);

            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    if (map[r, c] == 'M')
                    {
                        monsterDie = false;

                    }
                }

            }

            return (monsterDie);

        }

        private bool IsInside(int row, int col)
        {
            return row < map.GetLength(0) && col < map.GetLength(1) && row >= 0 && col >= 0;
        }

        private Monster.MonsterType GetStageMonsterType()
        {
            switch (Stage)
            {
                case 1:
                    return Monster.MonsterType.Slime;

                case 2:
                    return Monster.MonsterType.Goblin;

                case 3:
                    return Monster.MonsterType.Orc;

                default: // 4스테이지 이상은 Dragon으로 설정됩니다.
                    return Monster.MonsterType.Dragon;
            }
        }

        //public List<(int, int)> ListMonsterPos()//몬스터 개수만큼 반복
        //{
        //    List<(int, int)> monPosList = new List<(int, int)>();


        //    for (int i = 0; i < CountMonster(); i++)
        //    {
        //        monPosList.Add(FindMonster());

        //    }
        //    return monPosList;
        //}
    }
}
