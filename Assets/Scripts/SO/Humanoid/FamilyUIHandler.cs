using TMPro;
using UnityEngine;

public class FamilyUIHandler : MonoBehaviour
{
    [SerializeField] Humanoid Human;
    public TextMeshProUGUI humanName,age,Statuco,Productivity,Education,MartialStatus,Health,Gender;
    private void Start()
    {
        initFamilyUI();
    }
    public void initFamilyUI()
    {
        humanName.text = "Ýsmi : " + Human.Name;
        age.text = "Yaþý : " + Human.Age.ToString();
        Statuco.text = "Aile içindeki konumu : " + Human.statuco;
        Productivity.text = "Ýþ yükü : " + Human.Productivity.ToString();
        Education.text = "Okul durumu : " + Human.EducationLevel.ToString();
        MartialStatus.text = "Medeni hali  : " + Human.isMarried.ToString();
        Health.text = Human.Health.ToString();
        Gender.text = "Cinsiyeti :" + Human.isGenderMale.ToString();
    }

}
