using App.Data.DataSeeders;
using App.Data.Entities;
using App.Data.Entities.Base;
using App.Share.Consts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Configurations
{
	public static class AppCategoryConfig : IEntityTypeConfiguration<AppCategoryConfig>
	{
		public void Configure(this EntityTypeBuilder<AppCategory> builder)
		{
			builder.ToTable(DB.AppCategory.TABLE_NAME);

			// Khóa chính
			builder.HasKey(m => m.Id);

			builder.Property(m => m.Name)
				.HasMaxLength(DB.AppRole.NAME_LENGTH)
				.IsRequired();
		}
	}
}
