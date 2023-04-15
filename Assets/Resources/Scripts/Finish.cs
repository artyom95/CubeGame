using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField]
    private WinText _winText;
    
    private void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.gameObject.CompareTag(GlobalConstants.PLAYER_TAG))
        {
            _winText.Show();
        }
    }
}