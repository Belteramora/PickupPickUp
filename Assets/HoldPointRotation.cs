using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldPointRotation : MonoBehaviour
{
    public void UpdateRotation(Vector3 rotation)
    {
        transform.rotation = Quaternion.Euler(-rotation.x, transform.eulerAngles.y, transform.eulerAngles.z);
    }
}
