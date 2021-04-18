using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LiquidVolumeFX;
public class VolumesViewController : MonoBehaviour
{
    [SerializeField] GameObject _luquidGameObject;
    [SerializeField] LiquidVolume _liquidVolume;
    [SerializeField] GameObject _water;
    //Все данные измеряются в см^3.
    private float volume;
    private float rad = 20f;
    private float height = 25f;
    private float heightOfAdding = 0;
    void Start()
    {
        volume = Mathf.PI * rad *rad* height;
    }
    public void SetView(Liquid water)
    {
        #region тупо хаrд код шляпа, нужен будет нормально рендер но пока и так сойдет
        _luquidGameObject.transform.localScale = new Vector3(rad, height, rad) / 100;
        _liquidVolume.level = Mathf.Max(water.GetHeight(),heightOfAdding) / 25;
        Debug.Log(heightOfAdding);
        #endregion
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SetHeightOfAdding(15,3.5f);
        }
    }
    public void SetHeightOfAdding(float waterHeight, float preVolume)
    {
        var t = waterHeight * rad * rad*Mathf.PI;
        heightOfAdding = (preVolume + t) / (Mathf.PI * rad * rad);
    }
}
