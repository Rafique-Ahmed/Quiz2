using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject projectilePrefab;
    public GameObject projectilePrefabR;

    private Rigidbody playerRb;
    public float speed = 10.0f;


    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //Player Direction Inputs
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);


        if (Input.GetKeyDown(KeyCode.Space))
        {
        
        // Launch a projectile from the player
            if(transform.position.x<1){
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
           // Destroy(projectilePrefab, 3f);
            }
            if(transform.position.x>1){
            Instantiate(projectilePrefabR, transform.position, projectilePrefabR.transform.rotation);
         //   Destroy(projectilePrefabR, 3f);
            }

        }
    
    }
}
