using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TubeUIController : MonoBehaviour
{
    [SerializeField] Text volume; 

    [SerializeField] VolumesViewController tube;
     

    // Update is called once per frame
    void Update()
    {
        volume.text = "volume = " + tube._liquidVolume._level.ToString("#.##");
         
    }
}
