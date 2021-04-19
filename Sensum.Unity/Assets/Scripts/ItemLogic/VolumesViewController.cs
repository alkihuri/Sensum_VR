using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LiquidVolumeFX;
public class VolumesViewController : MonoBehaviour
{
    [SerializeField] GameObject _luquidGameObject;
    [SerializeField] LiquidVolume _liquidVolume;
    [SerializeField] GameObject _water;
    public List<float> addVolumes = new List<float>() {0.008f};
    //Все данные измеряются в см.
    private float volume;
    private float rad = 0.2f;
    private float height = 0.25f;
    void Start()
    {
        volume = 3.14f * rad *rad* height;
    }
    public void SetView(Liquid water)
    {
        #region тупо хаrд код шляпа, нужен будет нормально рендер но пока и так сойдет
        _luquidGameObject.transform.localScale = new Vector3(rad, height, rad);
        if(addVolumes.Count<1)
            _liquidVolume.level = (water.GetHeight()) / 25; //total level
        else
        {
            //float prevVolumeHeight = water.GetHeight()/100;
            //for (int i =0; i <addVolumes.Count; i++)
            //{
            //    prevVolumeHeight += GetHeightOfElementVolume(prevVolumeHeight, addVolumes[i]);
            //    _liquidVolume.level = prevVolumeHeight*100/ 25;
            //}
            //Debug.Log(prevVolumeHeight);
            float prevVolume = (water.GetHeight()/100)*3.14f*rad*rad;
            for(int i = 0; i < addVolumes.Count; i++)
            {
                prevVolume += addVolumes[i];
            }
            float prevVolumeHeight = prevVolume / (3.14f * rad * rad);
            Debug.Log(prevVolumeHeight);
            _liquidVolume.level = prevVolumeHeight * 100f / 25f;
        }
        #endregion
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

        }
    }
    private float GetHeightOfElementVolume(float previousVolume,float objectVolume) //находим высоту на которую поднимется жидкость при погружении в неё объекта объёмом Volume
    {
        return (objectVolume)/(3.14f*rad*rad);
    }
    public void GetHeightOfVolume(float waterHeight, float preVolume)
    {
        var t = waterHeight * rad * rad*3.14f;
    }
}
