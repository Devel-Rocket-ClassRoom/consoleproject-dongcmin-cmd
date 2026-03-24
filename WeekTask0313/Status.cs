using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekTask0313
{
    public class Status
    {






        Player player = new Player();
        Monster monster = new Monster();
        public Status()
        {





        }
        public void DefaultStatus()
        {
            
            Console.WriteLine("플레이어");
            //Console.WriteLine("플레이어직업");
            Console.WriteLine("Hp : " + Dungeon.playerHp);//직업에따라 다름
            Console.WriteLine("Damage : " + Dungeon.playerDamage);
            Console.WriteLine("몬스터");
            //Console.WriteLine("몬스터직업");
            Console.WriteLine("Hp : " + Dungeon.monsterHp);//직업에따라 다름
            Console.WriteLine("Damage : " + Dungeon.monsterDamage);
        }
        public void NowPlayerStatus()
        {
            
            
            Console.WriteLine("플레이어");
            //Console.WriteLine("플레이어직업");
            Console.WriteLine("Hp : " + Dungeon.playerHp);//직업에따라 다름
            Console.WriteLine("Damage : " + Dungeon.playerDamage);

        }
        public void NowMonsterStatus()
        {
            
            
            Console.WriteLine("몬스터");
            //Console.WriteLine("몬스터직업");
            Console.WriteLine("Hp :" + monster.Hp);//직업에따라 다름
            Console.WriteLine("Damage : " + Dungeon.monsterDamage);

        }
    }
}
