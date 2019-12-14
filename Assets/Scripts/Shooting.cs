using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {
    public Transform firePoint;
    public GameObject cardPrefab;
    public float bulletForce = 20f;
    // Update is called once per frame
    void Update() {
        if(Input.GetButtonDown("Fire1")) {
            Debug.Log("Shooting");
            Shoot();
        }
    }

    void Shoot() {
        GameObject card = Instantiate(cardPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = card.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
