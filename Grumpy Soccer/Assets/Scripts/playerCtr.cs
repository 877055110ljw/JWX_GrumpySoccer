using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCtr : MonoBehaviour
{

    Component force;
    public float timer = 1f;
    bool start = false;
    public GameObject ball;
    public float MAXRat=20.0f;
    public float MINRat = 5.0f;
    public float MaxAngle = 90.0f;
    public float speed = 0f;
    private Animator animator;
    Vector2 lastpos;
    Vector2 Newpos;
    // Start is called before the first frame update
    void Start()
    {

        
        //获取animator组件，使用该组件来控制动画状态
        lastpos = new Vector2(this.transform.position.x, this.transform.position.z);
        animator =  GetComponentInChildren<Animator>();

        //转换为hash值,效率更高

       // speed = Animator.StringToHash("speed");
    }

    // Update is called once per frame
    void Update()
    {
        if (start && timer > 0)
            timer -= Time.deltaTime;
        else
        {
            start = false;
        }
        Newpos = new Vector2(this.transform.position.x, this.transform.position.z);
        speed = (lastpos - Newpos).sqrMagnitude/ Time.deltaTime;
        //if (temp> speed)
            animator.SetFloat("speed", speed);
        //else
        //    animator.SetFloat("speed", 0);
        lastpos = Newpos;

    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "ball")
        {
            Vector3 dri = ball.transform.position - col.contacts[0].point;
            dri.y = 0;
            ball.GetComponent<ConstantForce>().enabled = true;
            float angle = Vector3.Angle(dri, this.transform.forward);
            angle = Mathf.Clamp(angle, 0.01f, MaxAngle);
            float forceRat = Mathf.Lerp(MINRat, MAXRat, (MaxAngle-angle)/MaxAngle);
            ball.GetComponent<Rigidbody>().velocity = forceRat * 0.5f * dri.normalized;
        }
    }
}
