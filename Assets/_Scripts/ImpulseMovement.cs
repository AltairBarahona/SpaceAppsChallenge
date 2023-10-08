using UnityEngine;

public class ImpulseMovement : MonoBehaviour
{
    public float impulseForce = 5.0f; // Fuerza del impulso
    private Rigidbody rb; // Referencia al Rigidbody del objeto

    private void Start()
    {
        // Obt�n la referencia al componente Rigidbody
        rb = GetComponent<Rigidbody>();
    }

    // Funci�n para avanzar en el eje Z
    public void Avanzar()
    {
        Vector3 impulse = transform.forward * impulseForce;
        rb.AddForce(impulse, ForceMode.Impulse);
    }

    // Funci�n para retroceder en el eje Z
    public void Retroceder()
    {
        Vector3 impulse = -transform.forward * impulseForce;
        rb.AddForce(impulse, ForceMode.Impulse);
    }

    // Funci�n para avanzar en el eje X
    public void Derecha()
    {
        Vector3 impulse = transform.right * impulseForce;
        rb.AddForce(impulse, ForceMode.Impulse);
    }

    // Funci�n para avanzar en el eje X en la direcci�n opuesta
    public void Izquierda()
    {
        Vector3 impulse = -transform.right * impulseForce;
        rb.AddForce(impulse, ForceMode.Impulse);
    }
}
