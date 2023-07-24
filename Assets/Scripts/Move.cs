using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    private Vector3 movement;
    private Rigidbody rigidbody;
    //public float xPos, zPos; 

    /*
    [HideInInspector] --> Hide in inspeector, inspectorde g�z�ken public de�i�kenini gizler 
    public int sayi;
    [SerializeField]  --> private de�i�kenini inspectorde g�sterdir
    private int sayi2;
    */
    // Start is called before the first frame update
    void Start()
    {
           rigidbody = GetComponent<Rigidbody>(); // <> casting  
    }

    // Update is called once per frame
    void Update()
    {
        MoveThePlayer();
    }

    private void MoveThePlayer()
    {
        float xPos = Input.GetAxis("Horizontal") * Time.deltaTime * speed; //GetAxis, Input de�eri al�r Project Settings alt�nda Input Managerda kay�tl� olan Horizontal de�erlini al�r
        float zPos = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        movement = new Vector3(xPos, 0f, zPos);

        //transform.position += movement; //Objeye tak�l� olan transformun position de�erine movement�n de�eri aktar�l�r.
        //transform.position += movement;
        rigidbody.AddForce(movement);


    }
}
