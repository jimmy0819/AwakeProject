using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatWaving : MonoBehaviour
{
    // Start is called before the first frame update
    public float a = 0.3f;
    float h = 0;
    float b = 1;
    float k = 0;
    public float speed = 0.1f;
    float x = 0;
    public float xoffset = 0;
    public float yoffset = 0;
    public float zoffset = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x+=speed;
        float wave = a * Mathf.Sin((x-h)/b)+ k;
        var origin = gameObject.transform.position;
        gameObject.transform.position = new Vector3(origin.x+wave*xoffset,origin.y+wave*yoffset,origin.z+wave*zoffset);
        if(x> (2*Mathf.PI*b)){
            x-=(2*Mathf.PI*b);
        }
    }
}
