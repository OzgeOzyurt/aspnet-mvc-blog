using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business.Dtos.User
{
	internal class CreateOrEditUserDto
	{
		public string UserName { get; set; }
		public string UserSurname { get; set; }
		public string UserNick { get; set; }
		public string UserEmail { get; set; }
	}
}
