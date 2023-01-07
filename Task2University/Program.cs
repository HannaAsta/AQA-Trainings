// See https://aka.ms/new-console-template for mo


using Task2University;

Person person = new Person("Varvara", "Pupkina");
Person person1 = new Person(" Homik", "Fine");
Person person2 = new Person("Gusik", "Kokis");
Person person3 = new Person("Makalin", " Danya");
Person person4 = new Person(" Halturina", "Daryia");

Teacher teacher = new Teacher(person, 12165465 , "phylosofia");
SupportStaff staff = new SupportStaff(person1, 122455, Position.Driver);
SupportStaff staff1 = new SupportStaff(person2, 5445, Position.Cleanperson);
SupportStaff staff2 = new SupportStaff(person3, 445454, Position.Securityguard);



DegreeTeacher degree = new DegreeTeacher (person4, 126546 ,"himical", "doctor", "professor");

UniversityEmployee[] employees = { teacher, staff, staff1, staff2, degree };



foreach (var employee in employees)
{ }