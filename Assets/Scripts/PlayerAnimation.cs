using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public Rigidbody2D Rigidbody;

    public Animator Animator;

    public Transform AnimatorTransform;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Rigidbody.velocity.x != 0) {
            Animator.SetInteger("State", 1);
            if (Rigidbody.velocity.x < 0) {
                AnimatorTransform.localScale = new Vector3(-1, 1, 1);
            } else {
                AnimatorTransform.localScale = new Vector3(1, 1, 1);
            }
        } else {
            Animator.SetInteger("State", 0);
        }
    }
}
