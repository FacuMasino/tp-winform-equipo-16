namespace Domain
{
    public class Category
    {
        private int _id;
        private string _name;

        //CONSTRUCTORES
        public Category(int id, string name)
        {
            this._id = id;
            this._name = name;
        }

        public Category() { }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
