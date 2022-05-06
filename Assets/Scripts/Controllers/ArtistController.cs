using Enums;
using UnityEngine;

namespace Controllers
{
    public class ArtistController : MonoBehaviour
    {
        public void OnClick()
        {
            PageController.Instance.ShowPage(Pages.Artist);
        }
    }
}