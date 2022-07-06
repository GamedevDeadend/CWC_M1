using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    

    
    
    void Start()
    {
        
        transform.position = new Vector3(3, 4, 1);
        InvokeRepeating("ColorChange", 0.5f,0.2f);
        
    }
    
    void Update()
    {
        transform.Rotate(10.0f * Time.deltaTime, 10.0f*Time.deltaTime, 10.0f*Time.deltaTime);

    }

    void ColorChange()
    {
        Material material = Renderer.material;
        float range = Random.Range(1.0f,10.0f);
        transform.localScale = new Vector3(1,1,1) * (range/3.0f);
        material.color = new Color(range, range, range, 90.0f);
    }
}
