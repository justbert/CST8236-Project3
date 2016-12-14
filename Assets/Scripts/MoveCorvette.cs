using UnityEngine;
using System.Collections;

public class MoveCorvette : MonoBehaviour
{

    public float acceleration;
    public float speed;
    public float angleSpeed;
    public float angleY;
    public float angleX;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            speed += acceleration * Time.deltaTime;
        }
        else if (speed > 0)
        {
            speed -= acceleration * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            speed -= acceleration * Time.deltaTime;
        }
        else if (speed < 0)
        {
            speed += acceleration * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            angleY -= Time.deltaTime * angleSpeed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            angleY += Time.deltaTime * angleSpeed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            angleX -= Time.deltaTime * angleSpeed;
        }

        if (Input.GetKey(KeyCode.W))
        {
            angleX += Time.deltaTime * angleSpeed;
        }

        transform.localRotation = Quaternion.Euler(angleX, angleY, 0.0f);
        transform.position -= (transform.forward * speed * Time.deltaTime);
    }

}
