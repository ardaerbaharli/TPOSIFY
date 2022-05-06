using System;
using Enums;
using Models;
using UnityEngine;

namespace Controllers
{
    public class NavbarController : MonoBehaviour
    {
        [SerializeField] private ToggleSwitch playPauseToggle;
        private Song currentSong;

        private void Start()
        {
            playPauseToggle.valueChanged += OnPlayPauseToggled;
        }

        private void OnDestroy()
        {
            playPauseToggle.valueChanged -= OnPlayPauseToggled;
        }

        private void OnPlayPauseToggled(bool value)
        {
            // TODO Pause the current playing song
        }

        public void ClickedOnSong()
        {
            PageController.Instance.ShowPage(Pages.NowPlaying);
        }

        public void MainMenuButton()
        {
            PageController.Instance.ShowPage(Pages.Main);
        }

        public void SearchButton()
        {
            PageController.Instance.ShowPage(Pages.Search);
        }

        public void LibraryButton()
        {
            PageController.Instance.ShowPage(Pages.MyLibrary);
        }
    }
}