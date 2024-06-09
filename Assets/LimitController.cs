using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LimitController : MonoBehaviour
{
    [SerializeField]
    Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        UpdateAnotherSliderValue();
    }

    public void UpdateAnotherSliderValue()
    {
        GetComponent<Slider>().maxValue = (int)Math.Round((slider.value* slider.value)/2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
