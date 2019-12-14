using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour {
    void Update() {
        Destroy(gameObject, 5);
    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Monster") {
            Destroy(gameObject);
        }
    }
}
