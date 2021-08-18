using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DVG.Oto.Web.Models.Api {
	public class Category {		
		public Guid Id { get; set; }
		public Guid ParentId { get; set; }
		public Guid SiteId { get; set; }
		public string Name { get; set; }		
		public string SeoTitle { get; set; }
		public string SeoSapo { get; set; }
		public string SeoKeyword { get; set; }
		public int Status { get; set; }
	}
}
