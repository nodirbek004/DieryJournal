using AutoMapper;
using DiaryJournal.Domain.Entitys.DiaryJournal;
using DiaryJournal.Domain.Entitys.Users;
using DiaryJournal.Service.DTOs.DierJournals;
using DiaryJournal.Service.DTOs.Users;

namespace DiaryJournal.Service.Mappers;

public class MappingProfile:Profile
{
    public MappingProfile()
    {
        CreateMap<User,UserCreationDTO>().ReverseMap();
        CreateMap<UserUpdateDTO,User>().ReverseMap();
        CreateMap<UserResulDTO,User>().ReverseMap();

        CreateMap<Journal, JournalCreationDTO>().ReverseMap();
        CreateMap<JournalUpdateDTO, Journal>().ReverseMap();
        CreateMap<JournalResultDTO, Journal>().ReverseMap();
        CreateMap<JournalResultDTO, JournalCreationDTO>().ReverseMap();
    }

}
