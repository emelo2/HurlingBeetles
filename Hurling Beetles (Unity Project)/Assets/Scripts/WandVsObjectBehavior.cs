using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WandVsObjectBehavior : MonoBehaviour {

    //public GameObject wand;
   // public GameObject obj;
    public Text pointText;
   /* public GameObject syl;
    public GameObject sphere;
    public GameObject capsul;*/

    private int points ;


    // Use this for initialization
    void Start () {
        points = 0;
        SetPointText();

		
	}
	
	// Update is called once per frame
	void Update () {
       // var distance = Vector3.Distance(obj.transform.position, wand.transform.position);

       /* if (distance <= 3 && Input.GetKeyDown("e"))
        {
            Destroy(obj.gameObject);
            points = points +1;
            SetPointText();
        }*/
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("obj"))
        {
            other.gameObject.SetActive(false);
            points = points + 1;
            SetPointText();
        }
    }
    void SetPointText()
    {
        pointText.text = "Score: " + points.ToString();
       
    }
}
