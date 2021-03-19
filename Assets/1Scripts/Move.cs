using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    public float speed = 5f;
    public int life = 5;
    //float jumpPower = 10f;
    public Text lifeUI;

    Rigidbody rig;

    // Start is called before the first frame update
    void Start() {
        rig = GetComponent<Rigidbody>();
        lifeUI.text = $"{gameObject.name} : {life}";
    }

    float h;
    float v;

    // Update is called once per frame
    void Update() {
        PlayerMove();
        Life(gameObject);

    }

    public void Life(GameObject player) {
        lifeUI.text = $"{gameObject.name} : {life}";

        if (life == 0) {
            GameManager.instace.GameFinish(player);
        }
    }

    void PlayerMove() {
        if (gameObject.name == "Player") {
            h = Input.GetAxis("Horizontal");
            v = Input.GetAxis("Vertical");
        } else if (gameObject.name == "Player2") {
            h = Input.GetAxis("Horizontal2");
            v = Input.GetAxis("Vertical2");
        }

        Vector3 dir = new Vector3(h, 0, v);
        dir.Normalize();

        //transform.position += dir * speed * Time.deltaTime;

        rig.AddForce(dir * speed * Time.deltaTime);
        //if (Input.GetButtonDown("Jump") ) {
        //    rig.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        //}
    }
}
