using UnityEngine;

[RequireComponent(typeof(Collider))]
[RequireComponent(typeof(Rigidbody))]
public abstract class ObstacleBase : MonoBehaviour
{
    [SerializeField, Layer]
    private int layerToCollideWith;

    private new Collider collider;
    private Rigidbody rb;

    [SerializeField]
    private int hp = 1;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        collider = GetComponent<Collider>();
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer.Equals(LayerMask.NameToLayer(GameConstants.BULLET_HARD_LAYER_NAME)))
        {
        }
        else if (collision.gameObject.layer.Equals(LayerMask.NameToLayer(GameConstants.BULLET_MID_LAYER_NAME)))
        {
        }
        else
        {
        }

        Destroy(gameObject);
    }
}