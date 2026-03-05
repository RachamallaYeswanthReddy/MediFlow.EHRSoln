using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MediFlow.EHR.Models
{
	public class EhrRecord
	{
		[Key]
		public int EhrId { get; set; }

		[Required]
		public int PatientId { get; set; }

		[Required]
		[StringLength(255)]
		public string Diagnosis { get; set; }

		public string DoctorNotes { get; set; }

		public DateTime VisitDate { get; set; } = DateTime.Now;

		// Navigation property for Entity Framework
		//[ForeignKey("PatientId")]
		//public virtual Patient Patient { get; set; }
	}
}
