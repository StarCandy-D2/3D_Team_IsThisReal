using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    Animator animator;
    Rigidbody _rigidbody;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float speed = new Vector2(_rigidbody.velocity.x, _rigidbody.velocity.z).magnitude;
        animator.SetFloat("MoveSpeed", speed);
    }
}
