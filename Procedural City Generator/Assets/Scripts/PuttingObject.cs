using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingObject : MonoBehaviour
{
	public GameObject[] streetTest;
	public int mapWidth = 20;
    public int mapHeight = 20;
	public float posY = 10f;
	public int sizeF = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    if(Input.GetMouseButton(1)) {
       var mousePos = Input.mousePosition;
			mousePos.z =  300.0f;  // we want 2m away from the camera position;
			//var objectPos = new Vector3(mapWidth, 0, mapHeight);
        Vector3 pos = new Vector3(mapWidth * sizeF, 40, mapHeight * sizeF);
	
		 Instantiate(streetTest[0], pos, Quaternion.identity);
		
}
}
}