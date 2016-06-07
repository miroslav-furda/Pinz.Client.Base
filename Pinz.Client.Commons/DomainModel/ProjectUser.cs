using Com.Pinz.DomainModel;

namespace Com.Pinz.Client.DomainModel
{
    public class ProjectUser : User, IProjectUser
    {
        public bool IsProjectAdmin { get; set; }
    }
}
