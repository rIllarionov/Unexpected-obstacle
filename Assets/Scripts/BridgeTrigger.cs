using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeTrigger : MonoBehaviour
{
    [SerializeField] private Bridge _bridge;
    [SerializeField] private Outline _playerOutline;
    
    // Start is called before the first frame update


    private void OnTriggerEnter(Collider other)
    {
        if (_playerOutline.OutlineWidth < 2f) 
        {
            _bridge.Break();
        }
    }
}
