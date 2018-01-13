using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour {
    public string userName = "Name";
    public GameObject controlledCrewmember;
    public GameObject roomText;
    // Use this for initialization
    void Start()
    {
        // roomText = GameObject.FindGameObjectWithTag("UI");
        if (controlledCrewmember != null)
        {
            transform.position = controlledCrewmember.transform.position;
            controlledCrewmember.GetComponent<CrewMember>().player = gameObject;
            controlledCrewmember.GetComponent<CrewMember>().playerControlled = true;
            controlledCrewmember.GetComponent<BoxCollider>().enabled = false;
        }
    }
    private void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Room")
        {
            roomText.GetComponent<Text>().text =  other.gameObject.name;
        }
    }
}
