using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private float _destroyTime = 10f; 
    private float _currentTime = 0f;
    private ObstacleSpawn _obstacleSpawn;

    private void Start()
    {
        _obstacleSpawn = FindObjectOfType<ObstacleSpawn>();
    }

    private void Update()
    {
        _currentTime += Time.deltaTime;
        if (!(_currentTime >= _destroyTime)) return;
        _obstacleSpawn.RemoveObstacle(gameObject);
        Destroy(gameObject);
    }
}
