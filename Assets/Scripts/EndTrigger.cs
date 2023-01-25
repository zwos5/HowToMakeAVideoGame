using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    /* Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/

    public GameManager gameManager;

    public void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }
}
