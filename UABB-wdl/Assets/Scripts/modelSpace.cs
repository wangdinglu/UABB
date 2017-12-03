using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modelSpace : MonoBehaviour {

    public int[,,] builtType = new int[8, 8, 12];
    public int[,] builtLevel = new int[8, 8];
    private int x;
    private int y;
    private int z;
    private int type;
    private int block;
    private GameObject tempModel;
    private string name;
    public EventManager em;
    private GameObject[] preModels = new GameObject[29];

    // Use this for initialization
    void Start () {
        for(int i = 0; i < 29; i++)
        {
            preModels[i] = Resources.Load("Models/m"+(i+1).ToString()) as GameObject;
        }
        block = 50;
        for (int i = 0; i < 8; i++)  // 
        {
            for (int j = 0; j < 8; j++) //  
            {
                builtLevel[i, j] = 0;
                for (int k = 0; k < 8; k++) // 
                {
                    builtType[i, j, k] = 0;
                }
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    public void buildHouse()
    {
        x = TileOpt.blockx;
        y = TileOpt.blocky;
        z = builtLevel[x, y];
        Debug.Log("[" + x + "," + y + "," + z + "]");
        type = Random.Range(0,6);
        tempModel=GameObject.Instantiate(preModels[type], preModels[type].transform.position, preModels[type].transform.rotation);
        tempModel.transform.Translate(block * x, block *z, block * y);
        tempModel.transform.name = x.ToString() + y.ToString() + z.ToString();
        //tempModel.transform.parent = builtModels[x, y, z].transform;
        builtType[x, y ,z] = type;
        builtLevel[x, y] = z + 1;
        em.endRole();
    }

    public void buildOffice()
    {
        x = TileOpt.blockx;
        y = TileOpt.blocky;
        z = builtLevel[x, y];
        Debug.Log("[" + x + "," + y + "," + z + "]");
        type = Random.Range(6, 11);
        tempModel = GameObject.Instantiate(preModels[type], preModels[type].transform.position, preModels[type].transform.rotation);
        tempModel.transform.Translate(block * x, block * z, block * y);
        tempModel.transform.name = x.ToString() + y.ToString() + z.ToString();
        //tempModel.transform.parent = builtModels[x, y, z].transform;
        builtLevel[x, y] = z + 1;
        builtType[x, y, z] = type;
        em.endRole();
    }

    public void buildCafe()
    {
        x = TileOpt.blockx;
        y = TileOpt.blocky;
        z = builtLevel[x, y];
        Debug.Log("[" + x + "," + y + "," + z + "]");
        type = Random.Range(11, 16);
        tempModel = GameObject.Instantiate(preModels[type], preModels[type].transform.position, preModels[type].transform.rotation);
        tempModel.transform.Translate(block * x, block * z, block * y);
        tempModel.transform.name = x.ToString() + y.ToString() + z.ToString();
        //tempModel.transform.parent = builtModels[x, y, z].transform;
        builtLevel[x, y] = z + 1;
        builtType[x, y, z] = type;
        em.endRole();
    }

    public void buildSchool()
    {
        x = TileOpt.blockx;
        y = TileOpt.blocky;
        z = builtLevel[x, y];
        Debug.Log("[" + x + "," + y + "," + z + "]");
        type = Random.Range(16, 18);
        builtType[x, y, z] = type;
        tempModel = GameObject.Instantiate(preModels[type], preModels[type].transform.position, preModels[type].transform.rotation);
        tempModel.transform.Translate(block * x, block * z, block * y);
        tempModel.transform.name = x.ToString() + y.ToString() + z.ToString();
        //tempModel.transform.parent = builtModels[x, y, z].transform;
        builtLevel[x, y] = z + 1;
        em.endRole();
    }

    public void buildPark()
    {
        x = TileOpt.blockx;
        y = TileOpt.blocky;
        z = builtLevel[x, y];
        Debug.Log("[" + x + "," + y + "," + z + "]");
        type = Random.Range(18, 21);
        builtType[x, y, z] = type;
        tempModel = GameObject.Instantiate(preModels[type], preModels[type].transform.position, preModels[type].transform.rotation);
        tempModel.transform.Translate(block * x, block * z, block * y);
        tempModel.transform.name = x.ToString() + y.ToString() + z.ToString();
        //tempModel.transform.parent = builtModels[x, y, z].transform;
        builtLevel[x, y] = z + 1;
        em.endRole();
    }

    public void buildShop()
    {
        x = TileOpt.blockx;
        y = TileOpt.blocky;
        z = builtLevel[x, y];
        Debug.Log("[" + x + "," + y + "," + z + "]");
        type = Random.Range(21, 29);
        builtType[x, y, z] = type;
        tempModel = GameObject.Instantiate(preModels[type], preModels[type].transform.position, preModels[type].transform.rotation);
        tempModel.transform.Translate(block * x, block * z, block * y);
        tempModel.transform.name = x.ToString() + y.ToString() + z.ToString();
        //tempModel.transform.parent = builtModels[x, y, z].transform;
        builtLevel[x, y] = z + 1;
        em.endRole();
    }

    public void destroyModel()
    {
        x = TileOpt.blockx;
        y = TileOpt.blocky;
        z = builtLevel[x, y];
        name = x.ToString() + y.ToString() + (z - 1).ToString();
        Destroy(GameObject.Find(name));
        builtLevel[x, y] = z - 1;
        em.endDestroy();
    }
}
