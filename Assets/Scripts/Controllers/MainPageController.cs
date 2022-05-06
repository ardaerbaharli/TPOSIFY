using System;
using Enums;
using UnityEngine;

namespace Controllers
{
    public class MainPageController : MonoBehaviour
    {
        private void OnEnable()
        {
            PageController.Instance.ShowNavbar();
        }

        private void OnDisable()
        {
            PageController.Instance.HideNavbar();
        }

        public void MRSClicked()
        {
            PageController.Instance.ShowPage(Pages.MRS);
        }

        public void SettingsClicked()
        {
            PageController.Instance.ShowPage(Pages.Settings);
        }
    }
}