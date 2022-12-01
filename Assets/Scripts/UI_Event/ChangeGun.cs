using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGun : MonoBehaviour
{
    Player _player;
    private void Awake()
    {
        _player = Player.Instance;
        ChangeHandGun();
    }

    public void ChangeHandGun()
    {
        _player.Gun = new HandGun();
        _player.Gun.ZoomableSetting(new ZoomDisable());
    }

    public void ChangeSniperRifle()
    {
        _player.Gun = new SniperRifle();
        _player.Gun.ZoomableSetting(new Zoomable());
    }
}
