using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode05
{
    public class Enemy : Character
    {
        public int GainExp
        { get; private set; }


        public Enemy(float maxHP, float attackPoint, float defencePoint, int gainExp,
            CharacterJobs job)
            : base(maxHP, attackPoint, defencePoint, job)
        {
            this.GainExp = gainExp;
        }

        public override void WriteProfile()
        {
            Console.WriteLine("敵です");
        }
    }
}
