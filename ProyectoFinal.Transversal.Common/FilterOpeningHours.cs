namespace ProyectoFinal.Transversal.Common
{
    public static class FilterOpeningHours
    {
        public static string Until_14 = "08:00 a 14:00";
        public static string Until_18 = "14:00 a 18:00";
        public static string AllDay = "18:00 a 08:00";

        public static string[] Get() 
        {
            return new string[] { Until_14, Until_18, AllDay };
        }
    }
}
