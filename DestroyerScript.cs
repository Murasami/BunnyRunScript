﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerScript : MonoBehaviour {
    public AudioSource deathSound;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            deathSound.Play();
            Application.LoadLevel(2);
            return;
        }
        if (other.gameObject.transform.parent)
        {
            Destroy(other.gameObject.transform.parent.gameObject);
        }
        else
        {
            Destroy(other.gameObject);
        }
    }
}
