using System;

namespace AccessModifiers
{
    // public class Person
    // {
    //     private DateTime _birthdate;

    //     // public void SetBirthdate(DateTime birthdate)
    //     // {
    //     //     _birthdate = birthdate;
    //     // }

    //     // public DateTime GetBirthdate()
    //     // {
    //     //     return _birthdate;
    //     // }

    //     public DateTime Birthdate{
    //         get { return _birthdate; }
    //         set { _birthdate = value; }
    //     }
    // }

    // Auto-implemented Properties
    public class Person
    {
        public DateTime Birthdate { get; private set; }
        public string Name { get; set; }   
        public string UserName { get; set; }    
        
        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }
    
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days/365;

                return years;
            }
        }
    }
}