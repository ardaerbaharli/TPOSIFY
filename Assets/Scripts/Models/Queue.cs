using System.Collections.Generic;

namespace Models
{
    public class Queue
    {
        private List<Song> nextSongs;
        private List<Song> previousSongs;
        private Song currentSong;

        public List<Song> NextSongs
        {
            get { return this.nextSongs; }
            set { this.nextSongs = value; }
        }

        public List<Song> PreviousSongs
        {
            get { return this.previousSongs; }
            set { this.previousSongs = value; }
        }

        public Song CurrentSong
        {
            get { return this.currentSong; }
            set { this.currentSong = value; }
        }
    }
}