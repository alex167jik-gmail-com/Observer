using System;

public class MedicalModule : IPatientObserver
{
    private string moduleName;

    public MedicalModule(string name)
    {
        moduleName = name;
    }

    public void Update(string patientName, string Condition)
    {
        Console.WriteLine($"{moduleName} reciben noticias del paciente {patientName}: Condición: {Condition}");
    }
}