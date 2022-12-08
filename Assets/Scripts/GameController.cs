using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Transform endGameUI;
    public BarController bar;
    public BallScript ball;

    public bool isStarted {
        get;
        private set; 
    }

    private void Start()
    {
        StartGame();
    }

    public void StartGame()
    {
        if (isStarted) return;
        endGameUI.gameObject.SetActive(false);
        isStarted = true;
        ball.Reset();
        bar.Reset();
    }

    public void EndGame() {
        if (!isStarted) return;
        endGameUI.gameObject.SetActive(true);
        isStarted = false;
    }
}
