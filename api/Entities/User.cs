using api.Entities.Bases;

namespace api.Entities
{
    public class User : AbstractEntity<long>
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? FullName { get; set; }
        public string UserName { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? Code { get; set; }
        public string? Avatar { get; set; }
        public int? Type { get; set; }
        public string? Phone { get; set; }
        public string? CardId { get; set; }
        public DateTime? Birthday { get; set; }
        public byte? TypeThird { get; set; }
        public DateTime? LastLoginAt { get; set; }
        public string? RegEmail { get; set; }
        public bool? IsPhoneConfirm { get; set; }
        public bool? IsEmailConfirm { get; set; }
        public int? LanguageId { get; set; }

    }
}
