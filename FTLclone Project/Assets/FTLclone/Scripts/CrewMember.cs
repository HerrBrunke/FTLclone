using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrewMember : MonoBehaviour {
    [LabeledBool("Player Controlled", "AI Controlled")]
    [SerializeField]
    public bool playerControlled = true;
    public GameObject player;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (playerControlled && player != null)
        {
            transform.position = player.transform.position;
            transform.rotation = player.transform.rotation;
        }
	}
}
