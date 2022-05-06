using System.Collections;
using System.Collections.Generic;
using Enums;
using UnityEngine;
using UnityEngine.UI;

namespace Controllers
{
    public class CreatePlaylistController : MonoBehaviour
    {

        [SerializeField] private InputField text;
        public void CancelButtonClicked()
        {
            PageController.Instance.GoBack();
        }

        public void CreateButtonClicked()
        {
            PageController.Instance.ShowPage(Pages.Playlist);
            text.text = "";
        }
        
    }
}
