using System.Collections.Generic;
using System.Linq;
using Enums;
using Extensions;
using UnityEngine;

namespace Controllers
{
    public class PageController : MonoBehaviour
    {
        private Pages currentPage;
        private List<Pages> previousPages;
        public GameObject navbar;
        public DictionaryUnity<Pages, GameObject> pages;

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

        public static PageController Instance { get; private set; }

        private void Awake()
        {
            if (Instance == null)
                Instance = this;
        }

        private void Start()
        {
            previousPages = new List<Pages>();
        }


        public void ShowPage(Pages page)
        {
            HidePage(currentPage);
            currentPage = page;
            pages[page].SetActive(true);
        }

        private void HidePage(Pages page)
        {
            PreviousPages.Add(page);
            pages[page].SetActive(false);
        }

        public void ShowNavbar()
        {
            navbar.SetActive(true);
        }

        public void HideNavbar()
        {
            navbar.SetActive(false);
        }

        public void GoBack()
        {
            var page = PreviousPages.Last();
            // ShowPage(page);
            PreviousPages.RemoveLast();

            pages[currentPage].SetActive(false);
            currentPage = page;
            pages[page].SetActive(true);
        }
    }
}