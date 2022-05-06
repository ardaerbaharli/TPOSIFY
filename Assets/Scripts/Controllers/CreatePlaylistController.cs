using System.Collections;
using System.Collections.Generic;
using Enums;
using UnityEngine;

namespace Controllers
{
    public class CreatePlaylistController : MonoBehaviour
    {
        public void CancelButtonClicked()
        {
            PageController.Instance.GoBack();
        }

        public void CreateButtonClicked()
        {
            PageController.Instance.ShowPage(Pages.Playlist);
        }
        
    }
}
