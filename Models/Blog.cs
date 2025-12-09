using System;
namespace blogging_platform.Models
{
	public class Blog
	{
		public int Id { get; set; }
		public string title { get; set; }
		public string content { get; set; }

        public Blog()
		{
		}
	}
}

