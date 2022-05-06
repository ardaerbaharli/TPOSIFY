using Enums;
using UnityEngine;

namespace Controllers
{
    public class SongController : MonoBehaviour
    {
        private PlayerController player;


        public void OnClick()
        {
            PageController.Instance.ShowPage(Pages.NowPlaying);
        }

        public void SongOptionsClicked()
        {
            PageController.Instance.ShowPage(Pages.SongOption);
        }

        public void SongSelectionToggle()
        {
        }

        public void SongShifter()
        {
        }

        public void LikeSongToggle()
        {
        }

        public void PlaySong()
        {
        }
    }
}