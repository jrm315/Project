using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class childAnimator : MonoBehaviour {

    public Animator animator;
    public GameObject child;
    public GameObject girlHair;
    public GameObject boyHair;
    public bool isGirl;
    public bool done;
    public Text text;

    public float initialPos;
    public float finalPos;

    public float initialPosR;
    public float finalPosR;
    public float initialPosL;
    public float finalPosL;

    // Use this for initialization
    void Start ()
    {
        animator = GetComponent<Animator>();
        child = GetComponent<GameObject>();
        //girlHair = GetComponent<GameObject>();
        text = GetComponent<Text>();
        isGirl = true;

        done = false;
        initialPos = 0;
        finalPos = 0;
        initialPosR = 0;
        finalPosR = 0;
        initialPosL = 0;
        finalPosL = 0;
}
	
	// Update is called once per frame
	void Update ()
    {
       
        // Make the child look at the camera.
        Vector3 cameraPosition = Camera.main.transform.position;
        cameraPosition.y = transform.position.y;
        transform.LookAt(cameraPosition);
        //------------------------------------------------------------------------------------------------------
        string sceneName = SceneManager.GetActiveScene().name;

        if (sceneName == "Menu 1")
        {
            

            if (OVRInput.GetLocalControllerVelocity(OVRInput.Controller.RTouch).x > 0.3)
            {
                done = true;
                initialPos = OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch).x;
            }
            if (done)
            {
                finalPos = OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch).x;
            }

            if (Mathf.Abs(initialPos - finalPos) > 0.3)
            {
                girlHair.SetActive(isGirl);
                boyHair.SetActive(!isGirl);
            }
            done = false;
        }
            

        if (sceneName == "Protocol 3")
        {
            if (OVRInput.GetLocalControllerVelocity(OVRInput.Controller.RTouch).y > 0.3 && OVRInput.GetLocalControllerVelocity(OVRInput.Controller.LTouch).y < -0.3)
            {
                initialPosR = OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch).y;
                initialPosL = OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch).y;
                done = true;
            }
            if (done)
            {
                finalPosR = initialPos = OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch).y;
                initialPosL = OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch).y;
            }

            if (Mathf.Abs(initialPosL - finalPosL) > 0.3 && Mathf.Abs(initialPosR - finalPosR) > 0.3)
            {
                animator.Play("1Dance");
            }
        }

    }

    public void idle()
    {
        animator.SetTrigger("Idle");
        animator.Play("1Idle");
    }
    
    public void sad()
    {
        animator.SetTrigger("Sad");
        animator.Play("1Sad");
    }

    public void happy()
    {
        animator.SetTrigger("Happy"); ;
        animator.Play("1Happy");
    }

    public void dance()
    {
        animator.Play("1Dance");
    }

    public void reallySad()
    {
        animator.Play("1Shock");
    }

    public void OnTriggerEnter(Collider other)
    {
        animator.Play("1Happy");
    }
}
