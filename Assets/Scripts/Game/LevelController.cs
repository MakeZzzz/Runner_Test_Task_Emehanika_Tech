using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField]  ObstacleSpawn _obstacleSpawn;
    [SerializeField] FireSpawn _fireSpawn;

    public void SetStartPosition() 
    {
        _fireSpawn.DestroyFires();
        _obstacleSpawn.DestroyObstacles();
    }
}
