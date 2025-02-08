using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace CloudAssignment_BackEnd.Models.Domain
{
    public class Doctor
    {
        [Key]
        public string Username { get; set; }
        public string Specialization { get; set; }
        public bool Availability { get; set; }
    }
}
