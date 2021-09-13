using UnityEngine;
using UnityEngine.EventSystems;

public class TapArea : MonoBehaviour, IPointerDownHandler
{
    private void Start() { }
    private void Update() { }
    public void OnPointerDown(PointerEventData eventData)
    {
        GameManager.Instance.CollectByTap(eventData.position, transform);
    }
}