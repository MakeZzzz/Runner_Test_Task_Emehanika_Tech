using UnityEngine;

public class FireController : MonoBehaviour
{
    [SerializeField] private float _fireSpeed = 30f;
    
    private FireSpawn _fireSpawn;

    private void Start()
    {
        _fireSpawn = FindObjectOfType<FireSpawn>();
    }

    private void Update()
    {
        transform.Translate(Vector3.back * _fireSpeed * Time.deltaTime);
    }

    private void OnDestroy()
    {
        _fireSpawn.RemoveFire(gameObject);
    }
}
