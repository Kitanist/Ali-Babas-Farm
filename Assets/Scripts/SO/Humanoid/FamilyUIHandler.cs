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
        humanName.text = "�smi : " + Human.Name;
        age.text = "Ya�� : " + Human.Age.ToString();
        Statuco.text = "Aile i�indeki konumu : " + Human.statuco;
        Productivity.text = "�� y�k� : " + Human.Productivity.ToString();
        Education.text = "Okul durumu : " + Human.EducationLevel.ToString();
        MartialStatus.text = "Medeni hali  : " + Human.isMarried.ToString();
        Health.text = Human.Health.ToString();
        Gender.text = "Cinsiyeti :" + Human.isGenderMale.ToString();
    }

}
