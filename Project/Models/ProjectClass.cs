using System.Collections.Generic;

namespace Project.Models
{
  public class ProjectClass
  {
    public string Description { get; set; }
    private static List<ProjectClass> _instances = new List<ProjectClass> {};

    public ProjectClass (string description)
    {
      Description = description;
      _instances.Add(this);
    }

    public static List<ProjectClass> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}