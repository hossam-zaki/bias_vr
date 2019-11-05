using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPopup : MonoBehaviour
{

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClosePanle()
    {
        animator.SetBool("play", false);
    }
}


