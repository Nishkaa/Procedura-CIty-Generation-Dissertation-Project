using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
	public float movement = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
		//forward and backwards movement
        float translation = Input.GetAxis("Vertical") * movement;
		float straffe = Input.GetAxis("Horizontal") * movement;
		translation*= Time.deltaTime;
		straffe*=Time.deltaTime;
		transform.Translate(straffe,0,translation);
		
		//cursor turning in defoult state
		if(Input.GetKeyDown("escape"))
			Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
    }
}
