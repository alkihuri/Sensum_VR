using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mixer : MonoBehaviour
{
    [SerializeField] TubeItem main;
    private void OnTriggerEnter(Collider other)
    {
        
        // if (other.gameObject.GetComponent<TubeItem>())
        // {
        //     Debug.Log("Triggered with... ");
        //     MixShit(main, other.gameObject.GetComponent<TubeItem>());
        // }
    }
}
