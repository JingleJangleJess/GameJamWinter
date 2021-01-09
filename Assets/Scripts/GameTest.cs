using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTest : MonoBehaviour
{
    public GameObject crackerL; //
    public GameObject crackerR;
    public float lStrength; //your cracker's strength
    public float rStrength; //the enemy cracker's strength
    private Timer timer;
    private Score score;
    private bool timeUp = false;
    // Start is called before the first frame update
    void Start()
    {
        timer = gameObject.GetComponent<Timer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timeUp == false && Input.GetKeyDown("space")) 
        { 
            lStrength += 1;//increment strength every keypress
            crackerL.GetComponent<Transform>().position = new Vector2();//wobble the cracker
        }
        //https://forum.unity.com/threads/shake-an-object-from-script.138382/
    }
    void TimeUp() 
    {
        timeUp = true;
        if (lStrength >= rStrength) { score.SendMessage("GameWin"); }
        else if (rStrength >= lStrength) { score.SendMessage("GameLose"); }
    }

    
}
