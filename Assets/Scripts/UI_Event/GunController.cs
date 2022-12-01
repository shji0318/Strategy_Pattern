using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    Player _player;
    HandGun _hGun;
    SniperRifle _sGun;
    private void Awake()
    {
        _player = Player.Instance;
        
        _hGun = new HandGun();
        _hGun.ZoomableSetting(new ZoomDisable());
        _sGun = new SniperRifle();
        _sGun.ZoomableSetting(new ZoomDisable());

        _player.Gun = _hGun;
    }

    public void ChangeHandGun()
    {
        _player.Gun = _hGun;        
    }

    public void ChangeSniperRifle()
    {
        _player.Gun = _sGun;
    }

    public void ChangeZoomable()
    {
        _player.Gun.ZoomableSetting(new Zoomable());
    }

    public void ChangeZoomDisable()
    {
        _player.Gun.ZoomableSetting(new ZoomDisable());
    }
}
