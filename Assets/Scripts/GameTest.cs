using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTest : MonoBehaviour
{
    public GameObject crackerL;
    public GameObject crackerR;
    public float lStrength;
    private float rStrength;
    private Timer timer;
    private bool timeUp = false;
    // Start is called before the first frame update
    void Start()
    {
        timer = gameObject.GetComponent<Timer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timeUp == false && Input.GetKeyDown("space")) { lStrength += 1; } //increment strength every keypress
    }
    void TimeUp() 
    {
        timeUp = true;
        if (lStrength >= rStrength) {}
    }

    
}
