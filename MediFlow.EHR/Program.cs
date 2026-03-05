using MediFlow.EHR.Models;
using MediFlow.EHR.Repositories;

IEhrRepository ehrRepo = new EhrRepository();

// Simulate adding a record
var newRecord = new EhrRecord
{
	PatientId = 1, // Assuming Patient 1 exists
	Diagnosis = "Acute Bronchitis",
	DoctorNotes = "Prescribed rest and hydration. Follow up in 5 days."
};

ehrRepo.CreateEhrEntry(newRecord);
Console.WriteLine("EHR Entry created successfully!");

// Retrieve records
var history = ehrRepo.GetEhrByPatient(1);
foreach (var entry in history)
{
	Console.WriteLine($"Date: {entry.VisitDate} | Diagnosis: {entry.Diagnosis}");
}