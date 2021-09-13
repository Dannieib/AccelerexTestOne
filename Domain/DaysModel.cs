using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccelerexTestOne.Domain
{
    public class DaysModel
    {
        //public List<T> Object { get; set; }
        public List<Monday> monday { get; set; }
        public List<Tuesday> tuesday { get; set; }
        public List<Wednesday> wednesday { get; set; }
        public List<Thursday> thursday { get; set; }
        public List<Friday> friday { get; set; }
        public List<Saturday> saturday { get; set; }
        public List<Sunday> sunday { get; set; }
    }

    public class ValueModel
    {
        public string type { get; set; }
        public int value { get; set; }
    }

    public class Friday : ValueModel,IDays
    {
        DaysEnum IDays.DayEnum => DaysEnum.Friday;
    }
    public class Saturday : ValueModel, IDays{DaysEnum IDays.DayEnum => DaysEnum.Saturday;}
    public class Sunday : ValueModel, IDays { DaysEnum IDays.DayEnum => DaysEnum.Sunday; }
    public class Monday : ValueModel, IDays { DaysEnum IDays.DayEnum => DaysEnum.Monday; }
    public class Tuesday : ValueModel, IDays { DaysEnum IDays.DayEnum => DaysEnum.Tuesday; }
    public class Wednesday : ValueModel, IDays { DaysEnum IDays.DayEnum => DaysEnum.Wednesday; }
    public class Thursday : ValueModel, IDays { DaysEnum IDays.DayEnum => DaysEnum.Thursday; }

    public interface IDays
    {
        public DaysEnum DayEnum  { get;}
    }

    public enum DaysEnum
    {
        Monday=1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
