using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode05
{
    public class Player : Character
    {
        public string Name
        { get; private set; }
        public int Level
        { get; private set; }


        public Player(string name, float maxHP, float attackPoint, float defencePoint,
            CharacterJobs job)
            : base(maxHP, attackPoint, defencePoint, job)
        {
            this.Name = name;
            this.Level = 1;
        }

        public override void WriteProfile()
        {
            Console.WriteLine("味方です。名前は" + Name);
        }
    }
}

