using App.Data.Entities;
using App.Share.Consts;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.DataSeeders
{
	public static class AppCategorySeeder
	{
		public static void SeedData(this EntityTypeBuilder<AppCategory> builder)
		{
			var now = new DateTime(year: 2023, month: 12, day: 1);

			// Tạo vai trò
			var listCategory = new List<AppCategory>()
			{
				Id = 1,
				Name = "Laptop",
				CreatedDate = now,
				UpdatedDate = now,
			},
			new List<AppCategory>();
			{
				Id = 2,
				Name = "Mobile phone",
				CreatedDate = now,
				UpdatedDate = now,
			};

			builder.HasData(listCategory);
		}
	}
}
