namespace Constructor
{
    internal class Program
    {
        public class Monster
        {
            public string Name;
            public int curHP;
            public int maxHP;

            public Monster(string _Name, int _maxHP)
            {
                Name = _Name;
                maxHP = _maxHP;
                curHP = _maxHP;
            }
        }
        public class Player
        {
            public string Name;
           
            public Monster[] monsterrr = new Monster[6];
            
            public int monsternumber = 0;
            public Player(string _name)
            {
                Name = _name;
            }
            public void Numbermonster(Monster monster)
            {
                if (monsternumber < 6)
                {
                    monsterrr[monsternumber] = monster;
                    
                    monsternumber++;
                }
                else
                {
                    Console.WriteLine("더 이상 몬스터를 소지할 수 없습니다.");
                }
            }
            public void MonsterNameNumber()
            {
                for (int i = 0; i < monsternumber; i++)
                {
                    Console.WriteLine($"몬스터 이름 : {monsterrr[i].Name}  체력 : {monsterrr[i].maxHP}");
                }
            }
        }
        static void Main(string[] args)
        {
            Player player = new Player("플레이어");
            Monster monster1 = new Monster("슬라임", 20);
            Monster monster2 = new Monster("고블린", 40);
            Monster monster3 = new Monster("골렘", 250);
            Monster monster4 = new Monster("오크", 70);
            Monster monster5 = new Monster("트롤", 150);
            Monster monster6 = new Monster("하피",80);
            Monster monster7 = new Monster("앤트맨", 65);

            player.Numbermonster(monster1);
            player.Numbermonster(monster2);
            player.Numbermonster(monster3);
            player.Numbermonster(monster4);
            player.Numbermonster(monster5);
            player.Numbermonster(monster6);
            player.Numbermonster(monster7);

            Console.WriteLine($"이름 : {player.Name}");
            player.MonsterNameNumber();
        }
    }
}
