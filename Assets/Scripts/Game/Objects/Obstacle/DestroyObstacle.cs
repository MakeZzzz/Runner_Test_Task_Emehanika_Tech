using UnityEngine;

public class DestroyObstacle : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
       Destroy(collision.gameObject);
    }
}
