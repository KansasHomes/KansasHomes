using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    //public int playerId = 0;
    public Animator animator;
    public GameObject crossHair;

    public GameObject skullPrefab;

    //private Player player;

    //void Awake(){
    //  player = ReInput.players.GetPlayer(playerId);
    //}

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);

        if (Input.GetButtonDown("Fire1")) {
          GameObject skull = Instantiate(skullPrefab, transform.position, Quaternion.identity);
          skull.GetComponent<Rigidbody2D>().velocity = new Vector2(1.0f, 0.0f);
        }

        MoveCrossHair();

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Magnitude", movement.magnitude);

        transform.position = transform.position + movement * Time.deltaTime;

    }

    private void MoveCrossHair(){
        Vector3 aim = new Vector3(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), 0.0f);

        if (aim.magnitude > 0.0f){
          aim.Normalize();
          aim *= 0.8f;
          crossHair.transform.localPosition = aim;
          crossHair.SetActive(false);
        } else {
          //crossHair.SetActive(false);
        }
    }
}
