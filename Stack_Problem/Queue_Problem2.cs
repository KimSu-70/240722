namespace Stack_Problem
{
    public class Queue_Problem2
    {
        static int[] Test (int[] input)
        {
            const int workDay = 8;  
            
            int Day = 1;  
            int work = workDay;  
            
            Queue<int> test = new Queue<int>(input);  
            List<int> endTest = new List<int>();  

            while (test.Count > 0)
            {
                int Hours = test.Dequeue();  

                while (Hours > 0)
                {
                    if (Hours <= work)
                    {
                        
                        work -= Hours;
                        Hours = 0;
                    }
                    else
                    {
                        
                        Hours -= work;
                        Day++;  
                        work = workDay;  
                    }
                }

                
                endTest.Add(Day);
            }

            return endTest.ToArray();
        }


        static void Main(string[] args)
        {
            int[] work = { 7, 2, 12, 10, 8, 6 };
            int[] result = Test(work);


        for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i]);
                if (i < result.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }
}
