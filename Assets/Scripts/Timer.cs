using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    public GameObject target;//target gameobject to send message to
    public float timer;
    private float currentTime;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = timer;
    }
    private void OnEnable()
    {
        currentTime = timer;
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void TimerFunc() 
    {
        currentTime -= 1 * Time.deltaTime;
        if (currentTime <= 0) { target.SendMessage("TimeUp"); }
    }
}
