namespace Kogane
{
    /// <summary>
    /// byte 型の拡張メソッドを管理するクラス
    /// </summary>
    public static class ByteExtensionMethods
    {
        //================================================================================
        // 関数(static)
        //================================================================================
        /// <summary>
        /// 1 なら true、0 なら false のbool 型に変換して返します
        /// </summary>
        public static bool ToBool( this byte self )
        {
            return self == 1;
        }

        /// <summary>
        /// 数値を指定された桁数で 0 埋めした文字列を返します
        /// </summary>
        /// <example>
        /// 123.ZeroFill( 4 ) → 01234
        /// 123.ZeroFill( 8 ) → 000001234
        /// </example>
        public static string ZeroFill( this byte self, int numberOfDigits )
        {
            return self.ToString( "D" + numberOfDigits );
        }
    }
}