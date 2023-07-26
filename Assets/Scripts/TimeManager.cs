using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    [SerializeField] float gameTime = 10f;
    public bool gameOver = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > gameTime && gameOver==false)
        {
            gameOver = true;
            Debug.Log("Next Level");
        }
        else
        {
            gameOver = false;
            Debug.Log("You Failed! Restart!");
        }
        
    }
}
