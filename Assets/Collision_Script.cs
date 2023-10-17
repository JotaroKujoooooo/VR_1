using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_Script : MonoBehaviour
{
    public int score = 10;
    public void OnCollisionEnter()
    {
        Debug.Log("True");
        score-=1;
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
