using UnityEngine;

public class SingletonBase<T> : MonoBehaviour
{
    public static T Instance { get; protected set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = GetComponent<T>();
        }
        else
        {
            Destroy(gameObject);
        }
    }
}