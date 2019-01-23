using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddlesBehav : MonoBehaviour
{
    // Start is called before the first frame update
    public string buttons = "LeftFlipper";
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetButton(buttons)){
            this.GetComponent<HingeJoint> ().useMotor = true;
        }
        else {
            this.GetComponent<HingeJoint> ().useMotor = false;
        }
    }   
}
