﻿namespace API.Models.DTO
{
    public class StudentDetailDto
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string StudentClass { get; set; }
        public string Subject { get; set; }
    }
}