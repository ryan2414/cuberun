using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {
    public float speed = 500f;
    Vector3 dir;

    // Start is called before the first frame update
    void Start() {
        dir = transform.forward;
    }

    // Update is called once per frame
    void Update() {
            transform.position += dir * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.name == "Player" || other.gameObject.name == "Player2") {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
            other.gameObject.GetComponent<Move>().life--;
            Destroy(gameObject, 0.1f);
        }
        
    }
}
