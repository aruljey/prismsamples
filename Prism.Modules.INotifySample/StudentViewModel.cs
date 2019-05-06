using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Modules.INotifySample.Model;
using System.ComponentModel.Composition;
using Prism.Mvvm;

namespace Prism.Modules.INotifySample
{
    [Export(typeof(StudentViewModel))]
    public class StudentViewModel : BindableBase
    {
        public ObservableCollection<Student> Students
        {
            get
            {
                var result = GetStudents();
                return result;
            }
        }

        private ObservableCollection<Student> GetStudents()
        {
            ObservableCollection<Student> students = new ObservableCollection<Student>
            {
                new Student { FirstName = "Mark", LastName = "allan" },
                new Student { FirstName = "allen", LastName = "paul" },
                new Student { FirstName = "harmseki", LastName = "semmi" }
            };
            return students;
        }
    }
}
