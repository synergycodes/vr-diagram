using UnityEngine;
using UnityEngine.UI;

public class CreateColorsPalette : MonoBehaviour
{
    private GameObject colorPaletteContainer; 
    public GameObject colorPrefab;

    private ModifyNodeColor modifyNodeColor;


    // Start is called before the first frame update
    void Start()
    {
        colorPaletteContainer = GameObject.Find("Color Palette");
        modifyNodeColor = gameObject.GetComponent<ModifyNodeColor>();

        for (int i = 0 ; i < Palette.colors.Length ; i++) {

                GameObject color = Instantiate(colorPrefab, colorPaletteContainer.transform);
                color.transform.localPosition = new Vector3(-130 + i * 60,0,0);
                color.transform.localScale = new Vector3(1,1,1);

                Color myColor = new Color();
                ColorUtility.TryParseHtmlString (Palette.colors[i], out myColor);
                color.GetComponent<Image>().color = myColor;
                color.GetComponent<Button>().onClick.AddListener(() => modifyNodeColor.modify(myColor));
        }    


        }

}
