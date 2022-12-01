using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Gun 
{
    public GunInfo _gunInfo;
    IZoomable _zoomable;
    

    public void Shot ()
    {
        Debug.Log($@"총을 쏩니다 {_gunInfo._sound} : 데미지 = {_gunInfo._damage} ");
    }

    public void Zoom ()
    {
        _zoomable.Zoom();
    }

    public abstract void GunInfoSetting();

    public void ZoomableSetting (IZoomable zoomable)
    {
        _zoomable = zoomable;
    }
   
    
}
