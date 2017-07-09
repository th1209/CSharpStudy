using System;
using System.Collections.Generic;
namespace CSharpStudy
{
    /// <summary>
    /// 辞書に関するサンプル処理をまとめたクラス。
    /// </summary>
    public class DictionarySample
    {
        public void BasicDictionary()
        {
            // 初期化。
            Dictionary<string, string> gameConfig = new Dictionary<string, string>() {
                {"gameTitle", "FinalFantasy"},
                {"genre", "Rpg"},
            };

            // 要素の追加。
            gameConfig.Add("maker", "SquareEnix");
            gameConfig["numbering"] = "15";

            // 要素の書き換え。
            gameConfig["genre"] = "Rpg";

            // 要素のカウント。
            Console.WriteLine(gameConfig.Count);

            // KeyやValueの存在チェック。
            Console.WriteLine(gameConfig.ContainsKey("invaldKey"));
            Console.WriteLine(gameConfig.ContainsValue("15"));

            // foreachで列挙する際は、個々の要素の型はKeyValuePairで返る。
            // (本格的なコードでは、型はvarにすると良いだろう。)
            foreach (KeyValuePair<string, string> pair in gameConfig) {
                Console.WriteLine("key :" + pair.Key + " value : " + pair.Value + " ");
            }
            Console.WriteLine("");

            // Keyだけ列挙する。
            foreach (string key in gameConfig.Keys) { 
                Console.Write(key + " ");
            }
            Console.WriteLine("");

            // Valueだけ列挙する。
            foreach (string value in gameConfig.Values) { 
                Console.Write(value + " ");
            }
            Console.WriteLine("");
        }
    }
}
