using App.Persistence.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business.Dtos.Post
{
	internal class ViewPostDto
	{
		public string PostTitle { get; set; }
		public string PostContext { get; set; }
		public PostImage PostImage { get; set; }
	}
}
