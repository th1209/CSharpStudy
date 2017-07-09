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
* C#では、staticクラスなるクラスを定義可能。
  * 以下のような制約があり、またテストも難しくなると思うので、当面は使わなくても良いだろう。
  * staticクラスの制約。
    * staticなクラスメンバしか保持することが出来ない。
    * 継承することができない。
* 静的メソッドはオーバーロードできるけれども、オーバーライドはできない。
* 静的プロパティは、初回アクセス時に初期化される。以下のMSのドキュメントの通り、staticコンストラクタで初期化するか、getアクセサで初期化すればいいだろう。
  * [静的クラスと静的クラス メンバー (C# プログラミング ガイド)](https://msdn.microsoft.com/ja-jp/library/79b3xss3.aspx#静的メンバー)
* 静的プロパティの継承時の振る舞いが、公式ドキュメントに書いておらずよく分からない...。C#の設計思想上、staticに対する継承は非推奨だろうから、まともな実行結果にはならないだろうが...。

#### 継承について
* C#では、多重継承できない。
* 派生クラスで基底クラスの引数付きコンストラクタを呼び出す場合、 `ClassName : base(args) {...}` のようにする。
* 派生クラスで基底クラスのメソッドをオーバーライドしようとすると、コンパイラで警告が出る。オーバーライドしようとする時は、以下のように `new` を付け、オーバーライドであることを明示すること
  * `public new void methodName {...}`
  * `new` キーワードと同様のことが `override` キーワードでもできるかも。あとで調べてみて。

#### 多態性について
* 静的な型と動的な型
  * 静的な型 : 宣言時の型のこと。 `typeof(ClassName)` で取得できる。
  * 動的な型 : 変数の実際の型。 `valName.GetType()` で取得できる。
* アップキャストとダウンキャスト
  * アップキャスト : 派生クラス -> 基底クラス
  * ダウンキャスト : 基底
* キャストに関する構文
  * `変数名 is 型名` : キャスト可能ならtrueを返す。
  * `変換先の変数 = 変換元の変数 as 型名` : キャストできるならキャスト後の変数を返し、キャストできないならnullを返す。
* 静的な型とvirtual
  * C#の場合、静的な型に応じたメソッドがコールされる。
  * つまり、派生クラスで普通にメソッドを定義すると、基底クラスのメソッドが呼ばれてしまう!
  * これでは多態性が働かないので、多態性を見越して使われるメソッドは、基底・派生の両方に `virtual` を付けてメソッドを定義するのが普通。
