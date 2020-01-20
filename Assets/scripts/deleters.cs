using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deleters : MonoBehaviour
{
	public Text instructor;

	public AudioSource musicSource;
   
	void Start () {
        Destroy(gameObject, 2);

		 instructor.text = "";
        }
	
	
	void Update () {
		 instructor.text = "Push the tringal off the map";

		 musicSource.Play();

                musicSource.loop = false;
	}
}

