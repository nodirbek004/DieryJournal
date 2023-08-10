using DiaryJournal.Service.DTOs.Users;
using DiaryJournal.Service.Helpers;
using System.Globalization;

namespace DiaryJournal.Service.Interfaces.Users;

public interface IUserService
{
    Task<Responce<UserResulDTO>> CreateAsync(UserCreationDTO dto);
    Task<Responce<UserResulDTO>> UpdateAsync(UserUpdateDTO dto);
    Task<Responce<bool>> DeleteAsync(long id);
    Task<Responce<UserResulDTO>> GetByNumberAsync (string number);

    Task<Responce<IEnumerable<UserResulDTO>>> GetAllAssync();

}
