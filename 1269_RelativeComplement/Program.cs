using System;

namespace _1269_RelativeComplement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] str = Console.ReadLine().Split();
            Int32 an = Int32.Parse(str[0]);
            Int32 bn = Int32.Parse(str[1]);

            /*List<Int32> a = new List<Int32>();
            List<Int32> b = new List<Int32>();
            List<Int32> ab = new List<Int32>();

            String[] aStr = Console.ReadLine().Split();

            for (Int32 i = 0; i < aStr.Length; i++)
                a.Add(Int32.Parse(aStr[i]));

            String[] bStr = Console.ReadLine().Split();

            for (Int32 i = 0; i < bStr.Length; i++)
                b.Add(Int32.Parse(bStr[i]));

            Int32 count = 0;

            for(Int32 i = 0; i < a.Count; i++)
                if (!b.Contains(a[i]))
                    count++;

            for (Int32 i = 0; i < b.Count; i++)
                if (!a.Contains(b[i]))
                    count++;

            Console.WriteLine(count);*/ //List Contains 메서드가 너무 많이 사용되어 시간복잡도에 의해 시간초과

            HashSet<Int32> a = new HashSet<Int32>();
            HashSet<Int32> b = new HashSet<Int32>();

            String[] aStr = Console.ReadLine().Split();

            for(Int32 i = 0; i < aStr.Length; i++)
                a.Add(Int32.Parse(aStr[i]));

            String[] bStr = Console.ReadLine().Split();

            for (Int32 i = 0; i < bStr.Length; i++)
                b.Add(Int32.Parse(bStr[i]));

            Int32 count = 0;

            foreach (var item in a)
                if (!b.Contains(item))
                    count++;

            foreach (var item in b)
                if (!a.Contains(item))
                    count++;

            Console.WriteLine(count);
        }
    }
}
