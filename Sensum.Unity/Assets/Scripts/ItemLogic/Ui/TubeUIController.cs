using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TubeUIController : MonoBehaviour
{
    [SerializeField] Text water;
    [SerializeField] Text oil;
    [SerializeField] Text mercury;

    [SerializeField] TubeItem tube;
     

    // Update is called once per frame
    void Update()
    {
        water.text = "water : " +  tube._water.GetHeight();
    }
}
