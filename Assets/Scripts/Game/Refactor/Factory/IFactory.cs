using UnityEngine;

public interface IFactory
{
    public GameObject RetrieveInstance();

    public void RecycleInstance(GameObject instance);
}