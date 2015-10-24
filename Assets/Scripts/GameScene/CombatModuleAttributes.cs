﻿using UnityEngine;
using System.Collections;

public class CombatModuleAttributes : MonoBehaviour {

    public float health;

    public float damage;



	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ModifyHealth(float a_modint)
    {
        health += a_modint;

        if (health <= 0)
        {
            if (this.gameObject.tag == "Enemy")
            {
                GameObject.Find("GameController").GetComponent<WaveController>().KilledEnemy();
                GameObject.Find("Player").GetComponent<PlayerStats>().AdjustSquareBucks(100);
            }
            Destroy(this.gameObject);
        }
    }

    
}
