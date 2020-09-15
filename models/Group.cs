namespace MusicSorter.models
{
    class Group
    {

        private string name;

        public Group(string name = "")
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

    }
}
