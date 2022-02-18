using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform gunNozzle;
    // Start is called before the first frame update
    float speed = 5000f;
    void Start()
    {
        //This is the debug script with a test fire using middle mouse.
    }

    // Update is called once per frame
    private void Update()
    {
        Ray myRay = new Ray(transform.position, transform.forward);
        RaycastHit rayHit;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("W");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("S");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("D");
        }
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("You pressed here" + Input.mousePosition);
        }
        if (Input.GetMouseButtonDown(2))
        {
            Debug.Log("MIDDLE MOUSE KEY");
            if (Physics.Raycast(myRay, out rayHit, Mathf.Infinity))
            {
                Debug.Log("Distance: " + rayHit.distance);
                if (rayHit.transform.gameObject.GetComponent<Enemy>())
                {
                    Debug.Log("ENEMY!");
                    Shoot();
                }
                if (rayHit.transform.gameObject.GetComponent<Terrain>())
                {
                    Debug.Log("TERRAIN!");
                    Shoot();
                }

            }
        }
    }
    private void Shoot()
    {
        GameObject go = Instantiate(bulletPrefab, gunNozzle.position, Quaternion.identity);
        go.GetComponent<Rigidbody>().AddForce(gunNozzle.forward * speed);
    }

    void Jump()
    {
        Debug.Log("Jump!");
    }

}