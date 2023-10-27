using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Gun : MonoBehaviour
{

    [SerializeField] GameObject bulletprefab;
    [SerializeField] Transform muzzle;
    XRGrabInteractable grab;
    void Start(){
        grab = GetComponent<XRGrabInteractable>();
        grab.activated.AddListener(Shoot);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Shoot(ActivateEventArgs args){
        GameObject bullet = Instantiate(bulletprefab);
        bullet.transform.position = muzzle.position;
        bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
    }
}
