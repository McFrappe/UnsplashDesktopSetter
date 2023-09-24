namespace UnsplashDesktopSetter
{
    public class ImageResolution
    {
        public string raw;
        public string full;
        public string regular;
        public string small;
        public string thumb;
        public string small_s3;

        public string SelectedResolution(string input)
        {
            if (input == null) return regular;

            if (input.Equals("raw"))
            {
                return raw;
            }

            if (input.Equals("full"))
            {
                return full;
            }

            if (input.Equals("regular"))
            {
                return regular;
            }

            if (input.Equals("small"))
            {
                return small;
            }

            if (input.Equals("thumb"))
            {
                return thumb;
            }

            if (input.Equals("small_s3"))
            {
                return small_s3;
            }

            return regular;
        }
    }
}