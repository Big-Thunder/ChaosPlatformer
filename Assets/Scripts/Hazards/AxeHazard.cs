using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeHazard : MonoBehaviour, IHazard
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float rotationSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateHazard()
    {
        rb.angularVelocity = Mathf.Lerp(rb.angularVelocity, 1000f, 7f * Time.deltaTime);
    }

    public void DeactivateHazard()
    {
        rb.angularVelocity = Mathf.Lerp(rb.angularVelocity, 0f, 7f * Time.deltaTime);
    }
}
