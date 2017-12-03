using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateInfo : MonoBehaviour {

    public Text gameTimesUpdate;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameTimesUpdate.text = "更新次数 "+Manager.gameTimes.ToString();
	}
}
