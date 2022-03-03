using UnityEngine;

public class PlayerController : Character
{
    public void FollowPath(Vector3 targetPosition)
    {
        //����
        PathRequestManager.Instance.RequestPath(transform.position, targetPosition, CallFollowTarget);
    }

}
