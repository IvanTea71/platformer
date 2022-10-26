using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawn : MonoBehaviour
{
    [SerializeField] private Coin _template;
    [SerializeField] private List<Transform> _spawns = new List<Transform>();

    private void Start()
    {
        for (int i = 0; i < _spawns.Count; i++)
        {
            Coin coin = Instantiate(_template, Vector3.zero, Quaternion.identity);
            Transform coinTransform = coin.transform;
            coinTransform.position = _spawns[i].transform.position;
        }
    }
}
