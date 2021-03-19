﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public GameObject target;
    Vector3 offset;

    private void Start() {
        offset = transform.position - target.transform.position;
    }
    private void Update() {
        transform.position =target.transform.position + offset;
    }

}
