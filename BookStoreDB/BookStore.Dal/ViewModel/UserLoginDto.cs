using BookStore.Domain;

namespace BookStore.Dal.ViewModel
{
    public class UserLoginDto
    {
        public UserLoginDto()
        {
        }
        public UserLoginDto(User user)
        {
            Email = user.Email;
            Password = user.Password;
        }

        public string Email { get; set; }
        public string Password { get; set; }
    }
}