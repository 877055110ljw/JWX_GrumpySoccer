using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scenceObjCtr : MonoBehaviour
{
    public GameObject ball;
    public float forceRat = 180.0f;
    public float maxSpeed = 4;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "ball")
        {
            // Calculate hit Factor
            var cur = ball.GetComponent<Rigidbody>().velocity.magnitude;
            Debug.Log("cur:" + cur);
            if (cur < maxSpeed)
            {
                Vector3 dri = ball.transform.position - col.contacts[0].point;
                ball.GetComponent<Rigidbody>().velocity = forceRat * 0.5f * dri.normalized;
            }
        }
    }
}
