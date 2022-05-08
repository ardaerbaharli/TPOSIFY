using System;
using System.Collections.Generic;
using System.Linq;
using Extensions;
using UnityEngine;
using UnityEngine.UI;

namespace Controllers
{
    public class SearchPageController : MonoBehaviour
    {
        public enum SearchResultType
        {
            Everything,
            Songs,
            Playlists,
            Artists
        }

        [SerializeField] private SearchResultTypeController everything, songs, artists, playlists;
        [SerializeField] private InputField search;
        public DictionaryUnity<SearchResultType, GameObject> resultPages;

        private List<SearchResultTypeController> _searchResultTypeControllers;
        private SearchResultType _currentSearchResultType;
        private string searchKeyword;

        private void Start()
        {
            _searchResultTypeControllers = new List<SearchResultTypeController>
            {
                everything,
                songs,
                artists,
                playlists
            };

            _currentSearchResultType = SearchResultType.Everything;
            everything.OnSelected();
        }

        private void OnEnable()
        {
            PageController.Instance.ShowNavbar();
            everything.onSelect += OnEverythingSelected;
            songs.onSelect += OnSongsSelected;
            artists.onSelect += OnArtistsSelected;
            playlists.onSelect += OnPlaylistsSelected;
        }

        public void SearchButton()
        {
            searchKeyword = search.text;
            if (!ValidateInput()) return;
            DisableOthers();
            GetResults();
        }

        private void DisableOthers()
        {
            resultPages.dictionary
                .Where(x => x.key != _currentSearchResultType)
                .ToList()
                .ForEach(x => x.value.SetActive(false));
        }

        private void GetResults()
        {
            resultPages[_currentSearchResultType].SetActive(true);
        }

        private void OnDisable()
        {
            PageController.Instance.HideNavbar();
            
            search.text = "";
            
            resultPages[_currentSearchResultType].SetActive(false);
            DeselectOthers(everything);
            everything.OnSelected();

            everything.onSelect -= OnEverythingSelected;
            songs.onSelect -= OnSongsSelected;
            artists.onSelect -= OnArtistsSelected;
            playlists.onSelect -= OnPlaylistsSelected;
        }

        private bool ValidateInput()
        {
            return !searchKeyword.IsNullOrWhiteSpace();
        }

        public void CancelButton()
        {
            PageController.Instance.GoBack();
        }


        private void OnPlaylistsSelected()
        {
            DeselectOthers(playlists);
            _currentSearchResultType = SearchResultType.Playlists;
        }

        private void OnArtistsSelected()
        {
            DeselectOthers(artists);
            _currentSearchResultType = SearchResultType.Artists;
        }

        private void OnSongsSelected()
        {
            DeselectOthers(songs);
            _currentSearchResultType = SearchResultType.Songs;
        }

        private void OnEverythingSelected()
        {
            DeselectOthers(everything);
            _currentSearchResultType = SearchResultType.Everything;
        }

        private void DeselectOthers(SearchResultTypeController srtc)
        {
            _searchResultTypeControllers
                .Where(x => x != srtc)
                .ToList()
                .ForEach(x => x.Deselect());
        }
    }
}