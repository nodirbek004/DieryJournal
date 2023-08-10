using AutoMapper;
using DiaryJournal.Data.Contexts;
using DiaryJournal.Data.IReapasitories.Commons;
using DiaryJournal.Data.Repasitories;
using DiaryJournal.Data.Repasitories.Commons;
using DiaryJournal.Domain.Entitys.Users;
using DiaryJournal.Service.DTOs.Users;
using DiaryJournal.Service.Helpers;
using DiaryJournal.Service.Interfaces.Users;
using DiaryJournal.Service.Mappers;
using Microsoft.EntityFrameworkCore;

namespace DiaryJournal.Service.Services.Users;

public class UserService : IUserService
{
    private readonly IMapper mapper;
    private readonly IUnitOfWork unitOfWork;
    private readonly AppDbContext dbContext;
    public UserService()
    {
        this.dbContext = new AppDbContext();
        this.unitOfWork = new UnitOfWork(dbContext);
        this.mapper=new Mapper(new MapperConfiguration(x=>x.AddProfile<MappingProfile>()));
    }
    public async Task<Responce<UserResulDTO>> CreateAsync(UserCreationDTO dto)
    {
        var existUser = await unitOfWork.UserRepasitory.SelectAsync(t => t.PhoneNumber.Equals(dto.PhoneNumber));
        if (existUser is not null)
            return new Responce<UserResulDTO>
            {
                StatusCode = 403,
                Message = "this User not Found"
            };
        var mappedUser=mapper.Map<User>(dto);
        await unitOfWork.UserRepasitory.CreateAsync(mappedUser);
        var test = await dbContext.SaveChangesAsync();
        var result = mapper.Map<UserResulDTO>(mappedUser);
        return new Responce<UserResulDTO>
        {
            StatusCode = 200,
            Message = "succesfull",
            Data= result
        };

    }

    public async Task<Responce<bool>> DeleteAsync(long id)
    {
        var existUser= await unitOfWork.UserRepasitory.SelectAsync(x=>x.Id.Equals(id));
        if (existUser is null)
            return new Responce<bool>
            {
                StatusCode = 404,
                Message = "This patient not found!",
                Data = false
            };
        unitOfWork.UserRepasitory.Delete(existUser);
        //await unitOfWork.SaveAsync();
        return new Responce<bool>
        {
            StatusCode = 200,
            Message = "Success",
            Data = true
        };

    }

    public async Task<Responce<IEnumerable<UserResulDTO>>> GetAllAssync()
    {
        var users = unitOfWork.UserRepasitory.SelectAll();
        List<UserResulDTO> result = new List<UserResulDTO>();
        foreach( var user in users)
        {
            result.Add(mapper.Map<UserResulDTO>(user));
        }

        return new Responce<IEnumerable<UserResulDTO>>
        {
            StatusCode = 200,
            Message = "succes",
            Data = result
        };
    }



    public async Task<Responce<UserResulDTO>> GetByNumberAsync(string number)
    {
        var existUser=unitOfWork.UserRepasitory.SelectAsync(x=>x.PhoneNumber.Equals(number));
        if (existUser is null)
            return new Responce<UserResulDTO>
            {
                StatusCode=404,
                Message="This User not found"
            };
        var result =mapper.Map<UserResulDTO>(existUser);
        return new Responce<UserResulDTO>
        {
            StatusCode = 200,
            Message = "succesfull",
            Data = result
        };

    }



    public async Task<Responce<UserResulDTO>> UpdateAsync(UserUpdateDTO dto)
    {
        User existuser = await this.unitOfWork.UserRepasitory.SelectAsync(x=>x.PhoneNumber.Equals(dto.PhoneNumber));
        if (existuser is  null)
            return new Responce<UserResulDTO>
            {
                StatusCode = 403,
                Message = "Not Found"

            };
        mapper.Map(dto, existuser); 
        unitOfWork.UserRepasitory.Update(existuser);
        //await unitOfWork.SaveAsync();

        var result = mapper.Map<UserResulDTO>(existuser);
        return new Responce<UserResulDTO>
        {
            StatusCode = 200,
            Message = "Succesfull",
            Data = result
        };


    }


}
