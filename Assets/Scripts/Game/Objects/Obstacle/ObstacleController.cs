using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    [SerializeField] private float _obstacleSpeed = 30f;
    private void Update()
    {
        transform.Translate(Vector3.back * _obstacleSpeed * Time.deltaTime);
    }
}
