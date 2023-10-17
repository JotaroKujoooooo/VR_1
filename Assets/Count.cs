using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count : MonoBehaviour
{
    public Text CounterText;
    public Collision_Script Cube;
    void Start()
    {
        
    }
    void FixedUpdate()
    {
        CounterText.text = "Score value is " + Cube.score;
    }
}
