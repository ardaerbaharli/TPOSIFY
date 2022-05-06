using Enums;
using UnityEngine;

namespace Controllers
{
    public class PlaylistController : MonoBehaviour
    {
        [SerializeField] private bool likeSongs;

        public void OnClick()
        {
            var page = likeSongs ? Pages.MyLibrary : Pages.Playlist;
            PageController.Instance.ShowPage(page);
        }
    }
}