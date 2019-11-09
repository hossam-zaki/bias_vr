using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floating : MonoBehaviour
{

    public float Increment=0f;
    
    public float Amplitude=0f;
    public float FloatVel=0f;
    public float DeltaPosition;
    public float initPos;
    
    public GameObject button;
    // Start is called before the first frame update
    void Start()
    {
        initPos=transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate() {
        FloatVel+= Increment;
        DeltaPosition=Mathf.Sin(FloatVel) * Amplitude;
        
        transform.position= new Vector3( transform.position.x , (initPos + DeltaPosition), transform.position.z);
    }
}
