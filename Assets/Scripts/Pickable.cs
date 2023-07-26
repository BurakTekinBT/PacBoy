using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Pickable : MonoBehaviour
{
    public int gainScore = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
            scoreManager.score += gainScore;
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
        ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
        scoreManager.score += gainScore;
        Destroy(gameObject);
        }
   
    }
}

