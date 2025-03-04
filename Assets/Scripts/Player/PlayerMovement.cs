using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement variables")]
    [SerializeField] private float _jumpPower;
    [SerializeField] private float _movementSpeed;
    [SerializeField] private bool _isGrounded;

    [Header("Settings")]
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private LayerMask _groundLayer;    
    [SerializeField] private Transform _groundCheck; 
    [SerializeField] private float _checkRadius;
    [SerializeField] private AnimationCurve _curve;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        _isGrounded = Physics.CheckSphere(_groundCheck.position, _checkRadius, _groundLayer);   
    }   

    public void Move(float direction, bool isJump)
    {
       if (isJump)
        Jump();

       if (Mathf.Abs(direction) > 0.01f)
        {
            HorizontalMovement(direction);            
        }        
    }

    private void Jump()
    {
        if (_isGrounded) 
            _rb.linearVelocity = new Vector2(_rb.linearVelocity.x, _jumpPower);
    }

    private void HorizontalMovement(float direction)
    {
        _rb.linearVelocity = new Vector2(-_curve.Evaluate(direction), _rb.linearVelocity.y);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(_groundCheck.position, _checkRadius);
    }
}
