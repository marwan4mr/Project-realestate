
using AutoMapper;
using Realstate_BL;
using Realstate_DAL;

public class UserManager : IUserManager
{
    private readonly IUserRepo _userRepo;
    private readonly IMapper _mapper;

    public UserManager(IUserRepo userRepo , IMapper mapper)
    {
        _userRepo = userRepo;
        _mapper = mapper;
    }

    public List<UserReadDTO> GetAllUsers()
    {
        var usersDB = _userRepo.GetAll().ToList();
        var usersDTO = _mapper.Map<List<UserReadDTO>>(usersDB);

        return usersDTO;
    }
    public UserReadDTO? GetUserById(Guid id)
    {
        var usersDB = _userRepo.GetById(id);

        if (usersDB == null)
            return null;

        var usersDTO = _mapper.Map<UserReadDTO>(usersDB);
        return usersDTO;
    }
    public UserReadDTO AddUser(UserWriteDTO userDTO)
    {
       var userdb = _mapper.Map<UserClass>(userDTO);
        userdb.Id = Guid.NewGuid();
        _userRepo.Add(userdb);
        _userRepo.SaveChanges();
        return _mapper.Map<UserReadDTO>(userdb);
    }
    public bool EditUser(UserWriteDTO userDTO)  
    {
        var userDb = _userRepo.GetById(userDTO.UserId);
        if(userDb==null)
            return false;
        _mapper.Map(userDb, userDTO);
        _userRepo.Update(userDb);
        _userRepo.SaveChanges();
        return true;
    }

    public void DeleteUser(Guid id)
    {
        var userDb = _userRepo.GetById(id);
        if (userDb == null)
            return;
        _userRepo.Delete(userDb);
    }

    public List<UserReadDTO> GetAllUsersInCompany()
    {
        var DBUsers = _userRepo.GetUsersWithCompany();
        return _mapper.Map<List<UserReadDTO>>(DBUsers);
    }
}
