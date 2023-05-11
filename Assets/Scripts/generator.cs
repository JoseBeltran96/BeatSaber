using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generator : MonoBehaviour
{
    public GameObject cube;
    public float spawnTime;
    private GameObject cubeRight;
    private GameObject cubeLeft;

    private void Start()
    {
        Invoke("Spawn", spawnTime);
    }

    public void Spawn()
    {

        if (Random.Range(0, 100) < 70)
        {
            cubeRight = Instantiate(cube, transform.position + Vector3.right * 0.3f, Quaternion.identity);
        }
        if (Random.Range(0, 100) < 70)
        {
            cubeLeft = Instantiate(cube, transform.position + Vector3.left * 0.3f, Quaternion.identity);
        }

        if (cubeRight != null)
        {
            cubeRight.GetComponent<Cube>().lados = Random.Range(0, 3);
        }

        if (cubeLeft != null)
        {
            cubeLeft.GetComponent<Cube>().lados = Random.Range(0, 3);
        }
        
        if (Random.Range(0, 100) < 30 && cubeRight != null)
        {
            cubeRight.GetComponent<Cube>().blue = false;
        }
        else if (cubeLeft != null)
        {
            if (cubeRight == null)
            {
                cubeLeft.GetComponent<Cube>().blue = Random.Range(0, 2) == 0 ? true : false;
            }
            cubeLeft.GetComponent<Cube>().blue = false;


        }

        Invoke("Spawn", spawnTime);
    }
}
