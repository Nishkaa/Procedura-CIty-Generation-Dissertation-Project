using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerKeepStreets : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	void OnCollisionEnter(Collision col){
		if(col.gameObject.name=="CubeDied"){
			Destroy(col.gameObject);
		}
		if(col.gameObject.name=="BlueCubeVariant(Clone)"){
			Destroy(col.gameObject);
		}
		if(col.gameObject.name=="GreenCubeVariant(Clone)"){
			Destroy(col.gameObject);
		}
		if(col.gameObject.name=="PurpleCubeVariant(Clone)"){
			Destroy(col.gameObject);
		}
		if(col.gameObject.name=="RedCube(Clone)"){
			Destroy(col.gameObject);
		}
		if(col.gameObject.name=="YellowCubeVariant(Clone)"){
			Destroy(col.gameObject);
		}
		if(col.gameObject.name=="streetcross1(Clone)"){
			Destroy(col.gameObject);
		}
		if(col.gameObject.name=="streetZ(Clone)"){
			Destroy(col.gameObject);
		}
		if(col.gameObject.name=="streetX(Clone)"){
			Destroy(col.gameObject);
		}
		if(col.gameObject.name=="grass(Clone)"){
			Destroy(col.gameObject);
		}
		//cube building parts
		//blue 6 part building
	if(col.gameObject.name=="BuildingBlocks1(Clone)"){
			Destroy(col.gameObject);
		}
		if(col.gameObject.name=="Part1"){
			Destroy(col.gameObject);
		}
		if(col.gameObject.name=="Part2"){
			Destroy(col.gameObject);
		}
		if(col.gameObject.name=="Part3"){
			Destroy(col.gameObject);
		}
		if(col.gameObject.name=="Part4"){
			Destroy(col.gameObject);
		}
		if(col.gameObject.name=="Part5"){
			Destroy(col.gameObject);
		}
		if(col.gameObject.name=="Part6"){
			Destroy(col.gameObject);
		}
		//green 5 block building
	if(col.gameObject.name=="BuildingBlocksGreen1(Clone)"){
			Destroy(col.gameObject);
		}
		if(col.gameObject.name=="Block1"){
			Destroy(col.gameObject);
		}
		if(col.gameObject.name=="Block2"){
			Destroy(col.gameObject);
		}
		if(col.gameObject.name=="Block3"){
			Destroy(col.gameObject);
		}
		if(col.gameObject.name=="Block4"){
			Destroy(col.gameObject);
		}
		if(col.gameObject.name=="Block5"){
			Destroy(col.gameObject);
		}
		// red 2 part building
	if(col.gameObject.name=="BuildingBlocksRed(Clone)"){
			Destroy(col.gameObject);
		}
		if(col.gameObject.name=="Part1"){
			Destroy(col.gameObject);
		}
		if(col.gameObject.name=="Part2"){
			Destroy(col.gameObject);
		}
		// yellow 3 Block building
	if(col.gameObject.name=="BuildingBlocksYellow(Clone)"){
			Destroy(col.gameObject);
		}
		if(col.gameObject.name=="Block1"){
			Destroy(col.gameObject);
		}
		if(col.gameObject.name=="Block2"){
			Destroy(col.gameObject);
		}
		if(col.gameObject.name=="Block3"){
			Destroy(col.gameObject);
		}
	if(col.gameObject.name=="PurpleCubeVariant(Clone)"){
			Destroy(col.gameObject);
		}
		
		
		//low polly prefabs
		if(col.gameObject.name=="SuburbHouseGrey"){
			Destroy(col.gameObject);
		}
		if(col.gameObject.name=="SuburbHouseYellow"){
			Destroy(col.gameObject);
		}
		if(col.gameObject.name=="fourStoryHouse"){
			Destroy(col.gameObject);
		}
		
		
	//russian low/high detailed prefabs
	if(col.gameObject.name=="Regroup14"){
			Destroy(col.gameObject);
		}
	if(col.gameObject.name=="rus_build1(Clone)"){
			Destroy(col.gameObject);
		}
		/*if(col.gameObject.name=="Road_Streight_A (1)"){
			Destroy(col.gameObject);
		}
		if(col.gameObject.name=="Road_Streight_A"){
			Destroy(col.gameObject);
		}
		if(col.gameObject.name=="Road_Cross_C_A"){
			Destroy(col.gameObject);
		}*/
		
		if(col.gameObject.name=="grass1"){
			Destroy(col.gameObject);
		}
		if(col.gameObject.name=="snow"){
			Destroy(col.gameObject);
		}
		if(col.gameObject.name=="Cube"){
			Destroy(col.gameObject);
		}
		if(col.gameObject.name=="cube"){
			Destroy(col.gameObject);
		}
		if(col.gameObject.name=="snow_grey"){
			Destroy(col.gameObject);
		}
		if(col.gameObject.name=="Birch_tree1"){
			Destroy(col.gameObject);
		}
	}
	
}
