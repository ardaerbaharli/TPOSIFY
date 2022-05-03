using UnityEngine.UI;

namespace Models
{
    public class Artist
    {
        private string name;
        private int artistId;
        private Image artistImage;
    
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    
        public int ArtistId
        {
            get { return artistId; }
            set { artistId = value; }
        }
    
        public Image ArtistImage
        {
            get { return artistImage; }
            set { artistImage = value; }
        }
    
    }
}