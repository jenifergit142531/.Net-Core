using System.ComponentModel.DataAnnotations;

namespace EFCoreDemo.Models
{
public class Employee
{
    [Key]
    public int Eid { get; set; }
    public string Ename { get; set; }
    public string Role { get; set; }
    public int Salary { get; set; }
}
}
