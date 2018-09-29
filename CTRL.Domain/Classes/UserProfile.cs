namespace CTRL.Domain.Classes
{
    public class UserProfile
    {
        public int UserIdentifier { get; set; }

        public string LoginName { get; set; }

        public bool IsActive {
            get
            {
                return UserIdentifier > 0;
            }
        }
    }
}
