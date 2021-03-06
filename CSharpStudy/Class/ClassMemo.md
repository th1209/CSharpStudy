﻿#### thisキーワードについて
* C#では、自身の参照を表すthisキーワードは省略可能。
* ただし、同一名称のローカル変数と区別したい場合は、明示的にthisキーワードを記載する必要がある。
    * 例えば、コンストラクタによるプロパティの初期化が該当する。

#### アクセシビリティ(可視性)について
* internalとは?
    * C#では、internalなるアクセシビリティがある。
    * これは、「同一アセンブリ(つまり、自身のプロジェクト内の他クラス)からはアクセスできるけど、他のアセンブリからはアクセスできない」と言った意味。
* クラスのアクセシビリティ
    * public, internalの2つ。
    * 省略した場合、アクセシビリティはinternalになる。
* クラスメンバのアクセシビリティ
    * public, protected internal, internal, protected, private
    * 省略した場合、アクセシビリティはprivateになる。

#### staticについて
* staticクラスについて
    * 以下のような制約がある。
        * staticなクラスメンバしか保持することが出来ない。
        * 継承することができない。
    * 上記の制約とテストが難しくなることを踏まえると、当面使わなくても良いだろう。
* staticメソッドについて
    * 静的メソッドはオーバーロードできるけれども、オーバーライドはできない。
    * 静的プロパティは、初回アクセス時に初期化される。以下のMSのドキュメントの通り、staticコンストラクタで初期化するか、getアクセサで初期化すればいいだろう。
        * [静的クラスと静的クラス メンバー (C# プログラミング ガイド)](https://msdn.microsoft.com/ja-jp/library/79b3xss3.aspx#静的メンバー)
* 静的プロパティの継承時の振る舞いが、公式ドキュメントに書いておらずよく分からない...。<br/>C#の設計思想上、staticに対する継承は非推奨だろうから、まともな実行結果にはならないだろうが...。

#### 継承について
* C#では、多重継承できない。
* 派生クラスで基底クラスの引数付きコンストラクタを呼び出す場合、 `ClassName : base(args) {...}` のようにする。

#### 多態性について
* 静的な型と動的な型
    * 静的な型 : 宣言時の型のこと。 `typeof(ClassName)` で取得できる。
    * 動的な型 : 変数の実際の型。 `valName.GetType()` で取得できる。
* アップキャストとダウンキャスト
    * アップキャスト : 派生クラス -> 基底クラス
    * ダウンキャスト : 基底クラス -> 派生クラス (普通はやらない)。
* キャストに関する構文
    * `変数名 is 型名` : キャスト可能ならtrueを返す。
    * `変換先の変数 = 変換元の変数 as 型名` : キャストできるならキャスト後の変数を返し、キャストできないならnullを返す。
* 静的な型とvirtual
    * C#の場合、静的な型に応じたメソッドがコールされる。
    * つまり、派生クラスで普通にメソッドを定義すると、基底クラスのメソッドが呼ばれてしまう!
    * これでは多態性が働かないので、多態性を見越して使われるメソッドは後述する `virtual & override` を付けてメソッドを定義するのが普通。
    * メソッドのオーバーライドは、`new`もしくは`virtual & override`キーワードで可能になる。違いを以下に示す。
        * `new`
            * こちらはポリモーフィックに呼ばれた場合、基底クラスのメソッドが呼ばれてしまう。
            * 基底クラス側に`virtual`キーワードは必要ない。
            * ex) `public new void methodName {...}`
        * `override`
            * こちらはポリモーフィックに呼ばれた場合でも、派生クラスのメソッドが呼ばれる。
            * 基底クラス側に`virtual`キーワードが必要。
            * ex) `public virtual  void methodName { //基底クラスの処理。 }`
            * ex) `public override void methodName { //派生クラスの処理。 }`
