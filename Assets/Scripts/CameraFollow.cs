using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [SerializeField] private Transform target;
    [SerializeField] private float cameraFollowSpeed;
    private Vector3 dist;
    // Start is called before the first frame update
    void Start()
    {
        dist = DistanceCamtoBall(target);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveTheCamera();
    }

    private void MoveTheCamera()
    {
        //transform.position = target.position + dist; //ilk y�ntem
        //Geli�mi� yumu�ak y�ntem
        Vector3 targetMove = target.position + dist;
        transform.position = Vector3.Lerp(transform.position, targetMove, cameraFollowSpeed);

        transform.LookAt(target.transform.position);// a��y� verece�imiz nesneye hedefler. Kamera s�rekli topa bakacak
    }

    private Vector3 DistanceCamtoBall(Transform newTarget) 
    {
        return  transform.position - newTarget.position; //direkt transform.position atanan nesnenin pozisyonunu al�r
    }
}
