using System.Text;   // 메서드 체이닝 코드
namespace Factory
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("안녕하세요")
                .AppendLine("반갑습니다")
                .AppendLine("어서오세요");

            OrcBuilder warriorOrcBuilder = new OrcBuilder();
            warriorOrcBuilder.SetName("오크 전사");
            warriorOrcBuilder.SetHP(300);

            OrcBuilder archorOrcBuilder = new OrcBuilder();
            archorOrcBuilder.SetName("오크 궁수");
            archorOrcBuilder.SetWeapon("나무 활");
            archorOrcBuilder.SetLevel(10);

            OrcBuilder shamanOrcBuilder = new OrcBuilder();
            shamanOrcBuilder
                .SetName("오크 주술사")
                .SetWeapon("저주받은 지팡이")
                .SetArmor("의식복")
                .SetHP(50);

            Orc[] orcs = new Orc[9];
            orcs[0] = warriorOrcBuilder.Build();
            orcs[1] = warriorOrcBuilder.Build();
            orcs[2] = warriorOrcBuilder.Build();

            orcs[3] = archorOrcBuilder.Build();
            orcs[4] = archorOrcBuilder.Build();
            orcs[5] = archorOrcBuilder.Build();

            orcs[6] = shamanOrcBuilder.Build();
            orcs[7] = shamanOrcBuilder.Build();
            orcs[7].armor = "반팔";
            orcs[8] = shamanOrcBuilder.Build();

            for (int i = 0; i < orcs.Length; i++)
            {
                Console.Write($"{i}번 오크 : ");
                Console.WriteLine($"{orcs[i].name} {orcs[i].weapon} {orcs[i].armor} {orcs[i].level} {orcs[i].hp}");
            }

            archorOrcBuilder.SetLevel(1);
            Orc newOrc = archorOrcBuilder.Build();
        }
    }

    public class OrcBuilder
    {
        public string name;
        public string weapon;
        public string armor;
        public int level;
        public int hp;

        public OrcBuilder()
        {
            name = "오크";
            weapon = "몽둥이";
            armor = "천옷";
            level = 1;
            hp = 100;
        }

        public Orc Build()
        {
            Orc orc = new Orc();

            orc.name = name;
            orc.weapon = weapon;
            orc.armor = armor;
            orc.level = level;
            orc.hp = hp;

            return orc;
        }

        public OrcBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }

        public OrcBuilder SetWeapon(string weapon)
        {
            this.weapon = weapon;
            return this;
        }

        public OrcBuilder SetArmor(string armor)
        {
            this.armor = armor;
            return this;
        }

        public OrcBuilder SetLevel(int level)
        {
            this.level = level;
            return this;
        }

        public OrcBuilder SetHP(int hp)
        {
            this.hp = hp;
            return this;
        }
    }

    public class Orc
    {
        public string name;
        public string weapon;
        public string armor;
        public int level;
        public int hp;
    }
}