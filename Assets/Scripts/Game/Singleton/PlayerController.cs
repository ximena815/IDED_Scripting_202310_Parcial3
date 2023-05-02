using UnityEngine;

public sealed class PlayerController : PlayerControllerBase
{
    protected override void Shoot()
    {
        Instantiate(selectedBullet, spawnPos.position, spawnPos.rotation)
                            .AddForce(transform.forward * shootForce, ForceMode.Force);
    }

    protected override void SelectBullet(int index)
    {
        selectedBullet = bulletPrefabs[GameUtils.GetClampedValue(index, bulletPrefabs.Length)];
    }
}