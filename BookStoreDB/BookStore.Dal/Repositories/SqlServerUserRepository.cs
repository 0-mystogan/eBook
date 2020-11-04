using BookStore.Dal.Context;
using BookStore.Dal.Helper;
using BookStore.Dal.Repositories;
using BookStore.Dal.ViewModel;
using BookStore.Domain;
using BookStore.Filter;
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
        private readonly IUriRepository _uriRepostory;
        public SqlServerUserRepository(BookStoreDbContext bookStoreDbContext, IUriRepository uriRepository)
        {
            _bookStoreDbContext = bookStoreDbContext;
            _uriRepostory = uriRepository;
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

        public async Task<UserDto> UpdateUser(UserDto user, CancellationToken cancellationToken = default)
        {
            var updateUser =  await _bookStoreDbContext.Users.FirstOrDefaultAsync(u => u.Id == user.Id, cancellationToken);

            updateUser.FirstName = user.FirstName;
            updateUser.LastName = user.LastName;
            updateUser.Address = user.Address;
            updateUser.Email = user.Email;
            updateUser.Password = user.Password;

            _bookStoreDbContext.Users.Update(updateUser);
            await _bookStoreDbContext.SaveChangesAsync(cancellationToken);

            return new UserViewModel(updateUser).User;
        }

        public async Task<UserDto> UpdateImage(UserDto user, CancellationToken cancellationToken = default)
        {
            var _user = await _bookStoreDbContext.Users.FirstOrDefaultAsync(u => u.Id == user.Id, cancellationToken);

            _user.Image = user.Image;

            _bookStoreDbContext.Users.Update(_user);
            await _bookStoreDbContext.SaveChangesAsync(cancellationToken);

            return new UserViewModel(_user).User;
        }

        public async Task<UserDto> GetUserById(int id, CancellationToken cancellation = default)
        {
            var _user = await _bookStoreDbContext.Users.FirstOrDefaultAsync(u => u.Id == id);
            return new UserViewModel(_user).User;
        }

        public async Task<PageDto<List<UserDto>>> GetAll(PaginationFilter filter, string route,CancellationToken cancellation = default)
        {
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            var pagedData = await _bookStoreDbContext.Users
                .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
                .Take(validFilter.PageSize)
                .ToListAsync();
            var totalRecords = await _bookStoreDbContext.Users.CountAsync();

            
            
            List<UserDto> userDto = new List<UserDto>();
            foreach (var user in pagedData)
            {
                userDto.Add(new UserViewModel(user).User);
            }
            return PaginationHelper.CreatePagedReponse<UserDto>(userDto, validFilter, totalRecords, _uriRepostory, route);
        }
    }
}
