using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FolderProject.Models
{
    [Table("Folder")]
    public class Folder
    {
        [Key]
        [Required]
        public int FolderId { get; set; }

        [Required]
        public string Name { get; set; }
        public int? ParentId { get; set; } = null;


        [ForeignKey("ParentId")]
        public Folder? ParentDirectory { get; set; }

        public List<Folder>? ChildDirectories { get; set; }

        public Folder()
        {
            ChildDirectories = new List<Folder>();
        }

    }
}
