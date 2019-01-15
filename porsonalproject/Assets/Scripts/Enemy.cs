using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    [SerializeField] GameObject player;
    [SerializeField] ParticleSystem _pSystem;
    Rigidbody2D rg2d;
	// Use this for initialization
	void Start () {
        rg2d = GetComponent<Rigidbody2D>();
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
        rg2d.AddForce(new Vector3(0,100,200));
        _pSystem.transform.position = transform.position;
        _pSystem.Play();
    }
}
