using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcctionButton : MonoBehaviour
{
    public Animator animator;
    public Canvas canvas;
    public Animator Videoanimator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {   
        if(other.tag=="Player"){
                        
            animator.SetBool("Active", true);
        }
        
    }

    public void PlayVideo(){
        animator.SetBool("Active", false);
        Videoanimator.SetBool("DisplayVideo", true);
    }
    
    public void CancelVideo(){
        animator.SetBool("Active", false);
    }
    
}
