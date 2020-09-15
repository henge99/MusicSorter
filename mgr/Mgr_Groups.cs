using MusicSorter.models;
using System.Collections.Generic;

namespace MusicSorter.mgr
{
    class Mgr_Groups
    {

        List<Group> groups;

        public Mgr_Groups()
        {
            groups = new List<Group>();
        }

        public Group AddSongToGroup(string groupname)
        {
            Group songGroup = null;
            foreach (Group group in groups)
            {
                if (group.GetName() == groupname)
                {
                    songGroup = group;
                    break;
                }
            }
            if (songGroup == null)
            {
                groups.Add(new Group(groupname));
            }
            return songGroup;
        }

    }
}