using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void UpdateTimeScale()
    {
         Time.timeScale = GetComponent<Slider>().value;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
