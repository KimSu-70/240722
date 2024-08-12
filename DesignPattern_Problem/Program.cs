using Microsoft.VisualBasic.FileIO;

namespace DesignPattern_Problem
{
    // 과제 2. 빌더패턴 활용하기
    // 이번 강의에선 빌더패턴의 예시로, 게임에 필요한 오브젝트를 생성하는 코드를 다루었었습니다.
    // 해당 개념을 참고하여, 원하는 Builder클래스를 만들고, 빌더를 통해서 다양한 객체를 생성해보세요.
    //
    // 아래는 예시입니다. 예시를 참고하여 원하는 Builder를 만들어 보세요
    //
    // MonsterBuilder 클래스를 만들어 몬스터의 이름, 외형, 전리품, 경험치, 공격범위, 전투스타일 등을 조합하여
    // 여러 유형의 Monster들을 만들 수 있습니다.
    public class MonsterBuilder
    {
        public string name;
        public string image;
        public string booty;
        public int exp;
        public float attackRange;
        public string battleStyle;

        public MonsterBuilder()
        {
            this.name = "오크";
            this.image = "기본 이미지";
            this.booty = "몽둥이";
            this.exp = 15;
            this.attackRange = 1.5f;
            this.battleStyle = "저돌적인 스타일";
        }

        public MonsterBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }

        public MonsterBuilder SetImage(string imasge)
        {
            this.image = imasge;
            return this;
        }

        public MonsterBuilder SetBooty(string booty)
        {
            this.booty = booty;
            return this;
        }
        public MonsterBuilder SetExp(int exp)
        {
            this.exp = exp;
            return this;
        }
        public MonsterBuilder SetAttackRange(float attackRange)
        {
            this.attackRange = attackRange;
            return this;
        }
        public MonsterBuilder SetBattleStyle(string battleStyle)
        {
            this.battleStyle = battleStyle;
            return this;
        }
        public void screen()
        {
            Console.WriteLine($"몬스터 이름 : {name}");
            Console.WriteLine($"공격범위 : {attackRange}");
        }
    }
    // AnimalBuilder 클래스를 만들어 동물의 이름, 외형, 생산품, 울음소리, 사료종류, 등을 조합하여
    // 여러 유형의 Animal들을 만들 수 있습니다.
    public class AnimalBuilder
    {
        public string name;
        public string image;
        public string booty;
        public string whine;
        public string feedtype;

        public AnimalBuilder()
        {
            this.name = "똥개";
            this.image = "노란색강아지";
            this.booty = "똥";
            this.whine = "멍멍";
            this.feedtype = "싸구려 사료";
        }

        public AnimalBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }

        public AnimalBuilder SetImage(string imasge)
        {
            this.image = imasge;
            return this;
        }

        public AnimalBuilder SetBooty(string booty)
        {
            this.booty = booty;
            return this;
        }
        public AnimalBuilder SetWhine(string whine)
        {
            this.whine = whine;
            return this;
        }
        public AnimalBuilder SetFeedType(string feedtype)
        {
            this.feedtype = feedtype;
            return this;
        }

        public void screen()
        {
            Console.WriteLine($"동물(이름) : {name}");
            Console.WriteLine($"울음소리 : {whine}");
            Console.WriteLine($"필요사료 : {feedtype}");
        }
    }

    // UnitBuilder 클래스를 만들어 유닛의 이름, 이동방법, 공격타입, 방어타입, 생산가격 등을 조합하여
    // 여러 유형의 Unit들을 만들 수 있습니다.
    public enum AttackType { normal, fire, ice, electric }
    public enum DefenseType { normal, fire, ice, electric }
    public class UnitBuilder
    {
        public string name;
        public string move;
        AttackType attackType;
        DefenseType defenseType;
        public int gold;

        public UnitBuilder()
        {
            this.name = "마린";
            this.move = "땅으로만 이동가능";
            this.attackType = AttackType.normal;
            this.defenseType = DefenseType.normal;
        }

        public UnitBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }

        public UnitBuilder SetMove(string move)
        {
            this.move = move;
            return this;
        }

        public UnitBuilder SetAttackType(AttackType attackType)
        {
            this.attackType = attackType;
            return this;
        }
        public UnitBuilder SetDefenseType(DefenseType defenseType)
        {
            this.defenseType = defenseType;
            return this;
        }
        public UnitBuilder SetGold(int gold)
        {
            this.gold = gold;
            return this;
        }

        public void screen()
        {
            Console.WriteLine($"유닛 : {name}");
            Console.WriteLine($"이동범위 : {move}");
            Console.WriteLine($"공격타입 : {attackType}");
            Console.WriteLine($"방어타입 : {defenseType}");
            Console.WriteLine($"골드 : {gold}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MonsterBuilder warriorOrcBuilde = new MonsterBuilder();
            warriorOrcBuilde.SetName("오크 전사");
            warriorOrcBuilde.SetImage("오크 전사 이미지");
            warriorOrcBuilde.SetExp(30);

            AnimalBuilder dog = new AnimalBuilder();
            dog.SetName("누렁이");
            dog.SetFeedType("고급사료");

            UnitBuilder hellboy = new UnitBuilder();
            hellboy.SetName("헬보이");
            hellboy.SetMove("땅,하늘 둘다 이동 가능");
            hellboy.SetAttackType(AttackType.fire);
            hellboy.SetDefenseType(DefenseType.fire);
            hellboy.SetGold(500);

            warriorOrcBuilde.screen();
            Console.WriteLine();
            dog.screen();
            Console.WriteLine();
            hellboy.screen();

        }
    }
}
