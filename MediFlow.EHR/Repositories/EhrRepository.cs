using System;
using MediFlow.EHR.Data;
using MediFlow.EHR.Models;
using Microsoft.EntityFrameworkCore;

namespace MediFlow.EHR.Repositories
{
	public class EhrRepository : IEhrRepository
	{
		private readonly HospitalDbContext _context;

		public EhrRepository()
		{
			_context = new HospitalDbContext();
		}

		public void CreateEhrEntry(EhrRecord record)
		{
			_context.EhrRecords.Add(record);
			_context.SaveChanges();
		}

		public List<EhrRecord> GetEhrByPatient(int patientId)
		{
			return _context.EhrRecords
						   .Where(r => r.PatientId == patientId)
						   .OrderByDescending(r => r.VisitDate)
						   .ToList();
		}

		public void UpdateEhrEntry(EhrRecord record)
		{
			_context.EhrRecords.Update(record);
			_context.SaveChanges();
		}

		public EhrRecord GetEhrById(int ehrId)
		{
			return _context.EhrRecords.Find(ehrId);
		}
	}
}
