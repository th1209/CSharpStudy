using System;
namespace CSharpStudy
{
    /// <summary>
    /// アクセサに関するサンプルクラス。
    /// </summary>
    public class AccessorsSample
    {
        public void BasicAccessors()
        {
            Person person = new Person();
            person.Name = "Jhon";
            person.Age = 10;
            Console.WriteLine("Name : " + person.Name);
            Console.WriteLine("Age : " + person.Age.ToString());
            Console.WriteLine("Id : " + person.Id.ToString());
        }
    }

    public class Person
    {
        // アクセサは、以下のように記載する。
        protected string name;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // C#3.0以降では、以下のような書き方も可能(自動プロパティと呼ぶ)。
        public uint Age { get; set; }

        // C#6.0以降では、getのみのアクセサを定義可能。
        public uint Id { get; }

        public Person() : this("", 0) { }

        public Person(string name, uint age)
        {
            // クラス内部でも、アクセサ経由でプロパティを触ると良い。
            this.Name = name;
            this.Age = age;

            // getのみのアクセサは、コンストラクタのみで初期化可能。
            Random r = new Random(1000);
            this.Id = (uint)r.Next(100000);
        }
    }


}
