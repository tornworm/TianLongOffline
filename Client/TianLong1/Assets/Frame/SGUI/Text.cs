using UnityEngine.EventSystems;
public class Text : UnityEngine.UI.Text, IPointerEnterHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        DebugT.Log("ddd");
    }
}
