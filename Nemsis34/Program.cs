using System;

namespace Nemsis34
{
  class Program
  {
    static void Main(string[] args)
    {
      var emsPatient = new ePatient()
      {
        ePatient01 = "42", // Identifier

        ePatientPatientNameGroup = new ePatientEPatientPatientNameGroup
        {
          ePatient02 = new ePatientEPatientPatientNameGroupEPatient02
          {
            Value = "Twohey" // Last Name
          },
          ePatient03 = new ePatientEPatientPatientNameGroupEPatient03
          {
            Value = "Michael" // First Name
          },
          ePatient04 = "A" // Middle Initial
        }
      };

      Console.WriteLine(
        $"Patient Name { emsPatient.ePatientPatientNameGroup.ePatient03.Value } " +
        $"{ emsPatient.ePatientPatientNameGroup.ePatient02.Value }");

      Console.ReadLine();
    }
  }
}
