using Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;


namespace Controllers
{
    public class SettingsController : MonoBehaviour
    {
        public void BackButtonClicked()
        {
            PageController.Instance.GoBack();
        }
        public void MembershipCancelationButtonClicked()
        {
            PageController.Instance.ShowPage(Pages.SignIn);
        }
        public void SignOutButtonClicked()
        {
            PageController.Instance.ShowPage(Pages.SignIn);
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