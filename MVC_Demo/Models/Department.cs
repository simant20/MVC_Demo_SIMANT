using System;
using System.ComponentModel.DataAnnotations;

namespace MVC_Demo.Models
{
	public class Department
	{
        [Key]
            public int DeptID { get; set; }

        [Required]
        public string DeptName { get; set; }

       
    }
}

