using System;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;

namespace UserManagement
{
    public class SafeAuthService
    {
        private readonly AuthService _auth;
        private readonly ILogger _logger;

        public SafeAuthService(AuthService auth)
        {
            _auth = auth;

            // Classic builder syntax (no top-level statements, no lambdas that capture 'builder')
            var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder.ClearProviders();
                builder.SetMinimumLevel(LogLevel.Information);
                builder.AddNLog();          // picks up nlog.config automatically
            });

            _logger = loggerFactory.CreateLogger("SafeAuthService");
        }

        public bool TryRegister(string user, string pass)
        {
            try
            {
                _auth.Register(user, pass);
                _logger.LogInformation("User {0} registered.", user);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Registration failed for {0}.", user);
                return false;
            }
        }

        public bool TryLogin(string user, string pass)
        {
            try
            {
                bool ok = _auth.Login(user, pass);
                _logger.LogInformation("Login {0} for {1}.", ok ? "succeeded" : "failed", user);
                return ok;
            }
            catch (Exception ex)
            {
                _logger.LogWarning(ex, "Login threw for {0}.", user);
                return false;
            }
        }
    }
}
