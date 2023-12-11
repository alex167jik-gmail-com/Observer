class Program
{
    static void Main()
    {
        // Crear el sujeto (información del paciente)
        var patient = new PatientSubject("Jhonny Cage");
        // Crear observadores (módulos médicos)
        var module1 = new MedicalModule("Cardiologia");
        
        var module2 = new MedicalModule("Neurologia");

        // Agregar observadores al sujeto
        patient.AddObserver(module1);
        patient.AddObserver(module2);
        patient.Condition = "Estable";
        // Cambiar la condición del paciente para notificar a los observadores

        // Resultado esperado: Ambos módulos médicos imprimirán un mensaje indicando el cambio en la condición del paciente.
    }
}