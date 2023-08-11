using AutoMapper;
using DiaryJournal.Data.Contexts;
using DiaryJournal.Data.Repasitories.Commons;
using DiaryJournal.Domain.Entitys.DiaryJournal;
using DiaryJournal.Service.DTOs.DierJournals;
using DiaryJournal.Service.Helpers;
using DiaryJournal.Service.Interfaces.DiaryJournals;
using DiaryJournal.Service.Mappers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace DiaryJournal.Service.Services.Journals;

public class JournalServive : IJournalService
{
    private UnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public JournalServive()
    {
        this.unitOfWork = new UnitOfWork();
        this.mapper = new Mapper(new MapperConfiguration(x => x.AddProfile<MappingProfile>()));
        
    }
    public async Task<Responce<JournalResultDTO>> CreateAsync(JournalCreationDTO dto)
    {
        var existJournal = (await unitOfWork.JournalRepasitory.SelectAsync(x => x.Name.Equals(dto.Name)));
        if (existJournal is not null)
            return new Responce<JournalResultDTO>
            {
                StatusCode = 404,
                Message = "Error",

            };
        var mappedJournal = mapper.Map<Journal>(dto);
        await unitOfWork.JournalRepasitory.CreateAsync(mappedJournal);
        var result=mapper.Map<JournalResultDTO>(mappedJournal);

        return new Responce<JournalResultDTO>
        {
            StatusCode = 200,
            Message = "OK",
            Data = result
        };
           
    }

    public async Task<Responce<bool>> DeleteAsync(string name)
    {
        var existJournal = await unitOfWork.JournalRepasitory.SelectAsync(x => x.Id.Equals(name));
        if (existJournal is null)
            return new Responce<bool>
            {
                StatusCode = 404,
                Message = "Not found",
                Data = false
            };
        
         unitOfWork.JournalRepasitory.Delete(existJournal);

        return new Responce<bool>
        {
            StatusCode = 200,
            Message = "Success",
            Data = true
        };
    }

    public Responce<IEnumerable<JournalResultDTO>> GetAllAsync()
    {
        var journals=unitOfWork.JournalRepasitory.SelectAll();
        List<JournalResultDTO> result = new List<JournalResultDTO>();
        foreach(var journal in journals)
        {
            result.Add(mapper.Map<JournalResultDTO>(journal));
            
        }
        return new Responce<IEnumerable<JournalResultDTO>>
        {
            StatusCode = 200,
            Message = "OK",
            Data = result
        };
    }

    public async Task<Responce<JournalResultDTO>> GetByNameAsync(string name)
    {
        var existJournal = unitOfWork.JournalRepasitory.SelectAsync(x=>x.Name.Equals(name));
        if (existJournal is null)
            return new Responce<JournalResultDTO>
            {
                StatusCode = 404,
                Message = "OK"
            };
        var result=mapper.Map<JournalResultDTO>(existJournal);
        return new Responce<JournalResultDTO> { StatusCode = 200,Message = "OK", Data=result};
    }

    public async Task<Responce<JournalResultDTO>> UpdateAsync(JournalUpdateDTO dto)
    {
        var exsistJournal = await this.unitOfWork.JournalRepasitory.SelectAsync(x => x.Name.Equals(dto.Name));
        if (exsistJournal is  null)
            return new Responce<JournalResultDTO>
            {
                StatusCode = 404,
                Message = "Error"
            };
        mapper.Map(dto, exsistJournal);
        unitOfWork.JournalRepasitory.Update(exsistJournal);

        var result =mapper.Map<JournalResultDTO>(exsistJournal);
        return new Responce<JournalResultDTO> { StatusCode = 200,Message = "OK", Data=result};


    }
}
