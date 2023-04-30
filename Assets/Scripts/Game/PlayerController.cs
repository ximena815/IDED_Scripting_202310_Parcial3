using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Player player = new Player();

    [SerializeField]
    private Rigidbody[] bulletPrefabs;

    private Rigidbody selectedBullet;

    [SerializeField]
    private Transform spawnPos;

    [SerializeField]
    private static float shootForce;

    public string PlayerScore { get => player?.Score.ToString(); }

    // Start is called before the first frame update

    // Update is called once per frame
    private void Update()
    {
        ProcessInput();
    }

    private void ProcessInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Fire
            if (selectedBullet != null && spawnPos != null)
            {
                Instantiate(selectedBullet, spawnPos.position, spawnPos.rotation).AddForce(transform.forward * shootForce, ForceMode.Force);
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            //Switch to bullet 1
            selectedBullet = bulletPrefabs[0];
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            //Switch to bullet 2
            selectedBullet = bulletPrefabs[1];
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            //Switch to bullet 3
            selectedBullet = bulletPrefabs[2];
        }
    }
}