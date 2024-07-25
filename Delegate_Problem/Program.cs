namespace Delegate_Problem
{
    public class Program
    {
        public class Player
        {
            private Armor curArmor;

            public void Equip(Armor armor)
            {
                Console.WriteLine($"플레이어가 {armor.name} 을/를 착용합니다.");
                curArmor = armor;
                curArmor.OnBreaked += UnEquip;
            }

            public void UnEquip()
            {
                Console.WriteLine($"플레이어가 {curArmor.name} 을/를 해제합니다.");
                curArmor.OnBreaked -= UnEquip;
                curArmor = null;
            }

            public void Hit()
            {
                if (curArmor != null)
                {
                    Console.WriteLine($"플레이어가 피해를 받아 {curArmor.name}의 내구도 1감소 하였습니다");
                    curArmor.DecreaseDurability();
                }
            }
        }

        public class Armor
        {
            public string name;
            private int durability;

            public event Action OnBreaked;

            public Armor(string name, int durability)
            {
                this.name = name;
                this.durability = durability;
            }

            public void DecreaseDurability()
            {
                durability--;
                if (durability <= 0)
                {
                    Break();
                }
            }

            private void Break()
            {
                Console.WriteLine("방어구가 소실되었습니다.");
                if(OnBreaked != null)
                {
                    OnBreaked();
                }
            }
        }

        static void Main(string[] args)
        {
            Player player = new Player();
            Armor ammor = new Armor("갑옷", 3);

            player.Equip(ammor);

            player.Hit();
            player.Hit();
            player.Hit();
        }
    }
}
