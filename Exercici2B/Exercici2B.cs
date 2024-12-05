using System;

namespace ProjecteProva2
{
    public class Exercici2B
    {
        public static void Main(string[] args)
        {
            int[] nums = { 10, 4, 6, 4, 8, -13, 2, 3 }; //anava a cridar-ho per referència des del projecte "Exercici2A" però no m'ha deixat, TODO,  int[] GetNums()

            for (int i = 0; i < nums.Length; i++)
            {
                Prova.FirstSort.Order(nums, nums[i], nums.Length);

                Console.WriteLine(nums[i] + "" + nums[i]+1);
            }
        }
    }
}