using UnityEngine;
using UnityEngine.UI;

public class movetext : MonoBehaviour
{
    public Slider slider;
    public Text valueText;
    public float movementSpeed = 5f;
    public float minX = 0f;
    public float maxX = 10f;
    public float minValue = 0f;
    public float maxValue = 174f;

    private void Start()
    {
        UpdateValueText();
    }

    private void Update()
    {
        float targetX = Mathf.Lerp(minX, maxX, slider.value);
        Vector3 targetPosition = new Vector3(targetX, transform.position.y, transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, movementSpeed * Time.deltaTime);

        UpdateValueText();
    }

    private void UpdateValueText()
    {
        float value = Mathf.Lerp(minValue, maxValue, slider.value);
        valueText.text = value.ToString("F1") + " mm";
    }
}
