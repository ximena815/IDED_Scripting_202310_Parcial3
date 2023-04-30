using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Player player = new Player();

    [Header("Movement params")]
    [SerializeField]
    [Range(20F, 50F)]
    private float speed = 20F;

    [Header("Shoot params")]
    [SerializeField]
    private Rigidbody[] bulletPrefabs;

    [SerializeField]
    private Transform spawnPos;

    [SerializeField]
    [Range(0F, 500F)]
    private float shootForce = 250F;

    private Rigidbody selectedBullet;

    private float hVal = 0F;
    public string PlayerScore { get => player?.Score.ToString(); }

    // Start is called before the first frame update

    // Update is called once per frame
    private void Update()
    {
        hVal = Input.GetAxis("Horizontal");
        transform.Translate(transform.right * hVal * speed * Time.deltaTime);

        ProcessShooting();
    }

    private void ProcessShooting()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Fire
            if (selectedBullet == null)
            {
                SelectBullet();
            }

            if (spawnPos != null)
            {
                Instantiate(selectedBullet, spawnPos.position, spawnPos.rotation).AddForce(transform.forward * shootForce, ForceMode.Force);
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            //Switch to bullet 1
            SelectBullet();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            //Switch to bullet 2
            SelectBullet(1);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            //Switch to bullet 3
            SelectBullet(2);
        }
    }

    private void SelectBullet(int index = 0)
    {
        selectedBullet = bulletPrefabs[Mathf.Clamp(index, 0, 2)];
    }
}