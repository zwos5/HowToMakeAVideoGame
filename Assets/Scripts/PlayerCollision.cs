using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Start is called before the first frame update
    /*void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/

    public playerMovement movement;
    //public GameManager gameManager;

    void OnCollisionEnter(Collision collisionInfo) {
        //Debug.Log("We hit something"); Testing function
        if (collisionInfo.collider.tag == "Obstacle")
        {
            //Debug.Log("We hit an obstacle");
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
        //Debug.Log(collisionInfo.collider.name);
    }
}
