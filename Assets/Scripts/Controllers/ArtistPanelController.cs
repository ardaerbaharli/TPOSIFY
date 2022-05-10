using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Controllers
{
    public class ArtistPanelController : MonoBehaviour
    {
        public void BackButton()
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
