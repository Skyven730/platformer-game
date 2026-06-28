using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController cc;
    public float moveSpeed;
    public float jumpForce;
    public float gravity;
    private Vector3 moveDir;

    void Update()
    {   
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Debug.Log("H: " + h + " V: " + v);

        moveDir.x = v * moveSpeed;
        moveDir.z = -h * moveSpeed;

        if (cc.isGrounded)
        {
            moveDir.y = -1f;

            if (Input.GetButtonDown("Jump"))
            {
                moveDir.y = jumpForce;
            }
        }
        else
        {
            moveDir.y -= gravity * Time.deltaTime;
        }

        cc.Move(moveDir * Time.deltaTime);
    }
}
// La suite plus tard