using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{

    public float speed = 5.0f;
    private Rigidbody myRigid;
    public GameManager myManager;

    // Start is called before the first frame update
    void Start()
    {
        myRigid = this.GetComponent<Rigidbody>();
        myRigid.AddForce((transform.forward + transform.right) * speed, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision) // 衝突したら消す
    {
        if(collision.gameObject.tag == "Finish")
        {
            Destroy(this.gameObject);
            myManager.GameOver();
        }
    }
}
