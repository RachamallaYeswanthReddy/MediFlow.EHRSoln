using System;
using System.Collections.Generic;
using System.Text;
using MediFlow.EHR.Models;
using Microsoft.EntityFrameworkCore;

namespace MediFlow.EHR.Data
{
	public class HospitalDbContext : DbContext
	{
		public DbSet<EhrRecord> EhrRecords { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			// 2. Since you are using a Console App, it's easier to hardcode 
			// the string first to ensure it works, then move to ConfigManager.
			optionsBuilder.UseSqlServer(@"Data Source=LTIN691219\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=true;TrustServerCertificate=true");
		}
	}
}
