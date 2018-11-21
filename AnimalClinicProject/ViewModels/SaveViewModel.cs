using AnimalClinicProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClinicProject.ViewModels
{
    public abstract class SaveViewModel : BaseInpc
    {
        public AppDbContext AppDbContext { get; set; }
        public abstract void Save();
    }
}
