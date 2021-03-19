//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Move_2P : MonoBehaviour {
//    public float speed = 5f;
//    float jumpPower = 10f;

//    bool isJump;

//    Rigidbody rig;
//    CharacterController cc;

//    // Start is called before the first frame update
//    void Start() {
//        rig = GetComponent<Rigidbody>();
//    }

//    // Update is called once per frame
//    void Update() {


//        Vector3 dir = new Vector3(h, 0, v);
//        dir.Normalize();

//        //transform.position += dir * speed * Time.deltaTime;

//        rig.AddForce(dir * speed * Time.deltaTime);
//        if (Input.GetButtonDown("Jump")) {
//            rig.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);


//        }

//    }
//}
