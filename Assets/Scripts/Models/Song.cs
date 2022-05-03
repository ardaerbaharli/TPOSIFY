using UnityEngine;

namespace Models
{
    public class Song
    {
        private string name;
        private string genre;
        private Artist artist;
        private Time time;
        private int songId;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public Artist Artist
        {
            get { return artist; }
            set { artist = value; }
        }

        public Time Time
        {
            get { return time; }
            set { time = value; }
        }

        public int SongId
        {
            get { return songId; }
            set { songId = value; }
        }
    }
}