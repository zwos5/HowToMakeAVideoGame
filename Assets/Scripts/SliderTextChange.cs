using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderTextChange : MonoBehaviour
{
    /* Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/

    public Slider Slider;
    public Text SliderNumber;
    public void UpdateText()
    {
        SliderNumber.text = Slider.value.ToString("f0"); //Float no decimal values
    }
}
