using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterList : MonoBehaviour {

	public bool[,,] Lord=new bool[8,8,12];
	public bool[,,] Tenement = new bool[8, 8, 12];
	public bool[,,] Government = new bool[8, 8, 12];
	public bool[,,] Company = new bool[8, 8, 12];

	void Start()
	{
        for (int i = 0; i < 8; i++)  // 
        {
            for (int j = 0; j < 8; j++) //  
            {
                for (int k = 0; k < 8; k++) // 
                {
                    Lord[i, j, k] = false;
                    Tenement[i, j, k] = false;
                    Government[i, j, k] = false;
                    Company[i, j, k] = false;
                }
            }
        }
    }

}
