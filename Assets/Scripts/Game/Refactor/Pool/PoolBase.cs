using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class PoolBase : MonoBehaviour, IPool
{
    [SerializeField]
    private int count = 0;

    [SerializeField]
    private GameObject basePrefab;

    private Queue<GameObject> instances = new Queue<GameObject>();

    private void Start()
    {
        PopulatePool();
    }

    public void RecycleInstance(GameObject instance)
    {
        instance.SetActive(false);
        instances.Enqueue(instance);
        instance.GetComponent<PoolableObject>().OnObjectToRecycle -= RecycleInstance;
    }

    public GameObject RetrieveInstance()
    {
        if (instances.Count == 0)
        {
            GameObject poolableObject = Instantiate(basePrefab, transform.position, Quaternion.identity);
            poolableObject.SetActive(false);
            instances.Enqueue(poolableObject);
        }
        
        GameObject pooledObject = instances.Dequeue();
        pooledObject.SetActive(true);
        pooledObject.GetComponent<PoolableObject>().OnObjectToRecycle += RecycleInstance;
        return pooledObject;
    }

    private void PopulatePool()
    {
        for (int i = 0; i < count; i++)
        {
            GameObject poolableObject = Instantiate(basePrefab, transform.position, Quaternion.identity);
            poolableObject.SetActive(false);
            poolableObject.transform.parent = transform.parent;
            instances.Enqueue(poolableObject);
        }
    }
}