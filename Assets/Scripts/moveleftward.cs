using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveleftward : MonoBehaviour
{
    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move fire left ward
        transform.Translate(Vector3.left * Time.deltaTime * speed);
        //Destroy fire after 3 frames 
        Destroy(gameObject,3f);
    }
}
