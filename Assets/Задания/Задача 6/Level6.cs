using Resources.Scripts;
using Unity.VisualScripting;
using UnityEngine;

public class Level6 : MonoBehaviour
{
    [SerializeField] 
    private GameObject _obstacle;
    
    private float _speed = 7;

    private void Start()
    {
        Instantiate(_obstacle);
     
    }

    private void Update()
    {
        var step = Time.deltaTime * _speed;
        var transformPosition = transform.position;
        transformPosition.x += step;

        transform.position = transformPosition;
       
    }
    
   
}