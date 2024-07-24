namespace Generic_
{
    internal class Program
    {
        /***************************************************************************
         * 인터페이스 (Interface)
         * 
         * 인터페이스는 맴버를 가질 수 있지만 직접 구현하지 않음 단지 정의만을 가짐
         * 인터페이스를 가지는 클래스에서 반드시 인터페이스의 정의를 구현해야함
         * 이를 반대로 표현하자면 인터페이스를 포함하는 클래스는
         * 반드시 인터페이스의 구성 요소들을 구현했다는 것을 보장함
         * Can-a 관계 : 클래스가 해당 행동을 할 수 있는 경우 적합함
         ***************************************************************************/

        // <인터페이스 정의>
        // 일반적으로 인터페이스의 이름은 I로 시작함
        // 인터페이스의 함수는 직접 구현하지 않고 정의만 진행
        public interface IEnterable
        {
            public void Enter();
        }

        public interface IOpenable
        {
            public void Open();
        }

        public interface IDamagable
        {
            public void TakeDamage(int damage);
        }


        // <인터페이스 포함>
        // 상속처럼 정의한 인터페이스를 클래스 : 뒤에 선언하여 사용
        // 인터페이스를 포함하는 경우 반드시 인터페이스에서 정의한 함수를 구현해야 함
        // 인터페이스는 여러개 포함 가능
        public class Duenson : IEnterable
        {
            public void Enter()
            {
                Console.WriteLine("던전에 입장합니다.");
            }
        }

        public class Chest : IOpenable, IDamagable
        {
            public void Open()
            {
                Console.WriteLine("상자를 엽니다.");
            }

            public void TakeDamage(int damage)
            {
                Console.WriteLine("상자가 부셔집니다.");
                Console.WriteLine("소량의 재료들을 떨어뜨립니다.");
            }
        }

        public class Door : IEnterable, IOpenable
        {
            private int hp = 10;

            public void Enter()
            {
                Console.WriteLine("문으로 들어갑니다.");
            }

            public void Open()
            {
                Console.WriteLine("문을 엽니다.");
            }
        }

        public class Car : IEnterable, IOpenable
        {
            private bool isOpened;

            public void Enter()
            {
                if (isOpened)
                {
                    Console.WriteLine("차에 탑승합니다.");
                }
                else
                {
                    Console.WriteLine("먼저 차를 열어주세요.");
                }
            }

            public void Open()
            {
                isOpened = true;
                Console.WriteLine("차의 잠금장치를 해제하고 엽니다.");
            }
        }

        public class Player
        {
            private int attackAmount = 5;

            public void Enter(IEnterable enterable)
            {
                enterable.Enter();
            }

            public void Open(IOpenable openable)
            {
                openable.Open();
            }

            public void Attack(IDamagable damagable)
            {
                damagable.TakeDamage(attackAmount);
            }
        }

        static void Main(string[] args)
        {
            float a = 10.1f;
            float b = 20.3f;

            Uitl.Swap(ref a, ref b);
            Console.WriteLine($"a={a},b={b}");  // a= 20.3 , b= 10.1

            Uitl1.SSS(ref a, ref b);
            Console.WriteLine($"a={a},b={b}"); // a= 20.3, b= 10.1

            Player player = new Player();

            Duenson duenson = new Duenson();
            Chest chest = new Chest();
            Door door = new Door();

            player.Attack(chest);

            player.Enter(duenson);
            player.Enter(door);

            player.Open(chest);
            player.Open(door);

            Car car = new Car();
            player.Enter(car);
            player.Open(car);
            player.Enter(car);
        }
    }
}

public static class Uitl
{
    public static void Swap(ref float left, ref float right)
    {
        float temp = left;
        left = right;
        right = temp;
    }
}
public static class Uitl1
{
    public static void SSS<T>(ref T a, ref T b)
    {
        T temp0 = a;
        a = b;
        a = temp0;
    }
}