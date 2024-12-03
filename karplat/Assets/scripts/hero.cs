using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;
public class hero : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Vector3 _input;

    private Rigidbody2D _rigidbody;
    private CharacterAnimations _animations;
    [SerializeField] private SpriteRenderer _Idle_0;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animations = GetComponentInChildren<CharacterAnimations>();
    }

    private void FixedUpdate()
    {
        Move();
    }


    private void Move()
    {
        _input = new Vector2(Input.GetAxis("Horizontal"), 0);
        transform.position += _input * _speed * Time.deltaTime;
        _isMoving = _input.x != 0 ? true : false;

        if(_input.x != 0)
        {
            _Idle_0.flipX = _input.x > 0 ? false : true;
        }


        _animations.IsMoving = _isMoving;



    }

}






























