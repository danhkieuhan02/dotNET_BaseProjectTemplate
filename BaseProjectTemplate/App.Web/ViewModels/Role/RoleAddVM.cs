﻿using App.Share.Consts;
using DNews.Shared.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.ViewModels.Role
{
	public class RoleAddVM
	{
		[AppRequired]
		[AppStringLength(2, DB.AppRole.NAME_LENGTH)]
		public string Name { get; set; }
		[AppRequired]
		[AppStringLength(2, DB.AppRole.DESC_LENGTH)]
		public string Desc { get; set; }

		// Chuỗi chứa permissionId, phân tách bởi dấu phẩy
		public string PermissionIds { get; set; }
	}
}