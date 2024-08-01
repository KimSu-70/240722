namespace Dictionary_
{
    internal class Programm
    {
        // 다른 예시
        static void Main(string[] args)
        {
            // 해시테이블 기반의 Dictionary 자료구조
            Dictionary<string, Monster> monsterDic = new Dictionary<string, Monster>();

            // 삽입
            monsterDic.Add("피카츄", new Monster("피카츄", MonsterType.Electric, 80));
            monsterDic.Add("파이리", new Monster("파이리", MonsterType.Fire, 90));
            monsterDic.Add("꼬부기", new Monster("꼬부기", MonsterType.Water, 70));
            monsterDic.Add("이상해씨", new Monster("이상해씨", MonsterType.Grass, 100));

            // 삭제
            monsterDic.Remove("이상해씨");

            // 탐색
            if (monsterDic.ContainsKey("피카츄"))     // 포함 확인
            {
                Monster find = monsterDic["피카츄"];   // O(1)
                Console.WriteLine($"{find.name}, {find.type}, {find.hp}");
            }
        }
    }

    public enum MonsterType { Fire, Water, Grass, Electric, Wind }

    public class Monster
    {
        public string name;
        public MonsterType type;
        public int hp;

        public Monster(string name, MonsterType type, int hp)
        {
            this.name = name;
            this.type = type;
            this.hp = hp;
        }
    }
}