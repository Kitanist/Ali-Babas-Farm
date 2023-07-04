using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Humanoid", menuName = "Human")]

public class Humanoid : ScriptableObject
{
    [Header("Degerler")]
    private int _health;
    private int _productivity;
    private int _age;
    private int _educationLevel;
    private string _name;
    public bool isGenderMale;
    public bool isMarried;
    public string statuco;
    public bool isHeadofFamily;
   
    // bebek yap , aile reisi yap, çiftlikten yolla , okula gönder,ilaç ver
    public int Health
    {
        get => _health;
        set 
        {
            _health = value; 
        }
    }
    public int Productivity
    {
        get => _productivity;
        set
        { 
            _productivity = value; 
        }
    }
    public int Age 
    { 
        get => _age;
        set
        {
            _age = value; 
        }
    }
    public int EducationLevel 
    {
        get => _educationLevel;
        set
        {
            _educationLevel = value;
        }
    }
    public string Name 
    {
        get => _name;
        set 
        {
            _name = value;
        }
    }
}
