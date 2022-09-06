using AutoMapper;
using KonusarakOgren.Core.DT0s.Users;
using KonusarakOgren.Core.Models;
using KonusarakOgren.Core.Repositories;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.Repository.Repositories
{
    public class AuthManager : IAuthManager
    {
        private readonly IMapper _mapper;
        private readonly UserManager<ApiUser> _userManager;

        public AuthManager(UserManager<ApiUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<bool> Login(LoginDto loginDto)
        {
            var _user = await _userManager.FindByNameAsync(loginDto.UserName);
            if (_user is null)
            {
                return default;
            }

            bool isValidCredentials = await _userManager.CheckPasswordAsync(_user, loginDto.Password);

            if (!isValidCredentials)
            {
                return default;
            }
            return isValidCredentials;
        }

        public async Task<IEnumerable<IdentityError>> RegisterAdmin(ApiUserDto userDto)
        {
            var user = _mapper.Map<ApiUser>(userDto);
            user.UserName = userDto.UserName;

            var result = await _userManager.CreateAsync(user, userDto.Password);

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "Admin");
            }

            return result.Errors;
        }

        public async Task<IEnumerable<IdentityError>> RegisterSysAdmin(ApiUserDto userDto)
        {
            var user = _mapper.Map<ApiUser>(userDto);
            user.UserName = userDto.UserName;

            var result = await _userManager.CreateAsync(user, userDto.Password);

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "SysAdmin");
            }

            return result.Errors;
        }

        async Task<IEnumerable<IdentityError>> IAuthManager.Register(ApiUserDto userDto)
        {
            var user = _mapper.Map<ApiUser>(userDto);
            user.UserName = userDto.UserName;

            var result = await _userManager.CreateAsync(user, userDto.Password);

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "Customer");
            }

            return result.Errors;
        }
    }
}
