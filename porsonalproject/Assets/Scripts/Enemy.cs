using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    [SerializeField] GameObject player;
    [SerializeField] ParticleSystem _pSystem;
    Rigidbody rg2d;

    Vector3 pos;
	// Use this for initialization
	void Start () {
        rg2d = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void LookPlayer()
    {
        transform.LookAt(player.transform.position);
    }
    public void MoveEnemy()
    {
        rg2d.AddForce(-transform.forward * 200,ForceMode.Impulse);
        Instantiate(_pSystem, transform.position, Quaternion.identity);
    }
}
