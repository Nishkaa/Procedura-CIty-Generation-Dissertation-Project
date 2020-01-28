using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeWorldSimple : MonoBehaviour
{
    public GameObject[] buildings;
	
    public GameObject xstreets;
    public GameObject zstreets;
    public GameObject crossroad;
    public int mapWidth = 20;
    public int mapHeight = 20;
	public int mapWidthOnClick = 20;
	public int mapHeightOnclick = 20;
    int[,] mapgrid;
    public int  buildingFootprint = 10;
    public int buildingFootprintStreets = 10;
	
    // Start is called before the first frame update
    void Start()
    {
        mapgrid = new int[mapWidth, mapHeight];

        //generate map data
    
            for(int h = 0; h < mapHeight; h++)
            {
                for(int w = 0; w<mapWidth; w++)
                {
                mapgrid[w, h] = (int)(Mathf.PerlinNoise(w / 7.0f , h / 7.0f) * 10);
                }
				 
			
            }
        //build streets
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
                Vector3 pos = new Vector3(w * buildingFootprint, 0, h * buildingFootprint);
                Vector3 posStreets = new Vector3(w * buildingFootprintStreets, 0, h * buildingFootprintStreets);
				Vector3 posYellow = new Vector3(w * buildingFootprint, 5, h * buildingFootprint);
				Vector3 posBlue = new Vector3(w * buildingFootprint, 4, h * buildingFootprint);
				Vector3 posRed = new Vector3(w * buildingFootprint, 5, h * buildingFootprint);
				Vector3 posPurple = new Vector3(w * buildingFootprint, 4, h * buildingFootprint);
				Vector3 posGreen = new Vector3(w * buildingFootprint, 18, h * buildingFootprint);
				Vector3 posGreen1 = new Vector3(w * buildingFootprint, 18, h * buildingFootprint);
				Vector3 posBuildingBlocks = new Vector3(w * buildingFootprint,5, h * buildingFootprint);
				                 if (result < -2)
                    Instantiate(crossroad, posStreets, crossroad.transform.rotation);
                else if (result < -1)
                    Instantiate(xstreets, posStreets, xstreets.transform.rotation);
                else if (result < 0)
                    Instantiate(zstreets, posStreets, zstreets.transform.rotation);


         
                else if (result < 1)
                    Instantiate(buildings[0], posBlue, Quaternion.identity);
                else if (result < 2)
                    Instantiate(buildings[1], posBuildingBlocks, Quaternion.identity);
                else if (result < 3)
                    Instantiate(buildings[2], posPurple, Quaternion.identity);
                else if (result < 4)
                    Instantiate(buildings[3], pos, Quaternion.identity);
                else if (result < 5)
                    Instantiate(buildings[4], posYellow, Quaternion.identity);
                else if (result < 6)
                    Instantiate(buildings[5], posRed, Quaternion.identity);
			  else if (result < 7)
                    Instantiate(buildings[6], posRed, Quaternion.identity);
			  else if (result < 8)
                    Instantiate(buildings[7], posRed, Quaternion.identity);
			  else if (result < 9)
                    Instantiate(buildings[8], posRed, Quaternion.identity);
			  else if (result < 10)
                    Instantiate(buildings[9], posRed, Quaternion.identity);
			else if (result == 10)
                    Instantiate(buildings[10], posRed, Quaternion.identity);
		
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
