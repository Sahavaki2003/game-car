using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField]
    float speed = 800;
    private float moveX;
    public WheelJoint2D Wheel1;
    void OnMove(InputValue move)
    {
        Vector2 movement = move.Get<Vector2>();
        moveX = movement.x * speed;
    }
    private void FixedUpdate()
    {
        if (moveX == 0f)
        {
            Wheel1.useMotor = false;
        }
        else
        {
            Wheel1.useMotor = true;
            JointMotor2D vantoc = new JointMotor2D();
            vantoc.motorSpeed = -moveX;
            vantoc.maxMotorTorque = Wheel1.motor.maxMotorTorque;//1000
            Wheel1.motor = vantoc;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
