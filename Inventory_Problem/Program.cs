namespace Inventory_Problem
{
    public class Program
    {
        static void Main123(string[] args)
        {
            Inventory inventory = new Inventory();
            Console.WriteLine("0번은 랜덤아이템을 추가합니다 1~9번은 아이템 삭제를 합니다.");
            while (true)
            {
                string input = Console.ReadLine();


                if (input == "0")
                {
                    inventory.RandomType();
                }
                else
                {
                    int inout;
                    if (int.TryParse(input, out inout) && inout >= 1 && inout <= 9)
                    {
                        inventory.BItem(inout);
                    }
                    else
                    {
                        Console.WriteLine("0 또는 1~9 숫자를 입력 해주세요.");
                    }
                }
            }
        }
    }
    public class Item
    {
        public string name;
        public Item(string _name)
        {
            name = _name;
        }
        public string GetName()
        {
            return name;
        }
    }
    public class Potion : Item
    {
        public Potion() : base("힐포션") { }
    }
    public class Weapon : Item
    {
        public Weapon() : base("롱소드") { }
    }
    public class Armor : Item
    {
        public Armor() : base("판급갑옷") { }
    }
    public class Accessory : Item
    {
        public Accessory() : base("낡은반지") { }
    }
    public class Food : Item
    {
        public Food() : base("딱딱한 곡물빵") { }
    }
    public class Inventory
    {
        private List<Item> item11 = new List<Item>();
        private const int Max = 9;

        public void Screen()
        {
            Console.Clear();
            Console.Write("가방 내부 : ");
            for (int i = 0; i < Max; i++)
            {
                if (i < item11.Count)
                {
                    Console.WriteLine($"공간 {i + 1} : {item11[i].name}");
                }
            }
        }

        public void AItem(Item item)
        {
            if (item11.Count < Max)
            {
                item11.Add(item);
                Screen();
            }
            else
            {
                Console.WriteLine("가방에 더 이상 공간이 없습니다.");
            }
        }
        
        public void BItem(int Number)
        {
            if (Number < 1 || Number > item11.Count)
            {
                Console.WriteLine("가방에 존재하지 않습니다.");
                return;
            }

            item11.RemoveAt(Number - 1);
            Screen();
        }

        public void RandomType()
        {
            Random random = new Random();
            int itemType = random.Next(5);
            Item item;

            if (itemType == 0)
            {
                item = new Potion();
            }
            else if (itemType == 1)
            {
                item = new Weapon();
            }
            else if (itemType == 2)
            {
                item = new Armor();
            }
            else if (itemType == 3)
            {
                item = new Accessory();
            }
            else
            {
                item = new Food();
            }
            
            AItem(item);
        }
    }
}