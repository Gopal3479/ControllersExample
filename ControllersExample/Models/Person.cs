﻿namespace ControllersExample.Models
{
    public class Person
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime? DateOfBirth { get; set; }


        public Gender Gender { get; set; }
        
    }

    public enum Gender
    {
        Male,Female,Other
    };
}
