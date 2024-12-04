using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimations : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    public bool IsMoving { private get; set; }

    public bool IsFlying { private get; set; }

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        _animator.SetBool("IsMoving", IsMoving);
        _animator.SetBool("IsFlying", IsFlying);
    }
    
    public void Jump()
    {
        _animator.SetTrigger("Jump");
    }
    
}
