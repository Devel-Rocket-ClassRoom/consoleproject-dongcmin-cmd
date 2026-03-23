using System;
using System.Collections.Generic;

namespace WeekTask0313
{
    
    
    //몬스터 체력0이하이면 제거-- 각 m hp 체크
    //플레이어 먹히면 게임오버-- 아에 게임 종료.---777


    //Q int return하는거 불필요한거?
    //Q 몬스터 여러마리, 함수합치기-findmonster/countmonster

    //



    //플레이어직업
    //몬스터 종류
    //M, P 를 다른 문자열(다른 모든 함수)로 바꾸는방법

    //몬스터 여러마리일때 움직임
    //-몬스터 관리 directory

    //1. 몬스터 여러마리--
    //2. 몬스터의 공격 조건
    //3. 



    internal class Program
    {
        static void Main(string[] args)
        {

            //DungeonOperater play = new DungeonOperater();
            //play.PlayGame();


            //Monster monster = new Monster();
            //if (monster.monType == Monster.MonsterType.Slime)
            //{

            //}

            DungeonGame game = new DungeonGame();
            Map map1 = new Map(10, 8, 2, 5);
            game.Play(map1);

            Map map2 = new Map(15, 12, 3, 7);
            game.Play(map2);

            Map map3 = new Map(20, 15, 4, 9);
            game.Play(map3);

            Map map4 = new Map(20, 25, 5, 0);
            game.Play(map4);
            //합치는 함수 만들기---777
        }
    }


    //부모 클래스 펠레이어 몬스터 공통- 던전
    //  -공통 데이터 메소드 선언
    // player monster class 정의
    //플레이어 전용 메소드
    // 예) 이동시 함수 사용
    //몬스터 전용 메소드
    //메인클래스에 플레이 함수 하나만
    //맵 클래스 만들고 코드 정리
    //몬스터 이동> 랜덤->좌표 수정

    //플레이어 몬스터 공격??
    //플레이어- 공격 키 따로만들고, 직업마다 범위, 공격력, 체력 다름
    //몬스터-일정범위 안에 있으면 플레이어 데미지 받음
    //몬스터 처리 시 아이템 드롭
    //아이템 획득 시 스텟 증가- 랜덤 or 몬스터 종류에 따라
    //플레이어 몬스터 체력,데미지 
    public class Opening
    {

    }
    public class Ending
    {

    }
    public abstract class character
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        abstract protected void MakeSound();
        //abstract protected 000   >> override protected void 000
    }
    public class Dungeon
    {
        //스테이지1 슬라임
        //스테이지2 고블린
        //스테이지3 오크
        //스테이지4 드래곤
        public static int playerHp = 100;
        public static int playerDamage = 20;
        public static int monsterHp = 100;
        public static int monsterDamage = 20;
        public static int monsterHp1 = 100;
        public static int monsterDamage1 = 20;
        public static int monsterHp2 = 100;
        public static int monsterDamage2 = 20;
        public static int monsterHp3 = 100;
        public static int monsterDamage3 = 20;

    }

    public interface IMonster
    {

    }

    public class MonsterManage
    {

    }

    public class DungeonOperater  
    {

        public void GameLoop(Map map)
        {
            //게임
            while (true)
            {
                Player player = new Player();

                map.PrintMap();

                //var PlayerPos = map.FindPlayer();
                var MonserNum = map.CountMonster();

                //int playerX = PlayerPos.Item1;
                //int playerY = PlayerPos.Item2;
                int monsterNumber = MonserNum;
                if (map.DetectDoor() == 0)
                {

                    break;
                }

                player.PlayerControl(map);
                //Console.WriteLine(playerX);
                //Console.WriteLine(playerY);
                //Console.WriteLine();


            }
        }
        public void SetStage()
        {
            List<Map> listMap = new List<Map>();
            Map map1 = new Map(10, 8, 3, 5);
            Map map2 = new Map(15, 12, 5, 7);
            Map map3 = new Map(20, 15, 7, 9);
            Map map4 = new Map(30, 20, 8, 11);
            listMap.Add(map1);
            listMap.Add(map2);
            listMap.Add(map3);
            listMap.Add(map4);


        }
        public void PlayGame()
        {



            //오프닝
            Map map1 = new Map(5, 5, 1, 2);




            GameLoop(map1);

            Map map2 = new Map(15, 12, 5, 7);
            Map map3 = new Map(20, 15, 7, 9);
            Map map4 = new Map(30, 20, 8, 11);
            GameLoop(map2);
            GameLoop(map3);
            GameLoop(map4);


            //엔딩
        }
    }
    public class DungeonGame
    {
        public DungeonGame()
        {

        }
        public void Play(Map map)
        {
            Monster monster = new Monster();
            

            ////플레이어 이름 설정
            //Console.WriteLine("플레이어의 이름을 적으세요");
            //string playerName = Console.ReadLine();

            ////플레이어 직업 선택


            ////랜덤 맵 생성 CreateMap
            //Map map1 = new Map(10, 10, 1, 3);
            //맵 출력 > PrintMap
            map.PrintMap();

            //상태창 출력-플레이어 몬스터 - Status.DefaultStatus
            Status status = new Status();
            status.DefaultStatus();

            while (true)
            {
                //플레이어 이동 > PlayerControl
                Player player = new Player();
                player.PlayerControl(map);
                //D에 들어가면 끝
                if (map.DetectDoor() == 0)
                {
                    break;
                }
                //맵> PrintMap
                Console.Clear();
                map.PrintMap();
                //플레이어의 공격 > PlayerAttack
                
                //결과창 > 상태창 출력-플레이어 몬스터 Status.NowPlayerStatus
                status.NowMonsterStatus();
                //몬스터 이동 > MonsterMovement
                monster.MonsterMove(map);
                //몬스터가 플레이어 먹으면 끝 p가 없으면 게임오버****
                if(map.PlayerDie() == true)
                {
                    Console.WriteLine("You Die.");
                    break;
                }
                //맵 > PrintMap
                Console.Clear();
                map.PrintMap();
                //(공격) > MonsterAttack
                monster.MonsterAttack();
                //결과창 NowMonsterStatus
                status.NowPlayerStatus();
                
            }



            //루프  ?? 여기서 반복문 해주면 될듯
        }

    }


}
