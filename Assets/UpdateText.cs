using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateText : MonoBehaviour
{
    [SerializeField]
    Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        UpdateTextValue();
    }

    public void UpdateTextValue()
    {
        GetComponent<Text>().text = "" + slider.value;
    }
}
