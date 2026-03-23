using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    //ctrl + k + d

    public class Person
    {
        public string Name = "사람";
        public int Age = 50;
        public int Sex;
        public string[] Citizenship;

    }

    public class JapanesePerson : Person
    {

    }

    class KoreanPerson : Person
    {
        public string Name;
        public int Age;
        public int Sex;
        public string Address;
        public string[] Citizenship;

        private int Id;
        private float Height;
        private float Weight;

        public KoreanPerson()
        {
            Name = "홍길동";
            Id = 0;
            Height = 0;
            Weight = 0;

        }
        public KoreanPerson(string name, int id, float height, float weight)
        {
            Name = name;
            Id = id;
            Height = height;
            Weight = weight;
        }
        public KoreanPerson(string s)
        {
            Name = s;
        }


        public int GetId()
        {
            int n = 10;
            return Id * n;
        }
        
    }



    





   
    //한국인이란 한국 국적을 가졌으며




    internal class Program



    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int>();
            ints.Add('A');
            Console.WriteLine(ints[0]);
            //0110
            //1011
            //Console.WriteLine(6 | 11);
            //Person person = new Person();
            //Person person1 = new Person();
            //KoreanPerson korean1 = new KoreanPerson();
            //KoreanPerson korean3 = new KoreanPerson();

            //person = korean1; //바뀌는게 뭐임?? 참조라 없는듯
            ////korean3 = (KoreanPerson)person1;
            //_ = person.Name;//korea1 name 나오게?
            //_ = korean3.Name;

            //KoreanPerson kor1 = new KoreanPerson("동");
            //_ = kor1.Name;

            //_ = korean1.Name;
            //_ = korean1.Sex;
            //korean1.Name = Console.ReadLine();
            //korean1.Sex = 0;    //0: 남자, 여자:1

            //KoreanPerson korean2 = new KoreanPerson("김말동", 2, 350f, 3.1f);
            //Dictionary<int, KoreanPerson> koreanPeopleDB = new Dictionary<int, KoreanPerson>();

            ////koreanPeopleDB.Add();
            //object o = korean1;
            //if(o is KoreanPerson)
            //{
            //    KoreanPerson k = (KoreanPerson)o;
            //}

            //foreach(string v in args)
            //{
            //    Console.WriteLine(v);
            //}


            //int a = 0;
            //int b = 10;
            //string str = "이것은 문자열";
            //bool check = false;
            //float c = 10.0f;
            //double d = 30.01;

            //c = (float)d;
            //c = a;


            //string cnt = Console.ReadLine();
            //str = Console.ReadLine();
            //a = int.Parse(cnt);
            //for (int i = 0; i < a; i++)
            //{
            //    Console.WriteLine(str);
            //    Console.WriteLine(i+1);
            //}
            //Console.WriteLine(a);
            //string star = "*";
            //for (int i = 0; i < a; i++)
            //{

            //    Console.WriteLine(star);

            //    star += "*";


            //}
            //a = 0;
            //do
            //{
            //    a++;
            //    Console.WriteLine("Test");
            //    check = a < b;
            //    Console.WriteLine(a);
            //}
            //while (check);
            //&&  ||

            //string p;
            //int a;
            //int b;
            //Console.WriteLine("마름모 가운데 별 홀수 숫자를 적으세요>>>");
            //string cnt = Console.ReadLine();
            //a = int.Parse(cnt);
            ////7 > 4
            //// 4 x 2 - 1 = 7
            //// 1줄 = 1개 2줄 = 3 3줄 5 4줄 = 7
            //// 만약 입력값이 홀수가 아니면 x 
            //// 홀수이면 (7 + 1) / 2

            //b = (a + 1) / 2;
            //string star = "*";
            //string n = " ";

            //while (a % 2 == 0)
            //{
            //    Console.WriteLine("홀수를 입력하세요.");
            //    cnt = Console.ReadLine();
            //    a = int.Parse(cnt);
            //    b = (a + 1) / 2;
            //    if (a % 2 != 0)
            //    {
            //        break;
            //    }
            //}

            //for (int i= 0; i < b; i++ )
            //{
            //    //0 1 2 3
            //    //Console.WriteLine(star);
            //    //star += "*";

            //    // 1 2 3 ...
            //    // 1
            //    //3 2 1 0 = 4 - i 반복
            //    for (int k = b- 1; i < k; k--)
            //    {
            //        //3 0  3 2 1
            //        //4  3 2 1
            //        Console.Write(n);

            //    }


            //    for (int j = 1; j <= (2*i + 1) ; j = j + 1)
            //    {

            //        Console.Write(star);

            //    }
            //    Console.WriteLine("");


            //}


            //for (int i = 0; i < b-1; i += 1)
            //{

            //    for (int k = 0; i >= k; k++)
            //    {
            //        Console.Write(n);

            //    }


            //    for (int j = a - 1; (2*i + 1) < j; j--)
            //        //65432
            //        //                                                                                 
            //    {
            //        Console.Write(star);
            //    }
            //    Console.WriteLine("");
            //}



            //   *
            //  ***
            // *****
            //*******
            // *****
            //2 x n + 1


            //int[] a= new int[10];
            //string[] s = new string[5];

            //List<string> str = new List<string>();

            //for(int i = 0; i < s.Length; i++)
            //{
            //    string tmp = Console.ReadLine();
            //    str.Add(tmp);
            //}

            //for (int i = 0; i < str.Count; i++)
            //{

            //    Console.WriteLine(str[i]);
            //}




            //int[] a = new int[10];
            //int[] b = { 1, 2, 3, 4, 5, 6, 7 };
            //Console.WriteLine(a.Length);
            //Console.WriteLine(b.Length);
            //List<int> c = new List<int>(){ 1, 2, 3, 4, 5, 6 };
            //c.Add(7);
            //c.Insert(1, 100);
            //Console.WriteLine(c[6]);
            //Console.WriteLine(c[1]);
            //c.RemoveAt(0);
            //// 100 2 3

            //c.Remove(100);
            ////2 3 4
            //Console.WriteLine(c[0]);
            //Console.WriteLine(c[1]);


            //int[] a = new int[10];
            //int[] b = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            ////Array.Clear(b, 1, 5);
            ////Array.Resize<int>(ref b, 20);
            ////Array.Sort(b);
            ////Array.Reverse(b);

            //for(int i = 0; i < b.Length; i++)
            //{
            //    Console.Write(b[i] + " ");
            //}
            //Console.WriteLine();


            //List<int> c = new List<int>() { 11, 21, 0, 1, 2, 3, 41, 8, 100, 7 };
            //c.Sort();
            //for(int i = 0; i < c.Count; i++)
            //{
            //    Console.Write(c[i] + " ");
            //}

            //int[ , ] a = new int[5, 5];
            //int[,] b = {
            //{ 0, 1, 2, 3, 4 },
            //{ 5, 6, 7, 8, 9, },
            //{ 10, 11, 12, 13, 14 },
            //{ 10, 11, 12, 13, 14 },
            //{ 10, 11, 12, 13, 14 }
            //};
            ////int[,,] c =

            //for(int row = 0; row < 5; row++)
            //{
            //    for(int col = 0; col < 5; col++)
            //    {
            //        a[row, col] = -1;
            //    }

            //    Console.Write(a);
            //}



            //Dictionary<string, int> d = new Dictionary<string, int>(); //System.Collections.Generic.Dictionary<int>? 
            //d.Add("apple", 5);
            //d.Add("strawberry", 10);

            //Dictionary<int, string> e = new Dictionary<int, string>();
            //e.Add(11, "hi");
            //e.Add(33, "world");

            //Dictionary<string, string> f = new Dictionary<string, string>();
            //f.Add("Death", "You Die.");
            //f.Add("Warn", "Warning! You almost Die ");
            ////f.Remove("Warn");


            //Console.WriteLine(f["Warn"]);

            //GameObject obj = Instantiate(projectile, spawnPoint.position, spawnPoint.rotation);
            //Rigidbody rb = obj.GetComponent<Rigidbody>(); -- getcomponent>>>??? <<<< 



            // Function 만들기
            // 0. Dictionary는 <string, string> 으로 정의
            // 1. 키, 값  두 개를 ReadLine 2개를 사용해 총 5번 입력 - for문?
            // 2. Dictionary 에 저장
            // 3. 출력

            //TestDictionary(3, "hi");




            //string a = Console.ReadLine();

            //int output = 0;

            //if(a == "A")
            //{
            //    output += 1; 
            //}
            //if(a =="B")
            //{
            //    output -= 1;
            //}
            //if(a == "C")
            //{
            //    output += 2;
            //}
            //if(a == "D")
            //{
            //    output -= 2;
            //}

            //switch(a)
            //{
            //    case "A":
            //        output += 1;
            //        break;

            //    case "B":
            //        output -= 1;
            //        break;

            //    case "C":
            //        output += 2;
            //        break;

            //    case "D":
            //        output -= 2;
            //        break;

            //    default:
            //        Console.WriteLine("잘못된 명령입니다");
            //        break;
            //}

            //char[,] stage1Map = {
            //    {' ', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'}, 
            //    {' ', '#', 'P', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
            //    {' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'}, 
            //    {' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
            //    {' ', '#', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'}, 
            //    {' ', '#', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
            //    {' ', '#', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'}, 
            //    {' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
            //    {' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'M', ' ', 'M', ' ', 'M', '#'}, 
            //    {' ', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'}
            //};
            //char[,] stage2Map =
            //{
            //    {' ', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'},
            //    {' ', '#', 'P', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
            //    {' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
            //    {' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
            //    {' ', '#', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
            //    {' ', '#', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
            //    {' ', '#', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
            //    {' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
            //    {' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'M', ' ', 'M', ' ', 'M', '#'},
            //    {' ', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'}
            //};

            //List<char[,]> list = new List<char[,]>();

            //list.Add();
            //char[,] stage3Map = CreateMap(10, 10);
            //GamePlay(stage1Map);
            //GamePlay(stage2Map);
            //[1,2]


            //char[,] map = { { } };




            //1. 맵데이터 가져온다
            //2. 플레이어 위치와 몬스터 개수를 알아낸다. 
            //3. P이동 : 'L' left, 'R' Right, 'U' Up, "D" Down <<ReadLine
            //4. 만약 벽이면 '이동못함' 출력
            //5. m으로 이동시 '성공' 출력 후 종료
            //5. printMap 으로 맵 출력



            //P right/left : [0,+/-] / up/down [-/+, 0] 
            //플레이어 위치  px + 1 = p 



            //p>m도달하면 끝.


            //랜덤하게 m배치
            //
            //PlayerControl(testMap, playerX, playerY);
            //GamePlay(stage1Map);



        }
        //static void InsertMonser(int count)
        //{
        //    Random rand = new Random();
        //    int randomX = rand.Next(0, rowLength);
        //    int randomY = rand.Next(0, colLength);
        //}

        static void PrintMap(char[,] map)
        {

            int row = map.GetLength(0);
            int col = map.GetLength(1);

            for (int r = 0; r < row; r++)
            {
                for(int c = 0; c < col; c++ )
                {
                    Console.Write(map[r, c]);
                }
                Console.WriteLine();
            }

        }

        static (int, int) FindPlayer(char[,] map)
        {
            
            int playerX = 0;
            int playerY = 0;
            int row = map.GetLength(0);
            int col = map.GetLength(1);

            for (int r = 0; r < row; r++)
            {
                for(int c = 0; c < col; c++ )
                {
                    if (map[r,c] == 'P')
                    {
                        playerX = c;
                        playerY = r;
                    }
                    
                }
                
            }
            
            return (playerX, playerY);

        }

        static int CountMonster(char[,] map)
        {
            //몬스터가 2개 이상이면 좌표를 각각 어떻게 표시????
            //몬스터가 여러개이면 여러개의 좌표를 return해야되는데 그럼 int 개수가 그에 따라 늘어남. 당장 한개일때는 의미없지만 3개이상될때는....???
            //몬스터 개수만 필요한가?
            int MonsterNumber = 0;
            
            int row = map.GetLength(0);
            int col = map.GetLength(1);

            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    if (map[r, c] == 'M')
                    {
                        MonsterNumber += 1;
                        
                    }
                }

            }

            return (MonsterNumber);

        }

        static void PlayerControl(char[,] map, int playerX, int playerY)
        {
            Console.WriteLine("방향을 입력하세요. R L U D");
            string Order = Console.ReadLine();
            if (Order != "R" && Order != "L" && Order != "U" && Order != "D")
            {
                Console.WriteLine("잘못된입력입니다!");
            }
            else if (Order == "R")
            {
                if (map[playerY, playerX + 1] == '#')
                {
                    Console.WriteLine("이동할수없습니다!");
                }
                
                else
                {
                    map[playerY, playerX + 1] = 'P';
                    map[playerY, playerX] = ' ';
                }
            }
            else if (Order == "L")
            {
                if (map[playerY, playerX - 1] == '#')
                {
                    Console.WriteLine("이동할수없습니다!");
                }
                
                else
                {
                    map[playerY, playerX - 1] = 'P';
                    map[playerY, playerX] = ' ';
                }
            }
            else if (Order == "U")
            {
                if (map[playerY - 1, playerX] == '#')
                {
                    Console.WriteLine("이동할수없습니다!");
                }
                
                else
                {
                    map[playerY - 1, playerX] = 'P';
                    map[playerY, playerX] = ' ';
                }
            }
            else if (Order == "D")
            {
                if (map[playerY + 1, playerX] == '#')
                {
                    Console.WriteLine("이동할수없습니다!");
                }
                
                else
                {
                    map[playerY + 1, playerX] = 'P';
                    map[playerY, playerX] = ' ';
                }
            }

        }

        static void GamePlay(char[,] map)
        {
            while (true)
            {
                PrintMap(map);

                var PlayerPos = FindPlayer(map);
                var MonserPos = CountMonster(map);

                int playerX = PlayerPos.Item1;
                int playerY = PlayerPos.Item2;
                int monsterNumber = MonserPos;
                if (monsterNumber == 0)
                {
                    Console.WriteLine("The End");
                    break;
                }

                PlayerControl(map, playerX, playerY);
                Console.WriteLine(playerX);
                Console.WriteLine(playerY);
                Console.WriteLine();
                //몬스터가 없으면 false!

            }
        }

        //static bool TestDictionary(int count, string msg)
        //{
        //    Dictionary<string, string> dic = new Dictionary<string, string>();



        //    for (int i = 0; i < count; i++)
        //    {
        //        string a;
        //        string b;
        //        a = Console.ReadLine();
        //        b = Console.ReadLine();
        //        dic.Add(a, b);
        //    }




        //    foreach (string v in dic.Values)
        //    {
        //        Console.WriteLine(v);
        //    }

        //    if (dic.Count > 5)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }



        //###############
        //#P            #
        //#             #
        //#             #
        //#    #        #
        //#    #        #
        //#    #        #
        //#             #
        //# M#
        //###############
        //}





    }


    //public struct GameData
    //{
    //    //변하지않는것들.
    //    public string stageName;
    //    public int dungeonCount;


    //    public GameData(string name, int count)
    //    {
    //        stageName = name;
    //        dungeonCount = count;


    //    }
    //}

    //public class DungeonGame1
    //{
    //    //int cols;
    //    //int rows;
    //    //char[,] map;

    //    //매판 문위치랑 플레이어위치이슈
    //    //List<GameData> stages = new List<GameData>();
    //    //GameData data = new GameData();
    //    public void RandomCreateMap()
    //    {
    //        Random random = new Random();

    //        int randomCreateCol = random.Next(5, 10);
    //        int randomCreateRow = random.Next(5, 10);
    //    }

    //    public void PlayGame()
    //    {
    //        List<char[,]> list = new List<char[,]>();

    //        //세로 가로 몬스터수 장애물수
    //        char[,] stage1Map = CreateMap(7, 9, 1, 3);
    //        char[,] stage2Map = CreateMap(15, 10, 3, 5);
    //        char[,] stage3Map = CreateMap(20, 15, 5, 8);
    //        char[,] stage4Map = CreateMap(30, 25, 10, 10);

    //        list.Add(stage1Map);
    //        list.Add(stage2Map);
    //        list.Add(stage3Map);
    //        list.Add(stage4Map);
    //        Console.WriteLine("Game Start");
    //        Console.WriteLine("Stage 1");

    //        for (int i = 0; i < list.Count; i++)
    //        {
    //            GameLOOP(list[i]);
    //            if (i != list.Count - 1)
    //            {
    //                Console.WriteLine("Next Stage");
    //                Console.WriteLine((i + 2) + "Stage");

    //            }
    //            else
    //            {
    //                Console.WriteLine("The End");
    //            }
    //        }
    //    }
    //    public int DetectDoor(char[,] map)
    //    {
    //        //문 개수
    //        int DoorNember = 0;

    //        int row = map.GetLength(0);
    //        int col = map.GetLength(1);

    //        for (int r = 0; r < row; r++)
    //        {
    //            for (int c = 0; c < col; c++)
    //            {
    //                if (map[r, c] == 'D')
    //                {
    //                    DoorNember += 1;
    //                }
    //            }
    //        }
    //        return (DoorNember);
    //    }


    //    public char[,] CreateMap(int col, int row, int mon, int obj)
    //    {

    //        char[,] map = new char[col, row];
    //        //맵생성
    //        for (int r = 0; r < col; r++)
    //        {
    //            for (int c = 0; c < row; c++)
    //            {
    //                if (c == 0 || c == row - 1 || r == 0 || r == col - 1)
    //                {
    //                    map[r, c] = '#';
    //                }

    //                else
    //                    map[r, c] = ' ';
    //            }

    //        }

    //        //DataTime dateTime = new DataTime();

    //        Random random = new Random();
    //        int randomRowPlayer;
    //        int randomColPlayer;
    //        int randomDoorRow;
    //        int randomDoorCol;
    //        //문이랑 플레이어 다른위치로!!!!!!!!! 문이랑 플레이어가 같을때 뜸
    //        do
    //        {
    //            randomColPlayer = random.Next(1, col - 1);
    //            randomRowPlayer = random.Next(1, row - 1);
    //            randomDoorCol = random.Next(1, col - 1);
    //            randomDoorRow = random.Next(1, row - 1);
    //        }
    //        while (randomRowPlayer == randomDoorRow && randomColPlayer == randomDoorCol);

    //        //장애물 랜덤 생성
    //        for (int i = 0; i < obj; i++)
    //        {
    //            int randomColO = random.Next(1, col - 1);
    //            int randomRowO = random.Next(1, row - 1);
    //            map[randomColO, randomRowO] = '#';
    //        }
    //        //몬스터 랜덤 생성
    //        for (int i = 0; i < mon; i++)
    //        {
    //            int randomColM = random.Next(1, col - 1);
    //            int randomRowM = random.Next(1, row - 1);
    //            map[randomColM, randomRowM] = 'M';
    //        }
    //        //플레이어, 문 랜덤 생성
    //        map[randomDoorCol, randomDoorRow] = 'D';
    //        Console.WriteLine($"D{randomDoorCol} {randomDoorRow}");
    //        map[randomColPlayer, randomRowPlayer] = 'P';
    //        Console.WriteLine($"P{randomColPlayer} {randomRowPlayer}");

    //        return map;
    //    }

    //    public void PrintMap(char[,] map)
    //    {
    //        //맵 프린트
    //        int row = map.GetLength(0);
    //        int col = map.GetLength(1);

    //        for (int r = 0; r < row; r++)
    //        {
    //            for (int c = 0; c < col; c++)
    //            {
    //                Console.Write(map[r, c]);
    //            }
    //            Console.WriteLine();
    //        }

    //    }

    //    public (int, int) FindPlayer(char[,] map)
    //    {
    //        //플레이어 좌표 찾기, 갱신
    //        int playerX = 0;
    //        int playerY = 0;
    //        int row = map.GetLength(0);
    //        int col = map.GetLength(1);

    //        for (int r = 0; r < row; r++)
    //        {
    //            for (int c = 0; c < col; c++)
    //            {
    //                if (map[r, c] == 'P')
    //                {
    //                    playerX = c;
    //                    playerY = r;
    //                }

    //            }

    //        }

    //        return (playerX, playerY);

    //    }

    //    public int CountMonster(char[,] map)
    //    {
    //        //몬스터 개수 찾기
    //        int MonsterNumber = 0;

    //        int row = map.GetLength(0);
    //        int col = map.GetLength(1);

    //        for (int r = 0; r < row; r++)
    //        {
    //            for (int c = 0; c < col; c++)
    //            {
    //                if (map[r, c] == 'M')
    //                {
    //                    MonsterNumber += 1;

    //                }
    //            }

    //        }

    //        return (MonsterNumber);

    //    }

    //    private void PlayerControl(char[,] map, int playerX, int playerY)
    //    {

    //        Console.WriteLine("방향을 입력하세요. Right : R, Left : L, Up: U, Down : D , Esc : 종료");
    //        string Order = Console.ReadLine();

    //        //특정 키 이외의 입력일때
    //        if (Order != "R" && Order != "L" && Order != "U" && Order != "D")
    //        {
    //            Console.WriteLine("잘못된입력입니다!");
    //        }
    //        //Right입력일때
    //        else if (Order == "R")
    //        {
    //            if (map[playerY, playerX + 1] == '#')
    //            {
    //                Console.WriteLine("이동할수없습니다!");
    //            }

    //            else
    //            {
    //                map[playerY, playerX + 1] = 'P';
    //                map[playerY, playerX] = ' ';
    //            }
    //        }
    //        //Left입력일때
    //        else if (Order == "L")
    //        {
    //            if (map[playerY, playerX - 1] == '#')
    //            {
    //                Console.WriteLine("이동할수없습니다!");
    //            }

    //            else
    //            {
    //                map[playerY, playerX - 1] = 'P';
    //                map[playerY, playerX] = ' ';
    //            }
    //        }
    //        //Up입력일때
    //        else if (Order == "U")
    //        {
    //            if (map[playerY - 1, playerX] == '#')
    //            {
    //                Console.WriteLine("이동할수없습니다!");
    //            }

    //            else
    //            {
    //                map[playerY - 1, playerX] = 'P';
    //                map[playerY, playerX] = ' ';
    //            }
    //            //Down입력일때
    //        }
    //        else if (Order == "D")
    //        {
    //            if (map[playerY + 1, playerX] == '#')
    //            {
    //                Console.WriteLine("이동할수없습니다!");
    //            }

    //            else
    //            {
    //                map[playerY + 1, playerX] = 'P';
    //                map[playerY, playerX] = ' ';
    //            }
    //        }

    //    }

    //    public void GameLOOP(char[,] map)
    //    {
    //        //게임
    //        while (true)
    //        {
    //            PrintMap(map);

    //            var PlayerPos = FindPlayer(map);
    //            var MonserNum = CountMonster(map);

    //            int playerX = PlayerPos.Item1;
    //            int playerY = PlayerPos.Item2;
    //            int monsterNumber = MonserNum;
    //            if (DetectDoor(map) == 0)
    //            {
    //                break;
    //            }

    //            PlayerControl(map, playerX, playerY);
    //            Console.WriteLine(playerX);
    //            Console.WriteLine(playerY);
    //            Console.WriteLine();


    //        }
    //    }


    //}


}
