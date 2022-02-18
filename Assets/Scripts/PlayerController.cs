using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    float move_horizontal;
    float move_vertical;
    public float jump_force;
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        move_horizontal = Input.GetAxis("Horizontal");
        move_vertical = Input.GetAxis("Vertical");

        Move(move_horizontal, move_vertical);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    void Move(float horizontal, float vertical)
    {
        Vector3 position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
        this.transform.position = position + Vector3.forward * horizontal * speed + Vector3.right * vertical * speed;
    }

    void Jump()
    {
        this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * jump_force);
    }
}