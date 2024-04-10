namespace LexisNexis.Shared
{
    public static class Utility
    {
        /*****************************************************
        * Get Mime Type
       *****************************************************/
        public static string GetMimeType(string fileName)
        {
            string mimeType = String.Empty;

            //get file extension
            string fileExtension = GetFileExtension(fileName);

            switch (fileExtension.ToLower())
            {
                case "jpg":
                case "jpeg":
                case "jfif":
                    mimeType = "image/jpeg";
                    break;

                case "gif":
                    mimeType = "image/gif";
                    break;

                case "bmp":
                    mimeType = "image/bmp";
                    break;

                case "png":
                    mimeType = "image/png";
                    break;
            }
            return mimeType;
        }

        /*****************************************************
         * Get File Extension
        *****************************************************/
        public static string GetFileExtension(string fileName)
        {
            string[] splitString = fileName.Split(".");
            return splitString[splitString.Length - 1];
        }
    }
}
