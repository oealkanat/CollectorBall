using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class sliderValue : MonoBehaviour
{
    public Slider slider;
    public TextMeshProUGUI sliderText;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sliderText.text = (slider.value).ToString();
    }
}
