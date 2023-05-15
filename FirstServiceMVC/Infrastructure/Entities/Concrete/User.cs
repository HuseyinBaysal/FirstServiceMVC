using FirstServiceMVC.Infrastructure.Entities.Abstract;

namespace FirstServiceMVC.Infrastructure.Entities.Concrete
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EMail { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

    }
}
