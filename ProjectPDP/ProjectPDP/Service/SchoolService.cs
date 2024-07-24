using Model;
using ProjectPDP.Enums;
using ProjectPDP.Specialists;
using System.Text.Json;

namespace ProjectPDP.Service;
public partial class SchoolService
{
    public SchoolService()
    {
        LoadTeachersFromJson();
        LoadStudentsFromJson();
        LoadSpecialistFromJson();
        LoadRoomFromJson();
        LoadGroupFromJson();
        LoadBookingFromJson();
    }

    private List<Booking> bookings { get; set; } = new List<Booking>();

    private List<Exam> exams { get; set; } = new List<Exam>();

    public List<Reports> reports { get; set; } = new List<Reports>();

    string FilePathBookingList = @"D:\\booking.txt";

    private void LoadBookingFromJson()
    {
        if (File.Exists(FilePathBookingList))
        {
            string json = string.Empty;
            using (StreamReader sr = new StreamReader(FilePathBookingList))
            {
                json = sr.ReadToEnd();
            }
            bookings = JsonSerializer.Deserialize<List<Booking>>(json);
        }
        else
            bookings = new List<Booking>();
    }

    private void SaveBookingToJson()
    {
        string searilized = JsonSerializer.Serialize<List<Booking>>(bookings);
        using (StreamWriter sw = new StreamWriter(FilePathBookingList))
        {
            sw.WriteLine(searilized);
        }
    }


    public void Booking(int teacherId, int roomId, int groupId, int studentId, DateTime start, DateTime end)
    {
        var teacher = teachers.FirstOrDefault(t => t.Id == teacherId);
        var student = students.FirstOrDefault(s => s.Id == studentId);
        var room = rooms.FirstOrDefault(s => s.Id == roomId);
        var group = groups.FirstOrDefault(r => r.Id == groupId);
        if (teacher != null || room != null || group != null || student != null)
        {
            Console.WriteLine("Invalid teacher or student or group or room ID .");
            return;
        }
        else
        {
            Console.WriteLine("Successiful booked.");
        }
        var booking = new Booking
        {
            TeacherId = teacherId,
            Teacher = teacher,
            StudentId = studentId,
            Student = student,
            RoomId = roomId,
            Room = room,
            GroupId = groupId,
            Group = group
        };
        //bookings.Add(booking);
        teacher.Bookings.Add(booking);
        room.Bookings.Add(booking);
        group.Bookings.Add(booking);
        student.Bookings.Add(booking);
        SaveBookingToJson();
    }

    public void Exam(int teacherId, int groupId, int roomId, DateTime start, DateTime end, DayOfWeek day)
    {
        //int id = exams.Count > 0 ? exams.Max(e => e.Id) + 1 : 1;
        //exams.Add(new Exam { Id = id });
        var teacher = teachers.FirstOrDefault(t => t.Id == teacherId);
        var room = rooms.FirstOrDefault(r => r.Id == roomId);
        var group = groups.FirstOrDefault(g => g.Id == groupId);

        if (room != null || group != null || teacher != null)
        {
            Console.WriteLine("Invalid group or room ID .");
            return;
        }
        else
        {
            Console.WriteLine("Successiful added.");
        }
        var Exam = new Exam
        {
            TeacherId = teacherId,
            Teacher = teacher,
            RoomId = roomId,
            Room = room,
            GroupId = groupId,
            Group = group,
            Start_on = start,
            End_on = end,
            //Day = start.DayOfWeek,
        };
        //bookings.Add(Exam);
        teacher.ExamList.Add(Exam);
        room.ExamList.Add(Exam);
        group.ExamList.Add(Exam);

    }

    public void ListExam()
    {
        int counter = 1;
        if (exams.Count > 0)
        {
            foreach (var exam in exams)
            {
                Console.WriteLine($"{counter}. {exam.Group.Name}  {exam.Teacher.Name} {exam.Day}  {exam.Room.Name}  {exam.Start_on} - {exam.End_on}");
                counter++;
            }
        }
        else
            Console.WriteLine("Exams list is empty");
    }

    public void AttachSpecialistToTeacher(int teacherId, int specialistId)
    {
        var teacher = teachers.FirstOrDefault(t => t.Id == teacherId);
        var specialist = specialists.FirstOrDefault(s => s.Id == specialistId);

        if (teacher == null || specialist == null)
        {
            Console.WriteLine("Invalid teacher or specialist ID.");
            return;
        }
        else
        {
            Console.WriteLine("Successiful attached.");
        }

        var teacherSpecialist = new TeacherSpecialist
        {
            TeacherId = teacherId,
            Teacher = teacher,
            SpecialistId = specialistId,
            Specialist = specialist
        };
        if (teacher.TeacherSpecialists.Contains(teacherSpecialist))
            teacher.TeacherSpecialists.Add(teacherSpecialist);
        //teacher.TeacherSpecialists.Add(teacherSpecialist);
        //specialist.TeacherSpecialists.Add(teacherSpecialist);
    }

    public void AttachTeacherAndStudentToGroup(int teacherId, int studentId, int groupId)
    {
        var teacher = teachers.FirstOrDefault(t => t.Id == teacherId);
        var student = students.FirstOrDefault(s => s.Id == studentId);
        var group = groups.FirstOrDefault(r => r.Id == groupId);

        if (teacher == null || student == null || group == null)
        {
            Console.WriteLine("Invalid teacher or specialist or group ID .");
            return;
        }
        else
        {
            Console.WriteLine("Successiful attached.");
        }
        var teacherStudentGroup = new TeacherStudentGroup
        {
            TeacherId = teacherId,
            Teacher = teacher,
            StudentId = studentId,
            Student = student,
            GroupId = groupId,
            Group = group
        };
        teacher.TeacherStudentGroups.Add(teacherStudentGroup);
        student.TeacherStudentGroups.Add(teacherStudentGroup);
        group.TeacherStudentGroups.Add(teacherStudentGroup);

    }

    public void Report()
    {
        int counter = 1;
        foreach (var t in teachers)
        {
            Console.WriteLine($"{counter}. {t.Name} {t.Bookings.Count}");
            Reports Reports = new Reports()
            {
                Id = counter,
                TeacherId = t.Id,
            };
            reports.Add(Reports);
            counter++;
        }
    }

    public void TeacherLessons(int ReportId)
    {
        int counter1 = 1;

        foreach (var report in reports)
        {
            if (report.Id == ReportId)
            {
                // report.Teacher.Name

                var teacher = teachers.FirstOrDefault(s => s.Id == report.TeacherId);

                List<Booking> list1 = teacher.Bookings;

                foreach (var booking in list1)
                {
                    Console.WriteLine($"{counter1}.{booking.Room.Name} {booking.Group.Name} {booking.start_on}--{booking.end_on}");
                    counter1++;
                }
            }
        }
    }

    public void GetList()
    {
        if (teachers.Count > 0)
            foreach (var teacher in teachers)
            {
                Console.WriteLine($"Teacher {teacher.Id}: {teacher.Name}");
                foreach (var ts in teacher.TeacherSpecialists)
                {
                    Console.WriteLine($"Specialist: {ts.Specialist.Name}. Stack: {ts.Specialist.Stack}");
                }
            }
        else
            Console.WriteLine("Teacher list is empty!");

        if (students.Count > 0)
            foreach (var student in students)
            {
                Console.WriteLine($"Student {student.Id}: {student.Name}");
            }
        else
            Console.WriteLine("Students list is empty!");

        if (groups.Count > 0)
            foreach (var group in groups)
            {
                Console.WriteLine($"Group {group.Id}: {group.Name}");
                foreach (var g in group.TeacherStudentGroups)
                {
                    Console.WriteLine($"Group: {g.Group.Name}. Group Teacher: {g.Teacher.Name}. Student: {g.Student.Name}.");
                }
            }
        else
            Console.WriteLine("Groups list is empty!");

        if (rooms.Count > 0)
            foreach (var room in rooms)
            {
                Console.WriteLine($"Room {room.Id}: {room.Name}");
            }
        else
            Console.WriteLine("Rooms list is empty!");

        if (bookings.Count > 0)
            foreach (var b in bookings)
            {
                Console.WriteLine($"Booking {b.Id}:");
                Console.WriteLine($"Room: {b.Room.Name}. Group Teacher: {b.Teacher.Name}. Student: {b.Student.Name}. Group: {b.Group.Name}. {b.start_on}----{b.end_on}");
            }
        else
            Console.WriteLine("Booking list is empty!");

        if (exams.Count > 0)
            foreach (var exam in exams)
            {
                Console.WriteLine($"Exam {exam.Id}:");
                foreach (var e in exam.ExamList)
                {
                    Console.WriteLine($"Group: {e.Group.Name}. Room: {e.Room.Name}.");
                }
            }
        else
            Console.WriteLine("Exam list is empty!");
    }

    public void GetGroupStudentsList(int groupId)
    {
        var group = groups.FirstOrDefault(s => s.Id == groupId);

        if (group != null)
            foreach (var student in group.TeacherStudentGroups)
                Console.WriteLine(student.Name);
        else
            Console.WriteLine("Not found group");
    }

    public void GetBookingList()
    {
        if (bookings.Count > 0)
        {
            foreach (var i in bookings)
            {
                Console.WriteLine($"Teacher Name: {i.Teacher.Name}, room Name: {i.Room.Name}, , Group name: {i.Group.Name}, {i.start_on} ---- {i.end_on}");
            }
        }
        else
            Console.WriteLine("Booking List is empty");
    }



}
