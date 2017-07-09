using System;
namespace CSharpStudy
{
    /// <summary>
    /// 単純な配列に関するサンプル処理をまとめたクラス。
    /// </summary>
    public class ArraySample
    {
        /// <summary>
        /// 基本的な配列に関するサンプル。
        /// </summary>
        public void BasicArray()
        {
            // 配列型変数の宣言。
            int[] array;

            // 配列型変数は宣言しただけでは使えず、領域の確保が必要。
            array = new int[20];

            // 配列の長さは、lenghtで取れる(この場合は20)。
            Console.WriteLine(array.Length);


            // 初期化時に値を代入する場合は、以下のように{}を使う。
            // この場合、長さの宣言は必要なし。
            int[] array2 = new int[] { 1, 2, 3, 5, 7 };
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine(array2[i]);
            }

        }

        /// <summary>
        /// C#独自の多次元配列に関するサンプル。
        /// </summary>
        public void RectangularArray()
        {
            // 宣言と初期化。
            int[,] array2D = new int[,] {
                    {1, 2},
                    {2, 1},
                    {0, 1},
                };

            // GetLength(0)で行数、GetLength(1)で列数が取れる。
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    Console.Write(array2D[i, j].ToString() + " ");
                }
                Console.WriteLine("");
            }
        }

        /// <summary>
        /// 多次元配列に関するサンプル。
        /// </summary>
        /// <remarks>
        /// tips:
        ///   int[,]のような書き方をする多次元配列をRectangularArrayと呼び、
        ///   int[][] のような書き方をする多次元配列をJaggedArrayと呼ぶ。
        ///   int[,] のような書き方をする配列が、必ず長方形型の要素を持つことになるからだろう。
        /// </remarks>
        public void JaggedArray()
        {
            int[][] array2D = new int[][] {
                    new int[] {1, 2},
                    new int[] {2, 1},
                    new int[] {0, 1},
                };

            for (int i = 0; i < array2D.Length; i++)
            {
                for (int j = 0; j < array2D[i].Length; j++)
                {
                    Console.Write(array2D[i][j].ToString() + " ");
                }
                Console.WriteLine("");
            }
        }

        /// <summary>
        /// 他の言語でもよく見る多次元配列のサンプル。
        /// </summary>
        public void ForEach()
        {
            // １次元配列の場合。
            int[] array = new int[] { 1, 2, 3, 5, 7 };
            foreach (int value in array)
            {
                Console.Write(value.ToString() + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("");

            // 多次元配列の場合。
            int[][] array2D = new int[][] {
                new int[] {1, 2},
                new int[] {2, 1},
                new int[] {0, 1},
            };
            foreach (int[] tmpArray in array2D)
            {
                foreach (int value in tmpArray)
                {
                    Console.Write(value.ToString() + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}
