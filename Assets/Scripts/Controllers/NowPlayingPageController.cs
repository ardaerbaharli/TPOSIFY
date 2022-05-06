using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Enums;

namespace Controllers
{
    public class NowPlayingPageController : MonoBehaviour
    {
        public void BackButtonClicked()
        {
            PageController.Instance.GoBack();
        }
        public void SongOptionButtonClicked()
        {
            PageController.Instance.ShowPage(Pages.SongOption);
        }
        public void ShareButtonClicked()
        {
            print("share");
        }
        public void QueueButtonClicked()
        {
            PageController.Instance.ShowPage(Pages.Queue);
        }

    }
}