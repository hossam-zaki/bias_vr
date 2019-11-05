using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoPlay : MonoBehaviour
{
    public GameObject Sphere;
    public GameObject Sphere2;
    public GameObject Camera;
    public float increment;
    public VideoPlayer[] video;
    

    private float count=0;
    private double  duration;

     MovieTexture video360 ;
    // Start is called before the first frame update
    void Start()
    {
       video360 = (MovieTexture)Sphere.GetComponent<Renderer>().material.mainTexture;
        video360.loop=true;
        video360.Play();
        
     
    }

    // Update is called once per frame
    void Update()
    {
        //duration = video[0].length;
        //Debug.Log(duration);
        count -= increment;
        Camera.transform.rotation=Quaternion.Euler(Camera.transform.rotation.x , Camera.transform.rotation.y + count ,transform.rotation.z );  
        if(Input.GetKeyDown(KeyCode.E)){
            video360.Stop();
            Camera.transform.position = Sphere2.transform.position;
            MovieTexture video360_2 = (MovieTexture)Sphere2.GetComponent<Renderer>().material.mainTexture;
            video360_2.loop=true;
            video360_2.Play();
          
        } 
        
    }

    Color GetRandomColor(){
        return new Color(Random.value, Random.value, Random.value);
    }
}
