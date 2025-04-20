using UnityEngine;
public class ClickableSprite : MonoBehaviour
{
    public GameObject canvasik;
    public AudioSource hitsound;
    public GameObject effect;
    GameObject psys;
    ParticleSystem psyseff;
    Animator anim;
    void Awake()
    {
        canvasik = GameObject.Find("Canvas");
        anim = GetComponent<Animator>();
    }

    void Start()
    {
        Vector3 mouse = Input.mousePosition;
        Vector3 posb = Camera.main.ScreenToWorldPoint(mouse);
    }

    void OnMouseDown()
    {
        Click();
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Click();
        }
    }

    void Click()
    {
        anim.SetTrigger("Clicked");
        Vector3 mouse = Input.mousePosition;
        Vector3 posb = Camera.main.ScreenToWorldPoint(mouse);
        psys = Instantiate(effect, posb, Quaternion.Euler(-90, 0, 0));
        psyseff = psys.GetComponent<ParticleSystem>();
        posb.z = 0;
        psys.transform.position = posb;
        psyseff.Emit(5);
        hitsound.pitch = Random.Range(0.8f, 1.2f);
        hitsound.Play();
    }

}
