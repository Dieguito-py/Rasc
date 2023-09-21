using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
    public Slider colorSlider;
    public GameObject targetObject;
    
    private void Start()
    {
        // Adicione um listener ao Slider para chamar a função ChangeColor quando o valor do Slider mudar.
        colorSlider.onValueChanged.AddListener(ChangeColor);
    }

    private void ChangeColor(float value)
    {
        // Interpole a cor do objeto com base no valor do Slider.
        Color startColor = new Color(39f / 255f, 76f / 255f, 111f / 255f); // Cor inicial (#274C6F)
        Color endColor = new Color(111f / 255f, 77f / 255f, 38f / 255f); // Cor final (#6F4D26)
        Color lerpedColor = Color.Lerp(startColor, endColor, value);

        // Atribua a cor interpolada ao objeto.
        targetObject.GetComponent<Renderer>().material.color = lerpedColor;
    }
}
