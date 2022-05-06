using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ToggleSwitch : MonoBehaviour, IPointerDownHandler
{
    public bool isOn;
    [SerializeField] private Image image;

    [SerializeField] private Sprite onImage;
    [SerializeField] private Sprite offImage;

    public delegate void ValueChanged(bool value);

    public event ValueChanged valueChanged;

    public void Toggle(bool value)
    {
        isOn = value;
        ToggleImage(isOn);

        if (valueChanged != null)
            valueChanged(isOn);
    }

    private void ToggleImage(bool value)
    {
        image.sprite = value ? onImage : offImage;
    }


    public void OnPointerDown(PointerEventData eventData)
    {
        Toggle(!isOn);
    }
}