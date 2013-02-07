using System;
using System.Collections.Generic;

namespace TeamMateContext
{
	/// <summary>
	/// Build type entity.
	/// </summary>
	public class BuildType
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string Href { get; set; }
		public string ProjectName { get; set; }
		public string ProjectId { get; set; }
		public string WebUrl { get; set; }
	}
	
	public class BuildTypes
	{
		public List<BuildType> BuildType { get; set; }
	}

	/// <summary>
	/// Project entity.
	/// </summary>
	public class Project
	{
		public string Description { get; set; }
		public bool Archived { get; set; }
		public string WebUrl { get; set; }
		public string Id { get; set; }
		public string Name { get; set; }
		public string Href { get; set; }
		public BuildTypes BuildTypes { get; set; }
		public object Templates { get; set; }
		public object Parameters { get; set; }
	}
}