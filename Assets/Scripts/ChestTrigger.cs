using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestTrigger : MonoBehaviour
{
    [SerializeField] private Chest _chest;
    [SerializeField] private Collider _playerCollider;
    // Start is called before the first frame update



    private void OnTriggerEnter(Collider other)
    {
        if (other ==_playerCollider)
        {
            _chest.Open();
        }
    }
}
