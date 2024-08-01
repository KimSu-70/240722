namespace Stack_Problem
{
    internal class Program
    {
        public static bool Test1(char input, char inout)
        {
            if (input == '(' && inout == ')')
                return true;
            if (input == '[' && inout == ']')
                return true;
            if (input == '{' && inout == '}')
                return true;
            return false;
        }
        
        
        public static bool Test2(string PV)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char a in PV)
            {
                if(a=='('||a=='['||a=='{')
                {
                    stack.Push(a);
                }
                else if (a==')'||a==']'|| a== '}')
                {
                    if (stack.Count ==0 || !Test1(stack.Peek(),a))
                    {
                        return false;
                    }
                    stack.Pop();
                }
            }
            return stack.Count ==0;
        }
        static void Main2121(string[] args)
        {
            Console.WriteLine("문자를 입력해주세요");
            string pv = Console.ReadLine();

            bool test = Test2(pv);

            if (test)
            {
                Console.WriteLine("올바르게 입력되었습니다.");
            }
            else
            {
                Console.WriteLine("잘못 입력하였습니다. 다시 입력해주세요");
            }
        }
    }
}
