using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStick : MonoBehaviour {
    public GameObject campFire;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Stick") {
            this.campFire.GetComponent<CampFire>().PickUpStick();
        }
    }
}
