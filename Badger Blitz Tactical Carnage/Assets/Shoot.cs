using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public int damage = 5;
    private new Camera camera;
    private LineRenderer laserline;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        laserline = GetComponent<LineRenderer>();
        player = GameObject.FindGameObjectWithTag("Player");
        camera = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0)){
            Debug.Log("Shot is shot");

            StartCoroutine(ShotEffect());
            Vector3 rayOrigin = camera.ViewportToWorldPoint (new Vector3(0.5f,0.5f,0));
            RaycastHit hit;
            laserline.SetPosition (0, player.transform.position);

            if (Physics.Raycast (rayOrigin, camera.transform.forward, out hit))
            {
                laserline.SetPosition(1, hit.point);
            }
        }
    }
    private IEnumerator ShotEffect(){
        laserline.enabled = true;
        yield return new WaitForSeconds(1);
        laserline.enabled = false;
    }
}
