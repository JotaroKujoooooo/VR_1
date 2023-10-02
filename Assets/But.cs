using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Butt : MonoBehaviour
{
    public GameObject cube;
    public void Buttt()
    {
        if (cube.active == false)
        {
            cube.SetActive(true);
        }
        else cube.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
    }
}
