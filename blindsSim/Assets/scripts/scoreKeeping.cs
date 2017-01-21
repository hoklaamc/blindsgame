using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreKeeping : MonoBehaviour
{
    private int score = 0;

    public countDownTimer time;

    public GameObject star;
    public GameObject star1;
    public GameObject star2;
    Vector3 pos1;
    Vector3 pos2;
    Vector3 pos3;
    bool reset = true;

    public GameObject lastBind;

    // Use this for initialization
    void Start()
    {
        pos1 = star.GetComponent<Rigidbody2D>().transform.position;
        pos2 = star1.GetComponent<Rigidbody2D>().transform.position;
        pos3 = star2.GetComponent<Rigidbody2D>().transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if ((lastBind.GetComponent<Rigidbody2D>().transform.position.y >= 1.7) && (reset == true) && (time.getTime() > 0))
        {
            score++;
            reset = false;
        }
        else if (lastBind.GetComponent<Rigidbody2D>().transform.position.y < 1.7)
        {
            reset = true;
        }
        if (score % 10 == 0)
        {
            star.GetComponent<Rigidbody2D>().velocity = new Vector3(20, 0, 0);
            star1.GetComponent<Rigidbody2D>().velocity = new Vector3(20, 0, 0);
            star2.GetComponent<Rigidbody2D>().velocity = new Vector3(20, 0, 0);
        }
        else if (score % 10 == 9)
        {
            star.transform.position = pos1;
            star1.transform.position = pos2;
            star2.transform.position = pos3;


        }
    }
    void OnGUI()
    {
        GUI.Label(new Rect(200, 100, 200, 200), "Score: " + score);
    }
}
