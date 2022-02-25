using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    //Variables for time interval
    private float startDelay = 2;
    private float repeatRate = 2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    void SpawnEnemy(){
        //This function perform spawning of enemly randomly
        int enemypos = Random.Range(1, 4);
        if(enemypos==1){
            Instantiate(enemyPrefab,new Vector3(8,0,7) ,  Quaternion.identity);
        }
        else if(enemypos==2){
            Instantiate(enemyPrefab,new Vector3(8,0,-7) ,  Quaternion.identity);
        }
        else if(enemypos==3){
            Instantiate(enemyPrefab,new Vector3(-8,0,7) ,  Quaternion.identity);
        }
        else if(enemypos==4){
            Instantiate(enemyPrefab,new Vector3(-8,0,-7) ,  Quaternion.identity);
        }
    }
}
