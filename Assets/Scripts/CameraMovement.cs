using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
    Vector3 offset = new Vector3(0, 0, -11);
    void Update() {
        transform.position = GameObject.FindGameObjectWithTag("Player").transform.position + offset;
    }
}
