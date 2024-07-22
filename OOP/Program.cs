namespace OOP
{
    internal class Program
    {
        class Chracter
        {
            public int lenel;
            public int hp;
            public int moveSpeed;
            public int ATK;
            public int attackHit;
        }
        public void MoveForward()
        {
            Console.WriteLine("전진 합니다");
        }
        public void MoveBackward()
        {
            Console.WriteLine("후진 합니다");
        }
        public void MoveLeft()
        {
            Console.WriteLine("좌회전 합니다");
        }
        public void MoveRight()
        {
            Console.WriteLine("우회전 합니다");
        }
        public void Attack()
        {
            Chracter chracter = new Chracter();
            chracter.ATK = 20;
            Console.WriteLine($"{chracter.ATK}의 피해를 주었습니다.");
        }
        public void AttackHit()
        {
            Chracter chracter = new Chracter();
            Console.WriteLine($"{chracter.attackHit}의 피해를 받았습니다");
            chracter.hp -= chracter.attackHit;
            if ( chracter.hp <= 0 )
            {
                Console.WriteLine("플레이어가 사망하였습니다");
            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}
