using Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Controllers
{
    public class AlbumPageController : MonoBehaviour
    {
        public void BackButtonClicked()
        {
            PageController.Instance.GoBack();
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
