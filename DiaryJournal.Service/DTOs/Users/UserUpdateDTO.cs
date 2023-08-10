﻿namespace DiaryJournal.Service.DTOs.Users;

public class UserUpdateDTO
{
    public long Id {  get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string PhoneNumber { get; set; }
}
