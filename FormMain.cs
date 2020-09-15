using MusicSorter.mgr;
using MusicSorter.models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MusicSorter
{
    public partial class FormMain : Form
    {
        private Mgr_Songs MgrSongs;

        public FormMain()
        {
            InitializeComponent();

            MgrSongs = new Mgr_Songs();
            listView1.Items.Clear();
        }

        private void songsLadenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MgrSongs.LoadSongFolder();
            List<Song> songs = MgrSongs.GetSongs();

            foreach (Song song in songs)
            {
                ListViewItem item = new ListViewItem();
                item.Text = song.GetFileName();
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, song.GetNicePath()));
                item.Group = new ListViewGroup(song.GetGroup().GetName());
                listView1.Items.Add(item);
            }
        }
    }
}
