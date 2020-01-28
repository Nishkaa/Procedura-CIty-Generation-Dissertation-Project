using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForestDestroyer : MonoBehaviour
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
		if(col.gameObject.name=="FirTree(Clone)"){
			Destroy(col.gameObject);
		}
		if(col.gameObject.name=="FirTree (4)(Clone)"){
			Destroy(col.gameObject);
		}
		if(col.gameObject.name=="FirTree (3)(Clone)"){
			Destroy(col.gameObject);
		}
		if(col.gameObject.name=="FirTree (2)(Clone)"){
			Destroy(col.gameObject);
		}
		if(col.gameObject.name=="FirTree (1)(Clone)"){
			Destroy(col.gameObject);
		}
		if(col.gameObject.name=="pineTree05(Clone)"){
			Destroy(col.gameObject);
		}
		if(col.gameObject.name=="grass1"){
			Destroy(col.gameObject);
		}
		if(col.gameObject.name=="pineTree05(Clone)"){
			Destroy(col.gameObject);
		}
		if(col.gameObject.name=="pineTree04(Clone)"){
			Destroy(col.gameObject);
		}
		if(col.gameObject.name=="pineTree03(Clone)"){
			Destroy(col.gameObject);
		}
		if(col.gameObject.name=="pineTree02(Clone)"){
			Destroy(col.gameObject);
		}
		if(col.gameObject.name=="pineTree(Clone)"){
			Destroy(col.gameObject);
		}
		
	}
	
}
