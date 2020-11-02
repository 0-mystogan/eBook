using BookStore.Dal.ViewModel;
using BookStore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BookStore.Dal.ViewModel
{
    public interface IUserRepository
    {
        Task<UserViewModel> AddUser(UserDto userRegister, CancellationToken cancellationToken = default);
        Task<UserDto> LogInUser(UserLoginDto userLogin, CancellationToken cancellationToken = default);
        Task<UserDto> UpdateUser(UserDto user, CancellationToken cancellationToken = default);
    }
}
