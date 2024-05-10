using UserModel;
using UserDTO;


namespace UserService
{
    public class UserServices
    {
        private readonly List<MUser> _users;
        private int _userIdCounter;

        public UserServices()
        {
            _users = new List<MUser>(); 
            _userIdCounter = 1; 
        }

        public IEnumerable<MUser> CreateUser(IUser userData)
        {
            var newUser = new MUser
            {
                id = _userIdCounter, 
                Username = userData.Username,
                Email = userData.Email,
                Tickets = new List<TicketModel.Ticket>() 
            };
            _users.Add(newUser);
            return _users.ToArray();
        }



        public List<IUser> GetAllUsers()
        {
            var userDtos = new List<IUser>();
            foreach (var user in _users)
            {
                var userDto = new IUser
                {
                    Username = user.Username,
                    Email = user.Email
                };
                userDtos.Add(userDto);
            }
            return userDtos;
        }

    }
}
