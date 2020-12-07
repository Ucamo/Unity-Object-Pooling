using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolController : MonoBehaviour
{
    public GameObject objectToSpawn;
    public int poolSize;    
    List<GameObject> objectPool;

    void Start()
    {
         //Initialize your properties
        objectPool = new List<GameObject>();
        //Create a pool and fill it with inactive GameObjects.
        for (int i = 0; i < poolSize; i++) {
            GameObject newGameObject = Instantiate (objectToSpawn);
            newGameObject.SetActive(false);
            objectPool.Add(newGameObject);
        }
    }

    public GameObject GetObjectFromPool(){
         //Get object from the pool
        foreach(GameObject objInPool in objectPool){
            //check if the object is inactive
            if(!objInPool.activeInHierarchy){
                return objInPool;
            }
        }
        //No inactive objects found, instantiate a new one and add it to the pool.
        GameObject newGameObject = Instantiate (objectToSpawn);
        newGameObject.SetActive(false);
        objectPool.Add(newGameObject);
        return GetObjectFromPool();
    }

}

