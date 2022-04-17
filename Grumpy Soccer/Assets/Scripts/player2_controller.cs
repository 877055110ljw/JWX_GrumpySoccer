using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class player2_controller : MonoBehaviour
{
    public GameObject ball;
    float pressTimeStart = 0;
    float pressTimeEnd = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            pressTimeStart = Time.time;
            
        }
        if (Input.GetKeyUp(KeyCode.I))
        {
            pressTimeEnd = 0;
            pressTimeStart = -1;
            float z = this.GetComponent<ConstantForce>().force.z;
            Vector3 ff;
            ff.x = this.GetComponent<ConstantForce>().force.x;
            ff.y = this.GetComponent<ConstantForce>().force.y;
            ff.z = 0;
            this.GetComponent<ConstantForce>().force = ff;
        }
        if(pressTimeStart > 0.0f)
        {
            pressTimeEnd = Time.time - pressTimeStart;
            Debug.Log("您按下了I键");
            float z = this.GetComponent<ConstantForce>().force.z;
            if (z < 20)
                z += 20f * pressTimeEnd;
            Vector3 ff;
            ff.x = this.GetComponent<ConstantForce>().force.x;
            ff.y = this.GetComponent<ConstantForce>().force.y;
            ff.z = z;
            this.GetComponent<ConstantForce>().force = ff;
        }
        
        if (Input.GetKeyDown(KeyCode.K))
        {
            Debug.Log("您按下了S键");
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            Debug.Log("您按下了A键");
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            Debug.Log("您按下了D键");
        }

    }
}
