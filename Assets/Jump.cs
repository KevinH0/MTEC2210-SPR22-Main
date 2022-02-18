using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class Jump : MonoBehaviour
{
    public StarterAssetsInputs _input;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_input.jump)
        {

            Debug.Log("Jump_");
        }
    }
}
