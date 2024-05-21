using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Transformation;

public class CameraFollower : MonoBehaviour
{
    public Transform mainCamera;
    void Update()
    {
        transform.position = mainCamera.position;
        transform.rotation = new Quaternion(transform.rotation.x, mainCamera.rotation.y, transform.rotation.z, transform.rotation.w);
    }
}
