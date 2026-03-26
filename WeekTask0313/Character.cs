using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekTask0313
{
    public abstract class Character
    {
        public string Name { get; protected set; }
        public int Hp { get; protected set; }
        public int Attack { get; protected set; }
        public int Row { get; protected set; }
        public int Col { get; protected set; }
        public bool IsAlive //hp가 0이하면 false
        {
            get { return Hp > 0; }
        }
        //public void OnDie()
        //{

        //}

        public Character(string name, int hp, int attack, int row, int col)
        {
            Name = name;
            Hp = hp;
            Attack = attack;
            Row = row;
            Col = col;
        }


        public void SetPosition(int row, int col)
        {
            Row = row;
            Col = col;
        }

        public void TakeDamage(int damage)
        {
            Hp -= damage;

            if (Hp < 0)
            {
                Hp = 0;
            }
        }   

        abstract protected void MakeSound();
        //abstract protected 000   >> override protected void 000
    }
}
