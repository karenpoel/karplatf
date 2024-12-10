using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;
public class Character : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private Vector3 _groundCheckOffset;
    [SerializeField] private LayerMask groundMask;


    public GameManager _gameManager;
    private Vector3 _input;
    private bool _isMoving;
    private bool _IsGrounded;
    private bool _IsFlying;
    
    private Rigidbody2D _rigidbody;
    private CharacterAnimations _animations;
    [SerializeField] private SpriteRenderer _Idle_0;

    public static Character Instance { get; set; }
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animations = GetComponentInChildren<CharacterAnimations>();
    }

    private void Update()
    {
        Move();
        CheckGround();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_IsGrounded)
            {
                Jump();
                _animations.Jump();
            }
            
        }
        _animations.IsMoving = _isMoving;
        _animations.IsFlying = IsFlying();
    }

    private bool IsFlying()
    {
        if(_rigidbody.velocity.y < 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    private void CheckGround()
    {
        float rayLength = 0.3f;
        Vector3 rayStartPosition = transform.position + _groundCheckOffset;
        RaycastHit2D hit = Physics2D.Raycast(rayStartPosition, rayStartPosition + Vector3.down, rayLength, groundMask);

        if (hit.collider != null)
        {
            _IsGrounded = hit.collider.CompareTag("Ground") ? true : false;
        }
        else
        {
            _IsGrounded = false;
        }
    }

    private void OnCollision2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Die();
        }
    }

    private void Die()
    {
        
        Debug.Log("Игрок умер!");
       
    }


    private void Move()
    {
        _input = new Vector2(Input.GetAxis("Horizontal"), 0);
        transform.position += _input * _speed * Time.deltaTime;
        _isMoving = _input.x != 0 ? true : false;

        if (_isMoving)
        {
            _Idle_0.flipX = _input.x > 0 ? false : true;
        }


        _animations.IsMoving = _isMoving;



    }

    private void Jump()
    {
        Debug.Log("Jump");
        _rigidbody.AddForce(transform.up * _jumpForce, ForceMode2D.Impulse);
    }

}






























