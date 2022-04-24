using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureProblem.Arrays_Part2
{
    class RotateImage : ISolvable
    {
        public void Solve()
        {
            int[][] nums = CreateMatrix();


            RotateMatrixOptmizeApproach(nums);
            PrintMatrix(nums);
            Console.WriteLine("Brute Force");
            nums = CreateMatrix();
            RotateBruteForce(nums);
            PrintMatrix(nums);
        }

        private void PrintMatrix(int[][] nums) {
            for (int i = 0; i < nums.Length; i++) {
                Console.WriteLine();
                for (int j = 0; j < nums[i].Length; j++) {
                    Console.Write(nums[i][j]+" ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("---END---");
        }
        public int[][] CreateMatrix() {
            int[][] nums=new int[4][];
            nums[0] = new int[4] { 5, 1, 9, 11 };
            nums[1] = new int[4] { 2, 4, 8, 10 };
            nums[2] = new int[4] { 13, 3, 6, 7 };
            nums[3] = new int[4] { 15, 14, 12, 16 };
            return nums;
        }
        public void RotateBruteForce(int[][] matrix)
        {
            int n = matrix.Length;
            int[][] dummy = new int[n][];
            for (int i = 0; i < n; i++)
            {
                dummy[i] = new int[n];
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dummy[j][n - i - 1] = matrix[i][j];
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i][j] = dummy[i][j];
                }
            }
        }
        public void RotateMatrixOptmizeApproach(int[][] matrix)
        {
            //Transpose logic
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = i; j < matrix[0].Length; j++)
                {
                    int temp = 0;
                    temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }
            //swap logic
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix.Length / 2; j++)
                {
                    int temp = 0;
                    temp = matrix[i][j];
                    matrix[i][j] = matrix[i][matrix.Length - 1 - j];
                    matrix[i][matrix.Length - 1 - j] = temp;
                }
            }
        }
    }
}
