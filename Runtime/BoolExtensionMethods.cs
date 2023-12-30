namespace Kogane
{
    /// <summary>
    /// bool 型の拡張メソッドを管理するクラス
    /// </summary>
    public static class BoolExtensionMethods
    {
        //================================================================================
        // 関数(static)
        //================================================================================
        /// <summary>
        /// true なら 1、false なら 0 の byte 型に変換して返します
        /// </summary>
        public static byte ToByte( this bool self )
        {
            return ( byte )( self ? 1 : 0 );
        }

        /// <summary>
        /// true なら 1、false なら 0 の int 型に変換して返します
        /// </summary>
        public static int ToInt( this bool self )
        {
            return self ? 1 : 0;
        }
    }
}