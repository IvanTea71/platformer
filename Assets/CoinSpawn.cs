using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawn : MonoBehaviour
{
    [SerializeField] private GameObject _template;
    [SerializeField] private List<GameObject> _spawns = new List<GameObject>();

    private void Start()
    {
        for (int i = 0; i < _spawns.Count; i++)
        {
            GameObject coin = Instantiate(_template, Vector3.zero, Quaternion.identity);
            Transform enemyTransform = coin.GetComponent<Transform>();
            enemyTransform.position = _spawns[i].transform.position;
        }
    }
}
