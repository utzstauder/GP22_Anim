using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeOnClick : MonoBehaviour
{
    public GameObject explosionPrefab;
    public float delay = 2f;
    
    private void OnMouseDown()
    {
        Vector3 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        position.z = 0;
        GameObject explosion = Instantiate(explosionPrefab, position , Quaternion.identity);
    }
}
