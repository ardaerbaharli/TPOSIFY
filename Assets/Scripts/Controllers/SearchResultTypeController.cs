using UnityEngine;
using UnityEngine.UI;

namespace Controllers
{
    public class SearchResultTypeController : MonoBehaviour
    {
        [SerializeField] private Image image;
        [SerializeField] private Color selectedColor;
        [SerializeField] private Color normalColor;
        public bool isSelected;

        public delegate void OnSelect();

        public event OnSelect onSelect;


        private void Start()
        {
            isSelected = false;
            ToggleImage();
        }

        public void OnSelected()
        {
            isSelected = true;
            ToggleImage();
            onSelect?.Invoke();
        }

        private void ToggleImage()
        {
            image.color = isSelected ? selectedColor : normalColor;
        }

        public void Deselect()
        {
            isSelected = false;
            ToggleImage();
        }
    }
}