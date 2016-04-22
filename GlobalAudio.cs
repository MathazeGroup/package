using UnityEngine;
using System.Collections;

public class GlobalAudio : MonoBehaviour {

    public bool IsMute;
    // Use this for initialization

    void Start()
    {
        int toggle = PlayerPrefs.GetInt("SFX");
        if (toggle == 1) IsMute = true;
        else IsMute = false;
        TunVol();
    }

    public void ToogleVol()
    {
        if (IsMute)
        {
            IsMute = false;
            PlayerPrefs.SetInt("SFX", 0);
            TunVol();
        }
        else
        {
            IsMute = true;
            PlayerPrefs.SetInt("SFX", 1);
            TunVol();
        }
    }
	
    public void TunVol()
    {
        if(IsMute) Camera.main.gameObject.GetComponent<AudioSource>().mute = true;
        else Camera.main.gameObject.GetComponent<AudioSource>().mute = false; ;
    }
	// Update is called once per frame
	void Update () {
	
	}
}
