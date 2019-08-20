using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Movement : MonoBehaviour
{
    public Rigidbody2D Rigidbody;

    public BoxCollider2D Player;

    public float moveStrength = 1;
    public float maxRunSpeed = 1;
    public float jumpStrength = 1;

    public bool isEric = false;

    private bool canJump = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ApplyInput();
        ClampMovement();
    }

    void ApplyInput() {
        Rigidbody.AddForce(Vector2.right * Input.GetAxis("Horizontal") * moveStrength, ForceMode2D.Impulse);

        if (canJump && Input.GetAxis("Jump") == 1) {
            Rigidbody.AddForce(Vector2.up * jumpStrength, ForceMode2D.Impulse);
            canJump = false;
        }

    }

    void OnCollisionEnter2D (Collision2D collidingObject) {
         if (collidingObject.gameObject.tag == "World") {
             canJump = true;
         }
     }

    void ClampMovement()
    {
        float cappedXVelocity = Mathf.Min(Mathf.Abs(Rigidbody.velocity.x), maxRunSpeed) * Mathf.Sign(Rigidbody.velocity.x);
        Rigidbody.velocity = new Vector3(cappedXVelocity, Rigidbody.velocity.y);
    }
}
