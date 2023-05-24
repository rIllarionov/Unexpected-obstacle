using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightStarter : MonoBehaviour
{
    [SerializeField] private Collider _player;
    private Outline _outline;

    private void Awake()
    {
        _outline = _player.GetComponent<Outline>();
    }
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other ==_player)
        {
            _outline.OutlineWidth = 2f;
            Destroy(gameObject);
        }
    }
}
