using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject[] things;
    public Transform[] points;
    public float beat;
    private float timer;
    public bool enable;
    
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer>beat)
        {
            GameObject thing = Instantiate(things[Random.Range(0,2)], points[Random.Range(0,4)]);
            thing.transform.localPosition = Vector3.zero;
            //thing.transform.Rotate(transform.forward, 90 * Random.Range(0,4));
            timer -= beat;
        }
        timer += Time.deltaTime;
    }
}
