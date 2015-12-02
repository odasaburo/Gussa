using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageTransparency : MonoBehaviour {

    public Color color;
    public float value;
	// Use this for initialization
	void Start () {
        color = this.gameObject.GetComponent<Image>().color;
        color.a = value;
        GetComponent<Image>().color = color;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SetTransparency(float transparency)
    {
        color.a = transparency;
        GetComponent<Image>().color = color;
    }
}
