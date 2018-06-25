using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class introScript : MonoBehaviour {

    public Button button;

    public GameObject tut;
    public GameObject tutG;
    public GameObject gender;

    public Button none;
    public Button mild;
    public Button moderate;
    public Button more;
    public Button severe;

    public int score;
    private int buttonNum; 

    private void Start()
    {
        button = GetComponent<Button>();
        gender = GameObject.Find("Gender");
        tut = GameObject.Find("Image Button");
        tutG = GameObject.Find("Image");
        score = 0;
        buttonNum = 0;
    }

    private void Update()
    {
        if (score > 0)
        {
            tut.gameObject.SetActive(false);
            tutG.gameObject.SetActive(false);
        }
        if (score > 1)
        {
            gender.gameObject.SetActive(false);
        }

    }

    public void turnOff()
    {
        button.gameObject.SetActive(false);
        score += 1;
    }

    public void scoreCount()
    {
        if (button.name == "Not at all")
        {
            // Do nothing. Or add 0 to the score.
        }
        else if (button.name == "Several days")
        {
            score += 1;
        }
        else if (button.name == "More than")
        {
            score += 2;
        }
        else if (button.name == "All")
        {
            score += 3;
        }
    }

    public void turnOffButton()
    {
        buttonNum += 1;
    }

    public void diagnosis()
    {
        if (score <= 4)
        {
            none.gameObject.SetActive(true);
            mild.gameObject.SetActive(false);
            moderate.gameObject.SetActive(false);
            more.gameObject.SetActive(false);
            severe.gameObject.SetActive(false);

        }
        else if (score > 4 && score <= 9)
        {
            none.gameObject.SetActive(false);
            mild.gameObject.SetActive(true);
            moderate.gameObject.SetActive(false);
            more.gameObject.SetActive(false);
            severe.gameObject.SetActive(false);
        }
        else if (score > 9 && score <= 14)
        {
            none.gameObject.SetActive(false);
            mild.gameObject.SetActive(false);
            moderate.gameObject.SetActive(true);
            more.gameObject.SetActive(false);
            severe.gameObject.SetActive(false);
        }
        else if (score > 14 && score <= 19)
        {
            none.gameObject.SetActive(false);
            mild.gameObject.SetActive(false);
            moderate.gameObject.SetActive(false);
            more.gameObject.SetActive(true);
            severe.gameObject.SetActive(false);
        }
        else if (score > 19)
        {
            none.gameObject.SetActive(false);
            mild.gameObject.SetActive(false);
            moderate.gameObject.SetActive(false);
            more.gameObject.SetActive(false);
            severe.gameObject.SetActive(true);
        }
    }

    


}
