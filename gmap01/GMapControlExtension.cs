namespace GMap.NET.WindowsForms
{
    public static class GMapControlExtension
    {
        public static void RefreshMap(this GMapControl map)
        {
            map.Zoom--;
            map.Zoom++;
        }
    }


}

