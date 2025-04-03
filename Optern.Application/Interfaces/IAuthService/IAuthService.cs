﻿
namespace Optern.Application.Interfaces.IAuthService
{
    public interface IAuthService
    {
        public Task<Response<string>> RegisterAsync(RegisterDTO model);
        public Task<Response<string>> ConfirmAccount(string email, string otpCode);

        public Task<Response<bool>> SendResetPasswordEmail(string email);
        public Task<Response<bool>> VerifyOtpAndResetPassword(ResetPasswordDto dto);
        public  Task<Response<bool>> ResendOtpAsync(string email, OtpType otpType);

        public Task<Response<LogInResponseDTO>> LogInAsync(LogInDTO model);

        public Task<Response<bool>> LogOut();
        public Task<RefreshToken> GetOrCreateRefreshToken(ApplicationUser user);

    }
}
