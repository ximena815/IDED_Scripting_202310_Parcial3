using UnityEngine;

[RequireComponent(typeof(Collider))]
[RequireComponent(typeof(Rigidbody))]
public abstract class ObstacleBase : MonoBehaviour
{
    [SerializeField, Layer]
    private int layerToCollideWith;

    [SerializeField]
    [Range(1, 3)]
    private int hp = 1;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer.Equals(LayerMask.NameToLayer(GameUtils.KILLVOLUME_LAYER_NAME)))
        {
            // No notifications here.
            Destroy(gameObject);
        }
        else
        {
            int collisionLayer = collision.gameObject.layer;
            Destroy(collision.gameObject);

            if (collisionLayer.Equals(LayerMask.NameToLayer(GameUtils.BULLET_HARD_LAYER_NAME)))
            {
                hp -= GameUtils.BULLET_HARD_PWR;
            }
            else if (collisionLayer.Equals(LayerMask.NameToLayer(GameUtils.BULLET_MID_LAYER_NAME)))
            {
                hp -= GameUtils.BULLET_MID_PWR;
            }
            else
            {
                hp -= GameUtils.BULLET_LOW_PWR;
            }

            if (hp < 1)
            {
                // TODO: Event to notify object destroyed

                Destroy(gameObject);
            }
        }
    }
}