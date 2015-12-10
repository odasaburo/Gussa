using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

    public GameObject[] founds_object;
    public GameObject[] checkstate;
    public GameObject[] level_animations;
    public int gamelevel;
    public bool GameAnimationstart;
	// Use this for initialization
	void Start () {
        GameAnimationstart = false;
    }
	
	// Update is called once per frame
	void Update () {
        int count = 0;
        for (int i = 0; i < founds_object.Length; i++)
        {
            if(founds_object[i] == null)
            {
                count++;
            }
        }

        if(count == founds_object.Length)
        {
            Debug.Log("start");
            GameAnimationstart = true;
        }

        int complete = 0;

        for(int i = 0; i < checkstate.Length; i++)
        {
            if (checkstate[i].activeSelf)
            {
                complete++;
            }
        }
        if (complete == checkstate.Length)
        {
            Debug.Log("game complete");
        }
	}

    public void PlayAnimations(string state)
    {
        level_animations[gamelevel].SetActive(true);
        level_animations[gamelevel].GetComponent<Animator>().SetTrigger(state);
    }
}
