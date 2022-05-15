using System.ComponentModel.DataAnnotations;

namespace TimelyApp.Form
{
    public class ProjectForm
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string StartTime { get; set; }

        [Required]
        //[DisplayFormat(DataFormatString = "yyyy-MM-dd HH:mm:ss")]
        public string EndTime { get; set; }
    }
}
