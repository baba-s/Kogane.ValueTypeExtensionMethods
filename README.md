# Kogane Value Type Extension Methods

bool、byte、float、int、uint 型の拡張メソッド

## bool

```cs
using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void Awake()
    {
        bool b = false;

        // false なら 0、true なら 1 の byte 型に変換
        Debug.Log( b.ToByte() );
    }
}
```

## byte

```cs
using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void Awake()
    {
        byte b = 1;

        // 0 なら false、1 なら true の bool 型に変換
        Debug.Log( b.ToBool() );

        // 指定した桁数で 0 埋めした文字列を取得
        Debug.Log( b.ZeroFill( 3 ) ); // 001
    }
}
```

## float

```cs
using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void Awake()
    {
        float f = 1;

        // 0.00001 までの誤差を許容して比較
        Debug.Log( f.SafeEquals( 1.1f ) );

        // 0.001f までの誤差を許容して比較
        Debug.Log( f.SafeEquals( 1.1f, 0.001f ) );

        // infinity でも NaN でもなければ true
        Debug.Log( f.IsValidated() );

        // infinity もしくは NaN なら既定値を取得
        Debug.Log( f.GetOrDefault() );

        // infinity もしくは NaN なら引数に指定した値を取得
        Debug.Log( f.GetOrDefault( 25 ) );
    }
}
```

## int

```cs
using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void Awake()
    {
        int i = 1;

        // 数値の回数分指定したコールバックが呼び出される
        i.Times( () => { } );
        i.Times( index => { } );

        // 数値の回数分指定したコールバックが呼び出される（逆順）
        i.TimesReverse( () => { } );
        i.TimesReverse( index => { } );

        // 指定した桁数で 0 埋めした文字列を取得
        Debug.Log( i.ZeroFill( 3 ) ); // 001

        // 指定した桁数の固定小数点数を付加した文字列を取得
        Debug.Log( i.FixedPoint( 3 ) ); // 1.000

        // 数値を加算して最大値以上になった分は 0 からの値として処理した数値を取得
        Debug.Log( i.Repeat( 4, 2 ) ); // 1

        // 偶数の場合 true
        Debug.Log( i.IsEven() ); // False

        // 奇数の場合 true
        Debug.Log( i.IsOdd() ); // True

        // 3桁区切りの文字列を取得
        Debug.Log( 12345.FormatWithComma() ); // 12,345
        
        // Enumerable.Range を実行
        foreach ( var x in i.Range() )
        {
            Debug.Log( x );
        }
    }
}
```

## uint

```cs
using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void Awake()
    {
        uint i = 1;

        // 数値の回数分指定したコールバックが呼び出される
        i.Times( () => { } );
        i.Times( index => { } );

        // 指定した桁数で 0 埋めした文字列を取得
        Debug.Log( i.ZeroFill( 3 ) ); // 001

        // 指定した桁数の固定小数点数を付加した文字列を取得
        Debug.Log( i.FixedPoint( 3 ) ); // 1.000

        // 数値を加算して最大値以上になった分は 0 からの値として処理した数値を取得
        Debug.Log( i.Repeat( 4, 2 ) ); // 1

        // 偶数の場合 true
        Debug.Log( i.IsEven() ); // False

        // 奇数の場合 true
        Debug.Log( i.IsOdd() ); // True

        // 3桁区切りの文字列を取得
        Debug.Log( 12345.FormatWithComma() ); // 12,345
    }
}
```
