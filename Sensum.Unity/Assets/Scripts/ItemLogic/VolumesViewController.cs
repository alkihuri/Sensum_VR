using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumesViewController : MonoBehaviour
{
    [SerializeField] GameObject _water;

    [SerializeField] GameObject _oil;

    [SerializeField] GameObject _mercury;
    [SerializeField] GameObject _tube;
    private float rad = 1;

    public void SetView(Liquid water, Liquid oil, Liquid mercury)
    {
        #region тупо хаrд код шляпа, нужен будет нормально рендер но пока и так сойдет
        _water.transform.localScale = new Vector3(rad, water.GetVolume(), rad);

        _oil.transform.localScale = new Vector3(rad, oil.GetVolume(), rad);

        _mercury.transform.localScale = new Vector3(rad, mercury.GetVolume(), rad);

        var totalVolume = oil.GetVolume() + water.GetVolume() + mercury.GetVolume();

        var totalHeight = totalVolume + .2f;

        _tube.transform.localScale = new Vector3(rad  +.1f, totalHeight  , rad+.1f);

        

        var basePostion = _tube.transform.position;


        var mercuryPosition = basePostion.y;
        var oilPosition = mercuryPosition  + mercury.GetVolume(); 
        var waterPosition = oilPosition + oil.GetVolume() ;
      
        _mercury.transform.position = basePostion + new Vector3(0, mercuryPosition, 0);
        _oil.transform.position = basePostion + new Vector3(0, oilPosition, 0);
        _water.transform.position = basePostion + new Vector3(0, waterPosition, 0);

        #endregion
    }
}
