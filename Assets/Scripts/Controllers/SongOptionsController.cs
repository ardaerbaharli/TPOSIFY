using Enums;
using UnityEngine;

namespace Controllers
{
    public class SongOptionsController : MonoBehaviour
    {
        
        public void AddToPlaylistButton()
        {
            PageController.Instance.ShowPage(Pages.AddToPlaylist);
        }
        public void GoToAlbumButton()
        {
            PageController.Instance.ShowPage(Pages.Album);
        }
        public void GoToArtistButton()
        {
            PageController.Instance.ShowPage(Pages.Artist);
        }

        public void BackButtonClicked()
        {
            PageController.Instance.GoBack();
        }
        
    }
}
