using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

namespace Controllers
{
    public class PlaylistPageController : MonoBehaviour
    {
        public void BackButtonClicked()
        {
            PageController.Instance.GoBack();
        }
        public void AddSongButtonClicked()
        {
            PageController.Instance.ShowPage(Pages.Search);
        }
        private void OnEnable()
        {
            PageController.Instance.ShowNavbar();
        }

        private void OnDisable()
        {
            PageController.Instance.HideNavbar();
        }

    }

}
