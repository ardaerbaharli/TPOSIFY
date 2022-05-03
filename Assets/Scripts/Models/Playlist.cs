using System.Collections.Generic;
using UnityEngine.UI;

namespace Models
{
    public class Playlist
    {
        private string name;
        private List<Song> songs;
        private int playlistId;
        private Image playlistImage;
        private string playlistCreatorId;
    
        public string Name { get => name; set => name = value; }
        public List<Song> Songs { get => songs; set => songs = value; }
        public int PlaylistId { get => playlistId; set => playlistId = value; }
        public Image PlaylistImage { get => playlistImage; set => playlistImage = value; }
        public string PlaylistCreatorId { get => playlistCreatorId; set => playlistCreatorId = value; }
    
    }
}