namespace ProyectoFinal.Transversal.Common
{
    public static class OpeningHours
    {
        public static string Until_14 = "08:00 a 14:00";
        public static string Until_18 = "08:00 a 18:00";
        public static string AllDay = "Las 24 hs";

        public static string[] Get()
        {
            return new string[] { Until_14, Until_18, AllDay };
        }
    }
}
