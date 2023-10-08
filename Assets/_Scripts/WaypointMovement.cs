using UnityEngine;

public class WaypointMovement : MonoBehaviour
{
    public Transform[] waypoints; // Array de puntos por los que se moverá el objeto
    public float[] speeds; // Array de velocidades para cada segmento entre puntos
    private int currentWaypointIndex = 0; // Índice del punto actual
    private float distanceToWaypoint; // Distancia al punto actual
    private Vector3 direction; // Dirección hacia el punto actual

    private void Start()
    {
        if (waypoints.Length == 0 || waypoints.Length != speeds.Length)
        {
            Debug.LogError("Asegúrate de configurar los waypoints y las velocidades correctamente.");
            enabled = false; // Deshabilita el script si no están configurados correctamente.
        }

        // Inicializa la posición del objeto en el primer waypoint
        transform.position = waypoints[currentWaypointIndex].position;
    }

    private void Update()
    {
        // Calcula la dirección y distancia hacia el waypoint actual
        direction = (waypoints[currentWaypointIndex].position - transform.position).normalized;
        distanceToWaypoint = Vector3.Distance(transform.position, waypoints[currentWaypointIndex].position);

        // Mueve el objeto hacia el waypoint actual a la velocidad correspondiente
        transform.Translate(direction * speeds[currentWaypointIndex] * Time.deltaTime);

        // Si el objeto está lo suficientemente cerca del waypoint actual, pasa al siguiente
        if (distanceToWaypoint < 0.1f)
        {
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length; // Avanza al siguiente waypoint
        }
    }
}
