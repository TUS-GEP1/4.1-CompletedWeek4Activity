using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableGravity : MonoBehaviour
{
    public Rigidbody2D theRB;
    // Start is called before the first frame update
    void Start()
    {
        theRB.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
