using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;
using UnityEngine.UI;

namespace Controllers
{
    public class AddToPlaylistPageController : MonoBehaviour
    {
        [SerializeField] private InputField inputText;
        public void CancelButtonClicked()
        {
            PageController.Instance.GoBack();
        }
        public void NewPlaylistButtonClicked()
        {
            PageController.Instance.ShowPage(Pages.CreatePlaylist);
        }
        private void OnDisable()
        {
            inputText.text = "";
            PageController.Instance.HideNavbar();
        }
        private void OnEnable()
        {
            PageController.Instance.ShowNavbar();
        }

    }
}