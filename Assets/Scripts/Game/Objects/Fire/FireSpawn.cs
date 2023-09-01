using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class FireSpawn : MonoBehaviour
{
    [SerializeField] private List<GameObject> _currentfires = new List<GameObject>();
    [SerializeField] private List<Transform> _spawnPoints = new List<Transform>();
    [SerializeField] private GameObject _fire;
    [SerializeField] private float _spawnInterval = 10f;
    
    private void Start() 
    {
       StartCoroutine(SpawnFiresCoroutine());
    }

    private IEnumerator SpawnFiresCoroutine() 
    {
        while (true) {
            yield return new WaitForSeconds(_spawnInterval);
            var currentPointIndex = Random.Range(0, _spawnPoints.Count);
            var newFire = Instantiate(_fire, _spawnPoints[currentPointIndex].position, Quaternion.identity);
            _currentfires.Add(newFire);
        }
    }
    public void DestroyFires()
    {
        foreach (var obj in _currentfires)
        {
            Destroy(obj);
        }
        _currentfires.Clear();
    }
    public void RemoveFire(GameObject gameObject)
    {
        _currentfires.Remove(gameObject);
    }
}
