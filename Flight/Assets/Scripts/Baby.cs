using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baby : MonoBehaviour {
    public int id;
    public GameObject current;

	// Use this for initialization
	void Start () {
        int random = Random.Range(0, 4);
        if (id == random)
        {
            current.SetActive(false);
        }
	}
	
	void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "destroy")
        {
            current.SetActive(false);
        }
    }
}
