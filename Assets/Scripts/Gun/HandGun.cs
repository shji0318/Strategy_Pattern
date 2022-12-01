using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGun : Gun
{
    public HandGun ()
    {
        GunInfoSetting();
    }
    public override void GunInfoSetting()
    {
        _gunInfo._damage = 1;
        _gunInfo._shotDelay =1;
        _gunInfo._sound = "탕탕탕!";       
    }
    
}
