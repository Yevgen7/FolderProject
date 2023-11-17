namespace FolderProject.Models
{
    public class IndexViewModel
    {
        public string? ParentName;
        public IEnumerable<Folder>? folders { get; set; }
    }
}
