﻿using UnityEngine;
using UnityEngine.UI;

namespace Assets
{
    public class PlayerController : MonoBehaviour
    {

        public float speed;
        public Text countText;
        public Text winText;

        private Rigidbody rb;
        private int count;

        void Start()
        {
            rb = GetComponent<Rigidbody>();
            count = 0;
            SetCountText();
            winText.text = "";
        }

        void FixedUpdate()
        {
            float moveHorizontal = Input.acceleration.x;
            float moveVertical = Input.acceleration.y;

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

            rb.AddForce(movement * speed);
        }

        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Pick Up"))
            {
                other.gameObject.SetActive(false);
                count = count + 1;
                SetCountText();
            }
        }

        void SetCountText()
        {
            countText.text = "Count: " + count.ToString();
            if (count >= 8)
            {
                winText.text = "You Win!";
            }
        }
    }
}