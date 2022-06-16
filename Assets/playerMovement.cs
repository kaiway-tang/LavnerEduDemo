using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField] Vector3 spd, jump;
    [SerializeField] Rigidbody2D rb;
    Transform trfm;
    bool canJump;
    // Start is called before the first frame update
    void Start()
    {
        trfm = transform;
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W)) && canJump)
        {
            rb.velocity = jump;
            Invoke("DisableJump",.02f);
        }
    }
    void DisableJump() { canJump = false; }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            trfm.position -= spd;
        }
        if (Input.GetKey(KeyCode.D))
        {
            trfm.position += spd;
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        canJump = true;
    }
}
