using System;
using System.Collections.Generic;
using System.Linq;

namespace Kogane
{
    /// <summary>
    /// int 型の拡張メソッドを管理するクラス
    /// </summary>
    public static class IntExtensionMethods
    {
        //================================================================================
        // 関数(static)
        //================================================================================
        /// <summary>
        /// 指定された回数分処理を繰り返します
        /// </summary>
        public static void Times( this int self, Action callback )
        {
            for ( var i = 0; i < self; i++ )
            {
                callback();
            }
        }

        /// <summary>
        /// 指定された回数分処理を繰り返します
        /// </summary>
        public static void Times( this int self, Action<int> callback )
        {
            for ( var i = 0; i < self; i++ )
            {
                callback( i );
            }
        }

        /// <summary>
        /// 指定された回数分処理を逆順に繰り返します
        /// </summary>
        public static void TimesReverse( this int self, Action callback )
        {
            for ( var i = self - 1; 0 <= i; i-- )
            {
                callback();
            }
        }

        /// <summary>
        /// 指定された回数分処理を逆順に繰り返します
        /// </summary>
        public static void TimesReverse( this int self, Action<int> callback )
        {
            for ( var i = self - 1; 0 <= i; i-- )
            {
                callback( i );
            }
        }

        /// <summary>
        /// 数値を指定された桁数で 0 埋めした文字列を返します
        /// </summary>
        /// <example>
        /// 123.ZeroFill( 4 ) → 01234
        /// 123.ZeroFill( 8 ) → 000001234
        /// </example>
        public static string ZeroFill( this int self, int numberOfDigits )
        {
            return self.ToString( "D" + numberOfDigits );
        }

        /// <summary>
        /// 数値に指定された桁数の固定小数点数を付加した文字列を返します
        /// </summary>
        /// <example>
        /// 123.FixedPoint( 2 ) → 123.00
        /// 123.FixedPoint( 4 ) → 123.0000
        /// </example>
        public static string FixedPoint( this int self, int numberOfDigits )
        {
            return self.ToString( "F" + numberOfDigits );
        }

        /// <summary>
        /// 数値を加算して範囲以上になった分は 0 からの値として処理して返します
        /// </summary>
        public static int Repeat
        (
            this int self,
            int      value,
            int      max
        )
        {
            return max == 0 ? self : ( self + value + max ) % max;
        }

        /// <summary>
        /// 偶数の場合 true を返します
        /// </summary>
        public static bool IsEven( this int self )
        {
            return self % 2 == 0;
        }

        /// <summary>
        /// 奇数の場合 true を返します
        /// </summary>
        public static bool IsOdd( this int self )
        {
            return self % 2 == 1;
        }

        /// <summary>
        /// 2 以上の場合 true を返します
        /// </summary>
        public static bool IsMultiple( this int self )
        {
            return 2 <= self;
        }

        /// <summary>
        /// 数値を 3 桁区切りの文字列に変換します
        /// </summary>
        public static string FormatWithComma( this int self )
        {
            return $"{self:#,##0}";
        }

        /// <summary>
        /// Enumerable.Range を実行します
        /// </summary>
        public static IEnumerable<int> Range( this int self )
        {
            return Enumerable.Range( 0, self );
        }

        /// <summary>
        /// 桁数を返します
        /// </summary>
        public static int GetDigits( this int num )
        {
            return num == 0 ? 1 : ( int )Math.Log10( num ) + 1;
        }
    }
}