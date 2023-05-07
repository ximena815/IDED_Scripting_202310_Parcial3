using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolableObject : MonoBehaviour
{
    public event Action<GameObject> OnObjectToRecycle;

    public void RecycleObject()
    {
        if (OnObjectToRecycle != null && gameObject != null) OnObjectToRecycle(gameObject);
    }
    
    public IEnumerator Cycle(float lifeTime)
    {
        yield return new WaitForSeconds(lifeTime);
        if (OnObjectToRecycle != null && gameObject != null) RecycleObject();
    }
}
