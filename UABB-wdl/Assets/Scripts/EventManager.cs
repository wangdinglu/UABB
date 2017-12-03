using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventManager : MonoBehaviour {

    public Text nameText;
    public Image nameImage;
    public Canvas osCanvas;
    public Canvas typeCanvas;
    public GameObject[,,] bms;//builtModelSpace

    // Use this for initialization
    void Start () {
        osCanvas = GameObject.Find("OSCanvas").GetComponent<Canvas>();
        typeCanvas = GameObject.Find("TypeCanvas").GetComponent<Canvas>();
    }

    // Update is called once per frame
    public void buildModelMode()
    {
        osCanvas.gameObject.SetActive(false);
        typeCanvas.gameObject.SetActive(true);

    }

    void Update()
    {
     
    }

    public void nextPlayer()
    {
        Manager.instance.nextTurn();
        if (Manager.instance.currentPlayerIndex == 0)
        {
            nameText.text = "外来租户";
            nameImage.sprite = Resources.Load<Sprite>("Sprites/Tenement");
        }
        else if (Manager.instance.currentPlayerIndex == 1)
        {
            nameText.text = "南头村民";
            nameImage.sprite = Resources.Load<Sprite>("Sprites/Farmer");
        }
        else if (Manager.instance.currentPlayerIndex == 2)
        {
            nameText.text = "当地政府";
            nameImage.sprite = Resources.Load<Sprite>("Sprites/Leader");
        }
        else {
            nameText.text = "社会企业";
            nameImage.sprite = Resources.Load<Sprite>("Sprites/Businessman");
        }
    }

    public void endRole()
    {
        typeCanvas = GameObject.Find("TypeCanvas").GetComponent<Canvas>();
        typeCanvas.gameObject.SetActive(false);
        nextPlayer();
    }

    public void endDestroy()
    {
        osCanvas.gameObject.SetActive(false);
        nextPlayer();
    }

}
