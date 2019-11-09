using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 20f;
    public float jumpForce = 400f;
    public float horizontalMove;
    bool jump = false;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal") * movementSpeed;
        /*if (horizontalMove > 0f)
            transform.localEulerAngles = new Vector3(0,0,0);
        if (horizontalMove < 0f)
            transform.localEulerAngles = new Vector3(0, 180, 0);*/
        if (Input.GetButtonDown("Jump"))
            jump = true;
        if (GetComponent<BaseWarrior>())
            GetComponent<BaseWarrior>().Hit();
        else if(GetComponent<BaseWizard>())
            GetComponent<BaseWizard>().Hit(fireBall_prefab);
        else if (GetComponent<BaseRanger>())
            GetComponent<BaseRanger>().Hit(grenade_prefab);
    }

    private void FixedUpdate()
    {
        Moving(horizontalMove,jump);
    }
    
    void Moving(float movement,bool canJump)
    {
        rb.velocity = new Vector2(movement * movementSpeed * Time.fixedDeltaTime,rb.velocity.y);
        if(canJump && GetComponent<CircleCollider2D>().IsTouchingLayers())
        {
            rb.AddForce(new Vector2(0, jumpForce));
            jump = !canJump;
        }
    }

}
