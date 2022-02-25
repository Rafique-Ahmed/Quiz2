using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //left & right fire collision dectection 
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Enemy")){
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }

    }
}
