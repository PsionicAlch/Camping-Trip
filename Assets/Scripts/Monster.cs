using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour {
    public int health = 5;
    public float speed = 3f;
    Transform playerPos;
    public Rigidbody2D rb;

    void Update() {
        this.playerPos = GameObject.FindGameObjectWithTag("Player").transform;

        if(this.health <= 0) {
            Destroy(gameObject);
        }

        Vector2 lookDir = (Vector2)playerPos.position - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;

        transform.Translate(new Vector3(speed * Time.deltaTime,speed * Time.deltaTime,0));
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Card") {
            this.health -= 1;
        }
    }
}
