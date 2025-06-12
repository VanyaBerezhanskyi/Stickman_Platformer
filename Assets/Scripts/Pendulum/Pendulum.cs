using System.Diagnostics.Contracts;
using UnityEngine;

public class Pendulum : MonoBehaviour
{
    public float speed = 500.0f;
    public float leftAngle = -0.35f;
    public float rightAngle = 0.35f;

    private Rigidbody2D _body;
    private bool _movingClockwise = true;

    void Start()
    {
        _body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        ChangeDirection();

        if (_movingClockwise)
        {
            _body.angularVelocity = speed;
        }

        if (!_movingClockwise)
        {
            _body.angularVelocity = -speed;
        }
    }

    public void ChangeDirection()
    {
        if (transform.rotation.z > rightAngle)
        {
            _movingClockwise = false;
        }

        if (transform.rotation.z < leftAngle)
        {
            _movingClockwise = true;
        }
    }
}
