using System;

namespace Hollysys.Common
{
    /// <summary>
    ///     转换器帮助类
    /// </summary>
    public static class ConverterHelper
    {
        /// <summary>
        /// </summary>
        /// <param name="thisValue"></param>
        /// <returns></returns>
        public static int ObjToInt(this object thisValue)
        {
            var result = 0;
            if (thisValue == null)
            {
                return 0;
            }

            if (thisValue != DBNull.Value && int.TryParse(thisValue.ToString(), out result))
            {
                return result;
            }

            return result;
        }

        /// <summary>
        /// </summary>
        /// <param name="thisValue"></param>
        /// <param name="errorValue"></param>
        /// <returns></returns>
        public static int ObjToInt(this object thisValue, int errorValue)
        {
            if (thisValue != null && thisValue != DBNull.Value && int.TryParse(thisValue.ToString(), out int result))
            {
                return result;
            }

            return errorValue;
        }

        /// <summary>
        /// </summary>
        /// <param name="thisValue"></param>
        /// <returns></returns>
        public static double ObjToMoney(this object thisValue)
        {
            if (thisValue != null && thisValue != DBNull.Value &&
                double.TryParse(thisValue.ToString(), out double toMoney))
            {
                return toMoney;
            }

            return 0;
        }

        /// <summary>
        /// </summary>
        /// <param name="thisValue"></param>
        /// <param name="errorValue"></param>
        /// <returns></returns>
        public static double ObjToMoney(this object thisValue, double errorValue)
        {
            if (thisValue != null && thisValue != DBNull.Value &&
                double.TryParse(thisValue.ToString(), out double toMoney))
            {
                return toMoney;
            }

            return errorValue;
        }

        /// <summary>
        /// </summary>
        /// <param name="thisValue"></param>
        /// <returns></returns>
        public static string ObjToString(this object thisValue)
        {
            return thisValue != null ? thisValue.ToString().Trim() : "";
        }

        /// <summary>
        /// </summary>
        /// <param name="thisValue"></param>
        /// <param name="errorValue"></param>
        /// <returns></returns>
        public static string ObjToString(this object thisValue, string errorValue)
        {
            return thisValue != null ? thisValue.ToString().Trim() : errorValue;
        }

        /// <summary>
        /// </summary>
        /// <param name="thisValue"></param>
        /// <returns></returns>
        public static decimal ObjToDecimal(this object thisValue)
        {
            if (thisValue != null && thisValue != DBNull.Value &&
                decimal.TryParse(thisValue.ToString(), out decimal toDecimal))
            {
                return toDecimal;
            }

            return 0;
        }

        /// <summary>
        /// </summary>
        /// <param name="thisValue"></param>
        /// <param name="errorValue"></param>
        /// <returns></returns>
        public static decimal ObjToDecimal(this object thisValue, decimal errorValue)
        {
            if (thisValue != null && thisValue != DBNull.Value &&
                decimal.TryParse(thisValue.ToString(), out decimal toDecimal))
            {
                return toDecimal;
            }

            return errorValue;
        }

        /// <summary>
        /// </summary>
        /// <param name="thisValue"></param>
        /// <returns></returns>
        public static DateTime ObjToDate(this object thisValue)
        {
            var toDateTime = DateTime.MinValue;
            if (thisValue != null && thisValue != DBNull.Value &&
                DateTime.TryParse(thisValue.ToString(), out toDateTime))
            {
                toDateTime = Convert.ToDateTime(thisValue);
            }

            return toDateTime;
        }

        /// <summary>
        /// </summary>
        /// <param name="thisValue"></param>
        /// <param name="errorValue"></param>
        /// <returns></returns>
        public static DateTime ObjToDate(this object thisValue, DateTime errorValue)
        {
            if (thisValue != null && thisValue != DBNull.Value &&
                DateTime.TryParse(thisValue.ToString(), out var toDate))
            {
                return toDate;
            }

            return errorValue;
        }

        /// <summary>
        /// </summary>
        /// <param name="thisValue"></param>
        /// <returns></returns>
        public static bool ObjToBool(this object thisValue)
        {
            var result = false;
            if (thisValue != null && thisValue != DBNull.Value && bool.TryParse(thisValue.ToString(), out result))
            {
                return result;
            }

            return result;
        }
    }
}