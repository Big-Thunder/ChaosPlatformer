using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Vector3 offset;
    public Transform playerTrans;
    
    // Start is called before the first frame update
    void Start()
    {
        playerTrans = GameObject.FindWithTag("Player").transform;
        offset = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = offset + playerTrans.position;
    }
}