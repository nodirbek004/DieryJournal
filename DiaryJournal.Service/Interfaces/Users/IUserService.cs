using DiaryJournal.Service.DTOs.Users;

namespace DiaryJournal.Service.Interfaces.Users;

public interface IUserService
{
    Task<UserResulDTO> CreateAsync(UserCreationDTO dto);
    Task<UserResulDTO> UpdateAsync(UserUpdateDTO dto);
    Task<bool> DeleteAsync(long id);
    Task<UserResulDTO> GetByIdAsync (long id);
    Task<IEnumerable<UserResulDTO>> GetAllAssync();
}
