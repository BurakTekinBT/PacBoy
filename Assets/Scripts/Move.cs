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
    [HideInInspector] --> Hide in inspeector, inspectorde gözüken public deðiþkenini gizler 
    public int sayi;
    [SerializeField]  --> private deðiþkenini inspectorde gösterdir
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
        float xPos = Input.GetAxis("Horizontal") * Time.deltaTime * speed; //GetAxis, Input deðeri alýr Project Settings altýnda Input Managerda kayýtlý olan Horizontal deðerlini alýr
        float zPos = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        movement = new Vector3(xPos, 0f, zPos);

        //transform.position += movement; //Objeye takýlý olan transformun position deðerine movementýn deðeri aktarýlýr.
        //transform.position += movement;
        rigidbody.AddForce(movement);


    }
}
