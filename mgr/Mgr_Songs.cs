using MusicSorter.models;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MusicSorter.mgr
{
    class Mgr_Songs
    {
        private string mainPath;
        private List<Song> songs;

        private Mgr_Groups MgrGroups;

        public Mgr_Songs()
        {
            mainPath = "";
            songs = new List<Song>();

            MgrGroups = new Mgr_Groups();
        }

        public void LoadSongFolder(string path = "")
        {
            // Load songs from folder and subfolders
            songs.Clear();
            if (path == "")
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                DialogResult result = folderBrowserDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    path = folderBrowserDialog.SelectedPath;
                    mainPath = path;
                }
                else
                {
                    return;
                }
            }           

            if (!string.IsNullOrWhiteSpace(path))
            {
                foreach (string songPath in Directory.GetFiles(path))
                {
                    string nicepath = songPath.Replace(mainPath + "\\", "");
                    string groupname = Directory.GetParent(songPath).Name;
                    Group group = MgrGroups.AddSongToGroup(groupname);
                    if (group != null)
                    {
                        Song song = new Song(
                           songPath,
                           Path.GetFileName(songPath),
                           nicepath,
                           group
                        );
                        songs.Add(song);
                    }
                }
                foreach (string directory in Directory.GetDirectories(path))
                {
                    LoadSongFolder(directory);
                }
            }

            return;

        }

        public List<Song> GetSongs()
        {
            return songs;
        }

    }
}
