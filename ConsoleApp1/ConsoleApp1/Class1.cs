using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Player
    {
        public float MaxHp;
        public float Hp;
        public float Atk;
        public float Df;
    

        public Player(float maxHp,float atk,float df)
        {
            this.MaxHp = maxHp;
            this.Hp = maxHp;
            this.Atk = atk;
            this.Df = df;
        }

        public void Attack(Player target)
        {
            float dameage = this.Atk - target.Df;
            if(dameage < 0) dameage = 0;

            target.Hp -= dameage;
        }


    }
}
