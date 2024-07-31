using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Problem
{
    public class JosephusPermutation
    {
        public static List<int> LhType(int N, int K)
        {
            Queue<int> queue = new Queue<int>();
            List<int> list = new List<int>();

            for (int i = 1; i <= N; i++)
            {
                queue.Enqueue(i);
            }
            
            while (queue.Count > 0)
            {
                for (int i = 0; i < K - 1; i++)
                {
                    int kh = queue.Dequeue();
                    queue.Enqueue(kh);
                }
                
                list.Add(queue.Dequeue());
            }
            return list;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("총 인원을 입력해주세요. :");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("제거할 순서를 정해주세요 :");
            int K = int.Parse(Console.ReadLine());

            List<int> NK = LhType(N,K);
            
            Console.Write($"입력받은 값 ({N}, {K}) 요세푸스 순열: < ");
            bool first = true;
            foreach (int number in NK)
            {
                if (!first)
                {
                    Console.Write(", ");
                }
                Console.Write(number);
                first = false;
            }
            Console.WriteLine(" >");
        }
    }
}
