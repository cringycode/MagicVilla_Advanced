namespace MagicVilla_Utility
{
    public static class SD
    {
        public enum ApiType
        {
            GET,
            POST,
            PUT,
            DELETE
        }

        public enum ContentType
        {
            Json,
            MultipartFormData
        }

        public static string SessionToken = "JWTToken";
        public static string CurrentAPIVersion = "v2";
        public const string Admin = "Admin";
        public const string Customer = "customer";
    }
}