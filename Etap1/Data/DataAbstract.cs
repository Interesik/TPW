namespace Data
{
    public abstract class DataAbstractApi
    {
        public static DataAbstractApi creatApi()
        {
            return new DataApi();
        }

        internal class DataApi : DataAbstractApi
        {

        }
    }
}