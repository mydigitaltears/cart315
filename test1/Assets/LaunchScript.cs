using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchScript : MonoBehaviour
{
    // Start is called before the first frame update
    public string buttons = "Launch";
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetButton(buttons)){
            this.GetComponent<ConstantForce> ().enabled = true;
        }
        else {
            this.GetComponent<ConstantForce> ().enabled = false;
        }
        
    }
}
