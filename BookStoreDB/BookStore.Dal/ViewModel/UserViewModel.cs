using BookStore.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Dal.ViewModel
{
    public class UserViewModel
    {
        public UserViewModel(User user)
        {
            User = new UserDto(user);
        }
        public UserDto User{ get; set; }
    }
}
