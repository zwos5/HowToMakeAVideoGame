using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getPlayerName : MonoBehaviour
{
    /* Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/

    public string inputName;
    public GameObject inputField;
    public GameObject textDisplay;

    public void DisplayName()
    {

        inputName = inputField.GetComponent<Text>().text;
        textDisplay.GetComponent<Text>().text = "Hello " + inputName + " good luck!";
    }

}
