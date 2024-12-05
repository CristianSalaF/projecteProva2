using System;

namespace projetcteProva2
{
    public class Exercici2a
    {
        const string TextFound = "S'ha trobat a la posicio {0}";
        public static void Main(string[] args)
        {
            int[] nums = { 10, 4, 6, 4, 8, -13, 2, 3 };
            
            for (int i = 0; i < nums.Length; i++)
            {
                PrintResult(nums, i);
            }
        }

        private static void PrintResult(int[] nums, int i)
        {
            Console.WriteLine(TextFound, Prova.SearchClass.BinarySearch(nums, 0, nums.Length - 1, nums[i]));
        }
    }
}