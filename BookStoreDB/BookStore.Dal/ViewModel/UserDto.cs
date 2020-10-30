using BookStore.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Dal.ViewModel
{
    public class UserDto
    {
        public UserDto()
        {

        }

        public UserDto(User user)
        {
            FirstName = user.FirstName;
            LastName = user.LastName;
            Email = user.Email;
            Password = user.Password;
            Address = user.Address;
            foreach (var order in user.Orders)
            {
                Orders.Add(new OrderViewModel(order));
            }
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public ICollection<OrderViewModel> Orders { get; set; }
    }
}
