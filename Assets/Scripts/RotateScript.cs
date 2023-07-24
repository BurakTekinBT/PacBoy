using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
    [SerializeField] private Vector3 angle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(angle);
        //transform.Rotate(x,y,z,Space.World); //nesnenin lokal lokasyonu ile d�nya lokasyonunun X Y Z de�erleri farkl� konumdad�r
                                            // E�er d�nya lokasyonuna g�re d�ns�n istersek bu �ekilde yapmak gerekir
    }
}
