using System;
using System.Collections.Generic;

public class PatientSubject
{
    private List<IPatientObserver> observers = new List<IPatientObserver>();
    private string patientName;
    private string condition;

    public PatientSubject(string name)
    {
        patientName = name;
        condition = "Estable";  
    }

    public string Condition
    {
        get => condition;
        set
        {
            condition = value;
            NotifyObservers();

        }
    }

    public void AddObserver(IPatientObserver observer)
    {
        observers.Add(observer);
    }   

    public void RemoveObserver(IPatientObserver observer)
    {
        observers.Remove(observer);
    }

    private void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(patientName, condition);
        }
    }
}