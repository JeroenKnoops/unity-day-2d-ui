using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Movement : MonoBehaviour
{
    public Rigidbody2D Rigidbody;

    public BoxCollider2D Player;

    public float moveStrength = 1;
    public float jumpStrength = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D[] hits = new RaycastHit2D[1];
        Player.Raycast(Vector2.down, hits);
        if (hits.Length > 0 && hits[0].distance < 1.5) {
            Debug.Log(hits[0].distance);
            Rigidbody.AddForce(Vector2.right * Input.GetAxis("Horizontal") * moveStrength);
            Rigidbody.AddForce(Vector2.up * Input.GetAxis("Jump") * jumpStrength);
        }
    }
}
