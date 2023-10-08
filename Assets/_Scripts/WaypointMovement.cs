using UnityEngine;

public class WaypointMovement : MonoBehaviour
{
    public Transform[] waypoints; // Array de puntos por los que se mover� el objeto
    public float[] speeds; // Array de velocidades para cada segmento entre puntos
    private int currentWaypointIndex = 0; // �ndice del punto actual
    private float distanceToWaypoint; // Distancia al punto actual
    private Vector3 direction; // Direcci�n hacia el punto actual

    private void Start()
    {
        if (waypoints.Length == 0 || waypoints.Length != speeds.Length)
        {
            Debug.LogError("Aseg�rate de configurar los waypoints y las velocidades correctamente.");
            enabled = false; // Deshabilita el script si no est�n configurados correctamente.
        }

        // Inicializa la posici�n del objeto en el primer waypoint
        transform.position = waypoints[currentWaypointIndex].position;
    }

    private void Update()
    {
        // Calcula la direcci�n y distancia hacia el waypoint actual
        direction = (waypoints[currentWaypointIndex].position - transform.position).normalized;
        distanceToWaypoint = Vector3.Distance(transform.position, waypoints[currentWaypointIndex].position);

        // Mueve el objeto hacia el waypoint actual a la velocidad correspondiente
        transform.Translate(direction * speeds[currentWaypointIndex] * Time.deltaTime);

        // Si el objeto est� lo suficientemente cerca del waypoint actual, pasa al siguiente
        if (distanceToWaypoint < 0.1f)
        {
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length; // Avanza al siguiente waypoint
        }
    }
}
