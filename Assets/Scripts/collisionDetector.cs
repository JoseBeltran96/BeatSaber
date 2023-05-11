using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionDetector : MonoBehaviour
{
    private void OnCollisionEnter(Collision x)
    {
        if (x.gameObject.CompareTag("Left"))
        {
            GetComponentInParent<Cube>().collisionDetected(false);
        }
        else if(x.gameObject.CompareTag("Right"))
        {
            GetComponentInParent<Cube>().collisionDetected(true);
        }
    }
}
