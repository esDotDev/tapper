using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarController : MonoBehaviour
{
    public Rigidbody leftMotor;
    public Rigidbody rightMotor;
    public float speed = 1f;

    private GameController game;
    private Vector3 startPos;

    private void Awake()
    {
        game = FindObjectOfType<GameController>();
        startPos = transform.position;
    }

    public void Reset()
    {
        var pos = leftMotor.transform.localPosition;
        pos.y = 0;
        leftMotor.transform.localPosition = pos;

        pos = rightMotor.transform.localPosition;
        pos.y = 0;
        rightMotor.transform.localPosition = pos;

    }


    private void FixedUpdate()
    {
        if(game.isStarted == false) return;
        float leftSpeed = 0;
        float rightSpeed = 0;

        if (Input.GetKey(KeyCode.A)) {
            leftSpeed = 1;
        } else if (Input.GetKey(KeyCode.Z)) {
            leftSpeed = -1;
        }

        if (Input.GetKey(KeyCode.K))
        {
            rightSpeed = 1;
        }
        else if (Input.GetKey(KeyCode.M))
        {
            rightSpeed = -1;
        }
        Transform board = leftMotor.transform.parent;
        var leftMotorPos = leftMotor.transform.localPosition + Vector3.up * speed * leftSpeed * Time.deltaTime;
        leftMotor.MovePosition(board.TransformPoint(leftMotorPos));

        var rightMotorPos = rightMotor.transform.localPosition + Vector3.up * speed * rightSpeed * Time.deltaTime;
        rightMotor.MovePosition(board.TransformPoint(rightMotorPos));


    }
}
