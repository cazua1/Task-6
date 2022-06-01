using UnityEngine;

public class UnitDestroyer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Unit>(out Unit unit))
        {
            Destroy(unit.gameObject);
        }
    }
}
