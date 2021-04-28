using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableZoneSettings : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.GetComponent<Grabber>())
        {
            other.gameObject.transform.position = other.gameObject.GetComponent<Grabber>().startOnePosition;
            other.gameObject.transform.rotation = other.gameObject.GetComponent<Grabber>().startOneRotation;
        }
    }
}
