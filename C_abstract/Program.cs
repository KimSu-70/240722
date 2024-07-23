namespace C_abstract
{
    internal class Program
    {
        //사이퍼즈
        public abstract class Voice
        {
            public abstract void voice();
        }
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
        public class A : Character
        {
            public A()
            {
                Name = "에이";
                attack = 15;
                HP = 120;
                defense = 10;
            }
            public override void skill()
            {
                Console.WriteLine("힐을 사용하였습니다.");
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
                Console.WriteLine("도발을 사용하였습니다.");
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
                Console.WriteLine("난무를 사용하였습니다");
            }
        }
        public class Aa : Voice
        {
            public override void voice()
            {
                Console.WriteLine("가는 목소리");
            }
        }
        public class Bb : Voice
        {
            public override void voice()
            {
                Console.WriteLine("무거운 목소리");
            }
        }
        public class Cc : Voice
        {
            public override void voice()
            {
                Console.WriteLine("귀여운 목소리");
            }
        }
        static void Main(string[] args)
        {
            A player = new A();
            Aa Player1 = new Aa();
            player.skill();
            Player1.voice();
            B player2 = new B();
            Bb player3 = new Bb();
            player2.skill();
            player3.voice();
            C player4 = new C();
            Cc player5 = new Cc();
            player4.skill();
            player5.voice();
        }
    }
}