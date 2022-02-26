using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Playinputs : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnFire(InputValue value) {
        Debug.Log("value is = " + value.Get<bool>());
    }

    public void Jump(InputAction.CallbackContext context) {
        Debug.Log("HOP");
    }

    public void Strafe(InputAction.CallbackContext context) {
        Debug.Log("Strafe");
    }
}
