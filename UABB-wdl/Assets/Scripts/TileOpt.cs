using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileOpt : MonoBehaviour {

	public Canvas osCanvas;
	public Canvas typeCanvas;
	private double positionx;
	private double positiony;
    public static int blockx;
    public static int blocky;
    private double originx;
    private double originy;
    private double blocksize;

	void Start()
	{
        originx = 890;
        originy = 65;
        blocksize = 120.5;
        osCanvas = GameObject.Find("OSCanvas").GetComponent<Canvas>();
        typeCanvas = GameObject.Find("TypeCanvas").GetComponent<Canvas>();
        osCanvas.gameObject.SetActive(false);
        typeCanvas.gameObject.SetActive(false);
    }


    public void WindowContain()
    {

    }

    void OnMouseEnter()
    {
        if (Manager.instance.currentPlayerIndex == 0)
        {
            transform.GetComponent<Renderer>().material.color = Color.yellow;
        }
        else if (Manager.instance.currentPlayerIndex == 1)
        {
            transform.GetComponent<Renderer>().material.color = Color.red;
        }
        else if (Manager.instance.currentPlayerIndex == 2)
        {
            transform.GetComponent<Renderer>().material.color = Color.blue;
        }
        else {
            transform.GetComponent<Renderer>().material.color = Color.green;
        }
    }

    void OnMouseExit()
    {
        transform.GetComponent<Renderer>().material.color = Color.white;
    }



    //处理鼠标移上物体以及点击事件

    void Update()
	{
        if (Input.GetMouseButtonDown(0)&&!typeCanvas.gameObject.activeSelf&&!osCanvas.gameObject.activeSelf)
        {
            // m_obj.enabled = true;  
            osCanvas.gameObject.SetActive(true);
            positionx = Input.mousePosition.x;
            positiony = Input.mousePosition.y;
            blockx = calIndexX(positionx);
            blocky = calIndexY(positiony);
            Debug.Log("[" + blockx + "," + blocky + "]");
        }
        
        /*if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Position X:"+Input.mousePosition.x);
            Debug.Log("Position Y:" + Input.mousePosition.y);
            Debug.Log("["+blockx+","+blocky+"]" );
        }*/
        //buildButton.onClick.AddListener (buildModel);
        //pulldownButton.onClick.AddListener (pulldownModel);
        //houseButton.onClick.AddListener (pulldownModel);
    }

	

    private int calIndexX(double positionx)
    {
        int x;
        x = (int)((positionx - originx) / blocksize);
        return x;
    }

    private int calIndexY(double positiony)
    {
        int y;
        y = (int)((positiony - originy) / blocksize);
        return y;
    }
    
}
	