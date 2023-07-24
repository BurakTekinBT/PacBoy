using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isColided = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision) //Herhangi bir obje fiziksel etkileþime girince çalýþýr
    {

        if(isColided== false)
        {
            Debug.Log(collision.gameObject.name);
            GetComponent<MeshRenderer>().material.color = Color.red;

            ScoreManager scoreManager = FindAnyObjectByType<ScoreManager>();
            scoreManager.score--;

            isColided = true;
        }

    }
}
