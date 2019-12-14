using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Camera cam;
    public int healthAmount;
    public Text healthText;
    Vector2 movement;
    Vector2 mousePos;

    void Update() {
        this.healthText.text = "Health: " + this.healthAmount.ToString();
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        if(this.healthAmount <= 0) {
            SceneManager.LoadScene("DeathScreen");
        }
    }

    void FixedUpdate() {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Monster") {
            this.healthAmount -= 1;
        }
    }
}