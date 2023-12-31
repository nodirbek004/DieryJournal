﻿using DiaryJournal.Data.Contexts;
using DiaryJournal.Data.IReapasitories;
using DiaryJournal.Data.IReapasitories.Commons;
using DiaryJournal.Domain.Entitys.DiaryJournal;
using DiaryJournal.Domain.Entitys.Users;

namespace DiaryJournal.Data.Repasitories.Commons;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext dbContext;
    public UnitOfWork()
    {
        dbContext = new AppDbContext();
        UserRepasitory = new UserRepasitory(dbContext);
        JournalRepasitory = new Repasitory<Journal>(dbContext);
    }
    public IUserRepasitory UserRepasitory { get; }
    public IRepasitory<Journal> JournalRepasitory { get; }



    public void Dispose()
    {
        GC.SuppressFinalize(true);
    }





}
