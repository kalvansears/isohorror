using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_Rotate: MonoBehaviour {

    KeyCode Clockwise = KeyCode.RightArrow;
    KeyCode CounterClock = KeyCode.LeftArrow;


	public GameObject Deg0_90;
	public GameObject Deg0_Neg90;
	public GameObject Deg180_90;
	public GameObject Deg180_Neg90;



    private Renderer Deg0_90_rend;
    private Renderer Deg0_Neg90_rend;
    private Renderer Deg180_90_rend;
    private Renderer Deg180_Neg90_rend;


    
	// Update is called once per frame
	void Update () {

        // Key Commands for Rotation
        
		if (Input.GetKeyDown(Clockwise))
			transform.Rotate (Vector3.up, 90);
		if (Input.GetKeyDown (CounterClock))
			transform.Rotate (Vector3.up, -90);

        // Hiding Walls


        Deg0_90_rend = Deg0_90.GetComponent<Renderer>();
        Deg0_Neg90_rend = Deg0_Neg90.GetComponent<Renderer>();
        Deg180_90_rend = Deg180_90.GetComponent<Renderer>();
        Deg180_Neg90_rend = Deg180_Neg90.GetComponent<Renderer>();

        Renderer[] renderChild090 = Deg0_90.GetComponentsInChildren<Renderer>();
        Renderer[] renderChild0N90 = Deg0_Neg90.GetComponentsInChildren<Renderer>();
        Renderer[] renderChild18090 = Deg180_90.GetComponentsInChildren<Renderer>();
        Renderer[] renderChild180N90 = Deg180_Neg90.GetComponentsInChildren<Renderer>();

        

        if (transform.eulerAngles.y == 0)
        {
            Deg0_90_rend.enabled = true;
            ChildRender(renderChild090, true);

            Deg0_Neg90_rend.enabled = true;
            ChildRender(renderChild0N90, true);

            Deg180_90_rend.enabled = false;
            ChildRender(renderChild18090, false);

            Deg180_Neg90_rend.enabled = false;
            ChildRender(renderChild180N90, false);


        }

        else if (transform.eulerAngles.y == 90)
        {
            Deg0_90_rend.enabled = true;
            ChildRender(renderChild090, true);

            Deg0_Neg90_rend.enabled = false;
            ChildRender(renderChild0N90, false);

            Deg180_90_rend.enabled = true;
            ChildRender(renderChild18090, true);

            Deg180_Neg90_rend.enabled = false;
            ChildRender(renderChild180N90, false);
        }

        else if (transform.eulerAngles.y == 180)
        {
            Deg0_90_rend.enabled = false;
            ChildRender(renderChild090, false);

            Deg0_Neg90_rend.enabled = false;
            ChildRender(renderChild0N90, false);

            Deg180_90_rend.enabled = true;
            ChildRender(renderChild18090, true);

            Deg180_Neg90_rend.enabled = true;
            ChildRender(renderChild180N90, true);

        }

        else
        {
            Deg0_90_rend.enabled = false;
            ChildRender(renderChild090, false);

            Deg0_Neg90_rend.enabled = true;
            ChildRender(renderChild0N90, true);

            Deg180_90_rend.enabled = false;
            ChildRender(renderChild18090, false);

            Deg180_Neg90_rend.enabled = true;
            ChildRender(renderChild180N90, true);

        }
	}

    public void ChildRender(Renderer[] renderChild, bool yesno)
    {
        foreach (Renderer r in renderChild)
            r.enabled = yesno;

    }



}


