using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BNG;

public class saber : GrabbableHaptics
{
    public LayerMask layer;
    private Vector3 previousPos;
    public Grabber grab1, grab2;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 1, layer))
        {
            if((Vector3.Angle(transform.position-previousPos, hit.transform.up)>130)||(Vector3.Angle(transform.position-previousPos, -(hit.transform.right))>130)||(Vector3.Angle(transform.position-previousPos, hit.transform.right)>130)||(Vector3.Angle(transform.position-previousPos, -(hit.transform.up))>130)||(Vector3.Angle(transform.position-previousPos, hit.transform.forward)>130)||(Vector3.Angle(transform.position-previousPos, -(hit.transform.forward))>130))
            {
                Destroy(hit.transform.gameObject);
                input.VibrateController(0.3f, 0.4f, 0.2f, grab1.HandSide);
                input.VibrateController(0.3f, 0.4f, 0.2f, grab2.HandSide);

            }
        }
        previousPos = transform.position;
    }
    /*void OnTriggerEnter(Collider collision) {   
        if (collision.gameObject != null) {
            if (collision.CompareTag("Enemy")) {
                Destroy(collision.transform.gameObject);
            }
        }
    }*/
}