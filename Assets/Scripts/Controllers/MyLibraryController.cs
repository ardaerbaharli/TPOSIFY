using Enums;
using UnityEngine;

namespace Controllers
{
    public class MyLibraryController : MonoBehaviour
    {
        private void OnEnable()
        {
            PageController.Instance.ShowNavbar();
        }

        private void OnDisable()
        {
            PageController.Instance.HideNavbar();
        }
        
        public void SearchButton()
        {
             PageController.Instance.ShowPage(Pages.Search);
        }

        public void CreatePlaylistButton()
        {
             PageController.Instance.ShowPage(Pages.CreatePlaylist);
        }
    }
}