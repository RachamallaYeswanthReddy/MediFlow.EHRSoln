using System;
using System.Collections.Generic;
using System.Text;
using MediFlow.EHR.Models;

namespace MediFlow.EHR.Repositories
{
	public interface IEhrRepository
	{
		void CreateEhrEntry(EhrRecord record);
		void UpdateEhrEntry(EhrRecord record);
		List<EhrRecord> GetEhrByPatient(int patientId);
		EhrRecord GetEhrById(int ehrId);
	}
}
