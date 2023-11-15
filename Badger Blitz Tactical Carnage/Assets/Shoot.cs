using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public int damage = 5;
    public float fireRate = 0.1f;
    private float nextFire;
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
        if(Input.GetMouseButton(0) && Time.time > nextFire){
            Debug.Log("Shot is shot");

            nextFire = Time.time + fireRate;

            StartCoroutine(ShotEffect());
            Vector3 rayOrigin = camera.ViewportToWorldPoint (new Vector3(0.5f,0.5f,0));
            RaycastHit hit;
            laserline.SetPosition (0, player.transform.position);

            if (Physics.Raycast (rayOrigin, camera.transform.forward, out hit))
            {
                laserline.SetPosition(1, hit.point);
                Health health = hit.collider.GetComponent<Health>();
                if(health != null){
                    health.TakeDamage(damage);

                }
            }
        }
    }
    private IEnumerator ShotEffect(){
        laserline.enabled = true;
        yield return new WaitForSeconds(0.15f);
        laserline.enabled = false;
    }
}
