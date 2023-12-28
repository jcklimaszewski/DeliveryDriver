using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject focusedObject;
    void LateUpdate()
    {
        transform.position = focusedObject.transform.position + new Vector3(0, 0, -10);
    }
}
