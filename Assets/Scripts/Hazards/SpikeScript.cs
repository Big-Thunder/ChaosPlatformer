using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SpikeScript : MonoBehaviour, IHazard
{
    [SerializeField] private Transform spikeContainer;
    [SerializeField] private float activatedPosition;
    [SerializeField] private float deactivatedPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        spikeContainer = transform.Find("SpikeContainer");
        deactivatedPosition = spikeContainer.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateHazard()
    {
        spikeContainer.position = Vector2.Lerp(spikeContainer.position, new Vector2(spikeContainer.position.x, activatedPosition), 7f * Time.deltaTime);
    }

    public void DeactivateHazard()
    {
        spikeContainer.position = Vector2.Lerp(spikeContainer.position, new Vector2(spikeContainer.position.x, deactivatedPosition), 7f * Time.deltaTime);
    }
}
