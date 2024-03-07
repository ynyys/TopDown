using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    // Varaiables
    [SerializeField]
    private GameObject _bulletPrefab;

    //public GameObject bullet;
    [SerializeField]
    private Transform _gunOffset;
    //public Transform bulletPos;
    [SerializeField]
    private float _timeBetweenShots;

    //private float timer;
    private GameObject _player;

    private bool _fireSingle;
    private float _lastFireTime;

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }
    // Update is called once per frame
    void Update()
    {
        
        float distance = Vector2.Distance(transform.position, _player.transform.position);

        if (distance < 12)
        {
            float timeSinceLastFire = Time.time - _lastFireTime;

            if (timeSinceLastFire >= _timeBetweenShots)
            {
                FireBullet();

                _lastFireTime = Time.time;
                //_fireSingle = false;
            }
        }  
    }

    void FireBullet()
    {
        Instantiate(_bulletPrefab, _gunOffset.position, Quaternion.identity);
    }


}
