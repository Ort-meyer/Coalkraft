using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tractor : MonoBehaviour
{

    public float DEBUGmovespeed;
    public float DEBUGturnSpeed;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * DEBUGmovespeed * Time.deltaTime;
        transform.Rotate(Vector3.up, DEBUGturnSpeed * Time.deltaTime);
    }
}
