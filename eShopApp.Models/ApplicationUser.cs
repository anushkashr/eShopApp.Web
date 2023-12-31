﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopApp.Models
{
	public class ApplicationUser:IdentityUser<int>
	{
		[Required]
		public string? Name { get; set; }
		[Required]
		public string? Address { get; set; }
		[Required]
		public string? City { get; set; }
		[Required]
		public string? State { get; set; }
		[Required]
		public string? PostalCode { get; set; }
	}
}
