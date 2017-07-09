using System;

namespace CSharpStudy
{
    /// <summary>
    /// このプロジェクトのエントリーポイント。
    /// </summary>"
    class EntryPoint
    {
        public static void Main(string[] args)
        {
            // 配列に関するサンプル。
            //var arraySample = new ArraySample();
            //arraySample.BasicArray();
            //arraySample.RectangularArray();
            //arraySample.JaggedArray();
            //arraySample.ForEach();

            // Listに関するサンプル。
            //var listSample = new ListSample();
            //listSample.BasicList();

            // Dictionaryに関するサンプル。
            //var dictionarySample = new DictionarySample();
            //dictionarySample.BasicDictionary();

            // アクセサに関するサンプル
            var accessorsSample = new AccessorsSample();
            accessorsSample.BasicAccessors();
        }
    }
}
