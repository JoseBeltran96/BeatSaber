using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public Material materialRed;
    public bool blue;
    public int lados;

    public float velocidad;

    private void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            if (i != lados)
            {
                transform.GetChild(i).gameObject.SetActive(false);
            }
            else if (!blue)
            {
                transform.GetChild(i).GetComponent<MeshRenderer>().material = materialRed;
            }
        }
    }

    private void Update()
    {
        transform.Translate(Vector3.back * velocidad);
    }

    public void collisionDetected(bool _blue)
    {
        if (_blue == blue)
        {
            gameManager.manager.updateScore();
        }
        else
        {
            gameManager.manager.takeDamage();
        }
        Destroy(gameObject);
        GetComponent<Collider>().enabled = false;
    }

    private void OnCollisionEnter(Collision x)
    {
        if (x.gameObject.CompareTag("Left") || x.gameObject.CompareTag("Right") )
        {
            if (x.gameObject.GetComponent<Saber>().direccionSable == lados)
            {
                collisionDetected(x.gameObject.GetComponent<Saber>().azul);
            }
            else
            {
                gameManager.manager.takeDamage();
                Destroy(gameObject);
            }
            
        }
    }
}
