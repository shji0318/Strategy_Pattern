using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    static Player _instance;
    Gun _gun;
    
    public static Player Instance { get => _instance; set => _instance = value; }
    public Gun Gun { get => _gun; set => _gun = value; }

    public void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }        
        
    }    

   
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            _gun.Shot();
        }
        else if (Input.GetMouseButton(1))
        {
            _gun.Zoom();
        }
    }
}
