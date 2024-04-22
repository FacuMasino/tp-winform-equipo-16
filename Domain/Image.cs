namespace Domain
{
    internal class Image
    {
        private int _id;
        private string _url;

        public Image(int id, string url)
        {
            this._id = id;
            this._url = url;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }
    }
}
