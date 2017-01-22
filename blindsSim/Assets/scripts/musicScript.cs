using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicScript : MonoBehaviour {

	public GameObject playingMusic;
	public GameObject winMusic;
	public GameObject loseMusic;
	private AudioSource music_audio;
	private AudioSource win_audio;
	private AudioSource lose_audio;

	void Start() {
		music_audio = playingMusic.GetComponent<AudioSource> (); 
		win_audio = winMusic.GetComponent<AudioSource> ();
		lose_audio = loseMusic.GetComponent<AudioSource> ();
	}

	public void playingMusicPlay() {
		music_audio.Play ();
	}

	public void playingMusicStop() {
		music_audio.Stop ();
	}

	public void winMusicPlay() {
		win_audio.Play ();
	}

	public void winMusicStop() {
		win_audio.Stop ();
	}

	public void loseMusicPlay() {
		lose_audio.Play ();
	}

	public void loseMusicStop() {
		lose_audio.Stop ();
	}
}
