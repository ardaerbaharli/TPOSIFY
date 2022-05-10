using System.Collections;
using System.Collections.Generic;
using Enums;
using UnityEngine;

namespace Controllers
{
    public class MRSController : MonoBehaviour
    {
        public void MrsButtonClicked()
        {
            PageController.Instance.ShowPage(Pages.FoundSongs);
        }

        public void BackButtonClicked()
        {
            PageController.Instance.GoBack();
        }
        
    }
}