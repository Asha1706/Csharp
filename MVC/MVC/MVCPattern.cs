using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    internal class MVCPattern
    {
        public static void Main(String[] args)
        {
            Student model = retriveStudentFromDatabase();

            StudentView view = new StudentView();

            StudentController controller = new StudentController(model, view);

            controller.updateView();

            controller.setStudentName("Asha Pasha");
            controller.setStudentRollNo("21251E0034");

            controller.updateView();
        }

        private static Student retriveStudentFromDatabase()
        {
            Student student = new Student();
            student.setName("Giri");
            student.setRollNo("15UCS157");
            return student;
        }
    }
}
