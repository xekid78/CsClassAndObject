# CsClassAndObject
クラスとオブジェクト（.NET Core）

## 処理
`Massage()`クラスの`HelloWorld()`メソッドを使う。

## コード
```
using System;

namespace Clsandobj
{
    class Message
    {
        public void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }
    }

    class Clsandobj
    {
        static void Main(string[] args)
        {
            Message msg = new Message();
            msg.HelloWorld();
        }
    }
}
```

## 出力結果  
```
Hello World
```
  
## 開発環境
| 開発ツール |  |
|:-|:-|
| OS | Windows10 |
| 統合開発環境(IDE) | Visual Studio Community 2017 |
| 開発言語 | Visual C# |
