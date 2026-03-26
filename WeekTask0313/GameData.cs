using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WeekTask0313
{
    public class MapData
    {
        public MapData()
        {
            //map;
        }
        [JsonInclude]
        public List<List<char>> map
        {
            get;
            set;
        }
        
    }
    public class GameData
    {
        // Json에 포함
        [JsonInclude] private string stageName;
        [JsonInclude] private int dungeonCount;

        // 포함하지 않음
        [JsonIgnore] public int Count { get; set; }

        public GameData(string name, int dCount, int count)
        {
            stageName = name;
            dungeonCount = dCount;
            Count = count;
        }
    }
    public class SaveLoadJson
    {
        
        static public string[] ConvertMap3(char[,] map)
        {
            int rows = map.GetLength(0);
            int cols = map.GetLength(1);
            string[] mapLines = new string[rows];

            for (int i = 0; i < rows; i++)
            {
                char[] row = new char[cols];
                for (int j = 0; j < cols; j++)
                    row[j] = map[i, j];

                mapLines[i] = new string(row);
            }
            return mapLines;
        }
        private string GetFilePath(Map.MapType mapType)
        {
            string folderPath = "./Map";
            string filePath;

            switch (mapType)
            {
                case Map.MapType.startMap:
                    {
                        filePath = Path.Combine(folderPath, "startmap.json");
                        break;
                    }
                case Map.MapType.eventMap:
                    {
                        filePath = Path.Combine(folderPath, "eventmap.json");
                        break;
                    }
                case Map.MapType.bossMap:
                    {
                        filePath = Path.Combine(folderPath, "bossmap.json");
                        break;
                    }
                default:
                    {
                        filePath = Path.Combine(folderPath, "map.json");
                        break;
                    }
            }
            return filePath;
        }
        public void SaveMap(Map.MapType mapType)
        {

            //Map map = new Map(10, 8, 2, 5);
            //Map map = new Map(Map.MapType.bossMap);
            

            string folderPath = "./Map";
            string filePath = GetFilePath(mapType);
            
            Map map = new Map(mapType);

            //string filePath1 = Path.Combine(folderPath, "map.json");

            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            var map1 = SaveLoadJson.ConvertMap3(map.map);

            string result = JsonSerializer.Serialize(map1, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, result);

        }

        public char[,] LoadMap(Map.MapType mapType)
        {
            string filePath = GetFilePath(mapType);
            
            string s = File.ReadAllText(filePath);
            string[] mm = JsonSerializer.Deserialize<string[]>(s);

            if (mm != null)
            {
                int rows = mm.Length;
                int cols = mm[0].Length;
                char[,] map = new char[rows,cols];
                for(int r  = 0; r < rows; r++)
                {
                    for(int c = 0; c < cols; c++)
                    {
                        map[r, c] = mm[r][c];
                    }
                    
                }
                Console.WriteLine("읽기 성공!: " + mm);

                return map;

            }
            else
            {
                Console.WriteLine("정상적인 데이터가 아닙니다.");
                return null;
            }
        }
        // GameData를 Json으로 저장하는 테스트 함수
        public void SaveGameData()
        {
            GameData gdata = new GameData("Blue dragon", 5, 10);

            // 저장할 파일 경로
            string folderPath = "./GameData";
            string filePath = Path.Combine(folderPath, "data.json");  // 폴더와 파일 이름 합치기-- ??

            // 폴더가 존재하지 않을 경우 생성
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            // 직렬화
            string result = JsonSerializer.Serialize(gdata, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, result);

            // 테스트 출력
            Console.WriteLine(result);
        }

        // Json으로 저장된 GameData를 읽는 테스트 함수
        public void LoadGameData()
        {
            string folderPath = "./GameData";
            string filePath = Path.Combine(folderPath, "data.json");  // 폴더와 파일 이름 합치기

            // 역직렬화
            string s = File.ReadAllText(filePath);
            GameData mm = JsonSerializer.Deserialize<GameData>(s);

            if (mm != null)
            {
                Console.WriteLine("읽기 성공!: " + mm);
            }
            else
            {
                Console.WriteLine("정상적인 데이터가 아닙니다.");
            }
        }
        //internal class GameData
        //{
        //    [JsonInclude] private string stageName;
        //    [JsonInclude] private int dungeonCount;
        //    public int Count { get; set; }
        //}
    }
}

