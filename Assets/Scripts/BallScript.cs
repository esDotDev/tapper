using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    private Vector3 startPos;

    private void Awake()
    {
        startPos = transform.position;
    }


    public void Reset()
    {
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        transform.position = startPos;
    }

    private void OnTriggerEnter(Collider other)
    {
        var gameOver = other.GetComponent<GameOverTrigger>();
        if (gameOver) {
            FindObjectOfType<GameController>().EndGame();
        }
    }
}
