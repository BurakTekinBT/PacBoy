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
        //transform.Rotate(x,y,z,Space.World); //nesnenin lokal lokasyonu ile dünya lokasyonunun X Y Z deðerleri farklý konumdadýr
                                            // Eðer dünya lokasyonuna göre dönsün istersek bu þekilde yapmak gerekir
    }
}
