using BookStore.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Dal.ViewModel
{
    public class UserLoginViewModel
    {
        public UserLoginViewModel(User user)
        {
            User = new UserLoginDto(user);
        }
        public UserLoginDto User { get; set; }
    }
}
