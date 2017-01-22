using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreKeeping : MonoBehaviour
{
    private int score = 0;

    private AudioSource alert_audio;

    public countDownTimer time;

    public GameObject plusOne;
    public GameObject star;
    public GameObject star1;
    public GameObject star2;
    Vector3 pos1;
    Vector3 pos2;
    Vector3 pos3;
    bool reset = true;

	public GUIStyle myStyle = new GUIStyle(); 

    public GameObject lastBind;

//	public GameObject gameMusic;
//	public GameObject winMusic;
//	public GameObject loseMusic;
//	private AudioSource music_audio;
//	private AudioSource win_audio;
//	private AudioSource lose_audio;
//
//	private bool winState;
//	private bool playing;

    // Use this for initialization
    void Start()
    {
        pos1 = star.GetComponent<Rigidbody2D>().transform.position;
        pos2 = star1.GetComponent<Rigidbody2D>().transform.position;
        pos3 = star2.GetComponent<Rigidbody2D>().transform.position;
        alert_audio = GetComponent<AudioSource>();
        plusOne.GetComponent<SpriteRenderer>().enabled = false;

//		winState = false;
//		playing = true;
//		music_audio = gameMusic.GetComponent<AudioSource> (); 
//		win_audio = winMusic.GetComponent<AudioSource> ();
//		lose_audio = loseMusic.GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
        if ((lastBind.GetComponent<Rigidbody2D>().transform.position.y >= 1.7) && (reset == true) && (time.getTime() > 0))
        {
            score++;
            alert_audio.Play();
            reset = false;
            plusOne.GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (lastBind.GetComponent<Rigidbody2D>().transform.position.y < 1.7)
        {
            reset = true;
            plusOne.GetComponent<SpriteRenderer>().enabled = false;
        }
		if (score % 10 == 0 && (score != 0))
        {
            star.GetComponent<Rigidbody2D>().velocity = new Vector3(20, 0, 0);
            star1.GetComponent<Rigidbody2D>().velocity = new Vector3(20, 0, 0);
            star2.GetComponent<Rigidbody2D>().velocity = new Vector3(20, 0, 0);
//			winState = true;
        }
        else if (score % 10 == 9)
        {
            star.transform.position = pos1;
            star1.transform.position = pos2;
            star2.transform.position = pos3;
        }

//		if (time.getTime () == 0 && playing == true) {
//			Debug.Log ("time ended!");
//			playing = false;
//			if (winState == true && playing == false) {
//				music_audio.Stop ();
//				win_audio.Play ();
//				lose_audio.Stop ();
//			} else if (winState == true && playing == false) {
//				music_audio.Stop ();
//				win_audio.Stop ();
//				lose_audio.Play ();
//			}
//		}
    }

    void OnGUI()
    {
		GUI.Label(new Rect(10, 40, 200, 200), "Score: " + score, myStyle);
    }

	public void resetScore()
	{
		score = 0;
//		winState = false;
//		playing = true;
	}
}
