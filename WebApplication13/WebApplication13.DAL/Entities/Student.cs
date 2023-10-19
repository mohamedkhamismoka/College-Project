using System;


namespace WebApplication13.DAL.Entities
;
    public  class Student
    {
        


        public int StudentId { get; set; }
        public string Name { get; set; }

    public  IEnumerable<Payment> payments { get; set; }
    [Column(TypeName ="Date")]
    public DateTime BirthDate { get; set; }

        public string address { get; set; }
        public  IEnumerable<Student_course> Students_courses { get; set; }
        public string phone { get; set; }

    public int DepartmentId { get; set; }


    public  Department dept { get; set; }



    public string mail { get; set; }

        public string imgname { get; set; }

     

    
}
