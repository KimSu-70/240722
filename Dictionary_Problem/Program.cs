namespace Dictionary_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MonsterData monsterData = new MonsterData();
            Monster monster = monsterData.monsterType["피카츄"];
            Monster monster1 = monsterData.monsterType["파이리"];
            Monster monster2 = monsterData.monsterType["꼬부기"];
            Monster monster3 = monsterData.monsterType["이상해씨"];
            Monster monster4 = monsterData.monsterType["리자몽"];
            Console.WriteLine($"몬스터 이름: {monster.name}, 체력: {monster.hp}");
            Console.WriteLine($"몬스터 이름: {monster1.name}, 체력: {monster1.hp}");
            Console.WriteLine($"몬스터 이름: {monster2.name}, 체력: {monster2.hp}");
            Console.WriteLine($"몬스터 이름: {monster3.name}, 체력: {monster3.hp}");
            Console.WriteLine($"몬스터 이름: {monster4.name}, 체력: {monster4.hp}");
        }
    }
    public class MonsterData
    {
        public Dictionary<string, Monster> monsterType = new Dictionary<string, Monster>();

        public MonsterData()
        {
            monsterType.Add("피카츄", new Monster("피카츄", 80));
            monsterType.Add("파이리", new Monster("파이리", 90));
            monsterType.Add("꼬부기", new Monster("꼬부기", 70));
            monsterType.Add("이상해씨", new Monster("이상해씨", 100));
            monsterType.Add("리자몽", new Monster("리자몽", 200));
        }
    }
    public class Monster
    {
        public string name;
        public int hp;

        public Monster(string _name, int _hp)
        {
            name = _name;
            hp = _hp;
        }
    }
}
