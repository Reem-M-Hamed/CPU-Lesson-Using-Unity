using UnityEngine;
using System.Collections;

public class Rotate3D : MonoBehaviour
{

    public float minX = -360.0f;
    public float maxX = 360.0f;

    public float minY = -360.0f;
    public float maxY = 360.0f;

    public float sensX = 100.0f;
    public float sensY = 100.0f;

    float rotationY = -260f;
    float rotationX = 190f;

    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            rotationX += Input.GetAxis("Mouse X") * sensX * Time.deltaTime;
            rotationY += Input.GetAxis("Mouse Y") * sensY * Time.deltaTime;
            rotationY = Mathf.Clamp(rotationY, minY, maxY);
            transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
        }
    }
}
