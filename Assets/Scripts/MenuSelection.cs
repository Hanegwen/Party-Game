using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuSelection : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Title()
    {
        SceneManager.LoadScene("Title");
    }

    public void Instructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void Credit()
    {
        SceneManager.LoadScene("Credit");
    }

    public void LevelSelect()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    public void One()
    {
        SceneManager.LoadScene("1");
    }

    public void Two()
    {
        SceneManager.LoadScene("2");
    }

    public void Three()
    {
        SceneManager.LoadScene("3");
    }
}
