using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperRifle : Gun
{
    public SniperRifle ()
    {
        GunInfoSetting();
    }
    public override void GunInfoSetting()
    {
        _gunInfo._damage = 5;
        _gunInfo._shotDelay = 5;
        _gunInfo._sound = "빵~!";
    }
}
