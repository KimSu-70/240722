namespace Delegate_
{
    using System;
    public class Callback
    {
        /*******************************************************************************
         * 콜백함수
         * 
         * 델리게이트를 이용하여 특정조건에서 반응하는 함수를 구현
         * 함수의 호출(Call)이 아닌 역으로 호출받을 때 반응을 참조하여 역호출(Callback)
         *******************************************************************************/

        //public static void Main()
        //{
        //    File file = new File();

        //    Button button = new Button();
        //    button.callback = file.Save;
        //    button.Click();

        //    button.callback = file.Load;
        //    button.Click();

        //    Player player = new Player();
        //    button.callback = player.Jump;
        //    button.Click();
        //}

        //public class Player
        //{
        //    public void Jump()
        //    {
        //        Console.WriteLine("플레이어가 점프합니다!");
        //    }
        //}

        //public class Button
        //{
        //    public Action callback;

        //    public void Click()
        //    {
        //        callback();
        //    }
        //}

        //public class File
        //{
        //    public void Save()
        //    {
        //        Console.WriteLine("저장 합니다.");
        //    }

        //    public void Load()
        //    {
        //        Console.WriteLine("불러오기 합니다.");
        //    }
        //}
        public static void Main()
        {
            Customer customer = new Customer();
            Restaurant restaurant = new Restaurant();

            customer.Reservation(restaurant);

            restaurant.Accept();
        }

        public class Customer
        {
            public void Reservation(Restaurant restaurant)
            {
                Console.WriteLine("레스토랑에 예약을 합니다.");
                restaurant.OnAcceptable = Enter;
            }

            public void Enter(Restaurant restaurant)
            {
                Console.WriteLine("레스토랑에 입장합니다.");
                restaurant.Enter();
            }
        }

        public class Restaurant
        {
            public Action<Restaurant> OnAcceptable;

            public void Accept()
            {
                Console.WriteLine("손님 받을 수 있습니다!");
                OnAcceptable(this);
            }

            public void Enter()
            {
                Console.WriteLine("손님을 받습니다.");
            }
        }
        //public static void Main()
        //{
        //    int[] array = { 3, -2, 1, -4, 9, -8, 7, -6, 5 };

        //    int index1 = CountIf(array, IsPositive);            // 배열 중 값이 양수인 데이터 갯수
        //    Console.WriteLine(index1);
        //    int index2 = CountIf(array, IsNagative);            // 배열 중 값이 음수인 데이터 갯수
        //    Console.WriteLine(index2);
        //    int index3 = CountIf(array, value => value > 5);    // 배열 중 값이 5보다 큰 데이터 갯수
        //    Console.WriteLine(index3);
        //}

        //public static int CountIf(int[] array, Predicate<int> predicate)
        //{
        //    int count = 0;

        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (predicate(array[i]))
        //        {
        //            return count++;
        //        }
        //    }

        //    return count;
        //}

        //public static bool IsPositive(int value)
        //{
        //    return value > 0;
        //}

        //public static bool IsNagative(int value)
        //{
        //    return value < 0;
        //}
    }
}