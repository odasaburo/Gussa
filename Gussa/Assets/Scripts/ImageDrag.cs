using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ImageDrag : MonoBehaviour {

    public Vector2 offset;
    public GameObject whiteobject;
    public bool dragState;
    public bool upstate;
    public Vector2 oldpos;
    public string gamelevelName;
    public string animationstate;
    // Use this for initialization
    void Start () {
         oldpos = GetComponent<Transform>().position;
	}

	// Update is called once per frame
	void Update () {

	}

    public void DownEvent()
    {
        if (dragState)
        {
            GetComponent<Transform>().position = new Vector3( Input.mousePosition.x, Input.mousePosition.y);
        }
    }

    public void UpEvent()
    {
        if (upstate)
        {
            whiteobject = GameObject.Find(this.gameObject.name.ToString() + "1");
            if (GetComponent<Transform>().position.x + offset.x > whiteobject.GetComponent<Transform>().position.x &&
               GetComponent<Transform>().position.x - offset.x < whiteobject.GetComponent<Transform>().position.x &&
               GetComponent<Transform>().position.y + offset.y > whiteobject.GetComponent<Transform>().position.y &&
               GetComponent<Transform>().position.y - offset.y < whiteobject.GetComponent<Transform>().position.y)
            {
                whiteobject.GetComponent<Image>().sprite = GetComponent<Image>().sprite;
                whiteobject.GetComponent<ImageDrag>().dragState = true;
                Destroy(this.gameObject);
            }
            else {
                GetComponent<Transform>().position = oldpos;
            }
        }
        else if (GameObject.Find(gamelevelName).GetComponent<LevelManager>().GameAnimationstart)
        {
            animationstate = "putdough";
            GameObject.Find(gamelevelName).GetComponent<LevelManager>().PlayAnimations(animationstate);
        }
        else
        {
            GetComponent<Transform>().position = oldpos;
        }
    }
}
