using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

namespace Controllers
{
    public class AddToPlaylistPageController : MonoBehaviour
    {
        public void CancelButtonClicked()
        {
            PageController.Instance.GoBack();
        }
        public void NewPlaylistButtonClicked()
        {
            PageController.Instance.ShowPage(Pages.CreatePlaylist);
        }
    }
}