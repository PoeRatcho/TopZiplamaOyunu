using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Zıplama : MonoBehaviour
{
    public float hız = 1f; 
    public float zıplama =10f ;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Zıpla();
        }
       
        Vector3 gitme = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Vector3 hızlanma = hız * gitme * Time.deltaTime;

        rb.MovePosition(transform.position + hızlanma);
        
        if (transform.position.y < 0f)
        {
            OyunuYenidenBaslat();
        }
    }
    void Zıpla()
    {
        rb.AddForce(Vector3.up * zıplama, ForceMode.Impulse);
    }
    void OyunuYenidenBaslat()
    {
       SceneManager.LoadScene(0);
    }





}

