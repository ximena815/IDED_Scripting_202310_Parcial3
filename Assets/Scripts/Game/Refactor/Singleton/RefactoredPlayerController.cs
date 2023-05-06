public class RefactoredPlayerController : PlayerControllerBase
{
    protected override bool NoSelectedBullet => throw new System.NotImplementedException();

    protected override void Shoot()
    {
        //base.Shoot();
    }

    protected override void SelectBullet(int index)
    {
        //base.SelectBullet(index);
    }
}