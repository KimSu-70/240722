namespace inheritance
{
    public class Program
    {
        // 사이퍼즈 상속 관계 표현
        public class Character()
        {
            protected string Name;     //이름
            protected int attack;      //기본 피해량
            protected int defense;     //기본 방어력
            protected int HP;          //체력

            public void TakeDamage(int attack)
            {
                HP -= attack - defense;
                if (HP <= 0)
                {
                    Die();
                }
            }
            private void Die()
            {
                Console.WriteLine("캐릭터 사망");
            }
            public virtual void skill()
            {
                Console.WriteLine("스킬을 사용 할 수 없습니다");
            }
        }
        public class A:Character
        {
            public A()
            {
                Name= "에이";
                attack = 15;
                HP = 120;
                defense = 10;
            }
            public override void skill()
            {
                Console.WriteLine("회복");
            }
        }
        public class B : Character
        {
            public B()
            {
                Name = "비";
                attack = 5;
                HP = 150;
                defense = 30;
            }
            public override void skill()
            {
                Console.WriteLine("도발");
            }
        }
        public class C : Character
        {
            public C()
            {
                Name = "시";
                attack = 25;
                HP = 130;
                defense = 5;
            }
            public override void skill()
            {
                Console.WriteLine("난무");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
