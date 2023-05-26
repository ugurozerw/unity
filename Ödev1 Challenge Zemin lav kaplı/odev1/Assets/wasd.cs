using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wasd : MonoBehaviour
{
    public float speed = 5f; // Topun hareket h�z�

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); // Yatay (A, D) giri�i al
        float moveVertical = Input.GetAxis("Vertical"); // Dikey (W, S) giri�i al

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical); // Hareket vekt�r� olu�tur

        Rigidbody rb = GetComponent<Rigidbody>(); // Topun Rigidbody bile�enine eri�

        rb.AddForce(movement * speed); // Hareketi topa uygula
    }
}