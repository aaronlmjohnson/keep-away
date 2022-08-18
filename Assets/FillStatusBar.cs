using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillStatusBar : MonoBehaviour
{
    public PlayerAtributes playerAttributes;
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        //bar = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        float fillValue = playerAttributes.CurrentHealth / playerAttributes.MaxHealth;
        slider.value = fillValue;
    }
}
