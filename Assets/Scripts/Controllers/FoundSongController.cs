using System.Collections;
using System.Collections.Generic;
using Enums;
using UnityEngine;

namespace Controllers
{
    public class FoundSongController : MonoBehaviour
    {
        public void BackButtonClicked()
        {
            PageController.Instance.GoBack();
        }

        public void SongOptionsButtonClicked()
        {
            PageController.Instance.ShowPage(Pages.SongOption);
        }

        public void PlayButtonClicked()
        {
            PageController.Instance.ShowPage(Pages.NowPlaying);
        }
    }
}
