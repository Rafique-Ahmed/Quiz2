using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveforward : MonoBehaviour
{
    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
       transform.Translate(Vector3.left * Time.deltaTime * speed); 
       Destroy(gameObject,3f);
    }
}