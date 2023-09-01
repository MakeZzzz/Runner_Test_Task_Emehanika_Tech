using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObstacleSpawn : MonoBehaviour
{ 
    [SerializeField] private List<GameObject> _obstaclePrefabs = new List<GameObject>(); 
    [SerializeField] private List<GameObject> _currentObstacles = new List<GameObject>(); 
    public Transform spawnPoint; 
    public float spawnInterval = 3f;

    private void Start()
    {
        StartCoroutine(SpawnObstaclesCoroutine());
    }
    private IEnumerator SpawnObstaclesCoroutine() 
    { 
        while (true) {
                yield return new WaitForSeconds(spawnInterval);
                var currentIndex =Random.Range(0,_obstaclePrefabs.Count);
                var newObstacle = Instantiate(_obstaclePrefabs[currentIndex], spawnPoint.position, Quaternion.identity);
                _currentObstacles.Add(newObstacle);
        }
    }

    public void DestroyObstacles()
    {
        if (_currentObstacles.Count <= 0) return;
        
        foreach (var obj in _currentObstacles)
        {
            Destroy(obj);
        }
        _currentObstacles.Clear();

    }
    public void RemoveObstacle(GameObject gameObject)
    {
        _currentObstacles.Remove(gameObject);
    }
}
