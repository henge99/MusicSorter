using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace MusicSorter.models
{
    class Song
    {

        private string path;
        private string filename;
        private string nicepath;
        private Group group;

        public Song(string path = "", string filename = "", string nicepath = "", Group group = null)
        {
            this.path = path;
            this.filename = filename;
            this.nicepath = nicepath;
            this.group = group;
        }

        public string GetFileName()
        {
            return filename;
        }

        public string GetPath()
        {
            return path;
        }

        public string GetNicePath()
        {
            return nicepath;
        }

        public Group GetGroup()
        {
            return group;
        }
    }
}
