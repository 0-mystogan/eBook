using BookStore.Dal.Context;
using BookStore.Dal.ViewModel;
using BookStore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BookStore.Dal.ViewModel
{
    public class SqlServerUserRepository : IUserRepository
    {
        private readonly BookStoreDbContext _bookStoreDbContext;
        public SqlServerUserRepository(BookStoreDbContext bookStoreDbContext)
        {
            _bookStoreDbContext = bookStoreDbContext;
        }

        public async Task<UserViewModel> AddUser(UserDto userRegister, CancellationToken cancellationToken = default)
        {
            var userDomain = new User
            {
                FirstName = userRegister.FirstName,
                LastName = userRegister.LastName,
                Email = userRegister.Email,
                Password = userRegister.Password,
                Address = userRegister.Address,
                CreatedBy = userRegister.FirstName.ToLower() + userRegister.LastName.ToLower()
            };
            await _bookStoreDbContext.Users.AddAsync(userDomain, cancellationToken);
            await _bookStoreDbContext.SaveChangesAsync(cancellationToken);
            return new UserViewModel(userDomain);
        }


        public async Task<UserDto> LogInUser(UserLoginDto userLogin, CancellationToken cancellationToken = default)
        {
            User User = await _bookStoreDbContext.Users.FirstOrDefaultAsync(u => u.Email == userLogin.Email && u.Password == userLogin.Password);
            //User.Orders = await _orderRepository.GetOrders(User.Id);
            return new UserViewModel(User).User;
        }

    }
}
