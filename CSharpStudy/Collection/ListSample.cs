using System;
using System.Collections.Generic;
namespace CSharpStudy
{
    /// <summary>
    /// Listに関するサンプル処理をまとめたクラス。
    /// </summary>
    public class ListSample
    {
        /// <summary>
        /// Listに関する基本的な処理のサンプル。
        /// </summary>
        public void BasicList()
        {
            List<string> fruits = new List<string>() { "apple", "cherry" };

            // 長さの取得。
            Console.WriteLine(fruits.Count);
            // Capacityプロパティは、既に確保済みの領域(再取得しなくても良い)の長さを返す。
            Console.WriteLine(fruits.Capacity);

            // 要素の挿入。
            fruits.Add("dorian");
            fruits.Insert(1, "banana");

            // 特定の要素を含むかチェック。
            Console.WriteLine(fruits.Contains("banana"));

            // 要素の書き換え。
            Console.WriteLine(fruits[2] = "cranberry");

            // リストを逆順にソート。
            fruits.Reverse();

            // ここまでの状態を、一旦コンソールに表示してみる。
            foreach (var fruit in fruits) {
                Console.Write(fruit + " ");
            }
            Console.WriteLine("");

            // 指定の要素を削除。
            fruits.RemoveAt(2);
            fruits.Remove("dorian");

            // InsertやRemoveを使うと、要素番号は詰められる。
            Console.WriteLine(fruits[0]);
            Console.WriteLine(fruits[1]);

            // 全要素を消去。
            fruits.Clear();
            Console.WriteLine(fruits.Count);
        }
    }
}
