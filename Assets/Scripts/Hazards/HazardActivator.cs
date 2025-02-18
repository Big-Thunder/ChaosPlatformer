using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class HazardActivator : MonoBehaviour
{
    [SerializeField] private Rigidbody2D playerRb;
    private IHazard[] hazards;
    
    // Start is called before the first frame update
    void Start()
    {
        playerRb = FindObjectOfType<PlayerMovementImproved>().GetComponent<Rigidbody2D>();
        hazards = FindObjectsOfType<MonoBehaviour>().OfType<IHazard>().ToArray();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerRb.velocity.magnitude >= 0.05f)
        {
            foreach (IHazard h in hazards)
            {
                h.ActivateHazard(); // All hazards activate
                Debug.Log("Activate");
                //TODO add cam shake to give a sense of urgency and chaos when player moves
            }
        }
        else
        {
            foreach (IHazard h in hazards)
            {
                h.DeactivateHazard(); // All hazards deactivate
                Debug.Log("Deactivate");
            }
        }
    }
}
