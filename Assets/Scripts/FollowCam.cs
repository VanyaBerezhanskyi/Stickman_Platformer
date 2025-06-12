using UnityEngine;

public class FollowCam : MonoBehaviour
{
    public Transform target;
    public float followSpeed = 2.0f;
    
    void FixedUpdate()
    {
        Vector3 targetPosition = new Vector3(target.position.x, target.position.y, transform.position.z);
        transform.position = Vector3.Slerp(transform.position, targetPosition, followSpeed * Time.deltaTime);
    }
}
