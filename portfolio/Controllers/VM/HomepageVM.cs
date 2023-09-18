using portfolio.Models;

namespace portfolio.Controllers.VM
{
    public class HomepageVM
    {
        public PersonalInfo? PersonalInfo { get; set; }
        public List<MyExpertise> MyExpertises { get; set; }
        public List<Education> Educations { get; set; }
    }
}
