using System;
using System.Collections.Generic;

namespace WeekTask0313
{


    public class Map
    {
        public static Random random = new Random();

        int doorRow, doorCol;

        public char[,] map;



        public char[,] CurrentMap
        {
            get { return map; }
        }
        List<Monster> monsters = new List<Monster>();
        public Map()
        {

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
                    monster = new Monster(randomRowM, randomColM);

                }
                while (map[randomRowM, randomColM] != ' ');

                //map[randomRowM, randomColM] = 'M'; 업데이트 함수 생성 필요.
                monsters.Add(monster);

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

        public void UpdateMap()
        {

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
