using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StoneUIController : MonoBehaviour
{
    public TextMeshProUGUI des ;
    public TextMeshProUGUI mass;
    public TextMeshProUGUI vol;
    [SerializeField] PhysItem pitem;
    // Start is called before the first frame update
    void Start()
    {
        pitem = GetComponent<PhysItem>();
    }

    // Update is called once per frame
    void Update()
    {
        des.text = "Плотность = "  + pitem.preDensity;

        vol.text = "Объем  = " + pitem.preVolume;

        mass.text = "Масса = " + pitem.preMass;

    }
}
