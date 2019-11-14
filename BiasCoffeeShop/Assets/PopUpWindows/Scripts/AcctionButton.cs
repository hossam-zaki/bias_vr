using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class AcctionButton : MonoBehaviour
{
    public Animator animator;
    public Animator Videoanimator;
    public Animator ReplayVideo;
    public VideoPlayer Video;
    public string scene;
    public float CountDown=1000f; 
    public GameObject CoffeeShop;

    private float Timer;
    private float VideoTime=1000f;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        Timer+=Time.deltaTime;
        CountDown= VideoTime- Timer;
        CountDown=Mathf.Clamp(CountDown, 0, VideoTime);

        if(CountDown<50)
        {
            ReplayVideo.SetBool("Active",true);
        }

    }

    public void OnTriggerEnter(Collider other)
    {           
        if(other.tag=="Player")
        {                        
            animator.SetBool("Active", true);
        }
        
    }

    public void PlayVideo(){
        VideoTime=(float)Video.length;
        CountDown=VideoTime;
        Timer=0;
        animator.SetBool("Active", false);
        Videoanimator.SetBool("DisplayVideo", true);
        Video.Play();
        CoffeeShop.SetActive(false);
    }
    
    public void CancelVideo(){
        animator.SetBool("Active", false);
    }


    public void ReviewVideo(){
        
        VideoTime=(float)Video.length;
        Video.Stop();
        Video.Play();
        Timer=0;
        ReplayVideo.SetBool("Active", false);
    }

    public void NextEscene(){
        SceneManager.LoadScene(scene);
    }
    
}
