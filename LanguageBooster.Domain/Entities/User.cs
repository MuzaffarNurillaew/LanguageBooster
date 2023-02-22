using LanguageBooster.Domain.Commons;

namespace LanguageBooster.Domain.Entities
{
    public class User : Auditable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
