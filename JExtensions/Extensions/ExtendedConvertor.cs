﻿namespace JCommon.Extensions
{
    public static class ExtendedConvertor
    {
        public static int ToInt32(this string str, int def = 0)
        {
            if (!int.TryParse(str, out int temp))
                return def;

            return temp;
        }

        public static float ToSingle(this string str, float def = 0)
        {
            if (!float.TryParse(str, out float temp))
                return def;

            return temp;
        }
        public static double ToDouble(this string str, double def = 0)
        {
            if (!double.TryParse(str, out double temp))
                return def;

            return temp;
        }
        public static short ToShort(this string str, short def = 0)
        {
            if (!short.TryParse(str, out short temp))
                return def;

            return temp;
        }

        public static byte ToByte(this string str, byte def = 0)
        {
            if (!byte.TryParse(str, out byte temp))
                return def;

            return temp;
        }

        public static bool ToBoolean(this string str, bool def = false)
        {
            if (!bool.TryParse(str, out bool temp))
                return def;

            return temp;
        }
    }
}
