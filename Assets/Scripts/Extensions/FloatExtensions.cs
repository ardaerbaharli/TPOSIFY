using UnityEngine;

namespace Extensions
{
    public static class FloatExtensions
    {
        public static bool IsSimiliar(this float float1, float float2, float precision)
        {
            return (Mathf.Abs(float1 - float2) <= precision);
        }

        public static bool IsDifferanceLessThan(this float float1, float float2, float precision)
        {
            return (Mathf.Abs(float1 - float2) < precision);
        }

        public static float RoundToMultiple(this float float1, float multiple)
        {
            if (float1 >= 0)
                return Mathf.Floor((float1 + multiple / 2) / multiple) * multiple;
            else
                return Mathf.Ceil((float1 - multiple / 2) / multiple) * multiple;
        }
    }
}