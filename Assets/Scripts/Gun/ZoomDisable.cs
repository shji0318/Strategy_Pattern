using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomDisable : IZoomable
{    
    public void Zoom()
    {
        Debug.Log("조준 할 수 없는 총입니다.");
    }
}
