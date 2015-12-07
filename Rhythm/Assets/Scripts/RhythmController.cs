using UnityEngine;
using System.Collections;

public class RhythmController : MonoBehaviour {

    public GameObject audioManager;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    void Update()
    {
        if (audioManager.gameObject.GetComponent<AudioSource>().clip != null && !audioManager.gameObject.GetComponent<AudioSource>().isPlaying && audioManager.gameObject.GetComponent<AudioSource>().clip.loadState == AudioDataLoadState.Loaded)
        {
            audioManager.gameObject.GetComponent<AudioSource>().Play();
        }
    }
}
