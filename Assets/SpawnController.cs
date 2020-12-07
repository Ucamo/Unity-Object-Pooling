using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public float spawnFrequency;
    Vector3 position;
    void Start()
    {
        //Initialize your properties
        position = new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        //start spawning objects.
        InvokeRepeating ("SpawnObject", spawnFrequency, spawnFrequency);
    }

    void SpawnObject(){             
        GameObject spawnObject = GetObjectFromMainPool();
        if(spawnObject!=null){
            spawnObject.transform.position=position;
            spawnObject.SetActive(true);
        }
        
    }

    GameObject GetObjectFromMainPool(){
         //Get object from the main pool
        GameObject objMainPool = GameObject.Find("MainPool");
        if(objMainPool!=null){
            return objMainPool.GetComponent<ObjectPoolController>().GetObjectFromPool();
        }
        return null;
    }
}
