using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logMovement : MonoBehaviour{


    public Rigidbody RB;


    // Start is called before the first frame update
    void Start()
    {
        RB.AddForce(0, 0, 200);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
