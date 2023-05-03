using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BNG;

public class Saber : GrabbableHaptics
{

    public Grabber grabR, grabL;
    private Manager manager;


    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.FindObjectOfType<Manager>();
    }


    void OnTriggerEnter(Collider collision) {   
        if (collision.CompareTag("Enemy")) 
        {
            manager.increaseScore(100);
        }
        else if(collision.CompareTag("NPC"))
        {
            manager.increaseStrike(1);
        }

        if (gameObject.CompareTag("RightSaber"))
        {
            input.VibrateController(0.3f, 0.4f, 0.2f, grabR.HandSide);
        }
        else
            input.VibrateController(0.3f, 0.4f, 0.2f, grabL.HandSide);

        Destroy(collision.transform.gameObject);

    }
}
