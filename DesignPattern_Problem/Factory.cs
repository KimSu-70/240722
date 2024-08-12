using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Problem
{
    //미완성입니다.




    // 과제 1. 팩토리 메소드 패턴 활용하기
    // 이번 강의에선 팩토리 메소드 패턴의 예시로, 게임에 필요한 오브젝트를 생성하는 코드를 다루었었습니다.
    // 해당 개념을 참고하여, ItemFactory 클래스를 만들고, 팩토리 메소드를 통해서 다양한 Item을 생성해보세요.
    //
    // Item은 ItemFactory를 통해서 생성하도록 한다.
    //
    // ItemFactory는 Create(ItemType type) 함수를 가진다.
    //
    // ItemType은 열거형으로 Potion, Weapon, Armor, Food 항목을 가진다
    //
    // ItemFactory는 Create 함수에 매개변수로 받은 열거형의 유형을 기준으로
    // 각 항목에 맞는 아이템 인스턴스를 생성하여 준다.
    public enum ItemType{ Potion, Weapon, Armor, Food }
    public class ItemFactory
    {
        public static Item item(ItemType itemType)
        {
            if (itemType == ItemType.Potion)
            {
                Potion potion = new Potion();
                potion.name = "포션";
                potion.image = "유리병에 담긴 빨간액체";
                potion.gold = 50;
                return potion;
            }
            else if (itemType == ItemType.Weapon)
            {
                Weapon weapon = new Weapon();
                weapon.name = "롱소드";
                weapon.image = "무딘 롱소드";
                weapon.attack = 10;
                weapon.gold = 100;
                return weapon;
            }
            
            else if (itemType == ItemType.Armor)
            {
                Armor armor = new Armor();
                armor.name = "천갑옷";
                armor.image = "해진 천갑옷";
                armor.defense = 5;
                armor.gold = 70;
                return armor;
            }
            
            else if (itemType == ItemType.Food)
            {
                Food food = new Food();
                food.name = "샌드위치";
                food.image = "먹음직스러운 샌드위치";
                food.gold = 20;
                return food;
            }
        }
    }
    public class Item
    {
        public string name;
        public string image;
        public int gold;
        public ItemType itemType;
        public Item()
        {
            this.name = "아이템";
            this.image = "기본 이미지";
            this.gold = 0;
            this.itemType = ItemType.Potion;
        }
    }

    public class Potion : Item
    {
        public Potion()
        {
            this.itemType = ItemType.Potion;
        }
    }

    public class Weapon : Item
    {
        public int attack;

        public Weapon()
        {
            this.itemType = ItemType.Weapon;
        }
    }

    public class Armor : Item
    {
        public int defense;

        public Armor()
        {
            this.itemType = ItemType.Armor;
        }
    }

    public class Food : Item
    {
        public Food()
        {
            this.itemType = ItemType.Food;
        }
    }

    internal class Factory
    {
        static void Main(string[] args)
        {
            Item potion = ItemFactory.item(ItemType.Potion);
            Item weapon = ItemFactory.item(ItemType.Weapon);
            Item armor = ItemFactory.item(ItemType.Armor);
            Item Food = ItemFactory.item(ItemType.Food);
        }
    }
}
