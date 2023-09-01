using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private InGameManager _inGameManager;
    [SerializeField] private float _jumpForce = 7f;
    
    private HashSet<GameObject> waterCollisions = new HashSet<GameObject>();
    private bool _isJumping = false;
    
    private void Update()
    {
        if (_isJumping == false && Input.GetKeyDown(KeyCode.Space)||(Input.touchCount > 0))
        {
            _rigidbody.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
            _animator.SetTrigger("Jump");
            _isJumping = true;
        }
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Fire"))
        {
            Destroy(collision.gameObject);
            _inGameManager.IncreaseFire();
        }
        
        if (!collision.CompareTag("Water") || waterCollisions.Contains(collision.gameObject)) return;
        _inGameManager.DecreaseFire();
        waterCollisions.Add(collision.gameObject);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _isJumping = false;
        }
    }
    private void OnTriggerExit(Collider collision)
    {
        waterCollisions.Remove(collision.gameObject);
    }
}
