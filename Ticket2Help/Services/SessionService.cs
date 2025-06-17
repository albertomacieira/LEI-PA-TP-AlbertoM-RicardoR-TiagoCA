using Ticket2Help.Models;

namespace UI.Services
{
    public static class SessionService
    {
        private static User? _currentUser;

        public static User? CurrentUser => _currentUser;

        public static bool IsAuthenticated => _currentUser != null;

        public static void Login(User user)
        {
            _currentUser = user;
        }

        public static void Logout()
        {
            _currentUser = null;
        }
    }
}
