namespace MusicSorter.models
{
    class Group
    {

        private string name;
        private Group parent;

        public Group(string name = "", Group parent = null)
        {
            this.name = name;
            this.parent = parent;
        }

        public string GetName()
        {
            return name;
        }

        public Group GetParent()
        {
            return parent;
        }

    }
}
