using System;

namespace Kogane
{
    /// <summary>
    /// float 型の拡張メソッドを管理するクラス
    /// </summary>
    public static class FloatExtensionMethods
    {
        //================================================================================
        // 関数(static)
        //================================================================================
        /// <summary>
        /// 指定した値と等しいかどうかを判断します。0.00001 までの誤差は許容します
        /// </summary>
        public static bool SafeEquals( this float self, float obj )
        {
            return self.SafeEquals( obj, 0.00001f );
        }

        /// <summary>
        /// 指定した値と等しいかどうかを判断します。threshold で指定された誤差は許容します
        /// </summary>
        public static bool SafeEquals
        (
            this float self,
            float      obj,
            float      threshold
        )
        {
            return Math.Abs( self - obj ) <= threshold;
        }

        /// <summary>
        /// 値が正常なら true を返します
        /// </summary>
        public static bool IsValidated( this float self )
        {
            return
                !float.IsInfinity( self ) &&
                !float.IsNaN( self )
                ;
        }

        /// <summary>
        /// 値が正常なら値をそのまま返します。値が不正なら defaultValue を返します
        /// </summary>
        public static float GetOrDefault( this float self )
        {
            return self.GetOrDefault( default );
        }

        /// <summary>
        /// 値が正常なら値をそのまま返します。値が不正なら defaultValue を返します
        /// </summary>
        public static float GetOrDefault( this float self, float defaultValue )
        {
            return float.IsInfinity( self ) || float.IsNaN( self ) ? defaultValue : self;
        }

        /// <summary>
        /// ほぼ整数なら true を返します
        /// </summary>
        public static bool IsApproximatelyInteger( this float value, float tolerance )
        {
            return Math.Abs( Math.Round( value ) - value ) <= tolerance;
        }
    }
}