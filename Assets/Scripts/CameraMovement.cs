using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float cameraSpeed = 1f;


    void Update()
    {
        transform.position += Vector3.right * cameraSpeed * Time.deltaTime;
    }
}
