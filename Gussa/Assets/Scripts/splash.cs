using UnityEngine;
using System.Collections;

public class splash : MonoBehaviour {

    public float count = 0;
	// Use this for initialization
	void Start () {
        count = 0;
	}
	
	// Update is called once per frame
	void Update () {
        count += Time.deltaTime;
        if(count >= 4f)
        {
            Application.LoadLevel("menu");
        }
	}
}
