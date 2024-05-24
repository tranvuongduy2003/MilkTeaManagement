using System.Globalization;

namespace MilkTeaManagement.WindowsApp.Helpers
{
    public static class ConvertCurrency
    {
        public static string ToVND(decimal number)
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            string resutl = decimal.ToDouble(number).ToString("#,###", cul.NumberFormat) + " VNĐ";
            return resutl;
        }
    }
}
