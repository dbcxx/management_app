﻿using backend_dotnet.Core.Dtos.Auth;
using backend_dotnet.Core.Dtos.General;
using System.Security.Claims;

namespace backend_dotnet.Core.Interfaces
{
    public interface IAuthService
    {
        Task<GeneralServiceResponseDto> SeedRolesAsync();
        Task<GeneralServiceResponseDto> RegisterAsync(RegisterDto registerDto);
        Task<LoginServiceResponseDto> LoginAsync(LoginDto loginDto);
        Task<GeneralServiceResponseDto> UpdateRoleAsync(ClaimsPrincipal User, UpdateRoleDto updateRoleDto);
        Task<LoginServiceResponseDto> MeAsync(MeDto meDto);
        Task<IEnumerable<UserInfoResult>> GetUsersListAsync();
        Task<UserInfoResult> GetUserDetailsByUserName(string userName);
        Task<IEnumerable<string>> GetUserNamesListAsync();
    }
}
