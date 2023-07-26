using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Transform target;
    [SerializeField] private float speed = 3f;
    [SerializeField] private float maxDistance = 1f;
    // Start is called before the first  frame update
    void Start()
    {
        target = GameObject.FindWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);

        float distance = Vector3.Distance(transform.position, target.position);

        if (distance > maxDistance)
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        else
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            TimeManager timeManager = new TimeManager();
            timeManager.gameOver = true;


        }
    }
}
