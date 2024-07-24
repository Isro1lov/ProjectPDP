using ProjectPDP.Service;
public class Program
{
    static void Main(string[] args)
    {
        var schoolService = new SchoolService();
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Update");
            Console.WriteLine("3. Delete");
            Console.WriteLine("4. List");
            Console.WriteLine("5. Service");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("1. Add Specialist");
                    Console.WriteLine("2. Add Teacher");
                    Console.WriteLine("3. Add Student");
                    Console.WriteLine("4. Add Group");
                    Console.WriteLine("5. Add Room");
                    var choice1 = Console.ReadLine();
                    switch (choice1)
                    {
                        case "1":
                            Console.Write("Enter Specialist Name Of Type: ");
                            var sName = Console.ReadLine();
                            Console.Write("Enter Specialist Stack: ");
                            var stack = Console.ReadLine();
                            schoolService.AddSpecialist(sName, stack);
                            Console.WriteLine("Successful added.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case "2":
                            Console.Write("Enter Teacher Name: ");
                            var tName = Console.ReadLine();
                            schoolService.AddTeacher(tName);
                            Console.WriteLine("Successful added.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case "3":
                            Console.Write("Enter Student Name: ");
                            var stName = Console.ReadLine();
                            schoolService.AddStudent(stName);
                            Console.WriteLine("Successful added.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case "4":
                            Console.Write("Enter Group Name: ");
                            var gName = Console.ReadLine();
                            schoolService.AddGroup(gName);
                            Console.WriteLine("Successful added.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case "5":
                            Console.Write("Enter Room Name: ");
                            var rName = Console.ReadLine();
                            schoolService.AddRoom(rName);
                            Console.WriteLine("Successful added.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("Invalid choice, please try again.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                    break;
                case "2":
                    Console.WriteLine("1. Update Specialist");
                    Console.WriteLine("2. Update Teacher");
                    Console.WriteLine("3. Update Student");
                    Console.WriteLine("4. Update Group");
                    Console.WriteLine("5. Update Room");
                    var choice2 = Console.ReadLine();
                    switch (choice2)
                    {
                        case "1":
                            Console.Write("Enter Specialist Id: ");
                            var sId = int.Parse(Console.ReadLine());
                            Console.Write("Enter Specialist Name: ");
                            var newSName = Console.ReadLine();
                            Console.Write("Enter Specialist Stack: ");
                            var newStack = Console.ReadLine();
                            schoolService.UpdateSpecialist(sId, newSName, newStack);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case "2":
                            Console.Write("Enter Teacher Id: ");
                            var tId = int.Parse(Console.ReadLine());
                            Console.Write("Enter Teacher Name: ");
                            var newTName = Console.ReadLine();
                            schoolService.UpdateTeacher(tId, newTName);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case "3":
                            Console.Write("Enter Student Id: ");
                            var stId = int.Parse(Console.ReadLine());
                            Console.Write("Enter Student Name: ");
                            var newSTName = Console.ReadLine();
                            schoolService.UpdateStudent(stId, newSTName);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case "4":
                            Console.Write("Enter Group Id: ");
                            var gId = int.Parse(Console.ReadLine());
                            Console.Write("Enter Group Name: ");
                            var newGName = Console.ReadLine();
                            schoolService.UpdateGroup(gId, newGName);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case "5":
                            Console.Write("Enter Room Id: ");
                            var rId = int.Parse(Console.ReadLine());
                            Console.Write("Enter Room Name: ");
                            var newRName = Console.ReadLine();
                            schoolService.UpdateRoom(rId, newRName);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("Invalid choice, please try again.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                    break;
                case "3":
                    Console.WriteLine("1. Delete Specialist");
                    Console.WriteLine("2. Delete Teacher");
                    Console.WriteLine("3. Delete Student");
                    Console.WriteLine("4. Delete Group");
                    Console.WriteLine("5. Delete Room");
                    var choice3 = Console.ReadLine();
                    switch (choice3)
                    {
                        case "1":
                            Console.Write("Enter Specialist Id: ");
                            var deleteSId = int.Parse(Console.ReadLine());
                            schoolService.DeleteSpecialist(deleteSId);
                            Console.WriteLine("Successiful deleted.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case "2":
                            Console.Write("Enter Teacher Id: ");
                            var deleteTId = int.Parse(Console.ReadLine());
                            schoolService.DeleteTeacher(deleteTId);
                            Console.WriteLine("Successiful deleted.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case "3":
                            Console.Write("Enter Student Id: ");
                            var deleteStId = int.Parse(Console.ReadLine());
                            schoolService.DeleteStudent(deleteStId);
                            Console.WriteLine("Successiful deleted.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case "4":
                            Console.Write("Enter Group Id: ");
                            var deleteGId = int.Parse(Console.ReadLine());
                            schoolService.DeleteGroup(deleteGId);
                            Console.WriteLine("Successiful deleted.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case "5":
                            Console.Write("Enter Room Id: ");
                            var deleteRId = int.Parse(Console.ReadLine());
                            schoolService.DeleteRoom(deleteRId);
                            Console.WriteLine("Successiful deleted.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("Invalid choice, please try again.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                    break;
                case "4":
                    Console.WriteLine("1. List Specialist");
                    Console.WriteLine("2. List Teacher");
                    Console.WriteLine("3. List Student");
                    Console.WriteLine("4. List Group");
                    Console.WriteLine("5. List Room");
                    Console.WriteLine("6. List Exam");
                    Console.WriteLine("7. Group full list");
                    Console.WriteLine("8. Booked room list");
                    Console.WriteLine("9. Get Full List");
                    var choice4 = Console.ReadLine();
                    switch (choice4)
                    {
                        case "1":
                            schoolService.ListSpecialists();
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case "2":
                            schoolService.ListTeacher();
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case "3":
                            schoolService.ListStudent();
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case "4":
                            schoolService.ListGroup();
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case "5":
                            schoolService.ListRoom();
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case "6":
                            Console.Clear();
                            schoolService.ListExam();
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case "7":
                            schoolService.ListGroup();
                            Console.Write("Enter a group id: ");
                            var Gid = int.Parse(Console.ReadLine());
                            schoolService.GetGroupStudentsList(Gid);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case "8":
                            schoolService.GetBookingList();
                            Console.ReadKey();
                            Console.Clear();
                            break ;
                        case "9":
                            schoolService.GetList();
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("Invalid choice, please try again.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                    break;
                case "5":
                    Console.WriteLine("1. Attach Specialist to Teacher");
                    Console.WriteLine("2. Attach Teacher and Student to Group");
                    Console.WriteLine("3. Booking room");
                    Console.WriteLine("4. Add Exam");
                    Console.WriteLine("5. Report");
                    var choice5 = Console.ReadLine();
                    switch (choice5)
                    {
                        case "1":
                            Console.Write("Enter Teacher Id: ");
                            var attTId = int.Parse(Console.ReadLine());
                            Console.Write("Enter Specialist Id: ");
                            var attSId = int.Parse(Console.ReadLine());
                            schoolService.AttachSpecialistToTeacher(attTId, attSId);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case "2":
                            Console.Write("Enter Teacher Id: ");
                            var attachTId = int.Parse(Console.ReadLine());
                            Console.Write("Enter Student Id: ");
                            var attachSId = int.Parse(Console.ReadLine());
                            Console.Write("Enter Group Id: ");
                            var attachGId = int.Parse(Console.ReadLine());
                            schoolService.AttachTeacherAndStudentToGroup(attachTId, attachSId, attachGId);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case "3":
                            Console.Clear();
                            schoolService.ListGroup();
                            Console.Write("Enter group id: ");
                            // var BookingGroupId = int.Parse(Console.ReadLine());
                            bool isTrueFormat = int.TryParse(Console.ReadLine(), out var BookingGroupId);
                            if (!isTrueFormat)
                            {
                                Console.WriteLine("Incorrect format");
                                Console.ReadKey();
                                Console.Clear();
                                continue;
                            }
                            else if (BookingGroupId == 0)
                            {
                                Console.WriteLine("Id cannot be 0");
                                Console.ReadKey();
                                Console.Clear();
                                continue;
                            }
                            schoolService.ListRoom();
                            Console.Write("Enter room id: ");
                            var BookingRoomId = int.Parse(Console.ReadLine());

                            schoolService.ListTeacher();
                            Console.Write("Enter Teacher id: ");
                            var BookingTeacherId = int.Parse(Console.ReadLine());

                            schoolService.ListStudent();
                            Console.Write("Enter Student id: ");
                            var BookingStudentId = int.Parse(Console.ReadLine());

                            Console.Write("Enter Time Lesson start (yy-mm-dd hh:mm): ");
                            bool isTrue = DateTime.TryParse(Console.ReadLine(), out var StartTime);

                            if (!isTrue)
                            {
                                Console.WriteLine("Date time format is incorrect");
                                Console.ReadKey();
                                Console.Clear();
                                continue;
                            }

                            Console.Write("Enter Time Lesson end (yy-mm-dd hh:mm): ");
                            bool isTrue1 = DateTime.TryParse(Console.ReadLine(), out var endTime);

                            if (!isTrue1)
                            {
                                Console.WriteLine("Date time format is incorrect");
                                Console.ReadKey();
                                Console.Clear();
                                continue;
                            }

                            schoolService.Booking(BookingRoomId, BookingTeacherId, BookingStudentId, BookingGroupId, StartTime, endTime);
                            Console.ReadKey();
                            Console.Clear();
                            //Console.Write("Enter Teacher Id: ");
                            //var atTId = int.Parse(Console.ReadLine());
                            //Console.Write("Enter Student Id: ");
                            //var atSId = int.Parse(Console.ReadLine());
                            //Console.Write("Enter Group Id: ");
                            //var atGId = int.Parse(Console.ReadLine());
                            //Console.Write("Enter Room Id: ");
                            //var atRId = int.Parse(Console.ReadLine());
                            //schoolService.Booking(atTId, atSId, atGId, atRId);
                            //Console.ReadKey();
                            //Console.Clear();
                            break;
                        case "4":

                            Console.Clear();
                            schoolService.ListTeacher();
                            try
                            {
                                Console.Write("Enter teacher Id: ");
                                int teacherId = int.Parse(Console.ReadLine());
                                schoolService.ListGroup();
                                Console.Write("Enter group Id: ");
                                int groupId = int.Parse(Console.ReadLine());
                                schoolService.ListRoom();
                                Console.Write("Enter room Id: ");
                                int roomId = int.Parse(Console.ReadLine());
                                try
                                {
                                    Console.WriteLine("Date time must be as this format: 2024-07-26 19:00");
                                    Console.Write("\nEnter Time Exam Start: ");
                                    DateTime ExamStart = DateTime.Parse(Console.ReadLine());
                                    Console.Write("Enter Time Exam End: ");
                                    DateTime ExamEnd = DateTime.Parse(Console.ReadLine());
                                    schoolService.Exam(teacherId,groupId, roomId, ExamStart, ExamEnd, ExamStart.DayOfWeek);
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Date time format is incorrect");
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Id must be poditive number");
                            }
                            Console.ReadKey();
                            Console.Clear();
                            //Console.Write("Enter Group Id: ");
                            //var eGId = int.Parse(Console.ReadLine());
                            //Console.Write("Enter Room Id: ");
                            //var eRId = int.Parse(Console.ReadLine());
                            //schoolService.Exam(eGId, eRId);
                            //Console.ReadKey();
                            //Console.Clear();
                            break;
                        case "5":
                            Console.Clear();
                            schoolService.Report();

                            if (schoolService.reports.Count != 0)
                            {
                                Console.Write("Enter an option: ");

                                bool isTrue2 = int.TryParse(Console.ReadLine(), out var option);

                                switch (option)
                                {
                                    case 0:
                                        Console.WriteLine("there is no 0");
                                        break;

                                    default:
                                        if (option <= schoolService.reports.Count)
                                        {
                                            schoolService.TeacherLessons(option);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Incorrect format");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        break;
                                }

                                schoolService.reports.Clear();
                            }
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("Invalid choice, please try again.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                    break;
                case "6":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }

            #region First
            //Console.WriteLine("1. Add Specialist");
            //Console.WriteLine("2. Add Teacher");
            //Console.WriteLine("3. Add Student");
            //Console.WriteLine("3.5 Add Group");
            //Console.WriteLine("4. Update Specialist");
            //Console.WriteLine("5. Update Teacher");
            //Console.WriteLine("6. Update Student");
            //Console.WriteLine("7. Delete Specialist");
            //Console.WriteLine("8. Delete Teacher");
            //Console.WriteLine("9. Delete Student");
            //Console.WriteLine("10. Attach Specialist to Teacher");
            //Console.WriteLine("11. List Specialist");
            //Console.WriteLine("12. List Teacher");
            //Console.WriteLine("13. List Student");
            //Console.WriteLine("14. Get Full List");
            //Console.WriteLine("15. Room booking");
            //Console.WriteLine("16. Attach Teacher and Student to Group");
            //Console.WriteLine("17. Exit");
            //Console.Write("Choose an option: ");
            //var choise2 = Console.ReadLine();
            //switch (choise2)
            //{
            //    case "1":
            //        Console.Write("Enter Specialist Name: ");
            //        var sName = Console.ReadLine();
            //        Console.Write("Enter Specialist Stack: ");
            //        var stack = Console.ReadLine();
            //        schoolService.AddSpecialist(sName, stack);
            //        Console.WriteLine("Successiful added.");
            //        Console.ReadKey();
            //        Console.Clear();
            //        break;
            //    case "2":
            //        Console.Write("Enter Teacher Name: ");
            //        var tName = Console.ReadLine();
            //        schoolService.AddTeacher(tName);
            //        Console.WriteLine("Successiful added.");
            //        Console.ReadKey();
            //        Console.Clear();
            //        break;
            //    case "3":
            //        Console.Write("Enter Student Name: ");
            //        var stName = Console.ReadLine();
            //        schoolService.AddStudent(stName);
            //        Console.WriteLine("Successiful added.");
            //        Console.ReadKey();
            //        Console.Clear();
            //        break;
            //    case "3.5":
            //        Console.Write("Enter Room Name: ");
            //        var rName = Console.ReadLine();
            //        schoolService.AddRoom(rName);
            //        Console.WriteLine("Successiful added.");
            //        Console.ReadKey();
            //        Console.Clear();
            //        break;
            //    case "4":
            //        Console.Write("Enter Specialist Id: ");
            //        var sId = int.Parse(Console.ReadLine());
            //        Console.Write("Enter Specialist Name: ");
            //        var newSName = Console.ReadLine();
            //        Console.Write("Enter Specialist Stack: ");
            //        var newStack = Console.ReadLine();
            //        schoolService.UpdateSpecialist(sId, newSName, newStack);
            //        Console.WriteLine("Successiful updated.");
            //        Console.ReadKey();
            //        Console.Clear();
            //        break;
            //    case "5":
            //        Console.Write("Enter Teacher Id: ");
            //        var tId = int.Parse(Console.ReadLine());
            //        Console.Write("Enter Teacher Name: ");
            //        var newTName = Console.ReadLine();
            //        schoolService.UpdateTeacher(tId, newTName);
            //        Console.WriteLine("Successiful updated.");
            //        Console.ReadKey();
            //        Console.Clear();
            //        break;
            //    case "6":
            //        Console.Write("Enter Student Id: ");
            //        var stId = int.Parse(Console.ReadLine());
            //        Console.Write("Enter Student Name: ");
            //        var newSTName = Console.ReadLine();
            //        schoolService.UpdateStudent(stId, newSTName);
            //        Console.WriteLine("Successiful updated.");
            //        Console.ReadKey();
            //        Console.Clear();
            //        break;
            //    case "7":
            //        Console.Write("Enter Specialist Id: ");
            //        var deleteSId = int.Parse(Console.ReadLine());
            //        schoolService.DeleteSpecialist(deleteSId);
            //        Console.WriteLine("Successiful deleted.");
            //        Console.ReadKey();
            //        Console.Clear();
            //        break;
            //    case "8":
            //        Console.Write("Enter Teacher Id: ");
            //        var deleteTId = int.Parse(Console.ReadLine());
            //        schoolService.DeleteTeacher(deleteTId);
            //        Console.WriteLine("Successiful deleted.");
            //        Console.ReadKey();
            //        Console.Clear();
            //        break;
            //    case "9":
            //        Console.Write("Enter Student Id: ");
            //        var deleteStId = int.Parse(Console.ReadLine());
            //        schoolService.DeleteStudent(deleteStId);
            //        Console.WriteLine("Successiful deleted.");
            //        Console.ReadKey();
            //        Console.Clear();
            //        break;
            //    case "10":
            //        Console.Write("Enter Teacher Id: ");
            //        var attTId = int.Parse(Console.ReadLine());
            //        Console.Write("Enter Specialist Id: ");
            //        var attSId = int.Parse(Console.ReadLine());
            //        schoolService.AttachSpecialistToTeacher(attTId, attSId);
            //        Console.ReadKey();
            //        Console.Clear();
            //        break;
            //    case "11":
            //        schoolService.ListSpecialists();
            //        Console.ReadKey();
            //        Console.Clear();
            //        break;
            //    case "12":
            //        schoolService.ListTeacher();
            //        Console.ReadKey();
            //        Console.Clear();
            //        break;
            //    case "13":
            //        schoolService.ListStudent();
            //        Console.ReadKey();
            //        Console.Clear();
            //        break;
            //    case "14":
            //        schoolService.GetList();
            //        Console.ReadKey();
            //        Console.Clear();
            //        break;
            //    case "15":
            //        Console.WriteLine("Enter room number: ");
            //        var rnum = int.Parse(Console.ReadLine());
            //        Console.WriteLine("Successiful entered");
            //        Console.ReadKey();
            //        Console.Clear();
            //        break;
            //    case "16":
            //        Console.Write("Enter Teacher Id: ");
            //        var attachTId = int.Parse(Console.ReadLine());
            //        Console.Write("Enter Student Id: ");
            //        var attachSId = int.Parse(Console.ReadLine());
            //        Console.WriteLine("Enter Room Id: ");
            //        var attachRId = int.Parse(Console.ReadLine());
            //        schoolService.AttachTeacherAndStudentToGroup(attachTId, attachSId, attachRId);
            //        Console.ReadKey();
            //        Console.Clear();
            //        break;
            //    case "17":
            //        exit = true;
            //        break;
            //    default:
            //        Console.WriteLine("Invalid choice, please try again.");
            //        Console.ReadKey();
            //        Console.Clear();
            //        break;
            //}
            #endregion
        }
    }
}