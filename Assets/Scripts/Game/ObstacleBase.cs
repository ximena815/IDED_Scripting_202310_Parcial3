using UnityEngine;

[RequireComponent(typeof(Collider))]
[RequireComponent(typeof(Rigidbody))]
public abstract class ObstacleBase : MonoBehaviour
{
    [SerializeField, Layer]
    private int layerToCollideWith;

    private new Collider collider;
    private Rigidbody rb;

    // Start is called before the first frame update
    private void Start()
    {
        collider = GetComponent<Collider>();
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer.Equals(layerToCollideWith))
        {
            //Event to update score
        }

        Destroy(gameObject);
    }
}