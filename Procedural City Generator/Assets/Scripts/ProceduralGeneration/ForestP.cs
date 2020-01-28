using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForestP : MonoBehaviour
{

 public GameObject[] TerrainType;
	
    public GameObject emptyspace1;
    public GameObject emptyspace2;
    public GameObject emptyspace3;
    public int mapWidth = 20;
    public int mapHeight = 20;
	public int mapWidthOnClick = 20;
	public int mapHeightOnclick = 20;
    int[,] mapgrid;
    public int  TerrainFootprint = 10;
    public int TerrainFootprintGrid = 10;
	
    // Start is called before the first frame update
    void Start()
    {
        mapgrid = new int[mapWidth, mapHeight];

        //generate map data
    
            for(int h = 0; h < mapHeight; h++)
            {
                for(int w = 0; w<mapWidth; w++)
                {
                mapgrid[w, h] = (int)(Mathf.PerlinNoise(w /10.0f , h / 2.0f) * 10);
                }
				 
			
            }
        //empty space grid
        //height
        int x = 0;
        for(int n = 0; n < 50; n++)
        {
            for(int h = 0; h < mapHeight; h++)
            {
                mapgrid[x, h] = -1;
            }
            x += Random.Range(5, 10);
            if (x >= mapWidth){
				break;
			
			}
        }
        //width
        int z = 0;
        for (int n = 0; n < 10; n++)
        {
            for (int w = 0; w < mapWidth; w++)
            {
                Debug.Log(z);
                if (mapgrid[w, z] == -1)
                    mapgrid[w, z] = -3;
                else
                    mapgrid[w, z] = -2;
            }
            z += Random.Range(5, 20);
            if (z >= mapHeight) break;
        }
        //generate city
        for (int h = 0; h < mapHeight; h++)
        {
            for(int w = 0; w < mapWidth; w++)
            {
                int result = mapgrid[w, h];
                Vector3 pos = new Vector3(w * TerrainFootprint, 0, h * TerrainFootprint);
                Vector3 posStreets = new Vector3(w * TerrainFootprintGrid, 0, h * TerrainFootprintGrid);
				Vector3 posYellow = new Vector3(w * TerrainFootprint, 0, h * TerrainFootprint);
				Vector3 posBlue = new Vector3(w * TerrainFootprint, 0, h * TerrainFootprint);
				Vector3 posRed = new Vector3(w * TerrainFootprint, 0, h * TerrainFootprint);
				Vector3 posPurple = new Vector3(w * TerrainFootprint, 0, h * TerrainFootprint);
				Vector3 posGreen = new Vector3(w * TerrainFootprint, 0, h * TerrainFootprint);
				Vector3 posGreen1 = new Vector3(w * TerrainFootprint, 0, h * TerrainFootprint);
				Vector3 posBuildingBlocks = new Vector3(w * TerrainFootprint,0, h * TerrainFootprint);
				                 if (result < -2)
                    Instantiate(emptyspace3, posStreets, emptyspace3.transform.rotation);
                else if (result < -1)
                    Instantiate(emptyspace1, posStreets, emptyspace1.transform.rotation);
                else if (result < 0)
                    Instantiate(emptyspace2, posStreets, emptyspace2.transform.rotation);


         
                else if (result < 1)
                    Instantiate(TerrainType[0], posBlue, Quaternion.identity);
                else if (result < 2)
                    Instantiate(TerrainType[1], posBuildingBlocks, Quaternion.identity);
                else if (result < 3)
                    Instantiate(TerrainType[2], posPurple, Quaternion.identity);
                else if (result < 4)
                    Instantiate(TerrainType[3], pos, Quaternion.identity);
                else if (result < 5)
                    Instantiate(TerrainType[4], posYellow, Quaternion.identity);
                else if (result < 6)
                    Instantiate(TerrainType[5], posRed, Quaternion.identity);
			  else if (result < 7)
                    Instantiate(TerrainType[6], posRed, Quaternion.identity);
			  else if (result < 8)
                    Instantiate(TerrainType[7], posRed, Quaternion.identity);
			  else if (result < 9)
                    Instantiate(TerrainType[8], posRed, Quaternion.identity);
			  else if (result < 10)
                    Instantiate(TerrainType[9], posRed, Quaternion.identity);
			else if (result == 10)
                    Instantiate(TerrainType[10], posRed, Quaternion.identity);
		
            }
        }
		
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetMouseButton(1)) {
       var mousePos = Input.mousePosition;
         mousePos.z = 2.0f;       // we want 2m away from the camera position
 
         var objectPos = Camera.current.ScreenToWorldPoint(mousePos);
		 
    
         }
     }
	
}

