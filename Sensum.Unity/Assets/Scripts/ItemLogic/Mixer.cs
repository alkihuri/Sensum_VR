using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mixer : MonoBehaviour
{
    [SerializeField] TubeItem main;
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.GetComponent<TubeItem>())
        {
            Debug.Log("Triggered with... ");
            MixShit(main, other.gameObject.GetComponent<TubeItem>());
        }
    }
    void MixShit(TubeItem a, TubeItem b)
    {
        a._water.AddVolume(b._water.GetVolume()); //  ну чем не исскуство, с этими ващими правилами бы всякие адаптеры мутили бы
        a._oil.AddVolume(b._oil.GetVolume());
        a._mercury.AddVolume(b._mercury.GetVolume());

        b._water.AddVolume(-b._water.GetVolume()); // просто на голодный желудок что за говнокод
        b._oil.AddVolume(-b._oil.GetVolume()); // чисто обнуляемся как ВВП
        b._mercury.AddVolume(-b._mercury.GetVolume());


        //Destroy(b.gameObject); // поматросил и бросил как говориться
    }
}
