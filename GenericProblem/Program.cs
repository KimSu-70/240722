namespace GenericProblem
{
    internal class Program
    {
        #region 1.제네릭 주석 달기 과제
        public abstract class Item        //추상 클래스로 Item 정의
        {
            public string Name { get; private set; }   // 아이템의 이름을 나타내기 위해 정의

            public Item(string name)  //이름값을 초기화
            {
                Name = name;
            }
        }

        public class Inventory<T> where T : Item  //where T : Item을 통해 T에는 'Item'을 상속 받은 클래스만 넣을 수 있게 정의
        {
            private T[] _list;  //T의 배열로 만들고 그 변수값을 지정
            private int _index; // 아이템 갯수

            public Inventory(int size) //T 배열의 크기 받고 초기화 하는 함수
            {
                _list = new T[size];    //size를 입력받은 만큼 배열 정의
            }

            public void Add(T item)  //아이템 추가 함수
            {
                if (_index < _list.Length)  //배열의 사이즈 보다 적을 시 동작하게 조건문 기입
                {
                    _list[_index] = item;   //조건을 만족할 시 아이템 추가
                    _index++;               //아이템 갯수 증가
                }
            }

            public void Remove()       //아이템 삭제 함수
            {
                if (_index > 0)   //아이템의 갯수가 0개 일때는 동작하면 안되니 0보다 많을때로 조건문 기입
                {
                    _index--;               //아이템 갯수 감소
                    _list[_index] = null;   //아이템 갯수가 감소함에 따라 그 숫자에 해당하던 배열에 값 초기화
                }
            }

            public void PrintItemNames()      //배열에 할당된 아이템 목록을 확인하기 위한 함수
            {
                Console.WriteLine("아이템 목록");

                foreach (T item in _list)       //foreah문으로 배열을 순회하며 is를 통해
                {                               //T item[0]이고 _list[0]일때 true로 판단하여 밑에 조건 문을 실행한다
                    if (item != null)                   //T item[0]에 아이템의 이름이 존재 할 경우 조건문을 실행한다
                        Console.WriteLine(item.Name);
                }
            }
        }

        public class Potion : Item              //Item을 상속받는 포션 클래스 함수
        {
            public Potion(string name) : base(name) { }     //포션의 이름을 받는 함수
        }
        #endregion
        static void Main(string[] args)
        {
            Inventory<Potion> potionInventory = new(10);  //포션의 배열값 지정

            potionInventory.Add(new Potion("체력 포션")); //Add 함수를 통해 포션 객체 추가
            potionInventory.Add(new Potion("마나 포션"));
            potionInventory.Add(new Potion("경험치 포션"));
            potionInventory.Add(new Potion("활력 포션"));

            potionInventory.Remove();                      //포션 배열에 아이템 삭제
            potionInventory.Remove();

            potionInventory.PrintItemNames();               // 포션 목록 출력
        }
    }
}
