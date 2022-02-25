using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverightward : MonoBehaviour
{
    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame for fire on right side
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed); 
        //Destroy fire after 3 frames 
        Destroy(gameObject,3f);
    }
}