using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField]  ObstacleSpawn _obstacleSpawn;
    [SerializeField] FireSpawn _fireSpawn;
    // private InGameManager _inGameManager;
    //
    // public void Init(InGameManager value) 
    // {
    //     _inGameManager = value;
    //     SetStartPosition();
    // }
    public void SetStartPosition() 
    {
        _fireSpawn.DestroyFires();
        _obstacleSpawn.DestroyObstacles();
    }
}
