using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Controllers
{
    public class QueueController : MonoBehaviour
    {
        public void BackButton()
        {
            PageController.Instance.GoBack();
        }
    }
}
