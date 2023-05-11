using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saber : MonoBehaviour
{
    public int direccionSable;
    private Vector3 ultPosicion;
    public bool azul;

    private void FixedUpdate()
    {
        Vector3 direccion = transform.position - ultPosicion;

        if (Mathf.Abs(direccion.x) > Mathf.Abs(direccion.y))
        {
            if (direccion.x < 0)
            {
                direccionSable = 2;
            }
            else
            {
                direccionSable = 3;
            }
        }
        else
        {
            if (direccion.y < 0)
            {
                direccionSable = 0;
            }
            else
            {
                direccionSable = 1;
            }
        }

        ultPosicion = transform.position;
    }
}
