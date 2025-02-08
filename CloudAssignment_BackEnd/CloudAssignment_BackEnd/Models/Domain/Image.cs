using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;

namespace CloudAssignment_BackEnd.Models.Domain
{
    public class Image
    {
        public Guid ImageID { get; set; }

        [NotMapped] // Exclude this property from the database
        public IFormFile File { get; set; }

        public string FileName { get; set; }

        public string? FileDescription { get; set; }
        public string FileExtension { get; set; }

        public long FileSizeInBytes { get; set; }

        public string FilePath { get; set; }
    }
}
