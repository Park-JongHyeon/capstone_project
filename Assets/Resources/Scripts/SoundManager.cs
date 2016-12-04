using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {


	public AudioClip EatClip;
	AudioSource EatSource;

	public static SoundManager soundManager;

	void Awake()
	{
		if (SoundManager.soundManager == null) {
			SoundManager.soundManager = this;
		}
	}
	// Use this for initialization
	void Start () {
		EatSource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	public void PlaySound () {
	
		EatSource.PlayOneShot (EatClip);
	}
}
