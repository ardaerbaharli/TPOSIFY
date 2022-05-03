using System.Collections.Generic;
using Enums;
using UnityEngine;

namespace Controllers
{
    public class PageController : MonoBehaviour
    {
        private Pages currentPage;
        private List<Pages> previousPages;

        public Pages CurrentPage
        {
            get => currentPage;
            set
            {
                previousPages.Add(currentPage);
                currentPage = value;
            }
        }

        public List<Pages> PreviousPages => previousPages;

        private void Start()
        {
            previousPages = new List<Pages>();
        }


        public void ShowPage(Pages page)
        {
        }

        public void HidePage(Pages page)
        {
        }


        public void ShowNavbar()
        {
        }

        public void HideNavbar()
        {
        }

        public void GoBackClicked()
        {
        }
    }
}