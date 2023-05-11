using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public int health;
    public int score;

    public static gameManager manager;

    private void Start()
    {
        manager = this;
    }

    public void updateScore()
    {
        score++;
        transform.GetChild(1).GetComponent<Text>().text = "Puntos: " + score;
    }

    public void takeDamage()
    {
        health--;
        transform.GetChild(0).GetComponent<Text>().text = "Vidas: " + health;
    }
}
