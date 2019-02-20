using System.Collections;
using System.Collections.Generic;
using Player;
using UnityEngine;

public class ViewPlayer : MonoBehaviour
{
    Rigidbody rb;
    Coroutine moveCo;
    ControllerPlayer controller;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }
    public void SetController(ControllerPlayer controller)
    {
        this.controller = controller;
    }
    public IEnumerator Move(float h, float v)
    {
        this.transform.Translate(0, 0, v);
        //rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, v);
        this.transform.Rotate(0, h, 0);
        yield return new WaitForEndOfFrame();
    }
    public void MovePlayer(float h, float v)
    {
        moveCo = StartCoroutine(Move(h, v));
    }
    public void DestroyPlayer()
    {
        Destroy(this.gameObject);
    }
}
