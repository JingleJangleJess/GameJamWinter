using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject WinObj;
    public GameObject LoseObj;
    private Image WinImg;
    private Image LoseImg;
    
    void Start()
    {
        WinImg = WinObj.GetComponent<Image>();
        LoseImg = LoseObj.GetComponent<Image>();
    }
    void Update()
    {
        
    }
    void GameWin() 
    {
        Debug.Log("Won!");
    }
    void GameLose() 
    {
        Debug.Log("Lost :c");
    }
}
