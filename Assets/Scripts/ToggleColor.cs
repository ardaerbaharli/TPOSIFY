using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ToggleColor : MonoBehaviour, IPointerDownHandler
{
    public bool isOn;
    [SerializeField] private Image image;

    [SerializeField] private Color onColor;
    [SerializeField] private Color offColor;

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
        image.color = value ? onColor : offColor;
    }


    public void OnPointerDown(PointerEventData eventData)
    {
        Toggle(!isOn);
    }
}