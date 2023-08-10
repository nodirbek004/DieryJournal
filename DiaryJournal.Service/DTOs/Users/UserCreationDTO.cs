﻿namespace DiaryJournal.Service.DTOs.Users;

public class UserCreationDTO
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string PhoneNumber { get; set; }
}
